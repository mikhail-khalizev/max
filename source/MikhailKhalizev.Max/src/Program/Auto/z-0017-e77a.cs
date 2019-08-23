using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x17_e77a-88d103ea")]
        public void Method_0017_e77a()
        {
            ii(0x17_e77a, 4); enterw(0x14, 0);                          /* enter 0x14, 0x0 */
            ii(0x17_e77e, 1); pushw(ds);                                /* push ds */
            ii(0x17_e77f, 3); mov(ax, 0x3e68);                          /* mov ax, 0x3e68 */
            ii(0x17_e782, 2); mov(ds, ax);                              /* mov ds, ax */
            ii(0x17_e784, 3); mov(ax, memw_a16[ss, bp + 0x6]);          /* mov ax, [bp+0x6] */
            ii(0x17_e787, 3); mov(memw_a16[ss, bp - 0x6], ax);          /* mov [bp-0x6], ax */
            ii(0x17_e78a, 2); pushw(0);                                 /* push 0x0 */
            ii(0x17_e78c, 2); pushw(0);                                 /* push 0x0 */
            ii(0x17_e78e, 3); lea(ax, bp - 0x14);                       /* lea ax, [bp-0x14] */
            ii(0x17_e791, 1); pushw(ss);                                /* push ss */
            ii(0x17_e792, 1); pushw(ax);                                /* push ax */
            ii(0x17_e793, 2); pushw(-0x1 /* 0xff */);                   /* push 0xffff */
            ii(0x17_e795, 1); nop();                                    /* nop */
            ii(0x17_e796, 1); pushw(cs);                                /* push cs */
            ii(0x17_e797, 3); callw(0x17_eb40, 0x3a6);                  /* call 0xeb40 */
            ii(0x17_e79a, 3); add(sp, 0xa);                             /* add sp, 0xa */
            ii(0x17_e79d, 3); mov(ah, memb_a16[ss, bp - 0x2]);          /* mov ah, [bp-0x2] */
            ii(0x17_e7a0, 2); sub(al, al);                              /* sub al, al */
            ii(0x17_e7a2, 3); sar(ax, 0x8);                             /* sar ax, 0x8 */
            ii(0x17_e7a5, 1); popw(ds);                                 /* pop ds */
            ii(0x17_e7a6, 1); leavew();                                 /* leave */
            ii(0x17_e7a7, 1); retfw();                                  /* retf */
        }
    }
}
