using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("34910e8f-44b4-4b23-81a2-2e4faf5e4d41")]
        public void Method_100a_a934()
        {
            ii(0x100a_a934, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x100a_a939, 5); calld(Definitions.sys_check_available_stack_size, 0xb_b414); /* call 0x10165d52 */
            ii(0x100a_a93e, 1); pushd(ebx);                             /* push ebx */
            ii(0x100a_a93f, 1); pushd(ecx);                             /* push ecx */
            ii(0x100a_a940, 1); pushd(esi);                             /* push esi */
            ii(0x100a_a941, 1); pushd(edi);                             /* push edi */
            ii(0x100a_a942, 1); pushd(ebp);                             /* push ebp */
            ii(0x100a_a943, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100a_a945, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x100a_a94b, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100a_a94e, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x100a_a951, 4); movsx(edx, memw_a32[ss, ebp - 0x4]);    /* movsx edx, word [ebp-0x4] */
            ii(0x100a_a955, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100a_a958, 5); calld(0x100a_b494, 0xb37);              /* call 0x100ab494 */
            ii(0x100a_a95d, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100a_a960, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100a_a963, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100a_a965, 1); popd(ebp);                              /* pop ebp */
            ii(0x100a_a966, 1); popd(edi);                              /* pop edi */
            ii(0x100a_a967, 1); popd(esi);                              /* pop esi */
            ii(0x100a_a968, 1); popd(ecx);                              /* pop ecx */
            ii(0x100a_a969, 1); popd(ebx);                              /* pop ebx */
            ii(0x100a_a96a, 1); retd(); return;                         /* ret */
        }
    }
}
