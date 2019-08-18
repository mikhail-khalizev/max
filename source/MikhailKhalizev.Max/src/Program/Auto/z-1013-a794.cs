using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("5f31543d-d713-465b-9d83-80f7898ee15b")]
        public void Method_1013_a794()
        {
            ii(0x1013_a794, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1013_a799, 5); calld(Definitions.sys_check_available_stack_size, 0x2_b5b4); /* call 0x10165d52 */
            ii(0x1013_a79e, 1); pushd(ebx);                             /* push ebx */
            ii(0x1013_a79f, 1); pushd(ecx);                             /* push ecx */
            ii(0x1013_a7a0, 1); pushd(edx);                             /* push edx */
            ii(0x1013_a7a1, 1); pushd(esi);                             /* push esi */
            ii(0x1013_a7a2, 1); pushd(edi);                             /* push edi */
            ii(0x1013_a7a3, 1); pushd(ebp);                             /* push ebp */
            ii(0x1013_a7a4, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1013_a7a6, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1013_a7ac, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1013_a7af, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1013_a7b2, 3); movsx(eax, memw_a32[ds, eax]);          /* movsx eax, word [eax] */
            ii(0x1013_a7b5, 3); imul(eax, eax, 0x12);                   /* imul eax, eax, 0x12 */
            ii(0x1013_a7b8, 3); add(eax, 0x4);                          /* add eax, 0x4 */
            ii(0x1013_a7bb, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1013_a7be, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1013_a7c1, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1013_a7c3, 1); popd(ebp);                              /* pop ebp */
            ii(0x1013_a7c4, 1); popd(edi);                              /* pop edi */
            ii(0x1013_a7c5, 1); popd(esi);                              /* pop esi */
            ii(0x1013_a7c6, 1); popd(edx);                              /* pop edx */
            ii(0x1013_a7c7, 1); popd(ecx);                              /* pop ecx */
            ii(0x1013_a7c8, 1); popd(ebx);                              /* pop ebx */
            ii(0x1013_a7c9, 1); retd(); return;                         /* ret */
        }
    }
}
