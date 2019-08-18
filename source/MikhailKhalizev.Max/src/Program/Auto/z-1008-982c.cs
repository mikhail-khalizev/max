using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1008_982c-e3a9b2b8")]
        public void Method_1008_982c()
        {
            ii(0x1008_982c, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1008_9831, 5); calld(Definitions.sys_check_available_stack_size, 0xd_c51c); /* call 0x10165d52 */
            ii(0x1008_9836, 1); pushd(ebx);                             /* push ebx */
            ii(0x1008_9837, 1); pushd(ecx);                             /* push ecx */
            ii(0x1008_9838, 1); pushd(edx);                             /* push edx */
            ii(0x1008_9839, 1); pushd(esi);                             /* push esi */
            ii(0x1008_983a, 1); pushd(edi);                             /* push edi */
            ii(0x1008_983b, 1); pushd(ebp);                             /* push ebp */
            ii(0x1008_983c, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1008_983e, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1008_9844, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1008_9847, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_984a, 4); mov(ax, memw_a32[ds, eax + 0xa]);       /* mov ax, [eax+0xa] */
            ii(0x1008_984e, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1008_9851, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1008_9854, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1008_9856, 1); popd(ebp);                              /* pop ebp */
            ii(0x1008_9857, 1); popd(edi);                              /* pop edi */
            ii(0x1008_9858, 1); popd(esi);                              /* pop esi */
            ii(0x1008_9859, 1); popd(edx);                              /* pop edx */
            ii(0x1008_985a, 1); popd(ecx);                              /* pop ecx */
            ii(0x1008_985b, 1); popd(ebx);                              /* pop ebx */
            ii(0x1008_985c, 1); retd(); return;                         /* ret */
        }
    }
}
