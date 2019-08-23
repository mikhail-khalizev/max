using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x66dc-2d8ed507")]
        public void Method_0000_66dc()
        {
            ii(0x66dc, 1);    wait();                                   /* wait */
            ii(0x66dd, 4);    jmp_abs(memw[ds, 0x9bc]);                 /* jmp word [0x9bc] */
        }
    }
}
