using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1015_b595-1fc1f2b9")]
        public void Method_1015_b595()
        {
            ii(0x1015_b595, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_b598, 7); mov(memd_a32[ds, eax + 0xa], 0x101c_afec); /* mov dword [eax+0xa], 0x101cafec */
            ii(0x1015_b59f, 5); if(jmpd_func(0x1015_b725, 0x181)) return; /* jmp 0x1015b725 */
        }
    }
}
