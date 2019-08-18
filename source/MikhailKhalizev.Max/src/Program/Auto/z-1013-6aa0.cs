using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1013_6aa0-bea62050")]
        public void Method_1013_6aa0()
        {
            ii(0x1013_6aa0, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1013_6aa5, 5); calld(Definitions.sys_check_available_stack_size, 0x2_f2a8); /* call 0x10165d52 */
            ii(0x1013_6aaa, 1); pushd(ebx);                             /* push ebx */
            ii(0x1013_6aab, 1); pushd(ecx);                             /* push ecx */
            ii(0x1013_6aac, 1); pushd(esi);                             /* push esi */
            ii(0x1013_6aad, 1); pushd(edi);                             /* push edi */
            ii(0x1013_6aae, 1); pushd(ebp);                             /* push ebp */
            ii(0x1013_6aaf, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1013_6ab1, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1013_6ab7, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1013_6aba, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1013_6abd, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1013_6ac0, 5); calld(0x1013_6ad6, 0x11);               /* call 0x10136ad6 */
            ii(0x1013_6ac5, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1013_6ac8, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1013_6acb, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1013_6ace, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1013_6ad0, 1); popd(ebp);                              /* pop ebp */
            ii(0x1013_6ad1, 1); popd(edi);                              /* pop edi */
            ii(0x1013_6ad2, 1); popd(esi);                              /* pop esi */
            ii(0x1013_6ad3, 1); popd(ecx);                              /* pop ecx */
            ii(0x1013_6ad4, 1); popd(ebx);                              /* pop ebx */
            ii(0x1013_6ad5, 1); retd(); return;                         /* ret */
        }
    }
}
