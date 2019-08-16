using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("6fe596ee-4605-4d88-8c01-5ce1b367dac1")]
        public void Method_1016_4788()
        {
            ii(0x1016_4788, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x1016_478d, 5); calld(Definitions.sys_check_available_stack_size, 0x15c0); /* call 0x10165d52 */
            ii(0x1016_4792, 1); pushd(ebx);                             /* push ebx */
            ii(0x1016_4793, 1); pushd(ecx);                             /* push ecx */
            ii(0x1016_4794, 1); pushd(esi);                             /* push esi */
            ii(0x1016_4795, 1); pushd(edi);                             /* push edi */
            ii(0x1016_4796, 1); pushd(ebp);                             /* push ebp */
            ii(0x1016_4797, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1016_4799, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1016_479f, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1016_47a2, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1016_47a5, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1016_47a8, 2); mov(ebx, memd_a32[ds, eax]);            /* mov ebx, [eax] */
            ii(0x1016_47aa, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x1016_47ad, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1016_47b0, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1016_47b3, 5); calld(0x1016_47c0, 0x8);                /* call 0x101647c0 */
            ii(0x1016_47b8, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1016_47ba, 1); popd(ebp);                              /* pop ebp */
            ii(0x1016_47bb, 1); popd(edi);                              /* pop edi */
            ii(0x1016_47bc, 1); popd(esi);                              /* pop esi */
            ii(0x1016_47bd, 1); popd(ecx);                              /* pop ecx */
            ii(0x1016_47be, 1); popd(ebx);                              /* pop ebx */
            ii(0x1016_47bf, 1); retd(); return;                         /* ret */
        }
    }
}