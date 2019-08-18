using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("9fcebf2c-6848-459d-93b4-0139e99615f2")]
        public void Method_1010_5d7d()
        {
            ii(0x1010_5d7d, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1010_5d82, 5); calld(Definitions.sys_check_available_stack_size, 0x5_ffcb); /* call 0x10165d52 */
            ii(0x1010_5d87, 1); pushd(ebx);                             /* push ebx */
            ii(0x1010_5d88, 1); pushd(ecx);                             /* push ecx */
            ii(0x1010_5d89, 1); pushd(esi);                             /* push esi */
            ii(0x1010_5d8a, 1); pushd(edi);                             /* push edi */
            ii(0x1010_5d8b, 1); pushd(ebp);                             /* push ebp */
            ii(0x1010_5d8c, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1010_5d8e, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1010_5d94, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1010_5d97, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1010_5d9a, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1010_5d9d, 5); calld(0x1010_6054, 0x2b2);              /* call 0x10106054 */
            ii(0x1010_5da2, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1010_5da5, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1010_5da8, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1010_5dab, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1010_5dad, 1); popd(ebp);                              /* pop ebp */
            ii(0x1010_5dae, 1); popd(edi);                              /* pop edi */
            ii(0x1010_5daf, 1); popd(esi);                              /* pop esi */
            ii(0x1010_5db0, 1); popd(ecx);                              /* pop ecx */
            ii(0x1010_5db1, 1); popd(ebx);                              /* pop ebx */
            ii(0x1010_5db2, 1); retd(); return;                         /* ret */
        }
    }
}
