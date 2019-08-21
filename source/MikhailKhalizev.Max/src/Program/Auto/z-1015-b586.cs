using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1015_b586-ce022e80")]
        public void Method_1015_b586()
        {
            ii(0x1015_b586, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_b589, 7); mov(memd_a32[ds, eax + 0xa], 0x101c_afe4); /* mov dword [eax+0xa], 0x101cafe4 */
            ii(0x1015_b590, 5); if(jmpd_func(0x1015_b725, 0x190)) return; /* jmp 0x1015b725 */
        }
    }
}
