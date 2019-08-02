using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("c0fe6b61-c535-4bb1-80cb-e61ae0811599")]
        public void Method_0014_e306()
        {
            ii(0x14_e306, 3); movsd_a32();                              /* a32 movsd */
            ii(0x14_e309, 3); movsd_a32();                              /* a32 movsd */
            ii(0x14_e30c, 3); jmpw_func(0x14_e067, -0x2a8); return;     /* jmp 0xe067 */
        }
    }
}
