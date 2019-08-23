using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x18_e054-a9dd7050")]
        public void Method_0018_e054()
        {
            ii(0x18_e054, 2); cmp(bl, ah);                              /* cmp bl, ah */
            ii(0x18_e056, 2); if(jaew_func(0x18_e062, 0xa)) return;     /* jae 0xe062 */
            ii(0x18_e058, 2); shl(bx, 0x1);                             /* shl bx, 1 */
            ii(0x18_e05a, 1); cld();                                    /* cld */
            ii(0x18_e05b, 3); jmpw_abs(memw_a16[cs, bx + si]);          /* jmp word [cs:bx+si] */
        }
    }
}
