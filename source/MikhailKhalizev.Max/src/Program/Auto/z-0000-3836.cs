using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("7dbcc415-182a-4bd1-9d5b-caec7f171912")]
        public void Method_0000_3836()
        {
            ii(0x3836, 3);    callw(0x4305, 0xacc);                     /* call 0x4305 */
            ii(0x3839, 4);    callw_abs(memw_a16[ds, 0x97a]);           /* call word [0x97a] */
            ii(0x383d, 3);    callw(0x42fc, 0xabc);                     /* call 0x42fc */
            ii(0x3840, 1);    retw(); return;                           /* ret */
        }
    }
}
