using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("3a1ac3f7-37e7-4504-8123-687b224e6394")]
        public void Method_0013_7408()
        {
            ii(0x13_7408, 4); enterw(0x14, 0);                          /* enter 0x14, 0x0 */
            ii(0x13_740c, 1); pushw(ds);                                /* push ds */
            ii(0x13_740d, 3); mov(ax, 0x3e68);                          /* mov ax, 0x3e68 */
            ii(0x13_7410, 2); mov(ds, ax);                              /* mov ds, ax */
            ii(0x13_7412, 2); sub(ax, ax);                              /* sub ax, ax */
            ii(0x13_7414, 3); mov(memw_a16[ss, bp - 0x14], ax);         /* mov [bp-0x14], ax */
            ii(0x13_7417, 3); mov(memw_a16[ss, bp - 0x12], ax);         /* mov [bp-0x12], ax */
            ii(0x13_741a, 5); mov(memw_a16[ss, bp - 0x6], 0x1500);      /* mov word [bp-0x6], 0x1500 */
            ii(0x13_741f, 3); lea(ax, bp - 0x14);                       /* lea ax, [bp-0x14] */
            ii(0x13_7422, 1); pushw(ss);                                /* push ss */
            ii(0x13_7423, 1); pushw(ax);                                /* push ax */
            ii(0x13_7424, 3); pushw(0xff00);                            /* push 0xff00 */
            ii(0x13_7427, 1); nop();                                    /* nop */
            ii(0x13_7428, 1); pushw(cs);                                /* push cs */
            ii(0x13_7429, 3); callw(0x13_eaed, 0x76c1);                 /* call 0xeaed */
            ii(0x13_742c, 3); add(sp, 0x6);                             /* add sp, 0x6 */
            ii(0x13_742f, 2); or(ax, ax);                               /* or ax, ax */
            ii(0x13_7431, 2); if(jnzw(0x13_7436, 0x3)) goto l_0x13_7436; /* jnz 0x7436 */
            ii(0x13_7433, 1); popw(ds);                                 /* pop ds */
            ii(0x13_7434, 1); leavew();                                 /* leave */
            ii(0x13_7435, 1); retfw(); return;                          /* retf */
        l_0x13_7436:
            ii(0x13_7436, 3); mov(ax, memw_a16[ss, bp - 0x6]);          /* mov ax, [bp-0x6] */
            ii(0x13_7439, 3); mov(memw_a16[ds, 0x1ea0], ax);            /* mov [0x1ea0], ax */
            ii(0x13_743c, 3); mov(ax, memw_a16[ss, bp - 0x2]);          /* mov ax, [bp-0x2] */
            ii(0x13_743f, 3); mov(memw_a16[ds, 0x1e9e], ax);            /* mov [0x1e9e], ax */
            ii(0x13_7442, 3); mov(ax, memw_a16[ss, bp - 0x4]);          /* mov ax, [bp-0x4] */
            ii(0x13_7445, 3); mov(memw_a16[ds, 0x1ea4], ax);            /* mov [0x1ea4], ax */
            ii(0x13_7448, 3); mov(ax, memw_a16[ss, bp - 0x8]);          /* mov ax, [bp-0x8] */
            ii(0x13_744b, 3); mov(memw_a16[ds, 0x1ea2], ax);            /* mov [0x1ea2], ax */
            ii(0x13_744e, 3); mov(ax, 0x1);                             /* mov ax, 0x1 */
            ii(0x13_7451, 1); popw(ds);                                 /* pop ds */
            ii(0x13_7452, 1); leavew();                                 /* leave */
            ii(0x13_7453, 1); retfw(); return;                          /* retf */
        }
    }
}
