using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("6b253372-c214-4126-9498-1ed2e3c3761a")]
        public void Method_0000_5c0d()
        {
            ii(0x5c0d, 3);    callw(0x5c26, 0x16);                      /* call 0x5c26 */
            ii(0x5c10, 3);    and(al, 0xe8);                            /* lock and al, 0xe8 */
            ii(0x5c13, 2);    adc(memw_a16[ds, bx + si], ax);           /* adc [bx+si], ax */
            ii(0x5c15, 2);    if(loopw_a16_func(0x5c38, 0x21)) return;  /* loop 0x5c38 */
        }
    }
}
