using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("d4daee40-0c9f-45b6-89c9-de086a099556")]
        public void Method_0000_7045()
        {
            ii(0x7045, 1);    pushw(ss);                                /* push ss */
            ii(0x7046, 1);    popw(ds);                                 /* pop ds */
            ii(0x7047, 1);    retw(); return;                           /* ret */
        }
    }
}
