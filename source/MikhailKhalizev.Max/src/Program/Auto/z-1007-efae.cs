using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("e9b15051-aaf8-4857-aa66-f1c1984766ee")]
        public void Method_1007_efae()
        {
            ii(0x1007_efae, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1007_efb3, 5); calld(Definitions.sys_check_available_stack_size, 0xe_6d9a); /* call 0x10165d52 */
            ii(0x1007_efb8, 1); pushd(ebx);                             /* push ebx */
            ii(0x1007_efb9, 1); pushd(ecx);                             /* push ecx */
            ii(0x1007_efba, 1); pushd(esi);                             /* push esi */
            ii(0x1007_efbb, 1); pushd(edi);                             /* push edi */
            ii(0x1007_efbc, 1); pushd(ebp);                             /* push ebp */
            ii(0x1007_efbd, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1007_efbf, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1007_efc5, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1007_efc8, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1007_efcb, 5); mov(edx, StringDefinitions.WaitingToAttack); /* mov edx, 0x101a01b8 */
            ii(0x1007_efd0, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1007_efd3, 5); calld(Definitions.sys_strcpy, 0xe_6ef7); /* call 0x10165ecf */
            ii(0x1007_efd8, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1007_efdb, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1007_efde, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1007_efe1, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1007_efe3, 1); popd(ebp);                              /* pop ebp */
            ii(0x1007_efe4, 1); popd(edi);                              /* pop edi */
            ii(0x1007_efe5, 1); popd(esi);                              /* pop esi */
            ii(0x1007_efe6, 1); popd(ecx);                              /* pop ecx */
            ii(0x1007_efe7, 1); popd(ebx);                              /* pop ebx */
            ii(0x1007_efe8, 1); retd(); return;                         /* ret */
        }
    }
}
