using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1008_cd28-c7fb556e")]
        public void Method_1008_cd28()
        {
            ii(0x1008_cd28, 5); mov(edx, StringDefinitions.UnknownState); /* mov edx, 0x101a0546 */
            ii(0x1008_cd2d, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_cd30, 5); calld(Definitions.sys_strcat, 0xd_91fc); /* call 0x10165f31 */
            ii(0x1008_cd35, 2); if(jmpd_func(0x1008_cd83, 0x4c)) return; /* jmp 0x1008cd83 */
        }
    }
}
