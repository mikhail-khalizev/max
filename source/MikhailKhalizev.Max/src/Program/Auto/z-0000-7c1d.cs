using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x7c1d-4c6290c6")]
        public void Method_0000_7c1d()
        {
            ii(0x7c1d, 3);    callw(0x7c36, 0x16);                      /* call 0x7c36 */
            ii(0x7c20, 3);    and(al, 0xe8);                            /* lock and al, 0xe8 */
            ii(0x7c23, 2);    adc(memw_a16[ds, bx + si], ax);           /* adc [bx+si], ax */
            ii(0x7c25, 2);    if(loopw_a16_func(0x7c48, 0x21)) return;  /* loop 0x7c48 */
            ii(0x7c27, 3);    callw(0x7c36, 0xc);                       /* call 0x7c36 */
            ii(0x7c2a, 2);    mov(bl, 0x3f);                            /* mov bl, 0x3f */
            ii(0x7c2c, 3);    callw(0x7c36, 0x7);                       /* call 0x7c36 */
            ii(0x7c2f, 2);    if(jzw_func(0x7c70, 0x3f)) return;        /* jz 0x7c70 */
            ii(0x7c31, 3);    callw(0x7c36, 0x2);                       /* call 0x7c36 */
        }
    }
}
