using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1017_9c60-1193c10")]
        public void /* sys */ Method_1017_9c60()
        {
            ii(0x1017_9c60, 1); push(ebp);                              /* push ebp */
            ii(0x1017_9c61, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1017_9c63, 3); mov(eax, memd[ss, ebp + 0x8]);          /* mov eax, [ebp+0x8] */
            ii(0x1017_9c66, 5); mov(memd[ds, 0x101b_e418], eax);        /* mov [0x101be418], eax */
            ii(0x1017_9c6b, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1017_9c6d, 1); pop(ebp);                               /* pop ebp */
            ii(0x1017_9c6e, 1); ret();                                  /* ret */
        }
    }
}
