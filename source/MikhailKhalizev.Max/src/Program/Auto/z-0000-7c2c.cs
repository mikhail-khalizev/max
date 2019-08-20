using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x7c2c-7f13c8be")]
        public void Method_0000_7c2c()
        {
            ii(0x7c2c, 3);    if(callw_up(0x7c36, 0x7)) return;         /* call 0x7c36 */
            ii(0x7c2f, 2);    if(jzw_func(0x7c70, 0x3f)) return;        /* jz 0x7c70 */
            ii(0x7c31, 3);    callw(0x7c36, 0x2);                       /* call 0x7c36 */
        }
    }
}
