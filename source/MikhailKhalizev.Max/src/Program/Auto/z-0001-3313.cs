using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1_3313-ccf6799c")]
        public void Method_0001_3313()
        {
            ii(0x1_3313, 3);  popw(memw_a16[ss, bp - 0x4]);             /* pop word [bp-0x4] */
            ii(0x1_3316, 2);  popw(gs);                                 /* pop gs */
            ii(0x1_3318, 2);  popw(fs);                                 /* pop fs */
            ii(0x1_331a, 2);  popad();                                  /* popad */
            ii(0x1_331c, 1);  popw(bp);                                 /* pop bp */
            ii(0x1_331d, 1);  retfw(); return;                          /* retf */
        }
    }
}
