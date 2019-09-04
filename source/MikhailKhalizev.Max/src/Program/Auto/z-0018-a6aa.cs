using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x18_a6aa-e96c95a4")]
        public void Method_0018_a6aa()
        {
            ii(0x18_a6aa, 3); mov(memw[ss, bp + 18], cs);               /* mov [bp+0x12], cs */
            ii(0x18_a6ad, 3); mov(memw[ss, bp + 20], cs);               /* mov [bp+0x14], cs */
            ii(0x18_a6b0, 3); mov(memw[ss, bp + 10], cs);               /* mov [bp+0xa], cs */
            ii(0x18_a6b3, 5); mov(memw[ss, bp + 16], 0xc09);            /* mov word [bp+0x10], 0xc09 */
            ii(0x18_a6b8, 3); mov(ax, 0xc04);                           /* mov ax, 0xc04 */
            ii(0x18_a6bb, 5); mov(memw[ss, bp + 8], 0xbff);             /* mov word [bp+0x8], 0xbff */
            ii(0x18_a6c0, 1); ret();                                    /* ret */
        }
    }
}
