using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1007_6054-b70b8a0f")]
        public void Method_1007_6054()
        {
            ii(0x1007_6054, 1); push(ebx);                              /* push ebx */
            ii(0x1007_6055, 1); push(ecx);                              /* push ecx */
            ii(0x1007_6056, 1); push(edx);                              /* push edx */
            ii(0x1007_6057, 1); push(esi);                              /* push esi */
            ii(0x1007_6058, 1); push(edi);                              /* push edi */
            ii(0x1007_6059, 1); push(ebp);                              /* push ebp */
            ii(0x1007_605a, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1007_605c, 6); sub(esp, 4);                            /* sub esp, 0x4 */
            ii(0x1007_6062, 4); mov(memb[ss, ebp - 4], 0);              /* mov byte [ebp-0x4], 0x0 */
            ii(0x1007_6066, 3); mov(al, memb[ss, ebp - 4]);             /* mov al, [ebp-0x4] */
            ii(0x1007_6069, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1007_606b, 1); pop(ebp);                               /* pop ebp */
            ii(0x1007_606c, 1); pop(edi);                               /* pop edi */
            ii(0x1007_606d, 1); pop(esi);                               /* pop esi */
            ii(0x1007_606e, 1); pop(edx);                               /* pop edx */
            ii(0x1007_606f, 1); pop(ecx);                               /* pop ecx */
            ii(0x1007_6070, 1); pop(ebx);                               /* pop ebx */
            ii(0x1007_6071, 1); ret();                                  /* ret */
        }
    }
}
