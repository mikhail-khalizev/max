using System;
using System.Collections.Generic;
using System.Linq;
using MikhailKhalizev.Max.Program;
using MikhailKhalizev.Processor.x86;
using MikhailKhalizev.Processor.x86.Core.Abstractions;

namespace MikhailKhalizev.Max.Dos
{
    public class DosMemory : BridgeProcessor
    {
        public RawProgramMain RawProgramMain { get; }

        public DosMemory(IProcessor implementation, RawProgramMain rawProgramMain)
            : base(implementation)
        {
            RawProgramMain = rawProgramMain;
        }


        public void dos_mem_init()
        {
            var memory = Implementation.Memory;

            var physMem = memory.GetMinSize(0, 0x100030);

            //for (var addr = 0x100000; addr < 0x100030; addr++)
            //    phys_mem_ms.get<char>(addr) = rand();

            /* type_of_ibm_pc */
            physMem[0xffffe] = 0xfc;
            physMem[0xfffff] = 0x55;

            /* int_67 source. */
            physMem[0xc841a] = 0x45;
            physMem[0xc841b] = 0x4d;
            physMem[0xc841c] = 0x4d;
            physMem[0xc841d] = 0x58;
            physMem[0xc841e] = 0x58;
            physMem[0xc841f] = 0x58;
            physMem[0xc8421] = 0x30;
        }


        SortedDictionary<Address /* phys_addr */, int /* size */> maps = new SortedDictionary<Address, int>();

        /** int 0x48
         * input:
         * bx - number of paragraphs
         * output:
         * cf = false if successful
         * ax - points to block if successful
         *    = 7 if unsufficient memory
         * bx - size of largest block if failed
         */
        public void dos_mem_alloc()
        {
            eflags.cf = true;

            // search first largest block

            bx += 1; // Как бы на внутренние нужды.
            if (bx == 0)
                throw new Exception();

            var findParagraph = 0;
            foreach (var pair in maps)
            {
                if (pair.Key / 16 - findParagraph < bx.UInt16)
                {
                    findParagraph = ((int)pair.Key + pair.Value + 15) / 16;
                    continue;
                }

                eflags.cf = false;
                break;
            }

            if (eflags.cf)
            {
                if (maps.Count != 0)
                {
                    var last = maps.Last();
                    findParagraph = ((int)last.Key + last.Value + 15) / 16;
                    if (bx.UInt16 <= 0xffff - findParagraph)
                        eflags.cf = false;
                }
                else
                {
                    findParagraph = 0;
                    eflags.cf = false;
                }
            }

            if (!eflags.cf)
            {
                ax = findParagraph;

                if (Memory.Length < (bx + ax).UInt32 * 16)
                    throw new Exception("std::bad_alloc()");

                bx -= 1;
                ax += 1;

                maps[ax.UInt16 * 16] = bx.UInt16 * 16;
            }
            else
            {
                ax = 7;
                bx = 0; // Лень считать.
                throw new Exception();
            }
        }

        public void dos_mem_free()
        {
            if (maps.Remove(es.Descriptor.Base))
            {
                eflags.cf = false;
            }
            else
            {
                eflags.cf = true;
                ax = 9;
            }
        }

        /** int 0x4a
         * input:
         * es - segment address of block
         * bx - requested new block size in paragraphs
         * output:
         * cf = false if successful
         * bx - max available block size if filed
         * ax = 8 if insufficient memory
         *    = 9 if invalid memory block in es
         */
        public void dos_mem_resize()
        {
            eflags.cf = true;

            if (!maps.TryGetValue(es.Descriptor.Base, out var iter))
            {
                ax = 9;
                return;
            }

            var next = maps.Keys.FirstOrDefault(x => es.Descriptor.Base < x);

            int next_par = 0xffff;
            if (iter < next)
                next_par = (int)next / 16;

            if (next_par * 16 - es.Descriptor.Base < bx.UInt16 * 16)
            {
                ax = 8;
                bx = 0; // Лень считать.
                throw new Exception();
            }

            if (Memory.Length < bx.UInt16 * 16 + iter)
                throw new Exception("std::bad_alloc()");

            eflags.cf = false;
            ax = es; /* Необязательно, но более реалистично. */
            maps[es.Descriptor.Base] = bx.UInt16 * 16;
        }


        static bool handle_1_use = false;
        static int handle_1_size = 0;
        static int handle_iter;

        public void xms_handler()
        {
            switch (ah.UInt16)
            {
                case 0x0:
                    ax = 0x300;
                    bx = 0x301;
                    dx = 0;
                    break;

                case 0x8:
                    ax = 0x3b40;
                    bl = 0x0;
                    dx = ax;
                    break;

                case 0x9: // allocate
                {
                    if (handle_1_use)
                        throw new NotImplementedException();

                    handle_1_use = true;
                    handle_1_size = dx.UInt16 * 1024; // dx is size in kb
                    dx = 1; // handle
                    ax = 1; // success

                    handle_iter = 0x13_0000;

                    if (Memory.Length < handle_1_size + handle_iter)
                        throw new Exception("std::bad_alloc()");

                    maps.Add(handle_iter, handle_1_size);
                }
                    break;

                case 0xa: // free.
                    if (handle_1_use && dx == 1)
                    {
                        maps.Remove(handle_iter);
                        handle_iter = 0;
                        handle_1_use = false;
                        handle_1_size = 0;
                        ax = 1; // success
                    }
                    else
                        throw new NotImplementedException();

                    break;

                case 0xc: // lock
                    ax = 1; // success
                    bx = 0; // addr
                    dx = handle_iter >> 16;
                    break;

                case 0xd: // unlock
                    if (handle_1_use && dx == 1)
                        ax = 1; // success
                    else
                        throw new NotImplementedException();
                    break;

                default:
                    throw new NotImplementedException();
            }

            retfw();
        }
    }
}
