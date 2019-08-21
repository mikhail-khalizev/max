using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100b_a73a-20d71c70")]
        public void Method_100b_a73a()
        {
            ii(0x100b_a73a, 5); mov(ebx, 0x5);                          /* mov ebx, 0x5 */
            ii(0x100b_a73f, 5); mov(edx, 0x36);                         /* mov edx, 0x36 */
            ii(0x100b_a744, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_a747, 5); calld(0x100b_a2c3, -0x489);             /* call 0x100ba2c3 */
            ii(0x100b_a74c, 5); mov(ebx, 0x5);                          /* mov ebx, 0x5 */
            ii(0x100b_a751, 5); mov(edx, 0x49);                         /* mov edx, 0x49 */
            ii(0x100b_a756, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_a759, 5); calld(0x100b_a2c3, -0x49b);             /* call 0x100ba2c3 */
            ii(0x100b_a75e, 5); if(jmpd_func(0x100b_a9b9, 0x256)) return; /* jmp 0x100ba9b9 */
        }
    }
}
