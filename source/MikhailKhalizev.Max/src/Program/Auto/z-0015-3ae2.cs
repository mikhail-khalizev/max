using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("e5d14a1b-c2b7-496b-b8f0-661ebd0e01c3")]
        public void Method_0015_3ae2()
        {
            ii(0x15_3ae2, 1); pushw(bx);                                /* push bx */
            ii(0x15_3ae3, 1); pushw(es);                                /* push es */
            ii(0x15_3ae4, 1); pushw(cx);                                /* push cx */
            ii(0x15_3ae5, 3); mov(cx, 0x400);                           /* mov cx, 0x400 */
            ii(0x15_3ae8, 4); xchg(memw_a16[ds, 0x3f64], cx);           /* xchg [0x3f64], cx */
            ii(0x15_3aec, 1); pushw(cx);                                /* push cx */
            ii(0x15_3aed, 1); pushw(ax);                                /* push ax */
            ii(0x15_3aee, 1); nop();                                    /* nop */
            ii(0x15_3aef, 1); pushw(cs);                                /* push cs */
            ii(0x15_3af0, 3); callw(0x15_3ca6, 0x1b3);                  /* call 0x3ca6 */
            ii(0x15_3af3, 1); popw(bx);                                 /* pop bx */
            ii(0x15_3af4, 4); popw(memw_a16[ds, 0x3f64]);               /* pop word [0x3f64] */
            ii(0x15_3af8, 1); popw(cx);                                 /* pop cx */
            ii(0x15_3af9, 2); mov(bx, dx);                              /* mov bx, dx */
            ii(0x15_3afb, 2); or(bx, ax);                               /* or bx, ax */
            ii(0x15_3afd, 2); if(jzw(0x15_3b02, 0x3)) goto l_0x15_3b02; /* jz 0x3b02 */
            ii(0x15_3aff, 1); popw(es);                                 /* pop es */
            ii(0x15_3b00, 1); popw(bx);                                 /* pop bx */
            ii(0x15_3b01, 1); retw(); return;                           /* ret */
        l_0x15_3b02:
            ii(0x15_3b02, 2); mov(ax, cx);                              /* mov ax, cx */
            ii(0x15_3b04, 3); if(jmpw_func(0x15_2203, -0x1904)) return; /* jmp 0x2203 */
        }
    }
}
