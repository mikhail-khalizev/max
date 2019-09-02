using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x19_43bc-41aba57a")]
        public void Method_0019_43bc()
        {
            ii(0x19_43bc, 4); enter(0x14, 0);                           /* enter 0x14, 0x0 */
            ii(0x19_43c0, 1); push(ds);                                 /* push ds */
            ii(0x19_43c1, 3); mov(ax, 0xa8);                            /* mov ax, 0xa8 */
            ii(0x19_43c4, 2); mov(ds, ax);                              /* mov ds, ax */
            ii(0x19_43c6, 5); mov(memw[ss, bp - 2], 0xff00);            /* mov word [bp-0x2], 0xff00 */
            ii(0x19_43cb, 5); mov(memw[ss, bp - 6], 0x1102);            /* mov word [bp-0x6], 0x1102 */
            ii(0x19_43d0, 3); mov(ax, memw[ss, bp + 6]);                /* mov ax, [bp+0x6] */
            ii(0x19_43d3, 3); mov(memw[ss, bp - 0x10], ax);             /* mov [bp-0x10], ax */
            ii(0x19_43d6, 3); push(memw[ss, bp + 8]);                   /* push word [bp+0x8] */
            ii(0x19_43d9, 3); push(memw[ss, bp + 8]);                   /* push word [bp+0x8] */
            ii(0x19_43dc, 3); lea(ax, memw[ss, bp - 0x14]);             /* lea ax, [bp-0x14] */
            ii(0x19_43df, 1); push(ss);                                 /* push ss */
            ii(0x19_43e0, 1); push(ax);                                 /* push ax */
            ii(0x19_43e1, 3); push(0xff00);                             /* push 0xff00 */
            ii(0x19_43e4, 1); nop();                                    /* nop */
            ii(0x19_43e5, 1); push(cs);                                 /* push cs */
            ii(0x19_43e6, 3); call(0x19_4188, -0x261);                  /* call 0x4188 */
            ii(0x19_43e9, 3); add(sp, 0xa);                             /* add sp, 0xa */
            ii(0x19_43ec, 1); pop(ds);                                  /* pop ds */
            ii(0x19_43ed, 1); leave();                                  /* leave */
            ii(0x19_43ee, 1); retf();                                   /* retf */
        }
    }
}
