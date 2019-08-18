using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("7b978723-12f9-4c01-99a7-14b76af0125e")]
        public void Method_0001_0e04()
        {
            ii(0x1_0e04, 1);  popw(ds);                                 /* pop ds */
            ii(0x1_0e05, 1);  popw(dx);                                 /* pop dx */
            ii(0x1_0e06, 1);  popw(ax);                                 /* pop ax */
            ii(0x1_0e07, 1);  retw(); return;                           /* ret */
        }
    }
}
