using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("7423bdb1-866c-4867-b36f-b9336534742d")]
        public void Method_0001_1303()
        {
            ii(0x1_1303, 3);  popw(memw_a16[ss, bp - 0x4]);             /* pop word [bp-0x4] */
            ii(0x1_1306, 2);  popw(gs);                                 /* pop gs */
            ii(0x1_1308, 2);  popw(fs);                                 /* pop fs */
            ii(0x1_130a, 2);  popad();                                  /* popad */
            ii(0x1_130c, 1);  popw(bp);                                 /* pop bp */
            ii(0x1_130d, 1);  retfw(); return;                          /* retf */
        }
    }
}
