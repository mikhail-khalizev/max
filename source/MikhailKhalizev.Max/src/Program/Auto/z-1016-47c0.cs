using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("25682e7a-c103-4cb4-abe4-097c2b824004")]
        public void Method_1016_47c0()
        {
            ii(0x1016_47c0, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x1016_47c5, 5); calld(Definitions.sys_check_available_stack_size, 0x1588); /* call 0x10165d52 */
            ii(0x1016_47ca, 1); pushd(ecx);                             /* push ecx */
            ii(0x1016_47cb, 1); pushd(esi);                             /* push esi */
            ii(0x1016_47cc, 1); pushd(edi);                             /* push edi */
            ii(0x1016_47cd, 1); pushd(ebp);                             /* push ebp */
            ii(0x1016_47ce, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1016_47d0, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1016_47d6, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1016_47d9, 3); mov(memd_a32[ss, ebp - 0x8], edx);      /* mov [ebp-0x8], edx */
            ii(0x1016_47dc, 3); mov(memd_a32[ss, ebp - 0x4], ebx);      /* mov [ebp-0x4], ebx */
            ii(0x1016_47df, 4); movsx(ebx, memw_a32[ss, ebp - 0x4]);    /* movsx ebx, word [ebp-0x4] */
            ii(0x1016_47e3, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1016_47e6, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1016_47e9, 5); calld(0x100c_d990, -0x9_6e5e);          /* call 0x100cd990 */
            ii(0x1016_47ee, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1016_47f0, 1); popd(ebp);                              /* pop ebp */
            ii(0x1016_47f1, 1); popd(edi);                              /* pop edi */
            ii(0x1016_47f2, 1); popd(esi);                              /* pop esi */
            ii(0x1016_47f3, 1); popd(ecx);                              /* pop ecx */
            ii(0x1016_47f4, 1); retd(); return;                         /* ret */
        }
    }
}
