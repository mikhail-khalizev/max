using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("929e281d-09f8-4815-bff0-e8ff26ce0a15")]
        public void Method_0018_e306()
        {
            ii(0x18_e306, 3); movsd_a32();                              /* a32 movsd */
            ii(0x18_e309, 3); movsd_a32();                              /* a32 movsd */
            ii(0x18_e30c, 3); if(jmpw_func(0x18_e067, -0x2a8)) return;  /* jmp 0xe067 */
        }
    }
}
