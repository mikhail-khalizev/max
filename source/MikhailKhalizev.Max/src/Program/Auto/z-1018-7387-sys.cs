using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("45054907-b3cc-4109-a59f-2e177861d91d")]
        public void /* sys */ Method_1018_7387()
        {
            ii(0x1018_7387, 3); sub(esp, 0x2c);                         /* sub esp, 0x2c */
            ii(0x1018_738a, 7); if(jmpd_abs(memd_a32[ds, eax * 4 + 0x101c_3080])) return; /* jmp dword [eax*4+0x101c3080] */
        }
    }
}
