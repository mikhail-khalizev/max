using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("d008013b-292e-493a-a414-fd086f3d3c5c")]
        public void Method_1009_b06b()
        {
            ii(0x1009_b06b, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1009_b070, 5); calld(Definitions.sys_check_available_stack_size, 0xc_acdd); /* call 0x10165d52 */
            ii(0x1009_b075, 1); pushd(ebx);                             /* push ebx */
            ii(0x1009_b076, 1); pushd(ecx);                             /* push ecx */
            ii(0x1009_b077, 1); pushd(edx);                             /* push edx */
            ii(0x1009_b078, 1); pushd(esi);                             /* push esi */
            ii(0x1009_b079, 1); pushd(edi);                             /* push edi */
            ii(0x1009_b07a, 1); pushd(ebp);                             /* push ebp */
            ii(0x1009_b07b, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1009_b07d, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1009_b083, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1009_b086, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1009_b089, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x1009_b08c, 5); calld(0x1007_6338, -0x2_4d59);          /* call 0x10076338 */
            ii(0x1009_b091, 3); lea(ebx, ebp - 0x8);                    /* lea ebx, [ebp-0x8] */
            ii(0x1009_b094, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1009_b096, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1009_b098, 5); calld(0x1007_64b8, -0x2_4be5);          /* call 0x100764b8 */
            ii(0x1009_b09d, 2); jmpd(0x1009_b0a7, 0x8); goto l_0x1009_b0a7; /* jmp 0x1009b0a7 */
        l_0x1009_b09f:
            ii(0x1009_b09f, 3); lea(eax, ebp - 0x8);                    /* lea eax, [ebp-0x8] */
            ii(0x1009_b0a2, 5); calld(0x1007_6bf8, -0x2_44af);          /* call 0x10076bf8 */
        l_0x1009_b0a7:
            ii(0x1009_b0a7, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1009_b0a9, 3); lea(eax, ebp - 0x8);                    /* lea eax, [ebp-0x8] */
            ii(0x1009_b0ac, 5); calld(0x1013_ad71, 0x9_fcc0);           /* call 0x1013ad71 */
            ii(0x1009_b0b1, 2); test(al, al);                           /* test al, al */
            ii(0x1009_b0b3, 2); if(jzd(0x1009_b0d4, 0x1f)) goto l_0x1009_b0d4; /* jz 0x1009b0d4 */
            ii(0x1009_b0b5, 5); calld(0x1008_a79c, -0x1_091e);          /* call 0x1008a79c */
            ii(0x1009_b0ba, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1009_b0bc, 2); mov(bl, al);                            /* mov bl, al */
            ii(0x1009_b0be, 3); lea(eax, ebp - 0x8);                    /* lea eax, [ebp-0x8] */
            ii(0x1009_b0c1, 5); calld(0x1007_63d4, -0x2_4cf2);          /* call 0x100763d4 */
            ii(0x1009_b0c6, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1009_b0c8, 5); mov(eax, 0x101c_3180);                  /* mov eax, 0x101c3180 */
            ii(0x1009_b0cd, 5); calld(0x100a_53ac, 0xa2da);             /* call 0x100a53ac */
            ii(0x1009_b0d2, 2); jmpd(0x1009_b09f, -0x35); goto l_0x1009_b09f; /* jmp 0x1009b09f */
        l_0x1009_b0d4:
            ii(0x1009_b0d4, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1009_b0d7, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x1009_b0da, 5); calld(0x1013_a6f4, 0x9_f615);           /* call 0x1013a6f4 */
            ii(0x1009_b0df, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1009_b0e1, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1009_b0e4, 3); add(eax, 0xf);                          /* add eax, 0xf */
            ii(0x1009_b0e7, 5); calld(0x1008_afe4, -0x1_0108);          /* call 0x1008afe4 */
            ii(0x1009_b0ec, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1009_b0ef, 5); mov(eax, 0x101c_3180);                  /* mov eax, 0x101c3180 */
            ii(0x1009_b0f4, 5); calld(0x100a_5e27, 0xad2e);             /* call 0x100a5e27 */
            ii(0x1009_b0f9, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1009_b0fb, 3); lea(eax, ebp - 0x8);                    /* lea eax, [ebp-0x8] */
            ii(0x1009_b0fe, 5); calld(0x1007_5f6c, -0x2_5197);          /* call 0x10075f6c */
            ii(0x1009_b103, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1009_b105, 1); popd(ebp);                              /* pop ebp */
            ii(0x1009_b106, 1); popd(edi);                              /* pop edi */
            ii(0x1009_b107, 1); popd(esi);                              /* pop esi */
            ii(0x1009_b108, 1); popd(edx);                              /* pop edx */
            ii(0x1009_b109, 1); popd(ecx);                              /* pop ecx */
            ii(0x1009_b10a, 1); popd(ebx);                              /* pop ebx */
            ii(0x1009_b10b, 1); retd(); return;                         /* ret */
        }
    }
}
