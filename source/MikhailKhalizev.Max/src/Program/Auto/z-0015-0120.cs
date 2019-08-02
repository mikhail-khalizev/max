using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("a992f905-5545-42db-8da2-60decf905b09")]
        public void Method_0015_0120()
        {
            ii(0x15_0120, 1); popw(ds);                                 /* pop ds */
            ii(0x15_0121, 1); popw(di);                                 /* pop di */
            ii(0x15_0122, 1); popw(si);                                 /* pop si */
            ii(0x15_0123, 1); popw(bp);                                 /* pop bp */
            ii(0x15_0124, 1); retfw(); return;                          /* retf */
        }
    }
}
