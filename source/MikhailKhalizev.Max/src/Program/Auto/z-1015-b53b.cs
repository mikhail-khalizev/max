using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1015_b53b-14098d5c")]
        public void Method_1015_b53b()
        {
            ii(0x1015_b53b, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_b53e, 7); mov(memd_a32[ds, eax + 0xa], 0x101c_b06c); /* mov dword [eax+0xa], 0x101cb06c */
            ii(0x1015_b545, 5); if(jmpd_func(0x1015_b725, 0x1db)) return; /* jmp 0x1015b725 */
        }
    }
}
