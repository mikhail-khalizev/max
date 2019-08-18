using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("3d1ce2d2-8bb6-40ac-ae97-79aca063064f")]
        public void Method_1008_07ea()
        {
            ii(0x1008_07ea, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1008_07ef, 5); calld(Definitions.sys_check_available_stack_size, 0xe_555e); /* call 0x10165d52 */
            ii(0x1008_07f4, 1); pushd(ebx);                             /* push ebx */
            ii(0x1008_07f5, 1); pushd(ecx);                             /* push ecx */
            ii(0x1008_07f6, 1); pushd(edx);                             /* push edx */
            ii(0x1008_07f7, 1); pushd(esi);                             /* push esi */
            ii(0x1008_07f8, 1); pushd(edi);                             /* push edi */
            ii(0x1008_07f9, 1); pushd(ebp);                             /* push ebp */
            ii(0x1008_07fa, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1008_07fc, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1008_0802, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1008_0805, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_0808, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x1008_080b, 5); calld(0x1007_6338, -0xa4d8);            /* call 0x10076338 */
            ii(0x1008_0810, 3); lea(ebx, ebp - 0x8);                    /* lea ebx, [ebp-0x8] */
            ii(0x1008_0813, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1008_0815, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1008_0817, 5); calld(0x1007_64b8, -0xa364);            /* call 0x100764b8 */
            ii(0x1008_081c, 2); jmpd(0x1008_0826, 0x8); goto l_0x1008_0826; /* jmp 0x10080826 */
        l_0x1008_081e:
            ii(0x1008_081e, 3); lea(eax, ebp - 0x8);                    /* lea eax, [ebp-0x8] */
            ii(0x1008_0821, 5); calld(0x1007_6bf8, -0x9c2e);            /* call 0x10076bf8 */
        l_0x1008_0826:
            ii(0x1008_0826, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_0828, 3); lea(eax, ebp - 0x8);                    /* lea eax, [ebp-0x8] */
            ii(0x1008_082b, 5); calld(0x1013_ad71, 0xb_a541);           /* call 0x1013ad71 */
            ii(0x1008_0830, 2); test(al, al);                           /* test al, al */
            ii(0x1008_0832, 2); if(jzd(0x1008_0853, 0x1f)) goto l_0x1008_0853; /* jz 0x10080853 */
            ii(0x1008_0834, 5); calld(0x1008_a79c, 0x9f63);             /* call 0x1008a79c */
            ii(0x1008_0839, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1008_083b, 2); mov(bl, al);                            /* mov bl, al */
            ii(0x1008_083d, 3); lea(eax, ebp - 0x8);                    /* lea eax, [ebp-0x8] */
            ii(0x1008_0840, 5); calld(0x1007_63d4, -0xa471);            /* call 0x100763d4 */
            ii(0x1008_0845, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1008_0847, 5); mov(eax, 0x101c_3180);                  /* mov eax, 0x101c3180 */
            ii(0x1008_084c, 5); calld(0x100a_53ac, 0x2_4b5b);           /* call 0x100a53ac */
            ii(0x1008_0851, 2); jmpd(0x1008_081e, -0x35); goto l_0x1008_081e; /* jmp 0x1008081e */
        l_0x1008_0853:
            ii(0x1008_0853, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_0856, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x1008_0859, 5); calld(0x1013_a6f4, 0xb_9e96);           /* call 0x1013a6f4 */
            ii(0x1008_085e, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_0860, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_0863, 3); add(eax, 0xf);                          /* add eax, 0xf */
            ii(0x1008_0866, 5); calld(0x1008_afe4, 0xa779);             /* call 0x1008afe4 */
            ii(0x1008_086b, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1008_086e, 5); mov(eax, 0x101c_3180);                  /* mov eax, 0x101c3180 */
            ii(0x1008_0873, 5); calld(0x100a_5e27, 0x2_55af);           /* call 0x100a5e27 */
            ii(0x1008_0878, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_087a, 3); lea(eax, ebp - 0x8);                    /* lea eax, [ebp-0x8] */
            ii(0x1008_087d, 5); calld(0x1007_5f6c, -0xa916);            /* call 0x10075f6c */
            ii(0x1008_0882, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1008_0884, 1); popd(ebp);                              /* pop ebp */
            ii(0x1008_0885, 1); popd(edi);                              /* pop edi */
            ii(0x1008_0886, 1); popd(esi);                              /* pop esi */
            ii(0x1008_0887, 1); popd(edx);                              /* pop edx */
            ii(0x1008_0888, 1); popd(ecx);                              /* pop ecx */
            ii(0x1008_0889, 1); popd(ebx);                              /* pop ebx */
            ii(0x1008_088a, 1); retd(); return;                         /* ret */
        }
    }
}
