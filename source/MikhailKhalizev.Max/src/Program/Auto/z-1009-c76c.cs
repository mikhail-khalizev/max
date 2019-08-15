using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("2a6e4174-671e-43f8-ab0f-5bbe759e02d3")]
        public void Method_1009_c76c()
        {
            ii(0x1009_c76c, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1009_c771, 5); calld(Definitions.sys_check_available_stack_size, 0xc_95dc); /* call 0x10165d52 */
            ii(0x1009_c776, 1); pushd(ebx);                             /* push ebx */
            ii(0x1009_c777, 1); pushd(ecx);                             /* push ecx */
            ii(0x1009_c778, 1); pushd(edx);                             /* push edx */
            ii(0x1009_c779, 1); pushd(esi);                             /* push esi */
            ii(0x1009_c77a, 1); pushd(edi);                             /* push edi */
            ii(0x1009_c77b, 1); pushd(ebp);                             /* push ebp */
            ii(0x1009_c77c, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1009_c77e, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1009_c784, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1009_c787, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1009_c78a, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x1009_c78c, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1009_c78f, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1009_c792, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1009_c794, 1); popd(ebp);                              /* pop ebp */
            ii(0x1009_c795, 1); popd(edi);                              /* pop edi */
            ii(0x1009_c796, 1); popd(esi);                              /* pop esi */
            ii(0x1009_c797, 1); popd(edx);                              /* pop edx */
            ii(0x1009_c798, 1); popd(ecx);                              /* pop ecx */
            ii(0x1009_c799, 1); popd(ebx);                              /* pop ebx */
            ii(0x1009_c79a, 1); retd(); return;                         /* ret */
        }
    }
}
