using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("cbcf9f45-1085-47c0-8ac9-bb01f812a2de")]
        public void Method_100a_b198()
        {
            ii(0x100a_b198, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x100a_b19d, 5); calld(Definitions.sys_check_available_stack_size, 0xb_abb0); /* call 0x10165d52 */
            ii(0x100a_b1a2, 1); pushd(ebx);                             /* push ebx */
            ii(0x100a_b1a3, 1); pushd(ecx);                             /* push ecx */
            ii(0x100a_b1a4, 1); pushd(esi);                             /* push esi */
            ii(0x100a_b1a5, 1); pushd(edi);                             /* push edi */
            ii(0x100a_b1a6, 1); pushd(ebp);                             /* push ebp */
            ii(0x100a_b1a7, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100a_b1a9, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x100a_b1af, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100a_b1b2, 3); mov(memb_a32[ss, ebp - 0x4], dl);       /* mov [ebp-0x4], dl */
            ii(0x100a_b1b5, 3); mov(al, memb_a32[ss, ebp - 0x4]);       /* mov al, [ebp-0x4] */
            ii(0x100a_b1b8, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x100a_b1bb, 3); mov(memb_a32[ds, edx + 0x7], al);       /* mov [edx+0x7], al */
            ii(0x100a_b1be, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100a_b1c0, 1); popd(ebp);                              /* pop ebp */
            ii(0x100a_b1c1, 1); popd(edi);                              /* pop edi */
            ii(0x100a_b1c2, 1); popd(esi);                              /* pop esi */
            ii(0x100a_b1c3, 1); popd(ecx);                              /* pop ecx */
            ii(0x100a_b1c4, 1); popd(ebx);                              /* pop ebx */
            ii(0x100a_b1c5, 1); retd(); return;                         /* ret */
        }
    }
}
