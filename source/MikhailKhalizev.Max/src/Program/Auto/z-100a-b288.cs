using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100a_b288-b70b8a0f")]
        public void Method_100a_b288()
        {
            ii(0x100a_b288, 1); push(ebx);                              /* push ebx */
            ii(0x100a_b289, 1); push(ecx);                              /* push ecx */
            ii(0x100a_b28a, 1); push(edx);                              /* push edx */
            ii(0x100a_b28b, 1); push(esi);                              /* push esi */
            ii(0x100a_b28c, 1); push(edi);                              /* push edi */
            ii(0x100a_b28d, 1); push(ebp);                              /* push ebp */
            ii(0x100a_b28e, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100a_b290, 6); sub(esp, 4);                            /* sub esp, 0x4 */
            ii(0x100a_b296, 4); mov(memb[ss, ebp - 4], 0);              /* mov byte [ebp-0x4], 0x0 */
            ii(0x100a_b29a, 3); mov(al, memb[ss, ebp - 4]);             /* mov al, [ebp-0x4] */
            ii(0x100a_b29d, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100a_b29f, 1); pop(ebp);                               /* pop ebp */
            ii(0x100a_b2a0, 1); pop(edi);                               /* pop edi */
            ii(0x100a_b2a1, 1); pop(esi);                               /* pop esi */
            ii(0x100a_b2a2, 1); pop(edx);                               /* pop edx */
            ii(0x100a_b2a3, 1); pop(ecx);                               /* pop ecx */
            ii(0x100a_b2a4, 1); pop(ebx);                               /* pop ebx */
            ii(0x100a_b2a5, 1); ret();                                  /* ret */
        }
    }
}
