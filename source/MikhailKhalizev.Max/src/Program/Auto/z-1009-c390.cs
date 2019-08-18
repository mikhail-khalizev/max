using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("e426142a-3778-4e6d-8e80-cd7b49a8d8cb")]
        public void Method_1009_c390()
        {
            ii(0x1009_c390, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1009_c395, 5); calld(Definitions.sys_check_available_stack_size, 0xc_99b8); /* call 0x10165d52 */
            ii(0x1009_c39a, 1); pushd(ebx);                             /* push ebx */
            ii(0x1009_c39b, 1); pushd(ecx);                             /* push ecx */
            ii(0x1009_c39c, 1); pushd(edx);                             /* push edx */
            ii(0x1009_c39d, 1); pushd(esi);                             /* push esi */
            ii(0x1009_c39e, 1); pushd(edi);                             /* push edi */
            ii(0x1009_c39f, 1); pushd(ebp);                             /* push ebp */
            ii(0x1009_c3a0, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1009_c3a2, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1009_c3a8, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1009_c3ab, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1009_c3ae, 1); inc(eax);                               /* inc eax */
            ii(0x1009_c3af, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1009_c3b2, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1009_c3b5, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1009_c3b7, 1); popd(ebp);                              /* pop ebp */
            ii(0x1009_c3b8, 1); popd(edi);                              /* pop edi */
            ii(0x1009_c3b9, 1); popd(esi);                              /* pop esi */
            ii(0x1009_c3ba, 1); popd(edx);                              /* pop edx */
            ii(0x1009_c3bb, 1); popd(ecx);                              /* pop ecx */
            ii(0x1009_c3bc, 1); popd(ebx);                              /* pop ebx */
            ii(0x1009_c3bd, 1); retd(); return;                         /* ret */
        }
    }
}
