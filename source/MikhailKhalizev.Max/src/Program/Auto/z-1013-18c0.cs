using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("b861d898-3c12-4869-8922-6ba1008ce854")]
        public void Method_1013_18c0()
        {
            ii(0x1013_18c0, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x1013_18c5, 5); calld(Definitions.sys_check_available_stack_size, 0x3_4488); /* call 0x10165d52 */
            ii(0x1013_18ca, 1); pushd(ecx);                             /* push ecx */
            ii(0x1013_18cb, 1); pushd(esi);                             /* push esi */
            ii(0x1013_18cc, 1); pushd(edi);                             /* push edi */
            ii(0x1013_18cd, 1); pushd(ebp);                             /* push ebp */
            ii(0x1013_18ce, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1013_18d0, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1013_18d6, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1013_18d9, 3); mov(memd_a32[ss, ebp - 0x8], edx);      /* mov [ebp-0x8], edx */
            ii(0x1013_18dc, 3); mov(memd_a32[ss, ebp - 0x4], ebx);      /* mov [ebp-0x4], ebx */
            ii(0x1013_18df, 4); movsx(ebx, memw_a32[ss, ebp - 0x4]);    /* movsx ebx, word [ebp-0x4] */
            ii(0x1013_18e3, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1013_18e6, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1013_18e9, 5); calld(0x1013_b0f9, 0x980b);             /* call 0x1013b0f9 */
            ii(0x1013_18ee, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1013_18f0, 1); popd(ebp);                              /* pop ebp */
            ii(0x1013_18f1, 1); popd(edi);                              /* pop edi */
            ii(0x1013_18f2, 1); popd(esi);                              /* pop esi */
            ii(0x1013_18f3, 1); popd(ecx);                              /* pop ecx */
            ii(0x1013_18f4, 1); retd(); return;                         /* ret */
        }
    }
}
