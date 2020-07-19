using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x18_f39c-b9e1a319")]
        public void Method_0018_f39c()
        {
            ii(0x18_f39c, 3);  mov(al, memb[ds, 0x1582]);              /* mov al, [0x1582] */
            ii(0x18_f39f, 2);  and(al, 1);                             /* and al, 0x1 */
            ii(0x18_f3a1, 1);  cbw();                                  /* cbw */
            ii(0x18_f3a2, 1);  ret();                                  /* ret */
        }
    }
}
