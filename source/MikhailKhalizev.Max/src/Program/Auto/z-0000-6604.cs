using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("a3c3674f-8148-4630-b559-f73fe05bf40e")]
        public void Method_0000_6604()
        {
            ii(0x6604, 1);    pushw(ax);                                /* push ax */
            ii(0x6605, 1);    pushw(bx);                                /* push bx */
            ii(0x6606, 4);    mov(bx, memw_a16[ds, 0x9b4]);             /* mov bx, [0x9b4] */
            ii(0x660a, 1);    cli();                                    /* cli */
        }
    }
}
