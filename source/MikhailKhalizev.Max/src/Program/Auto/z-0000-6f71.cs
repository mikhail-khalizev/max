using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x6f71-e40b9b0e")]
        public void Method_0000_6f71()
        {
            ii(0x6f71, 1);    pushw(cs);                                /* push cs */
            ii(0x6f72, 3);    callw(0x6b30, -0x445);                    /* call 0x6b30 */
            ii(0x6f75, 1);    sti();                                    /* sti */
            ii(0x6f76, 1);    retw();                                   /* ret */
        }
    }
}
