using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x19_3ae2-33294b3d")]
        public void Method_0019_3ae2()
        {
            ii(0x19_3ae2, 1); push(bx);                                 /* push bx */
            ii(0x19_3ae3, 1); push(es);                                 /* push es */
            ii(0x19_3ae4, 1); push(cx);                                 /* push cx */
            ii(0x19_3ae5, 3); mov(cx, 0x400);                           /* mov cx, 0x400 */
            ii(0x19_3ae8, 4); xchg(memw[ds, 0x3f64], cx);               /* xchg [0x3f64], cx */
            ii(0x19_3aec, 1); push(cx);                                 /* push cx */
            ii(0x19_3aed, 1); push(ax);                                 /* push ax */
            ii(0x19_3aee, 1); nop();                                    /* nop */
            ii(0x19_3aef, 1); push(cs);                                 /* push cs */
            ii(0x19_3af0, 3); call(0x19_3ca6, 0x1b3);                   /* call 0x3ca6 */
            ii(0x19_3af3, 1); pop(bx);                                  /* pop bx */
            ii(0x19_3af4, 4); pop(memw[ds, 0x3f64]);                    /* pop word [0x3f64] */
            ii(0x19_3af8, 1); pop(cx);                                  /* pop cx */
            ii(0x19_3af9, 2); mov(bx, dx);                              /* mov bx, dx */
            ii(0x19_3afb, 2); or(bx, ax);                               /* or bx, ax */
            ii(0x19_3afd, 2); if(jz(0x19_3b02, 0x3)) goto l_0x19_3b02;  /* jz 0x3b02 */
            ii(0x19_3aff, 1); pop(es);                                  /* pop es */
            ii(0x19_3b00, 1); pop(bx);                                  /* pop bx */
            ii(0x19_3b01, 1); ret(); return;                            /* ret */
        l_0x19_3b02:
            ii(0x19_3b02, 2); mov(ax, cx);                              /* mov ax, cx */
            ii(0x19_3b04, 3); if(jmp_func(0x19_2203, -0x1904)) return;  /* jmp 0x2203 */
        }
    }
}
