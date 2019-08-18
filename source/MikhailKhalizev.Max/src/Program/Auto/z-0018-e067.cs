using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x18_e067-75fb132e")]
        public void Method_0018_e067()
        {
            ii(0x18_e067, 3); mov(esp, ebp);                            /* mov esp, ebp */
            ii(0x18_e06a, 1); popw(ds);                                 /* pop ds */
            ii(0x18_e06b, 1); popw(es);                                 /* pop es */
            ii(0x18_e06c, 2); popad();                                  /* popad */
            ii(0x18_e06e, 2); iretd(); return;                          /* iretd */
        }
    }
}
