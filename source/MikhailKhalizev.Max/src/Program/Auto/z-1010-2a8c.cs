using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1010_2a8c-b70b8a0f")]
        public void Method_1010_2a8c()
        {
            ii(0x1010_2a8c, 1); push(ebx);                              /* push ebx */
            ii(0x1010_2a8d, 1); push(ecx);                              /* push ecx */
            ii(0x1010_2a8e, 1); push(edx);                              /* push edx */
            ii(0x1010_2a8f, 1); push(esi);                              /* push esi */
            ii(0x1010_2a90, 1); push(edi);                              /* push edi */
            ii(0x1010_2a91, 1); push(ebp);                              /* push ebp */
            ii(0x1010_2a92, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1010_2a94, 6); sub(esp, 0x4);                          /* sub esp, 0x4 */
            ii(0x1010_2a9a, 4); mov(memb[ss, ebp - 0x4], 0);            /* mov byte [ebp-0x4], 0x0 */
            ii(0x1010_2a9e, 3); mov(al, memb[ss, ebp - 0x4]);           /* mov al, [ebp-0x4] */
            ii(0x1010_2aa1, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1010_2aa3, 1); pop(ebp);                               /* pop ebp */
            ii(0x1010_2aa4, 1); pop(edi);                               /* pop edi */
            ii(0x1010_2aa5, 1); pop(esi);                               /* pop esi */
            ii(0x1010_2aa6, 1); pop(edx);                               /* pop edx */
            ii(0x1010_2aa7, 1); pop(ecx);                               /* pop ecx */
            ii(0x1010_2aa8, 1); pop(ebx);                               /* pop ebx */
            ii(0x1010_2aa9, 1); ret();                                  /* ret */
        }
    }
}
