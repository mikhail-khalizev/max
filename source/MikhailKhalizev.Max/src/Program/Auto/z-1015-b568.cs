using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1015_b568-e315284e")]
        public void Method_1015_b568()
        {
            ii(0x1015_b568, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_b56b, 7); mov(memd_a32[ds, eax + 0xa], 0x101c_afd4); /* mov dword [eax+0xa], 0x101cafd4 */
            ii(0x1015_b572, 5); if(jmpd_func(0x1015_b725, 0x1ae)) return; /* jmp 0x1015b725 */
        }
    }
}
