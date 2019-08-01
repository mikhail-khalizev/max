using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("46f2e389-faed-4f4e-8d4e-926c31629ea8")]
        public void Method_0000_5ff6()
        {
            ii(0x5ff6, 3);    callw(0x6ac5, 0xacc);                     /* call 0x6ac5 */
            ii(0x5ff9, 4);    callw_abs(memw_a16[ds, 0x97a]);           /* call word [0x97a] */
        }
    }
}
