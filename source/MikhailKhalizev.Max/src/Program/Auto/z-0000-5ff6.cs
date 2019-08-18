using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("4c4d76bf-3006-43ca-b63c-e0d5067ef3f0")]
        public void Method_0000_5ff6()
        {
            ii(0x5ff6, 3);    callw(0x6ac5, 0xacc);                     /* call 0x6ac5 */
            ii(0x5ff9, 4);    callw_abs(memw_a16[ds, 0x97a]);           /* call word [0x97a] */
            ii(0x5ffd, 3);    callw(0x6abc, 0xabc);                     /* call 0x6abc */
            ii(0x6000, 1);    retw(); return;                           /* ret */
        }
    }
}
