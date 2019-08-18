using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("ba6ac810-7cb0-4230-bc03-09324a42fc14")]
        public void Method_0019_0120()
        {
            ii(0x19_0120, 1); popw(ds);                                 /* pop ds */
            ii(0x19_0121, 1); popw(di);                                 /* pop di */
            ii(0x19_0122, 1); popw(si);                                 /* pop si */
            ii(0x19_0123, 1); popw(bp);                                 /* pop bp */
            ii(0x19_0124, 1); retfw(); return;                          /* retf */
        }
    }
}
