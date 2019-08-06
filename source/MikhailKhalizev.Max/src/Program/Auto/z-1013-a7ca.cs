using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("43f7ace6-cc0f-487e-b249-ca71eb91d407")]
        public void Method_1013_a7ca()
        {
            ii(0x1013_a7ca, 5); pushd(0x28);                            /* push 0x28 */
            ii(0x1013_a7cf, 5); calld(Definitions.sys_check_available_stack_size, 0x2b57e); /* call 0x10165d52 */
            ii(0x1013_a7d4, 1); pushd(ebx);                             /* push ebx */
            ii(0x1013_a7d5, 1); pushd(ecx);                             /* push ecx */
            ii(0x1013_a7d6, 1); pushd(esi);                             /* push esi */
            ii(0x1013_a7d7, 1); pushd(edi);                             /* push edi */
            ii(0x1013_a7d8, 1); pushd(ebp);                             /* push ebp */
            ii(0x1013_a7d9, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1013_a7db, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x1013_a7e1, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1013_a7e4, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1013_a7e7, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1013_a7ea, 5); calld(0x1013_a6f4, -0xfb);              /* call 0x1013a6f4 */
            ii(0x1013_a7ef, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1013_a7f2, 5); calld(0x1007_6b58, -0xc3c9f);           /* call 0x10076b58 */
            ii(0x1013_a7f7, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1013_a7f9, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x1013_a7fc, 5); calld(0x1007_6d14, -0xc3aed);           /* call 0x10076d14 */
            ii(0x1013_a801, 2); jmpd(0x1013_a80b, 0x8); goto l_0x1013_a80b; /* jmp 0x1013a80b */
        l_0x1013_a803:
            ii(0x1013_a803, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x1013_a806, 5); calld(0x1007_6bf8, -0xc3c13);           /* call 0x10076bf8 */
        l_0x1013_a80b:
            ii(0x1013_a80b, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1013_a80d, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x1013_a810, 5); calld(0x1013_ad71, 0x55c);              /* call 0x1013ad71 */
            ii(0x1013_a815, 2); test(al, al);                           /* test al, al */
            ii(0x1013_a817, 2); if(jzd(0x1013_a82d, 0x14)) goto l_0x1013_a82d; /* jz 0x1013a82d */
            ii(0x1013_a819, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x1013_a81c, 5); calld(0x1007_6c30, -0xc3bf1);           /* call 0x10076c30 */
            ii(0x1013_a821, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1013_a823, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1013_a826, 5); calld(0x1013_a2ab, -0x580);             /* call 0x1013a2ab */
            ii(0x1013_a82b, 2); jmpd(0x1013_a803, -0x2a); goto l_0x1013_a803; /* jmp 0x1013a803 */
        l_0x1013_a82d:
            ii(0x1013_a82d, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1013_a830, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1013_a833, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1013_a835, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x1013_a838, 5); calld(0x1007_5e24, -0xc4a19);           /* call 0x10075e24 */
            ii(0x1013_a83d, 2); jmpd(0x1013_a849, 0xa); goto l_0x1013_a849; /* jmp 0x1013a849 */
        //  ii(0x1013_a83f, 10); Недостижимый код.
        l_0x1013_a849:
            ii(0x1013_a849, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1013_a84c, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1013_a84e, 1); popd(ebp);                              /* pop ebp */
            ii(0x1013_a84f, 1); popd(edi);                              /* pop edi */
            ii(0x1013_a850, 1); popd(esi);                              /* pop esi */
            ii(0x1013_a851, 1); popd(ecx);                              /* pop ecx */
            ii(0x1013_a852, 1); popd(ebx);                              /* pop ebx */
            ii(0x1013_a853, 1); retd(); return;                         /* ret */
        }
    }
}
