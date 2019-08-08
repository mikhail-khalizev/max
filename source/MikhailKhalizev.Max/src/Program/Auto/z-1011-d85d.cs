using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("e984e8c4-e9c8-471d-a6ae-12742c3fb9df")]
        public void Method_1011_d85d()
        {
            ii(0x1011_d85d, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x1011_d862, 5); calld(Definitions.sys_check_available_stack_size, 0x4_84eb); /* call 0x10165d52 */
            ii(0x1011_d867, 1); pushd(ebx);                             /* push ebx */
            ii(0x1011_d868, 1); pushd(ecx);                             /* push ecx */
            ii(0x1011_d869, 1); pushd(esi);                             /* push esi */
            ii(0x1011_d86a, 1); pushd(edi);                             /* push edi */
            ii(0x1011_d86b, 1); pushd(ebp);                             /* push ebp */
            ii(0x1011_d86c, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1011_d86e, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1011_d874, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1011_d877, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1011_d87a, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_d87d, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1011_d880, 4); mov(memw_a32[ds, edx + 0x11], ax);      /* mov [edx+0x11], ax */
            ii(0x1011_d884, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1011_d886, 1); popd(ebp);                              /* pop ebp */
            ii(0x1011_d887, 1); popd(edi);                              /* pop edi */
            ii(0x1011_d888, 1); popd(esi);                              /* pop esi */
            ii(0x1011_d889, 1); popd(ecx);                              /* pop ecx */
            ii(0x1011_d88a, 1); popd(ebx);                              /* pop ebx */
            ii(0x1011_d88b, 1); retd(); return;                         /* ret */
        }
    }
}
