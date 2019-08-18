using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1009_efd7-ed4c53d9")]
        public void Method_1009_efd7()
        {
            ii(0x1009_efd7, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1009_efdc, 5); calld(Definitions.sys_check_available_stack_size, 0xc_6d71); /* call 0x10165d52 */
            ii(0x1009_efe1, 1); pushd(ebx);                             /* push ebx */
            ii(0x1009_efe2, 1); pushd(ecx);                             /* push ecx */
            ii(0x1009_efe3, 1); pushd(esi);                             /* push esi */
            ii(0x1009_efe4, 1); pushd(edi);                             /* push edi */
            ii(0x1009_efe5, 1); pushd(ebp);                             /* push ebp */
            ii(0x1009_efe6, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1009_efe8, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1009_efee, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1009_eff1, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1009_eff4, 5); mov(edx, StringDefinitions.LookForEnemyLandSeaMines); /* mov edx, 0x101a07ab */
            ii(0x1009_eff9, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1009_effc, 5); calld(Definitions.sys_strcpy, 0xc_6ece); /* call 0x10165ecf */
            ii(0x1009_f001, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1009_f004, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1009_f007, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1009_f00a, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1009_f00c, 1); popd(ebp);                              /* pop ebp */
            ii(0x1009_f00d, 1); popd(edi);                              /* pop edi */
            ii(0x1009_f00e, 1); popd(esi);                              /* pop esi */
            ii(0x1009_f00f, 1); popd(ecx);                              /* pop ecx */
            ii(0x1009_f010, 1); popd(ebx);                              /* pop ebx */
            ii(0x1009_f011, 1); retd(); return;                         /* ret */
        }
    }
}
