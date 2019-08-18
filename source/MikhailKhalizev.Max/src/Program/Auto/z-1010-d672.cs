using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1010_d672-ee5dbafa")]
        public void Method_1010_d672()
        {
            ii(0x1010_d672, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x1010_d677, 5); calld(Definitions.sys_check_available_stack_size, 0x5_86d6); /* call 0x10165d52 */
            ii(0x1010_d67c, 1); pushd(ebx);                             /* push ebx */
            ii(0x1010_d67d, 1); pushd(ecx);                             /* push ecx */
            ii(0x1010_d67e, 1); pushd(edx);                             /* push edx */
            ii(0x1010_d67f, 1); pushd(esi);                             /* push esi */
            ii(0x1010_d680, 1); pushd(edi);                             /* push edi */
            ii(0x1010_d681, 1); pushd(ebp);                             /* push ebp */
            ii(0x1010_d682, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1010_d684, 6); sub(esp, 0x4);                          /* sub esp, 0x4 */
            ii(0x1010_d68a, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1010_d68d, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1010_d690, 7); mov(memd_a32[ds, eax + 0x8], 0x1);      /* mov dword [eax+0x8], 0x1 */
            ii(0x1010_d697, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1010_d699, 1); popd(ebp);                              /* pop ebp */
            ii(0x1010_d69a, 1); popd(edi);                              /* pop edi */
            ii(0x1010_d69b, 1); popd(esi);                              /* pop esi */
            ii(0x1010_d69c, 1); popd(edx);                              /* pop edx */
            ii(0x1010_d69d, 1); popd(ecx);                              /* pop ecx */
            ii(0x1010_d69e, 1); popd(ebx);                              /* pop ebx */
            ii(0x1010_d69f, 1); retd(); return;                         /* ret */
        }
    }
}
