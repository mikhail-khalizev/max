using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x17_ea1e-a296786d")]
        public void Method_0017_ea1e()
        {
            ii(0x17_ea1e, 4); enter(0, 0);                              /* enter 0x0, 0x0 */
            ii(0x17_ea22, 1); push(ds);                                 /* push ds */
            ii(0x17_ea23, 3); mov(ax, 0x3e68);                          /* mov ax, 0x3e68 */
            ii(0x17_ea26, 2); mov(ds, ax);                              /* mov ds, ax */
            ii(0x17_ea28, 3); push(memw[ss, bp + 0xa]);                 /* push word [bp+0xa] */
            ii(0x17_ea2b, 3); mov(ax, memw[ss, bp + 8]);                /* mov ax, [bp+0x8] */
            ii(0x17_ea2e, 2); sub(dx, dx);                              /* sub dx, dx */
            ii(0x17_ea30, 2); mov(cl, 4);                               /* mov cl, 0x4 */
        l_0x17_ea32:
            ii(0x17_ea32, 2); shl(ax, 1);                               /* shl ax, 1 */
            ii(0x17_ea34, 2); rcl(dx, 1);                               /* rcl dx, 1 */
            ii(0x17_ea36, 2); dec(cl);                                  /* dec cl */
            ii(0x17_ea38, 2); if(jnz(0x17_ea32, -8)) goto l_0x17_ea32;  /* jnz 0xea32 */
            ii(0x17_ea3a, 3); add(ax, memw[ss, bp + 6]);                /* add ax, [bp+0x6] */
            ii(0x17_ea3d, 3); adc(dx, 0);                               /* adc dx, 0x0 */
            ii(0x17_ea40, 1); push(dx);                                 /* push dx */
            ii(0x17_ea41, 1); push(ax);                                 /* push ax */
            ii(0x17_ea42, 1); push(cs);                                 /* push cs */
            ii(0x17_ea43, 3); call(0x17_e96a, -0xdc);                   /* call 0xe96a */
            ii(0x17_ea46, 3); add(sp, 6);                               /* add sp, 0x6 */
            ii(0x17_ea49, 1); pop(ds);                                  /* pop ds */
            ii(0x17_ea4a, 1); leave();                                  /* leave */
            ii(0x17_ea4b, 1); retf();                                   /* retf */
        }
    }
}
