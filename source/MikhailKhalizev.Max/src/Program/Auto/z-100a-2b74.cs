using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100a_2b74-cd7bb9da")]
        public void Method_100a_2b74()
        {
            ii(0x100a_2b74, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x100a_2b79, 5); calld(Definitions.sys_check_available_stack_size, 0xc_31d4); /* call 0x10165d52 */
            ii(0x100a_2b7e, 1); pushd(ebx);                             /* push ebx */
            ii(0x100a_2b7f, 1); pushd(ecx);                             /* push ecx */
            ii(0x100a_2b80, 1); pushd(edx);                             /* push edx */
            ii(0x100a_2b81, 1); pushd(esi);                             /* push esi */
            ii(0x100a_2b82, 1); pushd(edi);                             /* push edi */
            ii(0x100a_2b83, 1); pushd(ebp);                             /* push ebp */
            ii(0x100a_2b84, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100a_2b86, 6); sub(esp, 0x4);                          /* sub esp, 0x4 */
            ii(0x100a_2b8c, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x100a_2b8f, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100a_2b91, 1); popd(ebp);                              /* pop ebp */
            ii(0x100a_2b92, 1); popd(edi);                              /* pop edi */
            ii(0x100a_2b93, 1); popd(esi);                              /* pop esi */
            ii(0x100a_2b94, 1); popd(edx);                              /* pop edx */
            ii(0x100a_2b95, 1); popd(ecx);                              /* pop ecx */
            ii(0x100a_2b96, 1); popd(ebx);                              /* pop ebx */
            ii(0x100a_2b97, 1); retd();                                 /* ret */
        }
    }
}
