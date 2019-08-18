using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100a_2f9c-4338b73e")]
        public void Method_100a_2f9c()
        {
            ii(0x100a_2f9c, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x100a_2fa1, 5); calld(Definitions.sys_check_available_stack_size, 0xc_2dac); /* call 0x10165d52 */
            ii(0x100a_2fa6, 1); pushd(ebx);                             /* push ebx */
            ii(0x100a_2fa7, 1); pushd(ecx);                             /* push ecx */
            ii(0x100a_2fa8, 1); pushd(esi);                             /* push esi */
            ii(0x100a_2fa9, 1); pushd(edi);                             /* push edi */
            ii(0x100a_2faa, 1); pushd(ebp);                             /* push ebp */
            ii(0x100a_2fab, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100a_2fad, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x100a_2fb3, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100a_2fb6, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x100a_2fb9, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100a_2fbb, 1); popd(ebp);                              /* pop ebp */
            ii(0x100a_2fbc, 1); popd(edi);                              /* pop edi */
            ii(0x100a_2fbd, 1); popd(esi);                              /* pop esi */
            ii(0x100a_2fbe, 1); popd(ecx);                              /* pop ecx */
            ii(0x100a_2fbf, 1); popd(ebx);                              /* pop ebx */
            ii(0x100a_2fc0, 1); retd(); return;                         /* ret */
        }
    }
}
