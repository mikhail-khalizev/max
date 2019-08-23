using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x7c18-61ae718a")]
        public void Method_0000_7c18()
        {
            ii(0x7c18, 3);    if(call_up(0x7c36, 0x1b)) return;         /* call 0x7c36 */
            ii(0x7c1b, 3);    mov(bx, 0xe822);                          /* mov bx, 0xe822 */
            ii(0x7c1e, 1);    push(ss);                                 /* push ss */
            ii(0x7c1f, 2);    add(al, dh);                              /* add al, dh */
            ii(0x7c21, 2);    and(al, 0xe8);                            /* and al, 0xe8 */
            ii(0x7c23, 2);    adc(memw[ds, bx + si], ax);               /* adc [bx+si], ax */
            ii(0x7c25, 2);    if(loop_func(0x7c48, 0x21)) return;       /* loop 0x7c48 */
        }
    }
}
