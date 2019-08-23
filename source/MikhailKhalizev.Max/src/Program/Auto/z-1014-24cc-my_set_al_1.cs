using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1014_24cc-44b9eb0e")]
        public void my_set_al_1()
        {
            ii(0x1014_24cc, 1); push(ebx);                              /* push ebx */
            ii(0x1014_24cd, 1); push(ecx);                              /* push ecx */
            ii(0x1014_24ce, 1); push(edx);                              /* push edx */
            ii(0x1014_24cf, 1); push(esi);                              /* push esi */
            ii(0x1014_24d0, 1); push(edi);                              /* push edi */
            ii(0x1014_24d1, 1); push(ebp);                              /* push ebp */
            ii(0x1014_24d2, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1014_24d4, 6); sub(esp, 0x4);                          /* sub esp, 0x4 */
            ii(0x1014_24da, 4); mov(memb[ss, ebp - 0x4], 0x1);          /* mov byte [ebp-0x4], 0x1 */
            ii(0x1014_24de, 3); mov(al, memb[ss, ebp - 0x4]);           /* mov al, [ebp-0x4] */
            ii(0x1014_24e1, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1014_24e3, 1); pop(ebp);                               /* pop ebp */
            ii(0x1014_24e4, 1); pop(edi);                               /* pop edi */
            ii(0x1014_24e5, 1); pop(esi);                               /* pop esi */
            ii(0x1014_24e6, 1); pop(edx);                               /* pop edx */
            ii(0x1014_24e7, 1); pop(ecx);                               /* pop ecx */
            ii(0x1014_24e8, 1); pop(ebx);                               /* pop ebx */
            ii(0x1014_24e9, 1); ret();                                  /* ret */
        }
    }
}
