using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x19_0120-251ef698")]
        public void Method_0019_0120()
        {
            ii(0x19_0120, 1); pop(ds);                                  /* pop ds */
            ii(0x19_0121, 1); pop(di);                                  /* pop di */
            ii(0x19_0122, 1); pop(si);                                  /* pop si */
            ii(0x19_0123, 1); pop(bp);                                  /* pop bp */
            ii(0x19_0124, 1); retf();                                   /* retf */
        }
    }
}
