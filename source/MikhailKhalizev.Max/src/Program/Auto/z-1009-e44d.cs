using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("b1dd7b0f-cbb9-41cb-8f23-148e0323c46e")]
        public void Method_1009_e44d()
        {
            ii(0x1009_e44d, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1009_e452, 5); calld(Definitions.sys_check_available_stack_size, 0xc_78fb); /* call 0x10165d52 */
            ii(0x1009_e457, 1); pushd(ebx);                             /* push ebx */
            ii(0x1009_e458, 1); pushd(ecx);                             /* push ecx */
            ii(0x1009_e459, 1); pushd(esi);                             /* push esi */
            ii(0x1009_e45a, 1); pushd(edi);                             /* push edi */
            ii(0x1009_e45b, 1); pushd(ebp);                             /* push ebp */
            ii(0x1009_e45c, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1009_e45e, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1009_e464, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1009_e467, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1009_e46a, 5); mov(edx, StringDefinitions.Survey);     /* mov edx, 0x101a0797 */
            ii(0x1009_e46f, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1009_e472, 5); calld(Definitions.sys_strcpy, 0xc_7a58); /* call 0x10165ecf */
            ii(0x1009_e477, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1009_e47a, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1009_e47d, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1009_e480, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1009_e482, 1); popd(ebp);                              /* pop ebp */
            ii(0x1009_e483, 1); popd(edi);                              /* pop edi */
            ii(0x1009_e484, 1); popd(esi);                              /* pop esi */
            ii(0x1009_e485, 1); popd(ecx);                              /* pop ecx */
            ii(0x1009_e486, 1); popd(ebx);                              /* pop ebx */
            ii(0x1009_e487, 1); retd(); return;                         /* ret */
        }
    }
}
