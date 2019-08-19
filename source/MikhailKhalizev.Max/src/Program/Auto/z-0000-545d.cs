using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x545d-4c6290c6")]
        public void Method_0000_545d()
        {
            ii(0x545d, 3);    callw(0x5476, 0x16);                      /* call 0x5476 */
            ii(0x5460, 3);    and(al, 0xe8);                            /* lock and al, 0xe8 */
            ii(0x5463, 2);    adc(memw_a16[ds, bx + si], ax);           /* adc [bx+si], ax */
            ii(0x5465, 2);    if(loopw_a16_func(0x5488, 0x21)) return;  /* loop 0x5488 */
            ii(0x5467, 3);    callw(0x5476, 0xc);                       /* call 0x5476 */
            ii(0x546a, 2);    mov(bl, 0x3f);                            /* mov bl, 0x3f */
            ii(0x546c, 3);    callw(0x5476, 0x7);                       /* call 0x5476 */
            ii(0x546f, 2);    if(jzw_func(0x54b0, 0x3f)) return;        /* jz 0x54b0 */
            ii(0x5471, 3);    callw(0x5476, 0x2);                       /* call 0x5476 */
        }
    }
}
