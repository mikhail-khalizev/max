using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("416b482f-b9d8-4ec6-8a46-b9eeadbd0385")]
        public void Method_100a_2b4f()
        {
            ii(0x100a_2b4f, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x100a_2b54, 5); calld(Definitions.sys_check_available_stack_size, 0xc_31f9); /* call 0x10165d52 */
            ii(0x100a_2b59, 1); pushd(ebx);                             /* push ebx */
            ii(0x100a_2b5a, 1); pushd(ecx);                             /* push ecx */
            ii(0x100a_2b5b, 1); pushd(esi);                             /* push esi */
            ii(0x100a_2b5c, 1); pushd(edi);                             /* push edi */
            ii(0x100a_2b5d, 1); pushd(ebp);                             /* push ebp */
            ii(0x100a_2b5e, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100a_2b60, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x100a_2b66, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100a_2b69, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x100a_2b6c, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100a_2b6e, 1); popd(ebp);                              /* pop ebp */
            ii(0x100a_2b6f, 1); popd(edi);                              /* pop edi */
            ii(0x100a_2b70, 1); popd(esi);                              /* pop esi */
            ii(0x100a_2b71, 1); popd(ecx);                              /* pop ecx */
            ii(0x100a_2b72, 1); popd(ebx);                              /* pop ebx */
            ii(0x100a_2b73, 1); retd(); return;                         /* ret */
        }
    }
}
