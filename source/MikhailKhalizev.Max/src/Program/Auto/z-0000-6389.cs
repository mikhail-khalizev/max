using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x6389-97478")]
        public void Method_0000_6389()
        {
            ii(0x6389, 2);    sub(ax, ax);                              /* sub ax, ax */
            ii(0x638b, 1);    ret();                                    /* ret */
        }
    }
}
