using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1017_b860-5de1bb9")]
        public void /* sys */ Method_1017_b860()
        {
            ii(0x1017_b860, 1); push(ebp);                              /* push ebp */
            ii(0x1017_b861, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1017_b863, 4); cmp(memd[ss, ebp + 8], 3);              /* cmp dword [ebp+0x8], 0x3 */
            ii(0x1017_b867, 3); setnz(al);                              /* setnz al */
            ii(0x1017_b86a, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1017_b86f, 3); add(eax, 3);                            /* add eax, 0x3 */
            ii(0x1017_b872, 5); mov(memd[ds, 0x101b_e204], eax);        /* mov [0x101be204], eax */
            ii(0x1017_b877, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1017_b879, 1); pop(ebp);                               /* pop ebp */
            ii(0x1017_b87a, 1); ret();                                  /* ret */
        }
    }
}
