using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1010_2acc-44b9eb0e")]
        public void Method_1010_2acc()
        {
            ii(0x1010_2acc, 1); push(ebx);                              /* push ebx */
            ii(0x1010_2acd, 1); push(ecx);                              /* push ecx */
            ii(0x1010_2ace, 1); push(edx);                              /* push edx */
            ii(0x1010_2acf, 1); push(esi);                              /* push esi */
            ii(0x1010_2ad0, 1); push(edi);                              /* push edi */
            ii(0x1010_2ad1, 1); push(ebp);                              /* push ebp */
            ii(0x1010_2ad2, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1010_2ad4, 6); sub(esp, 4);                            /* sub esp, 0x4 */
            ii(0x1010_2ada, 4); mov(memb[ss, ebp - 4], 1);              /* mov byte [ebp-0x4], 0x1 */
            ii(0x1010_2ade, 3); mov(al, memb[ss, ebp - 4]);             /* mov al, [ebp-0x4] */
            ii(0x1010_2ae1, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1010_2ae3, 1); pop(ebp);                               /* pop ebp */
            ii(0x1010_2ae4, 1); pop(edi);                               /* pop edi */
            ii(0x1010_2ae5, 1); pop(esi);                               /* pop esi */
            ii(0x1010_2ae6, 1); pop(edx);                               /* pop edx */
            ii(0x1010_2ae7, 1); pop(ecx);                               /* pop ecx */
            ii(0x1010_2ae8, 1); pop(ebx);                               /* pop ebx */
            ii(0x1010_2ae9, 1); ret();                                  /* ret */
        }
    }
}
