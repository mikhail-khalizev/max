using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100a_2df6-31bd8986")]
        public void Method_100a_2df6()
        {
            ii(0x100a_2df6, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x100a_2dfb, 5); calld(Definitions.sys_check_available_stack_size, 0xc_2f52); /* call 0x10165d52 */
            ii(0x100a_2e00, 1); pushd(ebx);                             /* push ebx */
            ii(0x100a_2e01, 1); pushd(ecx);                             /* push ecx */
            ii(0x100a_2e02, 1); pushd(edx);                             /* push edx */
            ii(0x100a_2e03, 1); pushd(esi);                             /* push esi */
            ii(0x100a_2e04, 1); pushd(edi);                             /* push edi */
            ii(0x100a_2e05, 1); pushd(ebp);                             /* push ebp */
            ii(0x100a_2e06, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100a_2e08, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x100a_2e0e, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x100a_2e11, 4); mov(memb_a32[ss, ebp - 0x8], 0);        /* mov byte [ebp-0x8], 0x0 */
            ii(0x100a_2e15, 3); mov(al, memb_a32[ss, ebp - 0x8]);       /* mov al, [ebp-0x8] */
            ii(0x100a_2e18, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100a_2e1a, 1); popd(ebp);                              /* pop ebp */
            ii(0x100a_2e1b, 1); popd(edi);                              /* pop edi */
            ii(0x100a_2e1c, 1); popd(esi);                              /* pop esi */
            ii(0x100a_2e1d, 1); popd(edx);                              /* pop edx */
            ii(0x100a_2e1e, 1); popd(ecx);                              /* pop ecx */
            ii(0x100a_2e1f, 1); popd(ebx);                              /* pop ebx */
            ii(0x100a_2e20, 1); retd(); return;                         /* ret */
        }
    }
}
