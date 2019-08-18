using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x4a24-7689a1a1")]
        public void Method_0000_4a24()
        {
            ii(0x4a24, 1);    popw(ds);                                 /* pop ds */
            ii(0x4a25, 1);    popw(ax);                                 /* pop ax */
            ii(0x4a26, 1);    pusha();                                  /* pusha */
            ii(0x4a27, 1);    pushw(es);                                /* push es */
            ii(0x4a28, 1);    pushw(ds);                                /* push ds */
            ii(0x4a29, 1);    pushw(ss);                                /* push ss */
            ii(0x4a2a, 3);    mov(ax, 0x20);                            /* mov ax, 0x20 */
            ii(0x4a2d, 2);    mov(ds, ax);                              /* mov ds, ax */
            ii(0x4a2f, 4);    pushw(memw_a16[ds, 0x996]);               /* push word [0x996] */
            ii(0x4a33, 2);    mov(bp, sp);                              /* mov bp, sp */
            ii(0x4a35, 4);    add(memw_a16[ss, bp + 0xe], 0x6);         /* add word [bp+0xe], 0x6 */
            ii(0x4a39, 2);    if(jmpw_func(0x4a8c, 0x51)) return;       /* jmp 0x4a8c */
        }
    }
}
