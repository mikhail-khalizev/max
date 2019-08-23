using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100a_b268-b70b8a0f")]
        public void Method_100a_b268()
        {
            ii(0x100a_b268, 1); push(ebx);                              /* push ebx */
            ii(0x100a_b269, 1); push(ecx);                              /* push ecx */
            ii(0x100a_b26a, 1); push(edx);                              /* push edx */
            ii(0x100a_b26b, 1); push(esi);                              /* push esi */
            ii(0x100a_b26c, 1); push(edi);                              /* push edi */
            ii(0x100a_b26d, 1); push(ebp);                              /* push ebp */
            ii(0x100a_b26e, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100a_b270, 6); sub(esp, 0x4);                          /* sub esp, 0x4 */
            ii(0x100a_b276, 4); mov(memb[ss, ebp - 0x4], 0);            /* mov byte [ebp-0x4], 0x0 */
            ii(0x100a_b27a, 3); mov(al, memb[ss, ebp - 0x4]);           /* mov al, [ebp-0x4] */
            ii(0x100a_b27d, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100a_b27f, 1); pop(ebp);                               /* pop ebp */
            ii(0x100a_b280, 1); pop(edi);                               /* pop edi */
            ii(0x100a_b281, 1); pop(esi);                               /* pop esi */
            ii(0x100a_b282, 1); pop(edx);                               /* pop edx */
            ii(0x100a_b283, 1); pop(ecx);                               /* pop ecx */
            ii(0x100a_b284, 1); pop(ebx);                               /* pop ebx */
            ii(0x100a_b285, 1); ret();                                  /* ret */
        }
    }
}
