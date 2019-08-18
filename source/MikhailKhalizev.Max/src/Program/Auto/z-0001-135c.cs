using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("a628dfe5-4994-4aeb-9b43-3a62b233fc61")]
        public void Method_0001_135c()
        {
            ii(0x1_135c, 3);  mov(al, memb_a16[ds, 0x1582]);            /* mov al, [0x1582] */
            ii(0x1_135f, 2);  and(al, 0x1);                             /* and al, 0x1 */
            ii(0x1_1361, 1);  cbw();                                    /* cbw */
            ii(0x1_1362, 1);  retw(); return;                           /* ret */
        }
    }
}
