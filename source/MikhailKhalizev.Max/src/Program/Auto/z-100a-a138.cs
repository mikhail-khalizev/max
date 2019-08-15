using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("3877c799-4df7-4a20-93ba-3930a2e1d5ef")]
        public void Method_100a_a138()
        {
            ii(0x100a_a138, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x100a_a13d, 5); calld(Definitions.sys_check_available_stack_size, 0xb_bc10); /* call 0x10165d52 */
            ii(0x100a_a142, 1); pushd(ebx);                             /* push ebx */
            ii(0x100a_a143, 1); pushd(ecx);                             /* push ecx */
            ii(0x100a_a144, 1); pushd(esi);                             /* push esi */
            ii(0x100a_a145, 1); pushd(edi);                             /* push edi */
            ii(0x100a_a146, 1); pushd(ebp);                             /* push ebp */
            ii(0x100a_a147, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100a_a149, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x100a_a14f, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100a_a152, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x100a_a155, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x100a_a15a, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100a_a15d, 5); calld(0x1013_a1be, 0x9_005c);           /* call 0x1013a1be */
            ii(0x100a_a162, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100a_a165, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100a_a168, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100a_a16b, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100a_a16e, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100a_a170, 1); popd(ebp);                              /* pop ebp */
            ii(0x100a_a171, 1); popd(edi);                              /* pop edi */
            ii(0x100a_a172, 1); popd(esi);                              /* pop esi */
            ii(0x100a_a173, 1); popd(ecx);                              /* pop ecx */
            ii(0x100a_a174, 1); popd(ebx);                              /* pop ebx */
            ii(0x100a_a175, 1); retd(); return;                         /* ret */
        }
    }
}
