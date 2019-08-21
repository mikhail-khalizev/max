using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100c_6a30-95f5facf")]
        public void Method_100c_6a30()
        {
            ii(0x100c_6a30, 5); mov(ebx, 0x3);                          /* mov ebx, 0x3 */
            ii(0x100c_6a35, 5); mov(edx, 0x36);                         /* mov edx, 0x36 */
            ii(0x100c_6a3a, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x100c_6a3d, 5); calld(0x100c_64f5, -0x54d);             /* call 0x100c64f5 */
            ii(0x100c_6a42, 4); cmp(memb_a32[ss, ebp - 0x4], 0);        /* cmp byte [ebp-0x4], 0x0 */
            ii(0x100c_6a46, 6); if(jnzd(0x100c_6aee, 0xa2)) goto l_0x100c_6aee; /* jnz 0x100c6aee */
            ii(0x100c_6a4c, 5); mov(ebx, 0x7);                          /* mov ebx, 0x7 */
            ii(0x100c_6a51, 5); mov(edx, 0x3a);                         /* mov edx, 0x3a */
            ii(0x100c_6a56, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x100c_6a59, 5); calld(0x100c_64f5, -0x569);             /* call 0x100c64f5 */
            ii(0x100c_6a5e, 5); mov(ebx, 0x1);                          /* mov ebx, 0x1 */
            ii(0x100c_6a63, 5); mov(edx, 0x36);                         /* mov edx, 0x36 */
            ii(0x100c_6a68, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x100c_6a6b, 5); calld(0x100c_64f5, -0x57b);             /* call 0x100c64f5 */
            ii(0x100c_6a70, 5); mov(ebx, 0x8);                          /* mov ebx, 0x8 */
            ii(0x100c_6a75, 5); mov(edx, 0x3a);                         /* mov edx, 0x3a */
            ii(0x100c_6a7a, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x100c_6a7d, 5); calld(0x100c_64f5, -0x58d);             /* call 0x100c64f5 */
            ii(0x100c_6a82, 5); mov(ebx, 0x8);                          /* mov ebx, 0x8 */
            ii(0x100c_6a87, 5); mov(edx, 0x36);                         /* mov edx, 0x36 */
            ii(0x100c_6a8c, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x100c_6a8f, 5); calld(0x100c_64f5, -0x59f);             /* call 0x100c64f5 */
            ii(0x100c_6a94, 5); mov(ebx, 0x3);                          /* mov ebx, 0x3 */
            ii(0x100c_6a99, 5); mov(edx, 0x49);                         /* mov edx, 0x49 */
            ii(0x100c_6a9e, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x100c_6aa1, 5); calld(0x100c_64f5, -0x5b1);             /* call 0x100c64f5 */
            ii(0x100c_6aa6, 5); mov(ebx, 0x1);                          /* mov ebx, 0x1 */
            ii(0x100c_6aab, 5); mov(edx, 0x49);                         /* mov edx, 0x49 */
            ii(0x100c_6ab0, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x100c_6ab3, 5); calld(0x100c_64f5, -0x5c3);             /* call 0x100c64f5 */
            ii(0x100c_6ab8, 5); mov(ebx, 0x8);                          /* mov ebx, 0x8 */
            ii(0x100c_6abd, 5); mov(edx, 0x49);                         /* mov edx, 0x49 */
            ii(0x100c_6ac2, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x100c_6ac5, 5); calld(0x100c_64f5, -0x5d5);             /* call 0x100c64f5 */
            ii(0x100c_6aca, 5); mov(ebx, 0x7);                          /* mov ebx, 0x7 */
            ii(0x100c_6acf, 5); mov(edx, 0x44);                         /* mov edx, 0x44 */
            ii(0x100c_6ad4, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x100c_6ad7, 5); calld(0x100c_64f5, -0x5e7);             /* call 0x100c64f5 */
            ii(0x100c_6adc, 5); mov(ebx, 0x8);                          /* mov ebx, 0x8 */
            ii(0x100c_6ae1, 5); mov(edx, 0x44);                         /* mov edx, 0x44 */
            ii(0x100c_6ae6, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x100c_6ae9, 5); calld(0x100c_64f5, -0x5f9);             /* call 0x100c64f5 */
        l_0x100c_6aee:
            ii(0x100c_6aee, 5); if(jmpd_func(0x100c_7115, 0x622)) return; /* jmp 0x100c7115 */
        }
    }
}
