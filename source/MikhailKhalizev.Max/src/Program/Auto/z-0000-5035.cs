using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("518057dd-5c79-41aa-90a1-876e87174d3c")]
        public void Method_0000_5035()
        {
            ii(0x5035, 1);    pushw(ss);                                /* push ss */
            ii(0x5036, 1);    popw(ds);                                 /* pop ds */
            ii(0x5037, 1);    retw(); return;                           /* ret */
        }
    }
}
