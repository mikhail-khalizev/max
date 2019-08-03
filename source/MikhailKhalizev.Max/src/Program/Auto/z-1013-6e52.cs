using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("7e70f072-5d8e-4f63-8351-9c725d505706")]
        public void Method_1013_6e52()
        {
            ii(0x1013_6e52, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x1013_6e57, 5); calld(Definitions.sys_check_available_stack_size, 0x2eef6); /* call 0x10165d52 */
            ii(0x1013_6e5c, 1); pushd(ebx);                             /* push ebx */
            ii(0x1013_6e5d, 1); pushd(ecx);                             /* push ecx */
            ii(0x1013_6e5e, 1); pushd(edx);                             /* push edx */
            ii(0x1013_6e5f, 1); pushd(esi);                             /* push esi */
            ii(0x1013_6e60, 1); pushd(edi);                             /* push edi */
            ii(0x1013_6e61, 1); pushd(ebp);                             /* push ebp */
            ii(0x1013_6e62, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1013_6e64, 6); sub(esp, 0x4);                          /* sub esp, 0x4 */
            ii(0x1013_6e6a, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1013_6e6d, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1013_6e70, 3); mov(eax, memd_a32[ds, eax + 0x4f]);     /* mov eax, [eax+0x4f] */
            ii(0x1013_6e73, 5); calld(0x100e_b68a, -0x4b7ee);           /* call 0x100eb68a */
            ii(0x1013_6e78, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1013_6e7a, 1); popd(ebp);                              /* pop ebp */
            ii(0x1013_6e7b, 1); popd(edi);                              /* pop edi */
            ii(0x1013_6e7c, 1); popd(esi);                              /* pop esi */
            ii(0x1013_6e7d, 1); popd(edx);                              /* pop edx */
            ii(0x1013_6e7e, 1); popd(ecx);                              /* pop ecx */
            ii(0x1013_6e7f, 1); popd(ebx);                              /* pop ebx */
            ii(0x1013_6e80, 1); retd(); return;                         /* ret */
        }
    }
}
