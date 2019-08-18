using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("8641c76a-62a5-43aa-b69f-5e83d455398a")]
        public void Method_0000_3fe6()
        {
            ii(0x3fe6, 3);    callw(0x4ab5, 0xacc);                     /* call 0x4ab5 */
            ii(0x3fe9, 4);    callw_abs(memw_a16[ds, 0x97a]);           /* call word [0x97a] */
            ii(0x3fed, 3);    callw(0x4aac, 0xabc);                     /* call 0x4aac */
            ii(0x3ff0, 1);    retw(); return;                           /* ret */
        }
    }
}
