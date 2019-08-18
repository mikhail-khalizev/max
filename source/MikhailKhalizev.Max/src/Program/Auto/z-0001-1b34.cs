using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("e1727d51-8cbf-46b3-870e-2ff7ca7883b2")]
        public void Method_0001_1b34()
        {
            ii(0x1_1b34, 1);  popw(ds);                                 /* pop ds */
            ii(0x1_1b35, 1);  popw(bp);                                 /* pop bp */
            ii(0x1_1b36, 1);  retw(); return;                           /* ret */
        }
    }
}
