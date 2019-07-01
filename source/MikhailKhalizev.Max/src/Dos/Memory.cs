﻿using System;
using System.Collections.Generic;
using System.Linq;
using MikhailKhalizev.Processor.x86.Abstractions;

namespace MikhailKhalizev.Max.Dos
{
    public class Memory : BridgeProcessor
    {
        public Memory(IProcessor implementation) 
            : base(implementation)
        { }


        public void dos_mem_init()
        {
            var processor = (Processor.x86.FullSimulate.Processor) Implementation;
            var memory = processor.Memory;

            var physMem = memory.mem_phys_raw(0, 0x100030);

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
                    findParagraph = (pair.Key + pair.Value + 15) / 16;
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
                    findParagraph = (last.Key + last.Value + 15) / 16;
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

                if (MemorySize < (bx + ax).Int32 * 16)
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
                next_par = next / 16;

            if (next_par * 16 - es.Descriptor.Base < bx.UInt16 * 16)
            {
                ax = 8;
                bx = 0; // Лень считать.
                throw new Exception();
            }

            if (MemorySize < bx.UInt16 * 16 + iter)
                throw new Exception("std::bad_alloc()");

            eflags.cf = false;
            ax = es; /* Необязятельно, но более реалистично. */
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

                    if (MemorySize < handle_1_size + 0x130000)
                        throw new Exception("std::bad_alloc()");

                    maps.Add(0x130000, handle_1_size);
                    handle_iter = 0x130000;
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
                    dx = 0x13; // addr >> 16
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
