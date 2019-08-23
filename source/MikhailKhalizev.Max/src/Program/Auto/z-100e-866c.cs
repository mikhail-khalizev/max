using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100e_866c-d5791e8a")]
        public void Method_100e_866c()
        {
            ii(0x100e_866c, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x100e_8671, 5); calld(Definitions.sys_check_available_stack_size, 0x7_d6dc); /* call 0x10165d52 */
            ii(0x100e_8676, 1); pushd(ebx);                             /* push ebx */
            ii(0x100e_8677, 1); pushd(ecx);                             /* push ecx */
            ii(0x100e_8678, 1); pushd(esi);                             /* push esi */
            ii(0x100e_8679, 1); pushd(edi);                             /* push edi */
            ii(0x100e_867a, 1); pushd(ebp);                             /* push ebp */
            ii(0x100e_867b, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100e_867d, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x100e_8683, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100e_8686, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x100e_8689, 4); movsx(edx, memw_a32[ss, ebp - 0x4]);    /* movsx edx, word [ebp-0x4] */
            ii(0x100e_868d, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_8690, 5); calld(0x100a_b494, -0x3_d201);          /* call 0x100ab494 */
            ii(0x100e_8695, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100e_8698, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100e_869b, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100e_869d, 1); popd(ebp);                              /* pop ebp */
            ii(0x100e_869e, 1); popd(edi);                              /* pop edi */
            ii(0x100e_869f, 1); popd(esi);                              /* pop esi */
            ii(0x100e_86a0, 1); popd(ecx);                              /* pop ecx */
            ii(0x100e_86a1, 1); popd(ebx);                              /* pop ebx */
            ii(0x100e_86a2, 1); retd();                                 /* ret */
        }
    }
}
