using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1016_5d04-b70b8a0f")]
        public void Method_1016_5d04()
        {
            ii(0x1016_5d04, 1); push(ebx);                              /* push ebx */
            ii(0x1016_5d05, 1); push(ecx);                              /* push ecx */
            ii(0x1016_5d06, 1); push(edx);                              /* push edx */
            ii(0x1016_5d07, 1); push(esi);                              /* push esi */
            ii(0x1016_5d08, 1); push(edi);                              /* push edi */
            ii(0x1016_5d09, 1); push(ebp);                              /* push ebp */
            ii(0x1016_5d0a, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1016_5d0c, 6); sub(esp, 0x4);                          /* sub esp, 0x4 */
            ii(0x1016_5d12, 4); mov(memb[ss, ebp - 0x4], 0);            /* mov byte [ebp-0x4], 0x0 */
            ii(0x1016_5d16, 3); mov(al, memb[ss, ebp - 0x4]);           /* mov al, [ebp-0x4] */
            ii(0x1016_5d19, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1016_5d1b, 1); pop(ebp);                               /* pop ebp */
            ii(0x1016_5d1c, 1); pop(edi);                               /* pop edi */
            ii(0x1016_5d1d, 1); pop(esi);                               /* pop esi */
            ii(0x1016_5d1e, 1); pop(edx);                               /* pop edx */
            ii(0x1016_5d1f, 1); pop(ecx);                               /* pop ecx */
            ii(0x1016_5d20, 1); pop(ebx);                               /* pop ebx */
            ii(0x1016_5d21, 1); ret();                                  /* ret */
        }
    }
}
