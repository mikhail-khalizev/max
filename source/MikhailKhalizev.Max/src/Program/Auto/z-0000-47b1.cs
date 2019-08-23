using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x47b1-e40b9b0e")]
        public void Method_0000_47b1()
        {
            ii(0x47b1, 1);    push(cs);                                 /* push cs */
            ii(0x47b2, 3);    call(0x4370, -0x445);                     /* call 0x4370 */
            ii(0x47b5, 1);    sti();                                    /* sti */
            ii(0x47b6, 1);    ret();                                    /* ret */
        }
    }
}
