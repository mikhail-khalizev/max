using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("b6ac994b-588c-44ea-a1a5-fa97521d2d29")]
        public void Method_0018_e062()
        {
            ii(0x18_e062, 5); or(memb_a32[ss, ebp + 0x2c], 0x1);        /* or byte [ebp+0x2c], 0x1 */
            ii(0x18_e067, 3); mov(esp, ebp);                            /* mov esp, ebp */
            ii(0x18_e06a, 1); popw(ds);                                 /* pop ds */
            ii(0x18_e06b, 1); popw(es);                                 /* pop es */
            ii(0x18_e06c, 2); popad();                                  /* popad */
            ii(0x18_e06e, 2); iretd(); return;                          /* iretd */
        }
    }
}
