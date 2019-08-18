using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x7c27-149d2b1c")]
        public void Method_0000_7c27()
        {
            ii(0x7c27, 3);    if(callw_up(0x7c36, 0xc)) return;         /* call 0x7c36 */
            ii(0x7c2a, 2);    mov(bl, 0x3f);                            /* mov bl, 0x3f */
            ii(0x7c2c, 3);    callw(0x7c36, 0x7);                       /* call 0x7c36 */
            ii(0x7c2f, 2);    if(jzw_func(0x7c70, 0x3f)) return;        /* jz 0x7c70 */
        }
    }
}
