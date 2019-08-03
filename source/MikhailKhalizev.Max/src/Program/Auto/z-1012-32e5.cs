using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("c3485c21-b6e9-432e-a534-6f0d875145f5")]
        public void Method_1012_32e5()
        {
            ii(0x1012_32e5, 5); pushd(0x70);                            /* push 0x70 */
            ii(0x1012_32ea, 5); calld(Definitions.sys_check_available_stack_size, 0x42a63); /* call 0x10165d52 */
            ii(0x1012_32ef, 1); pushd(ebx);                             /* push ebx */
            ii(0x1012_32f0, 1); pushd(ecx);                             /* push ecx */
            ii(0x1012_32f1, 1); pushd(edx);                             /* push edx */
            ii(0x1012_32f2, 1); pushd(esi);                             /* push esi */
            ii(0x1012_32f3, 1); pushd(edi);                             /* push edi */
            ii(0x1012_32f4, 1); pushd(ebp);                             /* push ebp */
            ii(0x1012_32f5, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1012_32f7, 6); sub(esp, 0x54);                         /* sub esp, 0x54 */
            ii(0x1012_32fd, 4); or(memb_a32[ss, ebp - 0x4], 0x1);       /* or byte [ebp-0x4], 0x1 */
            ii(0x1012_3301, 5); mov(ebx, 0x6c1);                        /* mov ebx, 0x6c1 */
            ii(0x1012_3306, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1012_3308, 3); lea(eax, ebp - 0x54);                   /* lea eax, [ebp-0x54] */
            ii(0x1012_330b, 5); calld(0x1012_13b0, -0x1f60);            /* call 0x101213b0 */
            ii(0x1012_3310, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1012_3313, 4); and(memb_a32[ss, ebp - 0x4], -0x2 /* 0xfe */); /* and byte [ebp-0x4], 0xfe */
            ii(0x1012_3317, 3); lea(eax, ebp - 0x54);                   /* lea eax, [ebp-0x54] */
            ii(0x1012_331a, 5); calld(0x1012_31dd, -0x142);             /* call 0x101231dd */
            ii(0x1012_331f, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1012_3321, 3); lea(eax, ebp - 0x54);                   /* lea eax, [ebp-0x54] */
            ii(0x1012_3324, 5); calld(0x1012_1791, -0x1b98);            /* call 0x10121791 */
            ii(0x1012_3329, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1012_332b, 1); popd(ebp);                              /* pop ebp */
            ii(0x1012_332c, 1); popd(edi);                              /* pop edi */
            ii(0x1012_332d, 1); popd(esi);                              /* pop esi */
            ii(0x1012_332e, 1); popd(edx);                              /* pop edx */
            ii(0x1012_332f, 1); popd(ecx);                              /* pop ecx */
            ii(0x1012_3330, 1); popd(ebx);                              /* pop ebx */
            ii(0x1012_3331, 1); retd(); return;                         /* ret */
        }
    }
}
