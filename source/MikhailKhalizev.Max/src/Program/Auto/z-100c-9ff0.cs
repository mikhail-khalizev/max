using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("00393c98-5829-48a1-b655-39133837e966")]
        public void Method_100c_9ff0()
        {
            ii(0x100c_9ff0, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x100c_9ff5, 5); calld(Definitions.sys_check_available_stack_size, 0x9_bd58); /* call 0x10165d52 */
            ii(0x100c_9ffa, 1); pushd(ebx);                             /* push ebx */
            ii(0x100c_9ffb, 1); pushd(ecx);                             /* push ecx */
            ii(0x100c_9ffc, 1); pushd(edx);                             /* push edx */
            ii(0x100c_9ffd, 1); pushd(esi);                             /* push esi */
            ii(0x100c_9ffe, 1); pushd(edi);                             /* push edi */
            ii(0x100c_9fff, 1); pushd(ebp);                             /* push ebp */
            ii(0x100c_a000, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100c_a002, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x100c_a008, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x100c_a00b, 5); calld(0x100c_a9dc, 0x9cc);              /* call 0x100ca9dc */
            ii(0x100c_a010, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x100c_a013, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100c_a016, 5); calld(0x100c_a974, 0x959);              /* call 0x100ca974 */
            ii(0x100c_a01b, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100c_a01e, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_a021, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100c_a023, 1); popd(ebp);                              /* pop ebp */
            ii(0x100c_a024, 1); popd(edi);                              /* pop edi */
            ii(0x100c_a025, 1); popd(esi);                              /* pop esi */
            ii(0x100c_a026, 1); popd(edx);                              /* pop edx */
            ii(0x100c_a027, 1); popd(ecx);                              /* pop ecx */
            ii(0x100c_a028, 1); popd(ebx);                              /* pop ebx */
            ii(0x100c_a029, 1); retd(); return;                         /* ret */
        }
    }
}
