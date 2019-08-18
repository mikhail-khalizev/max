using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("6406aab6-9926-42a8-9507-e5c343e57692")]
        public void Method_0000_687b()
        {
            ii(0x687b, 5);    mov(dx, memw_a16[cs, 0x2ad9]);            /* mov dx, [cs:0x2ad9] */
            ii(0x6880, 2);    or(dx, dx);                               /* or dx, dx */
            ii(0x6882, 2);    if(jzw(0x6888, 0x4)) goto l_0x6888;       /* jz 0x6888 */
            ii(0x6884, 2);    mov(ah, 0x45);                            /* mov ah, 0x45 */
            ii(0x6886, 2);    @int(0x67);                               /* int 0x67 */
        l_0x6888:
            ii(0x6888, 1);    retw(); return;                           /* ret */
        }
    }
}
