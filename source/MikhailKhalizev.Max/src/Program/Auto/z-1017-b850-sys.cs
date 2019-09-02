using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1017_b850-7eb25e8e")]
        public void /* sys */ Method_1017_b850()
        {
            ii(0x1017_b850, 1); push(ebp);                              /* push ebp */
            ii(0x1017_b851, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1017_b853, 3); mov(eax, memd[ss, ebp + 8]);            /* mov eax, [ebp+0x8] */
            ii(0x1017_b856, 5); mov(memd[ds, 0x101b_e200], eax);        /* mov [0x101be200], eax */
            ii(0x1017_b85b, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1017_b85d, 1); pop(ebp);                               /* pop ebp */
            ii(0x1017_b85e, 1); ret();                                  /* ret */
        }
    }
}
