using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("16ae47f8-3a01-490a-847b-4529adc6d034")]
        public void Method_100e_0dc8()
        {
            ii(0x100e_0dc8, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x100e_0dcd, 5); calld(Definitions.sys_check_available_stack_size, 0x84f80); /* call 0x10165d52 */
            ii(0x100e_0dd2, 1); pushd(ebx);                             /* push ebx */
            ii(0x100e_0dd3, 1); pushd(ecx);                             /* push ecx */
            ii(0x100e_0dd4, 1); pushd(esi);                             /* push esi */
            ii(0x100e_0dd5, 1); pushd(edi);                             /* push edi */
            ii(0x100e_0dd6, 1); pushd(ebp);                             /* push ebp */
            ii(0x100e_0dd7, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100e_0dd9, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x100e_0ddf, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100e_0de2, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x100e_0de5, 5); mov(ebx, 0x2);                          /* mov ebx, 0x2 */
            ii(0x100e_0dea, 3); lea(edx, ebp - 0x4);                    /* lea edx, [ebp-0x4] */
            ii(0x100e_0ded, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_0df0, 5); calld(0x1013_c055, 0x5b260);            /* call 0x1013c055 */
            ii(0x100e_0df5, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100e_0df7, 1); popd(ebp);                              /* pop ebp */
            ii(0x100e_0df8, 1); popd(edi);                              /* pop edi */
            ii(0x100e_0df9, 1); popd(esi);                              /* pop esi */
            ii(0x100e_0dfa, 1); popd(ecx);                              /* pop ecx */
            ii(0x100e_0dfb, 1); popd(ebx);                              /* pop ebx */
            ii(0x100e_0dfc, 1); retd(); return;                         /* ret */
        }
    }
}