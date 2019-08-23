using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x5c0d-4c6290c6")]
        public void Method_0000_5c0d()
        {
            ii(0x5c0d, 3);    if(call_up(0x5c26, 0x16)) return;         /* call 0x5c26 */
            ii(0x5c10, 3);    and(al, 0xe8);                            /* lock and al, 0xe8 */
            ii(0x5c13, 2);    adc(memw[ds, bx + si], ax);               /* adc [bx+si], ax */
            ii(0x5c15, 2);    if(loop_func(0x5c38, 0x21)) return;       /* loop 0x5c38 */
            ii(0x5c17, 3);    call(0x5c26, 0xc);                        /* call 0x5c26 */
            ii(0x5c1a, 2);    mov(bl, 0x3f);                            /* mov bl, 0x3f */
            ii(0x5c1c, 3);    call(0x5c26, 0x7);                        /* call 0x5c26 */
            ii(0x5c1f, 2);    if(jz_func(0x5c60, 0x3f)) return;         /* jz 0x5c60 */
            ii(0x5c21, 3);    call(0x5c26, 0x2);                        /* call 0x5c26 */
        }
    }
}
