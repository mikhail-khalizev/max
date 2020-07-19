using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1_3313-ccf6799c")]
        public void Method_0001_3313()
        {
            ii(0x1_3313, 3);  pop(memw[ss, bp - 4]);                   /* pop word [bp-0x4] */
            ii(0x1_3316, 2);  pop(gs);                                 /* pop gs */
            ii(0x1_3318, 2);  pop(fs);                                 /* pop fs */
            ii(0x1_331a, 2);  popad();                                 /* popad */
            ii(0x1_331c, 1);  pop(bp);                                 /* pop bp */
            ii(0x1_331d, 1);  retf();                                  /* retf */
        }
    }
}
