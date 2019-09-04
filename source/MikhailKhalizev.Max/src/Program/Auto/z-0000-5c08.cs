using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x5c08-61ae718a")]
        public void Method_0000_5c08()
        {
            ii(0x5c08, 3);  if(call_up(0x5c26, 0x1b)) return;          /* call 0x5c26 */
            ii(0x5c0b, 3);  mov(bx, 0xe822);                           /* mov bx, 0xe822 */
            ii(0x5c0e, 1);  push(ss);                                  /* push ss */
            ii(0x5c0f, 2);  add(al, dh);                               /* add al, dh */
            ii(0x5c11, 2);  and(al, 0xe8);                             /* and al, 0xe8 */
            ii(0x5c13, 2);  adc(memw[ds, bx + si], ax);                /* adc [bx+si], ax */
            ii(0x5c15, 2);  if(loop_func(0x5c38, 0x21)) return;        /* loop 0x5c38 */
        }
    }
}
