using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("4974ff8b-dfe1-4e08-acd1-55cc8e01b580")]
        public void Method_1016_2a15()
        {
            ii(0x1016_2a15, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1016_2a1a, 5); calld(Definitions.sys_check_available_stack_size, 0x3333); /* call 0x10165d52 */
            ii(0x1016_2a1f, 1); pushd(ebx);                             /* push ebx */
            ii(0x1016_2a20, 1); pushd(ecx);                             /* push ecx */
            ii(0x1016_2a21, 1); pushd(edx);                             /* push edx */
            ii(0x1016_2a22, 1); pushd(esi);                             /* push esi */
            ii(0x1016_2a23, 1); pushd(edi);                             /* push edi */
            ii(0x1016_2a24, 1); pushd(ebp);                             /* push ebp */
            ii(0x1016_2a25, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1016_2a27, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1016_2a2d, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1016_2a30, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1016_2a33, 5); calld(0x1007_6338, -0xe_c700);          /* call 0x10076338 */
            ii(0x1016_2a38, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1016_2a3a, 3); lea(eax, ebp - 0x8);                    /* lea eax, [ebp-0x8] */
            ii(0x1016_2a3d, 5); calld(0x1007_64b8, -0xe_c58a);          /* call 0x100764b8 */
            ii(0x1016_2a42, 2); jmpd(0x1016_2a4c, 0x8); goto l_0x1016_2a4c; /* jmp 0x10162a4c */
        l_0x1016_2a44:
            ii(0x1016_2a44, 3); lea(eax, ebp - 0x8);                    /* lea eax, [ebp-0x8] */
            ii(0x1016_2a47, 5); calld(0x1007_6bf8, -0xe_be54);          /* call 0x10076bf8 */
        l_0x1016_2a4c:
            ii(0x1016_2a4c, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1016_2a4e, 3); lea(eax, ebp - 0x8);                    /* lea eax, [ebp-0x8] */
            ii(0x1016_2a51, 5); calld(0x1013_ad71, -0x2_7ce5);          /* call 0x1013ad71 */
            ii(0x1016_2a56, 2); test(al, al);                           /* test al, al */
            ii(0x1016_2a58, 2); if(jzd(0x1016_2a78, 0x1e)) goto l_0x1016_2a78; /* jz 0x10162a78 */
            ii(0x1016_2a5a, 3); lea(eax, ebp - 0x8);                    /* lea eax, [ebp-0x8] */
            ii(0x1016_2a5d, 5); calld(0x1007_63a0, -0xe_c6c2);          /* call 0x100763a0 */
            ii(0x1016_2a62, 5); calld(0x1008_aa04, -0xd_8063);          /* call 0x1008aa04 */
            ii(0x1016_2a67, 2); test(al, al);                           /* test al, al */
            ii(0x1016_2a69, 3); lea(eax, ebp - 0x8);                    /* lea eax, [ebp-0x8] */
            ii(0x1016_2a6c, 5); calld(0x1007_63a0, -0xe_c6d1);          /* call 0x100763a0 */
            ii(0x1016_2a71, 5); calld(0x1016_4b08, 0x2092);             /* call 0x10164b08 */
            ii(0x1016_2a76, 2); jmpd(0x1016_2a44, -0x34); goto l_0x1016_2a44; /* jmp 0x10162a44 */
        l_0x1016_2a78:
            ii(0x1016_2a78, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1016_2a7a, 3); lea(eax, ebp - 0x8);                    /* lea eax, [ebp-0x8] */
            ii(0x1016_2a7d, 5); calld(0x1007_5f6c, -0xe_cb16);          /* call 0x10075f6c */
            ii(0x1016_2a82, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1016_2a84, 1); popd(ebp);                              /* pop ebp */
            ii(0x1016_2a85, 1); popd(edi);                              /* pop edi */
            ii(0x1016_2a86, 1); popd(esi);                              /* pop esi */
            ii(0x1016_2a87, 1); popd(edx);                              /* pop edx */
            ii(0x1016_2a88, 1); popd(ecx);                              /* pop ecx */
            ii(0x1016_2a89, 1); popd(ebx);                              /* pop ebx */
            ii(0x1016_2a8a, 1); retd(); return;                         /* ret */
        }
    }
}
