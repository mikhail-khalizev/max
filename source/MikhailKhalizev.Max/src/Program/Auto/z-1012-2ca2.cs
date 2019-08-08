using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("5faf04d1-e92b-44d6-a263-f72366536b3e")]
        public void Method_1012_2ca2()
        {
            ii(0x1012_2ca2, 5); mov(edx, 0x1b);                         /* mov edx, 0x1b */
            ii(0x1012_2ca7, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1012_2caa, 5); calld(0x1012_2716, -0x599);             /* call 0x10122716 */
            ii(0x1012_2caf, 7); mov(memd_a32[ss, ebp - 0x10], 0);       /* mov dword [ebp-0x10], 0x0 */
            ii(0x1012_2cb6, 2); if(jmpd_func(0x1012_2cbe, 0x6)) return; /* jmp 0x10122cbe */
        }
    }
}
