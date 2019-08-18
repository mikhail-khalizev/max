using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("ea25dd9d-c2c1-43e7-87df-f2e64e318656")]
        public void Method_0000_60cb()
        {
            ii(0x60cb, 5);    mov(dx, memw_a16[cs, 0x2ad9]);            /* mov dx, [cs:0x2ad9] */
            ii(0x60d0, 2);    or(dx, dx);                               /* or dx, dx */
            ii(0x60d2, 2);    if(jzw(0x60d8, 0x4)) goto l_0x60d8;       /* jz 0x60d8 */
            ii(0x60d4, 2);    mov(ah, 0x45);                            /* mov ah, 0x45 */
            ii(0x60d6, 2);    @int(0x67);                               /* int 0x67 */
        l_0x60d8:
            ii(0x60d8, 1);    retw(); return;                           /* ret */
        }
    }
}
