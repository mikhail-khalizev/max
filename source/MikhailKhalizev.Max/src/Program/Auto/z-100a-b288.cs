using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("bc647528-7567-40da-9558-025b919c7554")]
        public void Method_100a_b288()
        {
            ii(0x100a_b288, 1); pushd(ebx);                             /* push ebx */
            ii(0x100a_b289, 1); pushd(ecx);                             /* push ecx */
            ii(0x100a_b28a, 1); pushd(edx);                             /* push edx */
            ii(0x100a_b28b, 1); pushd(esi);                             /* push esi */
            ii(0x100a_b28c, 1); pushd(edi);                             /* push edi */
            ii(0x100a_b28d, 1); pushd(ebp);                             /* push ebp */
            ii(0x100a_b28e, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100a_b290, 6); sub(esp, 0x4);                          /* sub esp, 0x4 */
            ii(0x100a_b296, 4); mov(memb_a32[ss, ebp - 0x4], 0);        /* mov byte [ebp-0x4], 0x0 */
            ii(0x100a_b29a, 3); mov(al, memb_a32[ss, ebp - 0x4]);       /* mov al, [ebp-0x4] */
            ii(0x100a_b29d, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100a_b29f, 1); popd(ebp);                              /* pop ebp */
            ii(0x100a_b2a0, 1); popd(edi);                              /* pop edi */
            ii(0x100a_b2a1, 1); popd(esi);                              /* pop esi */
            ii(0x100a_b2a2, 1); popd(edx);                              /* pop edx */
            ii(0x100a_b2a3, 1); popd(ecx);                              /* pop ecx */
            ii(0x100a_b2a4, 1); popd(ebx);                              /* pop ebx */
            ii(0x100a_b2a5, 1); retd(); return;                         /* ret */
        }
    }
}
