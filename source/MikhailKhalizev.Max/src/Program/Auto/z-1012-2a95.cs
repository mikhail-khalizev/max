using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1012_2a95-662daede")]
        public void Method_1012_2a95()
        {
            ii(0x1012_2a95, 5); mov(edx, 0xd);                          /* mov edx, 0xd */
            ii(0x1012_2a9a, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1012_2a9d, 5); calld(0x1012_2716, -0x38c);             /* call 0x10122716 */
            ii(0x1012_2aa2, 7); mov(memd_a32[ss, ebp - 0x10], 0);       /* mov dword [ebp-0x10], 0x0 */
            ii(0x1012_2aa9, 2); if(jmpd_func(0x1012_2ab1, 0x6)) return; /* jmp 0x10122ab1 */
        }
    }
}
