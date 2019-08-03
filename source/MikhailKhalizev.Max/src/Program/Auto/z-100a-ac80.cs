using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("69c3b677-94d8-429a-9f69-4fc2c2524078")]
        public void Method_100a_ac80()
        {
            ii(0x100a_ac80, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x100a_ac85, 5); calld(Definitions.sys_check_available_stack_size, 0xbb0c8); /* call 0x10165d52 */
            ii(0x100a_ac8a, 1); pushd(ebx);                             /* push ebx */
            ii(0x100a_ac8b, 1); pushd(ecx);                             /* push ecx */
            ii(0x100a_ac8c, 1); pushd(esi);                             /* push esi */
            ii(0x100a_ac8d, 1); pushd(edi);                             /* push edi */
            ii(0x100a_ac8e, 1); pushd(ebp);                             /* push ebp */
            ii(0x100a_ac8f, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100a_ac91, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x100a_ac97, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100a_ac9a, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x100a_ac9d, 4); movsx(edx, memw_a32[ss, ebp - 0x4]);    /* movsx edx, word [ebp-0x4] */
            ii(0x100a_aca1, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100a_aca4, 5); calld(0x1013_a854, 0x8fbab);            /* call 0x1013a854 */
            ii(0x100a_aca9, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100a_acac, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100a_acaf, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100a_acb1, 1); popd(ebp);                              /* pop ebp */
            ii(0x100a_acb2, 1); popd(edi);                              /* pop edi */
            ii(0x100a_acb3, 1); popd(esi);                              /* pop esi */
            ii(0x100a_acb4, 1); popd(ecx);                              /* pop ecx */
            ii(0x100a_acb5, 1); popd(ebx);                              /* pop ebx */
            ii(0x100a_acb6, 1); retd(); return;                         /* ret */
        }
    }
}