using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x18_f343-ccf6799c")]
        public void Method_0018_f343()
        {
            ii(0x18_f343, 3); pop(memw[ss, bp - 4]);                    /* pop word [bp-0x4] */
            ii(0x18_f346, 2); pop(gs);                                  /* pop gs */
            ii(0x18_f348, 2); pop(fs);                                  /* pop fs */
            ii(0x18_f34a, 2); popad();                                  /* popad */
            ii(0x18_f34c, 1); pop(bp);                                  /* pop bp */
            ii(0x18_f34d, 1); retf();                                   /* retf */
        }
    }
}
