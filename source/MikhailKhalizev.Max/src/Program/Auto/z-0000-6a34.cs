using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x6a34-f7ebcfb1")]
        public void Method_0000_6a34()
        {
            ii(0x6a34, 1);    popw(ds);                                 /* pop ds */
            ii(0x6a35, 1);    popw(ax);                                 /* pop ax */
            ii(0x6a36, 1);    pusha();                                  /* pusha */
            ii(0x6a37, 1);    pushw(es);                                /* push es */
            ii(0x6a38, 1);    pushw(ds);                                /* push ds */
            ii(0x6a39, 1);    pushw(ss);                                /* push ss */
            ii(0x6a3a, 3);    mov(ax, 0x20);                            /* mov ax, 0x20 */
            ii(0x6a3d, 2);    mov(ds, ax);                              /* mov ds, ax */
            ii(0x6a3f, 4);    pushw(memw_a16[ds, 0x996]);               /* push word [0x996] */
            ii(0x6a43, 2);    mov(bp, sp);                              /* mov bp, sp */
            ii(0x6a45, 4);    add(memw_a16[ss, bp + 0xe], 0x6);         /* add word [bp+0xe], 0x6 */
            ii(0x6a49, 2);    if(jmpw_func(0x6a9c, 0x51)) return;       /* jmp 0x6a9c */
        }
    }
}
