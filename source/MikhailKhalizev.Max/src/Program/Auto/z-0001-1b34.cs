using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1_1b34-8b931")]
        public void Method_0001_1b34()
        {
            ii(0x1_1b34, 1);  pop(ds);                                  /* pop ds */
            ii(0x1_1b35, 1);  pop(bp);                                  /* pop bp */
            ii(0x1_1b36, 1);  ret();                                    /* ret */
        }
    }
}
