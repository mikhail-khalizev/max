using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("f644b84b-2982-49d4-84c2-de23df2e7420")]
        public void Method_1009_3098()
        {
            ii(0x1009_3098, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1009_309d, 5); calld(Definitions.sys_check_available_stack_size, 0xd_2cb0); /* call 0x10165d52 */
            ii(0x1009_30a2, 1); pushd(ebx);                             /* push ebx */
            ii(0x1009_30a3, 1); pushd(ecx);                             /* push ecx */
            ii(0x1009_30a4, 1); pushd(esi);                             /* push esi */
            ii(0x1009_30a5, 1); pushd(edi);                             /* push edi */
            ii(0x1009_30a6, 1); pushd(ebp);                             /* push ebp */
            ii(0x1009_30a7, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1009_30a9, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1009_30af, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1009_30b2, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1009_30b5, 5); mov(edx, StringDefinitions.ManageBuildings); /* mov edx, 0x101a05f1 */
            ii(0x1009_30ba, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1009_30bd, 5); calld(Definitions.sys_strcpy, 0xd_2e0d); /* call 0x10165ecf */
            ii(0x1009_30c2, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1009_30c5, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1009_30c8, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1009_30cb, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1009_30cd, 1); popd(ebp);                              /* pop ebp */
            ii(0x1009_30ce, 1); popd(edi);                              /* pop edi */
            ii(0x1009_30cf, 1); popd(esi);                              /* pop esi */
            ii(0x1009_30d0, 1); popd(ecx);                              /* pop ecx */
            ii(0x1009_30d1, 1); popd(ebx);                              /* pop ebx */
            ii(0x1009_30d2, 1); retd(); return;                         /* ret */
        }
    }
}
