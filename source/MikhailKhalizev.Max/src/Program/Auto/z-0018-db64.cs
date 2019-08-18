using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x18_db64-8b931")]
        public void Method_0018_db64()
        {
            ii(0x18_db64, 1); popw(ds);                                 /* pop ds */
            ii(0x18_db65, 1); popw(bp);                                 /* pop bp */
            ii(0x18_db66, 1); retw(); return;                           /* ret */
        }
    }
}
