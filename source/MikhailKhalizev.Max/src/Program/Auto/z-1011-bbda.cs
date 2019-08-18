using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1011_bbda-555f1d78")]
        public void Method_1011_bbda()
        {
            ii(0x1011_bbda, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x1011_bbdf, 5); calld(Definitions.sys_check_available_stack_size, 0x4_a16e); /* call 0x10165d52 */
            ii(0x1011_bbe4, 1); pushd(ebx);                             /* push ebx */
            ii(0x1011_bbe5, 1); pushd(ecx);                             /* push ecx */
            ii(0x1011_bbe6, 1); pushd(esi);                             /* push esi */
            ii(0x1011_bbe7, 1); pushd(edi);                             /* push edi */
            ii(0x1011_bbe8, 1); pushd(ebp);                             /* push ebp */
            ii(0x1011_bbe9, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1011_bbeb, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1011_bbf1, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1011_bbf4, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1011_bbf7, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1011_bbf9, 1); popd(ebp);                              /* pop ebp */
            ii(0x1011_bbfa, 1); popd(edi);                              /* pop edi */
            ii(0x1011_bbfb, 1); popd(esi);                              /* pop esi */
            ii(0x1011_bbfc, 1); popd(ecx);                              /* pop ecx */
            ii(0x1011_bbfd, 1); popd(ebx);                              /* pop ebx */
            ii(0x1011_bbfe, 1); retd(); return;                         /* ret */
        }
    }
}
