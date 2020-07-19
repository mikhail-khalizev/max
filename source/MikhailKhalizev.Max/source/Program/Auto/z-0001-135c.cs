using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1_135c-b9e1a319")]
        public void Method_0001_135c()
        {
            ii(0x1_135c, 3);  mov(al, memb[ds, 0x1582]);               /* mov al, [0x1582] */
            ii(0x1_135f, 2);  and(al, 1);                              /* and al, 0x1 */
            ii(0x1_1361, 1);  cbw();                                   /* cbw */
            ii(0x1_1362, 1);  ret();                                   /* ret */
        }
    }
}
