using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1_1303-ccf6799c")]
        public void Method_0001_1303()
        {
            ii(0x1_1303, 3);  pop(memw[ss, bp - 4]);                   /* pop word [bp-0x4] */
            ii(0x1_1306, 2);  pop(gs);                                 /* pop gs */
            ii(0x1_1308, 2);  pop(fs);                                 /* pop fs */
            ii(0x1_130a, 2);  popad();                                 /* popad */
            ii(0x1_130c, 1);  pop(bp);                                 /* pop bp */
            ii(0x1_130d, 1);  retf();                                  /* retf */
        }
    }
}
