using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100b_a9c2-837d1a1")]
        public void Method_100b_a9c2()
        {
            ii(0x100b_a9c2, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x100b_a9c7, 5); calld(Definitions.sys_check_available_stack_size, 0xa_b386); /* call 0x10165d52 */
            ii(0x100b_a9cc, 1); pushd(ecx);                             /* push ecx */
            ii(0x100b_a9cd, 1); pushd(esi);                             /* push esi */
            ii(0x100b_a9ce, 1); pushd(edi);                             /* push edi */
            ii(0x100b_a9cf, 1); pushd(ebp);                             /* push ebp */
            ii(0x100b_a9d0, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100b_a9d2, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x100b_a9d8, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100b_a9db, 3); mov(memd_a32[ss, ebp - 0x8], edx);      /* mov [ebp-0x8], edx */
            ii(0x100b_a9de, 3); mov(memb_a32[ss, ebp - 0x4], bl);       /* mov [ebp-0x4], bl */
            ii(0x100b_a9e1, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100b_a9e3, 1); popd(ebp);                              /* pop ebp */
            ii(0x100b_a9e4, 1); popd(edi);                              /* pop edi */
            ii(0x100b_a9e5, 1); popd(esi);                              /* pop esi */
            ii(0x100b_a9e6, 1); popd(ecx);                              /* pop ecx */
            ii(0x100b_a9e7, 1); retd(); return;                         /* ret */
        }
    }
}
