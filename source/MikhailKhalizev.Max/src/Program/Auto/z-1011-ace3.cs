using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("9bf8fd1b-2d45-4d97-a01e-4d5eb6dc9d2b")]
        public void Method_1011_ace3()
        {
            ii(0x1011_ace3, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x1011_ace8, 5); calld(Definitions.sys_check_available_stack_size, 0x4_b065); /* call 0x10165d52 */
            ii(0x1011_aced, 1); pushd(ebx);                             /* push ebx */
            ii(0x1011_acee, 1); pushd(ecx);                             /* push ecx */
            ii(0x1011_acef, 1); pushd(esi);                             /* push esi */
            ii(0x1011_acf0, 1); pushd(edi);                             /* push edi */
            ii(0x1011_acf1, 1); pushd(ebp);                             /* push ebp */
            ii(0x1011_acf2, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1011_acf4, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1011_acfa, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1011_acfd, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1011_ad00, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1011_ad02, 1); popd(ebp);                              /* pop ebp */
            ii(0x1011_ad03, 1); popd(edi);                              /* pop edi */
            ii(0x1011_ad04, 1); popd(esi);                              /* pop esi */
            ii(0x1011_ad05, 1); popd(ecx);                              /* pop ecx */
            ii(0x1011_ad06, 1); popd(ebx);                              /* pop ebx */
            ii(0x1011_ad07, 1); retd(); return;                         /* ret */
        }
    }
}
