using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100d_51c4-44b9eb0e")]
        public void Method_100d_51c4()
        {
            ii(0x100d_51c4, 1); push(ebx);                              /* push ebx */
            ii(0x100d_51c5, 1); push(ecx);                              /* push ecx */
            ii(0x100d_51c6, 1); push(edx);                              /* push edx */
            ii(0x100d_51c7, 1); push(esi);                              /* push esi */
            ii(0x100d_51c8, 1); push(edi);                              /* push edi */
            ii(0x100d_51c9, 1); push(ebp);                              /* push ebp */
            ii(0x100d_51ca, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100d_51cc, 6); sub(esp, 4);                            /* sub esp, 0x4 */
            ii(0x100d_51d2, 4); mov(memb[ss, ebp - 4], 1);              /* mov byte [ebp-0x4], 0x1 */
            ii(0x100d_51d6, 3); mov(al, memb[ss, ebp - 4]);             /* mov al, [ebp-0x4] */
            ii(0x100d_51d9, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100d_51db, 1); pop(ebp);                               /* pop ebp */
            ii(0x100d_51dc, 1); pop(edi);                               /* pop edi */
            ii(0x100d_51dd, 1); pop(esi);                               /* pop esi */
            ii(0x100d_51de, 1); pop(edx);                               /* pop edx */
            ii(0x100d_51df, 1); pop(ecx);                               /* pop ecx */
            ii(0x100d_51e0, 1); pop(ebx);                               /* pop ebx */
            ii(0x100d_51e1, 1); ret();                                  /* ret */
        }
    }
}
