using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("c1d64c18-b5a6-4031-8789-42faca286b2a")]
        public void Method_0014_ab00()
        {
            ii(0x14_ab00, 3); cmp(cx, 0x10);                            /* cmp cx, 0x10 */
            ii(0x14_ab03, 2); if(jaew(0x14_ab13, 0xe)) goto l_0x14_ab13; /* jae 0xab13 */
            ii(0x14_ab05, 2); test(al, 0xf);                            /* test al, 0xf */
            ii(0x14_ab07, 2); if(jnzw(0x14_ab13, 0xa)) goto l_0x14_ab13; /* jnz 0xab13 */
            ii(0x14_ab09, 3); shr(ax, 0x4);                             /* shr ax, 0x4 */
            ii(0x14_ab0c, 3); shl(cl, 0x4);                             /* shl cl, 0x4 */
            ii(0x14_ab0f, 2); or(ah, cl);                               /* or ah, cl */
            ii(0x14_ab11, 1); stc();                                    /* stc */
            ii(0x14_ab12, 1); retw(); return;                           /* ret */
        l_0x14_ab13:
            ii(0x14_ab13, 3); mov(ax, memw_a16[ds, 0x9b4]);             /* mov ax, [0x9b4] */
            ii(0x14_ab16, 1); clc();                                    /* clc */
            ii(0x14_ab17, 1); retw(); return;                           /* ret */
        }
    }
}
