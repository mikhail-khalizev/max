using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("12827fb9-4bd9-417d-b463-53d12aa48911")]
        public void Method_1013_6df4()
        {
            ii(0x1013_6df4, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x1013_6df9, 5); calld(Definitions.sys_check_available_stack_size, 0x2ef54); /* call 0x10165d52 */
            ii(0x1013_6dfe, 1); pushd(ebx);                             /* push ebx */
            ii(0x1013_6dff, 1); pushd(ecx);                             /* push ecx */
            ii(0x1013_6e00, 1); pushd(edx);                             /* push edx */
            ii(0x1013_6e01, 1); pushd(esi);                             /* push esi */
            ii(0x1013_6e02, 1); pushd(edi);                             /* push edi */
            ii(0x1013_6e03, 1); pushd(ebp);                             /* push ebp */
            ii(0x1013_6e04, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1013_6e06, 6); sub(esp, 0x4);                          /* sub esp, 0x4 */
            ii(0x1013_6e0c, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1013_6e0f, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1013_6e12, 3); mov(eax, memd_a32[ds, eax + 0x4f]);     /* mov eax, [eax+0x4f] */
            ii(0x1013_6e15, 5); calld(0x100e_b1b2, -0x4bc68);           /* call 0x100eb1b2 */
            ii(0x1013_6e1a, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1013_6e1c, 1); popd(ebp);                              /* pop ebp */
            ii(0x1013_6e1d, 1); popd(edi);                              /* pop edi */
            ii(0x1013_6e1e, 1); popd(esi);                              /* pop esi */
            ii(0x1013_6e1f, 1); popd(edx);                              /* pop edx */
            ii(0x1013_6e20, 1); popd(ecx);                              /* pop ecx */
            ii(0x1013_6e21, 1); popd(ebx);                              /* pop ebx */
            ii(0x1013_6e22, 1); retd(); return;                         /* ret */
        }
    }
}