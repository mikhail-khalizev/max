using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("882a8ce8-57e3-46fe-9684-6880ef24b14b")]
        public void Method_0000_3f1c()
        {
            ii(0x3f1c, 1);    nop();                                    /* nop */
            ii(0x3f1d, 4);    if(jmpw_abs(memw_a16[ds, 0x9bc])) return; /* jmp word [0x9bc] */
        }
    }
}
