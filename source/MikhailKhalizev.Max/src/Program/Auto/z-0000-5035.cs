using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x5035-89d3a")]
        public void Method_0000_5035()
        {
            ii(0x5035, 1);  push(ss);                                  /* push ss */
            ii(0x5036, 1);  pop(ds);                                   /* pop ds */
            ii(0x5037, 1);  ret();                                     /* ret */
        }
    }
}
