using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1_1c5a-144367e")]
        public void Method_0001_1c5a()
        {
            ii(0x1_1c5a, 1);  pop(si);                                 /* pop si */
            ii(0x1_1c5b, 2);  xor(ax, ax);                             /* xor ax, ax */
            ii(0x1_1c5d, 1);  ret();                                   /* ret */
        }
    }
}
