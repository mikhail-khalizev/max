using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("f1bbb746-e58a-4b7a-94b8-b35fb4fe4d5f")]
        public void Method_1010_4470()
        {
            ii(0x1010_4470, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1010_4475, 5); calld(Definitions.sys_check_available_stack_size, 0x6_18d8); /* call 0x10165d52 */
            ii(0x1010_447a, 1); pushd(ebx);                             /* push ebx */
            ii(0x1010_447b, 1); pushd(ecx);                             /* push ecx */
            ii(0x1010_447c, 1); pushd(esi);                             /* push esi */
            ii(0x1010_447d, 1); pushd(edi);                             /* push edi */
            ii(0x1010_447e, 1); pushd(ebp);                             /* push ebp */
            ii(0x1010_447f, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1010_4481, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1010_4487, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1010_448a, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1010_448d, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x1010_4492, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1010_4495, 5); calld(0x1007_5e24, -0x8_e676);          /* call 0x10075e24 */
            ii(0x1010_449a, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1010_449d, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1010_44a0, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1010_44a3, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1010_44a6, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1010_44a8, 1); popd(ebp);                              /* pop ebp */
            ii(0x1010_44a9, 1); popd(edi);                              /* pop edi */
            ii(0x1010_44aa, 1); popd(esi);                              /* pop esi */
            ii(0x1010_44ab, 1); popd(ecx);                              /* pop ecx */
            ii(0x1010_44ac, 1); popd(ebx);                              /* pop ebx */
            ii(0x1010_44ad, 1); retd(); return;                         /* ret */
        }
    }
}
