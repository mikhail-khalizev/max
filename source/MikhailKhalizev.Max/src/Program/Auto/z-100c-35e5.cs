using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("b59abd3d-68c8-44f6-ba3d-5c069584efb9")]
        public void Method_100c_35e5()
        {
            ii(0x100c_35e5, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x100c_35ea, 5); calld(Definitions.sys_check_available_stack_size, 0xa2763); /* call 0x10165d52 */
            ii(0x100c_35ef, 1); pushd(ebx);                             /* push ebx */
            ii(0x100c_35f0, 1); pushd(ecx);                             /* push ecx */
            ii(0x100c_35f1, 1); pushd(esi);                             /* push esi */
            ii(0x100c_35f2, 1); pushd(edi);                             /* push edi */
            ii(0x100c_35f3, 1); pushd(ebp);                             /* push ebp */
            ii(0x100c_35f4, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100c_35f6, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x100c_35fc, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100c_35ff, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x100c_3602, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100c_3605, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100c_3607, 3); mov(dl, memb_a32[ds, eax + 0x26]);      /* mov dl, [eax+0x26] */
            ii(0x100c_360a, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_360d, 3); movsx(eax, memw_a32[ds, eax]);          /* movsx eax, word [eax] */
            ii(0x100c_3610, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x100c_3612, 2); if(jnzd(0x100c_3635, 0x21)) goto l_0x100c_3635; /* jnz 0x100c3635 */
            ii(0x100c_3614, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x100c_3617, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_361a, 3); add(eax, 0x4d);                         /* add eax, 0x4d */
            ii(0x100c_361d, 5); calld(0x1008_aab4, -0x38b6e);           /* call 0x1008aab4 */
            ii(0x100c_3622, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x100c_3625, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_3628, 3); add(eax, 0x57);                         /* add eax, 0x57 */
            ii(0x100c_362b, 5); calld(0x1008_aab4, -0x38b7c);           /* call 0x1008aab4 */
            ii(0x100c_3630, 5); jmpd(0x100c_36a3, 0x6e); goto l_0x100c_36a3; /* jmp 0x100c36a3 */
        l_0x100c_3635:
            ii(0x100c_3635, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_3638, 3); add(eax, 0x43);                         /* add eax, 0x43 */
            ii(0x100c_363b, 5); calld(0x100c_b000, 0x79c0);             /* call 0x100cb000 */
            ii(0x100c_3640, 3); lea(ebx, ebp - 0xc);                    /* lea ebx, [ebp-0xc] */
            ii(0x100c_3643, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100c_3645, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x100c_3647, 5); calld(0x1008_a1a4, -0x394a8);           /* call 0x1008a1a4 */
            ii(0x100c_364c, 2); jmpd(0x100c_3656, 0x8); goto l_0x100c_3656; /* jmp 0x100c3656 */
        l_0x100c_364e:
            ii(0x100c_364e, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x100c_3651, 5); calld(0x1007_6bf8, -0x4ca5e);           /* call 0x10076bf8 */
        l_0x100c_3656:
            ii(0x100c_3656, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100c_3658, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x100c_365b, 5); calld(0x1013_ad71, 0x77711);            /* call 0x1013ad71 */
            ii(0x100c_3660, 2); test(al, al);                           /* test al, al */
            ii(0x100c_3662, 2); if(jzd(0x100c_3699, 0x35)) goto l_0x100c_3699; /* jz 0x100c3699 */
            ii(0x100c_3664, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x100c_3667, 5); calld(0x1008_a0f8, -0x39574);           /* call 0x1008a0f8 */
            ii(0x100c_366c, 5); calld(0x1008_a370, -0x39301);           /* call 0x1008a370 */
            ii(0x100c_3671, 3); cmp(eax, memd_a32[ss, ebp - 0x4]);      /* cmp eax, [ebp-0x4] */
            ii(0x100c_3674, 2); if(jnzd(0x100c_3697, 0x21)) goto l_0x100c_3697; /* jnz 0x100c3697 */
            ii(0x100c_3676, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x100c_3679, 5); calld(0x100c_af38, 0x78ba);             /* call 0x100caf38 */
            ii(0x100c_367e, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100c_3680, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_3683, 3); add(eax, 0x43);                         /* add eax, 0x43 */
            ii(0x100c_3686, 5); calld(0x100c_afa0, 0x7915);             /* call 0x100cafa0 */
            ii(0x100c_368b, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100c_368d, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x100c_3690, 5); calld(0x1008_8e4c, -0x3a849);           /* call 0x10088e4c */
            ii(0x100c_3695, 2); jmpd(0x100c_36a3, 0xc); goto l_0x100c_36a3; /* jmp 0x100c36a3 */
        l_0x100c_3697:
            ii(0x100c_3697, 2); jmpd(0x100c_364e, -0x4b); goto l_0x100c_364e; /* jmp 0x100c364e */
        l_0x100c_3699:
            ii(0x100c_3699, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100c_369b, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x100c_369e, 5); calld(0x1008_8e4c, -0x3a857);           /* call 0x10088e4c */
        l_0x100c_36a3:
            ii(0x100c_36a3, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100c_36a5, 1); popd(ebp);                              /* pop ebp */
            ii(0x100c_36a6, 1); popd(edi);                              /* pop edi */
            ii(0x100c_36a7, 1); popd(esi);                              /* pop esi */
            ii(0x100c_36a8, 1); popd(ecx);                              /* pop ecx */
            ii(0x100c_36a9, 1); popd(ebx);                              /* pop ebx */
            ii(0x100c_36aa, 1); retd(); return;                         /* ret */
        }
    }
}
