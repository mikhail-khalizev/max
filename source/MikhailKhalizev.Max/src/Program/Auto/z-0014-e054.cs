using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("8a85d766-0abe-4ef2-ad64-9b799b480189")]
        public void Method_0014_e054()
        {
            ii(0x14_e054, 2); cmp(bl, ah);                              /* cmp bl, ah */
            ii(0x14_e056, 2); jaew_func(0x14_e062, 0xa);                /* jae 0xe062 */
            ii(0x14_e058, 2); shl(bx, 0x1);                             /* shl bx, 1 */
            ii(0x14_e05a, 1); cld();                                    /* cld */
            ii(0x14_e05b, 3); jmpw_abs(memw_a16[cs, bx + si]); return;  /* jmp word [cs:bx+si] */
        }
    }
}
