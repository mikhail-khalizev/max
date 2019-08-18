using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("7a15f0ce-7ac4-40bd-b4f4-22fb8ea27899")]
        public void Method_0000_5c08()
        {
            ii(0x5c08, 3);    if(callw_up(0x5c26, 0x1b)) return;        /* call 0x5c26 */
            ii(0x5c0b, 3);    mov(bx, 0xe822);                          /* mov bx, 0xe822 */
            ii(0x5c0e, 1);    pushw(ss);                                /* push ss */
            ii(0x5c0f, 2);    add(al, dh);                              /* add al, dh */
            ii(0x5c11, 2);    and(al, 0xe8);                            /* and al, 0xe8 */
            ii(0x5c13, 2);    adc(memw_a16[ds, bx + si], ax);           /* adc [bx+si], ax */
            ii(0x5c15, 2);    if(loopw_a16_func(0x5c38, 0x21)) return;  /* loop 0x5c38 */
        }
    }
}
