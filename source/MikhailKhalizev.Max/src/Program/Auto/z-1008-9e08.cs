using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1008_9e08-fa153812")]
        public void Method_1008_9e08()
        {
            ii(0x1008_9e08, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1008_9e0d, 5); calld(Definitions.sys_check_available_stack_size, 0xd_bf40); /* call 0x10165d52 */
            ii(0x1008_9e12, 1); pushd(ebx);                             /* push ebx */
            ii(0x1008_9e13, 1); pushd(ecx);                             /* push ecx */
            ii(0x1008_9e14, 1); pushd(edx);                             /* push edx */
            ii(0x1008_9e15, 1); pushd(esi);                             /* push esi */
            ii(0x1008_9e16, 1); pushd(edi);                             /* push edi */
            ii(0x1008_9e17, 1); pushd(ebp);                             /* push ebp */
            ii(0x1008_9e18, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1008_9e1a, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1008_9e20, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1008_9e23, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_9e26, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x1008_9e28, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1008_9e2b, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1008_9e2e, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1008_9e30, 1); popd(ebp);                              /* pop ebp */
            ii(0x1008_9e31, 1); popd(edi);                              /* pop edi */
            ii(0x1008_9e32, 1); popd(esi);                              /* pop esi */
            ii(0x1008_9e33, 1); popd(edx);                              /* pop edx */
            ii(0x1008_9e34, 1); popd(ecx);                              /* pop ecx */
            ii(0x1008_9e35, 1); popd(ebx);                              /* pop ebx */
            ii(0x1008_9e36, 1); retd(); return;                         /* ret */
        }
    }
}
