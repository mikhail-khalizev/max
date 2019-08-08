using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("fd951e95-443f-4968-8816-0f9c9c9922f6")]
        public void Method_100d_66a4()
        {
            ii(0x100d_66a4, 3); mov(eax, memd_a32[ss, ebp - 0x30]);     /* mov eax, [ebp-0x30] */
            ii(0x100d_66a7, 5); calld(Definitions.sys_free, 0x9_4a15);  /* call 0x1016b0c1 */
        }
    }
}
