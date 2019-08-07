using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("48380498-5998-49f9-99e9-79a9edaabcb1")]
        public void Method_0015_43bc()
        {
            ii(0x15_43bc, 4); enterw(0x14, 0);                          /* enter 0x14, 0x0 */
            ii(0x15_43c0, 1); pushw(ds);                                /* push ds */
            ii(0x15_43c1, 3); mov(ax, 0xa8);                            /* mov ax, 0xa8 */
            ii(0x15_43c4, 2); mov(ds, ax);                              /* mov ds, ax */
            ii(0x15_43c6, 5); mov(memw_a16[ss, bp - 0x2], 0xff00);      /* mov word [bp-0x2], 0xff00 */
            ii(0x15_43cb, 5); mov(memw_a16[ss, bp - 0x6], 0x1102);      /* mov word [bp-0x6], 0x1102 */
            ii(0x15_43d0, 3); mov(ax, memw_a16[ss, bp + 0x6]);          /* mov ax, [bp+0x6] */
            ii(0x15_43d3, 3); mov(memw_a16[ss, bp - 0x10], ax);         /* mov [bp-0x10], ax */
            ii(0x15_43d6, 3); pushw(memw_a16[ss, bp + 0x8]);            /* push word [bp+0x8] */
            ii(0x15_43d9, 3); pushw(memw_a16[ss, bp + 0x8]);            /* push word [bp+0x8] */
            ii(0x15_43dc, 3); lea(ax, bp - 0x14);                       /* lea ax, [bp-0x14] */
            ii(0x15_43df, 1); pushw(ss);                                /* push ss */
            ii(0x15_43e0, 1); pushw(ax);                                /* push ax */
            ii(0x15_43e1, 3); pushw(0xff00);                            /* push 0xff00 */
            ii(0x15_43e4, 1); nop();                                    /* nop */
            ii(0x15_43e5, 1); pushw(cs);                                /* push cs */
            ii(0x15_43e6, 3); callw(0x15_4188, -0x261);                 /* call 0x4188 */
            ii(0x15_43e9, 3); add(sp, 0xa);                             /* add sp, 0xa */
            ii(0x15_43ec, 1); popw(ds);                                 /* pop ds */
            ii(0x15_43ed, 1); leavew();                                 /* leave */
            ii(0x15_43ee, 1); retfw(); return;                          /* retf */
        }
    }
}
