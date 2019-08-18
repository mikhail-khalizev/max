using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1_336c-b9e1a319")]
        public void Method_0001_336c()
        {
            ii(0x1_336c, 3);  mov(al, memb_a16[ds, 0x1582]);            /* mov al, [0x1582] */
            ii(0x1_336f, 2);  and(al, 0x1);                             /* and al, 0x1 */
            ii(0x1_3371, 1);  cbw();                                    /* cbw */
            ii(0x1_3372, 1);  retw(); return;                           /* ret */
        }
    }
}
