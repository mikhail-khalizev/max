using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("86932bb7-b72d-4b17-8fde-61c1ac3b100e")]
        public void Method_1009_c894()
        {
            ii(0x1009_c894, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1009_c899, 5); calld(Definitions.sys_check_available_stack_size, 0xc_94b4); /* call 0x10165d52 */
            ii(0x1009_c89e, 1); pushd(ebx);                             /* push ebx */
            ii(0x1009_c89f, 1); pushd(ecx);                             /* push ecx */
            ii(0x1009_c8a0, 1); pushd(edx);                             /* push edx */
            ii(0x1009_c8a1, 1); pushd(esi);                             /* push esi */
            ii(0x1009_c8a2, 1); pushd(edi);                             /* push edi */
            ii(0x1009_c8a3, 1); pushd(ebp);                             /* push ebp */
            ii(0x1009_c8a4, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1009_c8a6, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1009_c8ac, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1009_c8af, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1009_c8b2, 4); mov(ax, memw_a32[ds, eax + 0x5]);       /* mov ax, [eax+0x5] */
            ii(0x1009_c8b6, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1009_c8b9, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1009_c8bc, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1009_c8be, 1); popd(ebp);                              /* pop ebp */
            ii(0x1009_c8bf, 1); popd(edi);                              /* pop edi */
            ii(0x1009_c8c0, 1); popd(esi);                              /* pop esi */
            ii(0x1009_c8c1, 1); popd(edx);                              /* pop edx */
            ii(0x1009_c8c2, 1); popd(ecx);                              /* pop ecx */
            ii(0x1009_c8c3, 1); popd(ebx);                              /* pop ebx */
            ii(0x1009_c8c4, 1); retd(); return;                         /* ret */
        }
    }
}