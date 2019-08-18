using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1009_c8c8-c24dc1d8")]
        public void Method_1009_c8c8()
        {
            ii(0x1009_c8c8, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1009_c8cd, 5); calld(Definitions.sys_check_available_stack_size, 0xc_9480); /* call 0x10165d52 */
            ii(0x1009_c8d2, 1); pushd(ebx);                             /* push ebx */
            ii(0x1009_c8d3, 1); pushd(ecx);                             /* push ecx */
            ii(0x1009_c8d4, 1); pushd(edx);                             /* push edx */
            ii(0x1009_c8d5, 1); pushd(esi);                             /* push esi */
            ii(0x1009_c8d6, 1); pushd(edi);                             /* push edi */
            ii(0x1009_c8d7, 1); pushd(ebp);                             /* push ebp */
            ii(0x1009_c8d8, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1009_c8da, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1009_c8e0, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1009_c8e3, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1009_c8e6, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x1009_c8e8, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1009_c8eb, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1009_c8ee, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1009_c8f0, 1); popd(ebp);                              /* pop ebp */
            ii(0x1009_c8f1, 1); popd(edi);                              /* pop edi */
            ii(0x1009_c8f2, 1); popd(esi);                              /* pop esi */
            ii(0x1009_c8f3, 1); popd(edx);                              /* pop edx */
            ii(0x1009_c8f4, 1); popd(ecx);                              /* pop ecx */
            ii(0x1009_c8f5, 1); popd(ebx);                              /* pop ebx */
            ii(0x1009_c8f6, 1); retd(); return;                         /* ret */
        }
    }
}
