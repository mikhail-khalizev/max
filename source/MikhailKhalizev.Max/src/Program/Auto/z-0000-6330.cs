using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x6330-97478")]
        public void Method_0000_6330()
        {
            ii(0x6330, 2);    sub(ax, ax);                              /* sub ax, ax */
            ii(0x6332, 1);    retw();                                   /* ret */
        }
    }
}
