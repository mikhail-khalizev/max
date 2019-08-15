using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("dd8581c0-ca37-4236-9b08-2fa7f786b67b")]
        public void Method_100a_2eb6()
        {
            ii(0x100a_2eb6, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x100a_2ebb, 5); calld(Definitions.sys_check_available_stack_size, 0xc_2e92); /* call 0x10165d52 */
            ii(0x100a_2ec0, 1); pushd(ebx);                             /* push ebx */
            ii(0x100a_2ec1, 1); pushd(ecx);                             /* push ecx */
            ii(0x100a_2ec2, 1); pushd(esi);                             /* push esi */
            ii(0x100a_2ec3, 1); pushd(edi);                             /* push edi */
            ii(0x100a_2ec4, 1); pushd(ebp);                             /* push ebp */
            ii(0x100a_2ec5, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100a_2ec7, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x100a_2ecd, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100a_2ed0, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x100a_2ed3, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100a_2ed5, 1); popd(ebp);                              /* pop ebp */
            ii(0x100a_2ed6, 1); popd(edi);                              /* pop edi */
            ii(0x100a_2ed7, 1); popd(esi);                              /* pop esi */
            ii(0x100a_2ed8, 1); popd(ecx);                              /* pop ecx */
            ii(0x100a_2ed9, 1); popd(ebx);                              /* pop ebx */
            ii(0x100a_2eda, 1); retd(); return;                         /* ret */
        }
    }
}
