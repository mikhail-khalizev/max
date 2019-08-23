using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x17_d0b0-75fb132e")]
        public void Method_0017_d0b0()
        {
            ii(0x17_d0b0, 3); mov(esp, ebp);                            /* mov esp, ebp */
            ii(0x17_d0b3, 1); popw(ds);                                 /* pop ds */
            ii(0x17_d0b4, 1); popw(es);                                 /* pop es */
            ii(0x17_d0b5, 2); popad();                                  /* popad */
            ii(0x17_d0b7, 2); iretd();                                  /* iretd */
        }
    }
}
