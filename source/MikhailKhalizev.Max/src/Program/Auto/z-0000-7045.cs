using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x7045-89d3a")]
        public void Method_0000_7045()
        {
            ii(0x7045, 1);    pushw(ss);                                /* push ss */
            ii(0x7046, 1);    popw(ds);                                 /* pop ds */
            ii(0x7047, 1);    retw();                                   /* ret */
        }
    }
}
