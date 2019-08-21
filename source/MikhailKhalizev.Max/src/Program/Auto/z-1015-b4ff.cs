using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1015_b4ff-833e7163")]
        public void Method_1015_b4ff()
        {
            ii(0x1015_b4ff, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_b502, 7); mov(memd_a32[ds, eax + 0xa], 0x101c_b01c); /* mov dword [eax+0xa], 0x101cb01c */
            ii(0x1015_b509, 5); if(jmpd_func(0x1015_b725, 0x217)) return; /* jmp 0x1015b725 */
        }
    }
}
