using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1017_9c70-1b46a2db")]
        public void /* sys */ Method_1017_9c70()
        {
            ii(0x1017_9c70, 1); push(ebp);                              /* push ebp */
            ii(0x1017_9c71, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1017_9c73, 3); mov(edx, memd[ss, ebp + 8]);            /* mov edx, [ebp+0x8] */
            ii(0x1017_9c76, 5); mov(eax, memd[ds, 0x101b_e43c]);        /* mov eax, [0x101be43c] */
            ii(0x1017_9c7b, 6); cmp(edx, 0x7fff);                       /* cmp edx, 0x7fff */
            ii(0x1017_9c81, 2); if(jbe(0x1017_9c88, 5)) goto l_0x1017_9c88; /* jbe 0x10179c88 */
            ii(0x1017_9c83, 5); mov(edx, 0x7fff);                       /* mov edx, 0x7fff */
        l_0x1017_9c88:
            ii(0x1017_9c88, 6); mov(memd[ds, 0x101b_e43c], edx);        /* mov [0x101be43c], edx */
            ii(0x1017_9c8e, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1017_9c90, 1); pop(ebp);                               /* pop ebp */
            ii(0x1017_9c91, 1); ret();                                  /* ret */
        }
    }
}
