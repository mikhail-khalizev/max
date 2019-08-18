using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1009_c2a4-32596cf2")]
        public void Method_1009_c2a4()
        {
            ii(0x1009_c2a4, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1009_c2a9, 5); calld(Definitions.sys_check_available_stack_size, 0xc_9aa4); /* call 0x10165d52 */
            ii(0x1009_c2ae, 1); pushd(ebx);                             /* push ebx */
            ii(0x1009_c2af, 1); pushd(ecx);                             /* push ecx */
            ii(0x1009_c2b0, 1); pushd(edx);                             /* push edx */
            ii(0x1009_c2b1, 1); pushd(esi);                             /* push esi */
            ii(0x1009_c2b2, 1); pushd(edi);                             /* push edi */
            ii(0x1009_c2b3, 1); pushd(ebp);                             /* push ebp */
            ii(0x1009_c2b4, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1009_c2b6, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1009_c2bc, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1009_c2bf, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1009_c2c2, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x1009_c2c4, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1009_c2c7, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1009_c2ca, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1009_c2cc, 1); popd(ebp);                              /* pop ebp */
            ii(0x1009_c2cd, 1); popd(edi);                              /* pop edi */
            ii(0x1009_c2ce, 1); popd(esi);                              /* pop esi */
            ii(0x1009_c2cf, 1); popd(edx);                              /* pop edx */
            ii(0x1009_c2d0, 1); popd(ecx);                              /* pop ecx */
            ii(0x1009_c2d1, 1); popd(ebx);                              /* pop ebx */
            ii(0x1009_c2d2, 1); retd(); return;                         /* ret */
        }
    }
}
