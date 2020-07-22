using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x18_dc8a-144367e")]
        public void Method_0018_dc8a()
        {
            ii(0x18_dc8a, 1);  pop(si);                                /* pop si */
            ii(0x18_dc8b, 2);  xor(ax, ax);                            /* xor ax, ax */
            ii(0x18_dc8d, 1);  ret();                                  /* ret */
        }
    }
}
