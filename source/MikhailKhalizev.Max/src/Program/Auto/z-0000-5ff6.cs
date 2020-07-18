using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x5ff6-8abfc9d9")]
        public void Method_0000_5ff6()
        {
            ii(0x5ff6, 3);  call(0x6ac5, 0xacc);                       /* call 0x6ac5 */
            ii(0x5ff9, 4);  call_abs(memw[ds, 0x97a]);                 /* call word [0x97a] */
            ii(0x5ffd, 3);  call(0x6abc, 0xabc);                       /* call 0x6abc */
            ii(0x6000, 1);  ret();                                     /* ret */
        }
    }
}
