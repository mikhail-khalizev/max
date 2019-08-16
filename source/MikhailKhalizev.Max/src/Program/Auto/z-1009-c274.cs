using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("119fac8f-2059-4ff2-b2e7-f618209a981a")]
        public void Method_1009_c274()
        {
            ii(0x1009_c274, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1009_c279, 5); calld(Definitions.sys_check_available_stack_size, 0xc_9ad4); /* call 0x10165d52 */
            ii(0x1009_c27e, 1); pushd(ebx);                             /* push ebx */
            ii(0x1009_c27f, 1); pushd(ecx);                             /* push ecx */
            ii(0x1009_c280, 1); pushd(edx);                             /* push edx */
            ii(0x1009_c281, 1); pushd(esi);                             /* push esi */
            ii(0x1009_c282, 1); pushd(edi);                             /* push edi */
            ii(0x1009_c283, 1); pushd(ebp);                             /* push ebp */
            ii(0x1009_c284, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1009_c286, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1009_c28c, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1009_c28f, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1009_c292, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x1009_c294, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1009_c297, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1009_c29a, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1009_c29c, 1); popd(ebp);                              /* pop ebp */
            ii(0x1009_c29d, 1); popd(edi);                              /* pop edi */
            ii(0x1009_c29e, 1); popd(esi);                              /* pop esi */
            ii(0x1009_c29f, 1); popd(edx);                              /* pop edx */
            ii(0x1009_c2a0, 1); popd(ecx);                              /* pop ecx */
            ii(0x1009_c2a1, 1); popd(ebx);                              /* pop ebx */
            ii(0x1009_c2a2, 1); retd(); return;                         /* ret */
        }
    }
}