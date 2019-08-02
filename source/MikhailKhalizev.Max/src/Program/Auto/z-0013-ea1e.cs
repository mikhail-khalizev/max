using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("4761ddc7-2abc-430a-a00c-90508e15fa62")]
        public void Method_0013_ea1e()
        {
            ii(0x13_ea1e, 4); enterw(0, 0);                             /* enter 0x0, 0x0 */
            ii(0x13_ea22, 1); pushw(ds);                                /* push ds */
            ii(0x13_ea23, 3); mov(ax, 0x3e68);                          /* mov ax, 0x3e68 */
            ii(0x13_ea26, 2); mov(ds, ax);                              /* mov ds, ax */
            ii(0x13_ea28, 3); pushw(memw_a16[ss, bp + 0xa]);            /* push word [bp+0xa] */
            ii(0x13_ea2b, 3); mov(ax, memw_a16[ss, bp + 0x8]);          /* mov ax, [bp+0x8] */
            ii(0x13_ea2e, 2); sub(dx, dx);                              /* sub dx, dx */
            ii(0x13_ea30, 2); mov(cl, 0x4);                             /* mov cl, 0x4 */
        l_0x13_ea32:
            ii(0x13_ea32, 2); shl(ax, 0x1);                             /* shl ax, 1 */
            ii(0x13_ea34, 2); rcl(dx, 0x1);                             /* rcl dx, 1 */
            ii(0x13_ea36, 2); dec(cl);                                  /* dec cl */
            ii(0x13_ea38, 2); if(jnzw(0x13_ea32, -0x8)) goto l_0x13_ea32; /* jnz 0xea32 */
            ii(0x13_ea3a, 3); add(ax, memw_a16[ss, bp + 0x6]);          /* add ax, [bp+0x6] */
            ii(0x13_ea3d, 3); adc(dx, 0);                               /* adc dx, 0x0 */
            ii(0x13_ea40, 1); pushw(dx);                                /* push dx */
            ii(0x13_ea41, 1); pushw(ax);                                /* push ax */
            ii(0x13_ea42, 1); pushw(cs);                                /* push cs */
            ii(0x13_ea43, 3); callw(0x13_e96a, -0xdc);                  /* call 0xe96a */
            ii(0x13_ea46, 3); add(sp, 0x6);                             /* add sp, 0x6 */
            ii(0x13_ea49, 1); popw(ds);                                 /* pop ds */
            ii(0x13_ea4a, 1); leavew();                                 /* leave */
            ii(0x13_ea4b, 1); retfw(); return;                          /* retf */
        }
    }
}
