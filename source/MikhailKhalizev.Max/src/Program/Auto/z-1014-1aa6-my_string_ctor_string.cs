using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("4a14733b-4566-41da-bc9f-a31e42fb02dc")]
        public void my_string_ctor_string()
        {
            ii(0x1014_1aa6, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1014_1aab, 5); calld(Definitions.sys_check_available_stack_size, 0x2_42a2); /* call 0x10165d52 */
            ii(0x1014_1ab0, 1); pushd(ebx);                             /* push ebx */
            ii(0x1014_1ab1, 1); pushd(ecx);                             /* push ecx */
            ii(0x1014_1ab2, 1); pushd(esi);                             /* push esi */
            ii(0x1014_1ab3, 1); pushd(edi);                             /* push edi */
            ii(0x1014_1ab4, 1); pushd(ebp);                             /* push ebp */
            ii(0x1014_1ab5, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1014_1ab7, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1014_1abd, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1014_1ac0, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1014_1ac3, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_1ac6, 2); mov(edx, memd_a32[ds, eax]);            /* mov edx, [eax] */
            ii(0x1014_1ac8, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_1acb, 2); mov(memd_a32[ds, eax], edx);            /* mov [eax], edx */
            ii(0x1014_1acd, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_1ad0, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x1014_1ad2, 5); calld(Definitions.my_string_add_ref, 0x98d); /* call 0x10142464 */
            ii(0x1014_1ad7, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_1ada, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1014_1add, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1014_1ae0, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1014_1ae2, 1); popd(ebp);                              /* pop ebp */
            ii(0x1014_1ae3, 1); popd(edi);                              /* pop edi */
            ii(0x1014_1ae4, 1); popd(esi);                              /* pop esi */
            ii(0x1014_1ae5, 1); popd(ecx);                              /* pop ecx */
            ii(0x1014_1ae6, 1); popd(ebx);                              /* pop ebx */
            ii(0x1014_1ae7, 1); retd(); return;                         /* ret */
        }
    }
}
