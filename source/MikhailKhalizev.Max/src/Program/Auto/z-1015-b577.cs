using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1015_b577-34ba9a57")]
        public void Method_1015_b577()
        {
            ii(0x1015_b577, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_b57a, 7); mov(memd_a32[ds, eax + 0xa], 0x101c_afdc); /* mov dword [eax+0xa], 0x101cafdc */
            ii(0x1015_b581, 5); if(jmpd_func(0x1015_b725, 0x19f)) return; /* jmp 0x1015b725 */
        }
    }
}
