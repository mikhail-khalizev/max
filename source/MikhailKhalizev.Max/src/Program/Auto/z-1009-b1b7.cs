using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1009_b1b7-5c22d9a9")]
        public void Method_1009_b1b7()
        {
            ii(0x1009_b1b7, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1009_b1bc, 5); calld(Definitions.sys_check_available_stack_size, 0xc_ab91); /* call 0x10165d52 */
            ii(0x1009_b1c1, 1); pushd(ebx);                             /* push ebx */
            ii(0x1009_b1c2, 1); pushd(ecx);                             /* push ecx */
            ii(0x1009_b1c3, 1); pushd(edx);                             /* push edx */
            ii(0x1009_b1c4, 1); pushd(esi);                             /* push esi */
            ii(0x1009_b1c5, 1); pushd(edi);                             /* push edi */
            ii(0x1009_b1c6, 1); pushd(ebp);                             /* push ebp */
            ii(0x1009_b1c7, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1009_b1c9, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1009_b1cf, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1009_b1d2, 4); mov(memb_a32[ss, ebp - 0x8], 0x28);     /* mov byte [ebp-0x8], 0x28 */
            ii(0x1009_b1d6, 3); mov(al, memb_a32[ss, ebp - 0x8]);       /* mov al, [ebp-0x8] */
            ii(0x1009_b1d9, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1009_b1db, 1); popd(ebp);                              /* pop ebp */
            ii(0x1009_b1dc, 1); popd(edi);                              /* pop edi */
            ii(0x1009_b1dd, 1); popd(esi);                              /* pop esi */
            ii(0x1009_b1de, 1); popd(edx);                              /* pop edx */
            ii(0x1009_b1df, 1); popd(ecx);                              /* pop ecx */
            ii(0x1009_b1e0, 1); popd(ebx);                              /* pop ebx */
            ii(0x1009_b1e1, 1); retd();                                 /* ret */
        }
    }
}
