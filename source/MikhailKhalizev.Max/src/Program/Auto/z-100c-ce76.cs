using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("549c175b-effb-49a8-800f-a589be37443b")]
        public void Method_100c_ce76()
        {
            ii(0x100c_ce76, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x100c_ce7b, 5); calld(Definitions.sys_check_available_stack_size, 0x9_8ed2); /* call 0x10165d52 */
            ii(0x100c_ce80, 1); pushd(ebx);                             /* push ebx */
            ii(0x100c_ce81, 1); pushd(ecx);                             /* push ecx */
            ii(0x100c_ce82, 1); pushd(esi);                             /* push esi */
            ii(0x100c_ce83, 1); pushd(edi);                             /* push edi */
            ii(0x100c_ce84, 1); pushd(ebp);                             /* push ebp */
            ii(0x100c_ce85, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100c_ce87, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x100c_ce8d, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100c_ce90, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x100c_ce93, 5); mov(edx, StringDefinitions.ReloadUnitWithAmmunition); /* mov edx, 0x101a1442 */
            ii(0x100c_ce98, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100c_ce9b, 5); calld(Definitions.sys_strcpy, 0x9_902f); /* call 0x10165ecf */
            ii(0x100c_cea0, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100c_cea3, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100c_cea6, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100c_cea9, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100c_ceab, 1); popd(ebp);                              /* pop ebp */
            ii(0x100c_ceac, 1); popd(edi);                              /* pop edi */
            ii(0x100c_cead, 1); popd(esi);                              /* pop esi */
            ii(0x100c_ceae, 1); popd(ecx);                              /* pop ecx */
            ii(0x100c_ceaf, 1); popd(ebx);                              /* pop ebx */
            ii(0x100c_ceb0, 1); retd(); return;                         /* ret */
        }
    }
}