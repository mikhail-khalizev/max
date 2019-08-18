using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("678e2021-8c00-4d3a-9571-9fcb3bae9b02")]
        public void Method_0000_7c1d()
        {
            ii(0x7c1d, 3);    callw(0x7c36, 0x16);                      /* call 0x7c36 */
            ii(0x7c20, 3);    and(al, 0xe8);                            /* lock and al, 0xe8 */
            ii(0x7c23, 2);    adc(memw_a16[ds, bx + si], ax);           /* adc [bx+si], ax */
            ii(0x7c25, 2);    if(loopw_a16_func(0x7c48, 0x21)) return;  /* loop 0x7c48 */
        }
    }
}
