using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("29b02963-abd1-4953-be30-9567dacc8aac")]
        public void Method_0000_fb24()
        {
            ii(0xfb24, 1);    popw(ds);                                 /* pop ds */
            ii(0xfb25, 1);    popw(bp);                                 /* pop bp */
            ii(0xfb26, 1);    retw(); return;                           /* ret */
        }
    }
}
