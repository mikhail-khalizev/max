using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1017_94c0-4cfc1dce")]
        public void /* sys */ Method_1017_94c0()
        {
            ii(0x1017_94c0, 1); push(ebp);                              /* push ebp */
            ii(0x1017_94c1, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1017_94c3, 3); mov(eax, memd[ss, ebp + 8]);            /* mov eax, [ebp+0x8] */
            ii(0x1017_94c6, 5); mov(memd[ds, 0x1020_9dc4], eax);        /* mov [0x10209dc4], eax */
            ii(0x1017_94cb, 3); mov(eax, memd[ss, ebp + 12]);           /* mov eax, [ebp+0xc] */
            ii(0x1017_94ce, 5); mov(memd[ds, 0x1020_9dcc], eax);        /* mov [0x10209dcc], eax */
            ii(0x1017_94d3, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1017_94d5, 1); pop(ebp);                               /* pop ebp */
            ii(0x1017_94d6, 1); ret();                                  /* ret */
        }
    }
}
