using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100f_6185-a9c95fbf")]
        public void Method_100f_6185()
        {
            ii(0x100f_6185, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100f_6187, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x100f_618a, 5); calld(0x1007_5f6c, -0x8_0223);          /* call 0x10075f6c */
        }
    }
}
