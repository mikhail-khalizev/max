using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100a_5307-79970631")]
        public void Method_100a_5307()
        {
            ii(0x100a_5307, 5); pushd(0x28);                            /* push 0x28 */
            ii(0x100a_530c, 5); calld(Definitions.sys_check_available_stack_size, 0xc_0a41); /* call 0x10165d52 */
            ii(0x100a_5311, 1); pushd(ebx);                             /* push ebx */
            ii(0x100a_5312, 1); pushd(ecx);                             /* push ecx */
            ii(0x100a_5313, 1); pushd(edx);                             /* push edx */
            ii(0x100a_5314, 1); pushd(esi);                             /* push esi */
            ii(0x100a_5315, 1); pushd(edi);                             /* push edi */
            ii(0x100a_5316, 1); pushd(ebp);                             /* push ebp */
            ii(0x100a_5317, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100a_5319, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x100a_531f, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x100a_5322, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_5325, 5); calld(0x1008_aef4, -0x1_a436);          /* call 0x1008aef4 */
            ii(0x100a_532a, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100a_532c, 3); lea(eax, ebp - 0x8);                    /* lea eax, [ebp-0x8] */
            ii(0x100a_532f, 5); calld(0x1008_ae70, -0x1_a4c4);          /* call 0x1008ae70 */
            ii(0x100a_5334, 2); jmpd(0x100a_533e, 0x8); goto l_0x100a_533e; /* jmp 0x100a533e */
        l_0x100a_5336:
            ii(0x100a_5336, 3); lea(eax, ebp - 0x8);                    /* lea eax, [ebp-0x8] */
            ii(0x100a_5339, 5); calld(0x1007_6bf8, -0x2_e746);          /* call 0x10076bf8 */
        l_0x100a_533e:
            ii(0x100a_533e, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_5340, 3); lea(eax, ebp - 0x8);                    /* lea eax, [ebp-0x8] */
            ii(0x100a_5343, 5); calld(0x1013_ad71, 0x9_5a29);           /* call 0x1013ad71 */
            ii(0x100a_5348, 2); test(al, al);                           /* test al, al */
            ii(0x100a_534a, 2); if(jzd(0x100a_5365, 0x19)) goto l_0x100a_5365; /* jz 0x100a5365 */
            ii(0x100a_534c, 3); lea(eax, ebp - 0x8);                    /* lea eax, [ebp-0x8] */
            ii(0x100a_534f, 5); calld(0x1008_adc4, -0x1_a590);          /* call 0x1008adc4 */
            ii(0x100a_5354, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100a_5357, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100a_535a, 3); mov(edx, memd_a32[ds, eax + 0x2]);      /* mov edx, [eax+0x2] */
            ii(0x100a_535d, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100a_5360, 3); calld_abs(memd_a32[ds, edx + 0x48]);    /* call dword [edx+0x48] */
            ii(0x100a_5363, 2); jmpd(0x100a_5336, -0x2f); goto l_0x100a_5336; /* jmp 0x100a5336 */
        l_0x100a_5365:
            ii(0x100a_5365, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_5368, 5); calld(0x1013_a6f4, 0x9_5387);           /* call 0x1013a6f4 */
            ii(0x100a_536d, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_5370, 3); add(eax, 0xa);                          /* add eax, 0xa */
            ii(0x100a_5373, 5); calld(0x1013_a6f4, 0x9_537c);           /* call 0x1013a6f4 */
            ii(0x100a_5378, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_537b, 3); add(eax, 0x14);                         /* add eax, 0x14 */
            ii(0x100a_537e, 5); calld(0x1013_a6f4, 0x9_5371);           /* call 0x1013a6f4 */
            ii(0x100a_5383, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_5386, 3); add(eax, 0x1e);                         /* add eax, 0x1e */
            ii(0x100a_5389, 5); calld(0x1013_a6f4, 0x9_5366);           /* call 0x1013a6f4 */
            ii(0x100a_538e, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_5391, 3); add(eax, 0x28);                         /* add eax, 0x28 */
            ii(0x100a_5394, 5); calld(0x1013_a6f4, 0x9_535b);           /* call 0x1013a6f4 */
            ii(0x100a_5399, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_539b, 3); lea(eax, ebp - 0x8);                    /* lea eax, [ebp-0x8] */
            ii(0x100a_539e, 5); calld(0x1008_8bbc, -0x1_c7e7);          /* call 0x10088bbc */
            ii(0x100a_53a3, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100a_53a5, 1); popd(ebp);                              /* pop ebp */
            ii(0x100a_53a6, 1); popd(edi);                              /* pop edi */
            ii(0x100a_53a7, 1); popd(esi);                              /* pop esi */
            ii(0x100a_53a8, 1); popd(edx);                              /* pop edx */
            ii(0x100a_53a9, 1); popd(ecx);                              /* pop ecx */
            ii(0x100a_53aa, 1); popd(ebx);                              /* pop ebx */
            ii(0x100a_53ab, 1); retd();                                 /* ret */
        }
    }
}
