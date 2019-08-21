using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100b_a8a1-1508104d")]
        public void Method_100b_a8a1()
        {
            ii(0x100b_a8a1, 5); mov(ebx, 0x3);                          /* mov ebx, 0x3 */
            ii(0x100b_a8a6, 5); mov(edx, 0x34);                         /* mov edx, 0x34 */
            ii(0x100b_a8ab, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_a8ae, 5); calld(0x100b_a2c3, -0x5f0);             /* call 0x100ba2c3 */
            ii(0x100b_a8b3, 5); mov(ebx, 0x2);                          /* mov ebx, 0x2 */
            ii(0x100b_a8b8, 5); mov(edx, 0x4d);                         /* mov edx, 0x4d */
            ii(0x100b_a8bd, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_a8c0, 5); calld(0x100b_a2c3, -0x602);             /* call 0x100ba2c3 */
            ii(0x100b_a8c5, 5); mov(ebx, 0x2);                          /* mov ebx, 0x2 */
            ii(0x100b_a8ca, 5); mov(edx, 0x37);                         /* mov edx, 0x37 */
            ii(0x100b_a8cf, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_a8d2, 5); calld(0x100b_a2c3, -0x614);             /* call 0x100ba2c3 */
            ii(0x100b_a8d7, 5); mov(ebx, 0x2);                          /* mov ebx, 0x2 */
            ii(0x100b_a8dc, 5); mov(edx, 0x45);                         /* mov edx, 0x45 */
            ii(0x100b_a8e1, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_a8e4, 5); calld(0x100b_a2c3, -0x626);             /* call 0x100ba2c3 */
            ii(0x100b_a8e9, 5); mov(ebx, 0x2);                          /* mov ebx, 0x2 */
            ii(0x100b_a8ee, 5); mov(edx, 0x44);                         /* mov edx, 0x44 */
            ii(0x100b_a8f3, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_a8f6, 5); calld(0x100b_a2c3, -0x638);             /* call 0x100ba2c3 */
            ii(0x100b_a8fb, 5); if(jmpd_func(0x100b_a9b9, 0xb9)) return; /* jmp 0x100ba9b9 */
        }
    }
}
