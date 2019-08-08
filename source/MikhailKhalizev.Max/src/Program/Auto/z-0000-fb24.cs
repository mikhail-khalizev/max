using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("1a1ab443-12e7-40e0-b16b-209f48b7432b")]
        public void Method_0000_fb24()
        {
            ii(0xfb24, 1);    popw(ds);                                 /* pop ds */
            ii(0xfb25, 1);    popw(bp);                                 /* pop bp */
            ii(0xfb26, 1);    retw(); return;                           /* ret */
        }
    }
}
