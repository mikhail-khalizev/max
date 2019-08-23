using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100d_e97e-6bfcfe96")]
        public void Method_100d_e97e()
        {
            ii(0x100d_e97e, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x100d_e983, 5); calld(Definitions.sys_check_available_stack_size, 0x8_73ca); /* call 0x10165d52 */
            ii(0x100d_e988, 1); pushd(ebx);                             /* push ebx */
            ii(0x100d_e989, 1); pushd(ecx);                             /* push ecx */
            ii(0x100d_e98a, 1); pushd(esi);                             /* push esi */
            ii(0x100d_e98b, 1); pushd(edi);                             /* push edi */
            ii(0x100d_e98c, 1); pushd(ebp);                             /* push ebp */
            ii(0x100d_e98d, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100d_e98f, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x100d_e995, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100d_e998, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x100d_e99b, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_e99e, 5); calld(0x100d_e493, -0x510);             /* call 0x100de493 */
            ii(0x100d_e9a3, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100d_e9a5, 1); popd(ebp);                              /* pop ebp */
            ii(0x100d_e9a6, 1); popd(edi);                              /* pop edi */
            ii(0x100d_e9a7, 1); popd(esi);                              /* pop esi */
            ii(0x100d_e9a8, 1); popd(ecx);                              /* pop ecx */
            ii(0x100d_e9a9, 1); popd(ebx);                              /* pop ebx */
            ii(0x100d_e9aa, 1); retd();                                 /* ret */
        }
    }
}
