using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1015_b4c3-e9204a9f")]
        public void Method_1015_b4c3()
        {
            ii(0x1015_b4c3, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_b4c6, 7); mov(memd_a32[ds, eax + 0xa], 0x101c_b064); /* mov dword [eax+0xa], 0x101cb064 */
            ii(0x1015_b4cd, 5); if(jmpd_func(0x1015_b725, 0x253)) return; /* jmp 0x1015b725 */
        }
    }
}
