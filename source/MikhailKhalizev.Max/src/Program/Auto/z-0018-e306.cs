using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x18_e306-2709a49c")]
        public void Method_0018_e306()
        {
            ii(0x18_e306, 3);  movsd_a32();                            /* a32 movsd */
            ii(0x18_e309, 3);  movsd_a32();                            /* a32 movsd */
            ii(0x18_e30c, 3);  if(jmp_func(0x18_e067, -0x2a8)) return; /* jmp 0xe067 */
        }
    }
}
