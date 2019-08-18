using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("e79619f6-b358-4363-aa2e-15e8bdb8558e")]
        public void Method_0018_a6aa()
        {
            ii(0x18_a6aa, 3); mov(memw_a16[ss, bp + 0x12], cs);         /* mov [bp+0x12], cs */
            ii(0x18_a6ad, 3); mov(memw_a16[ss, bp + 0x14], cs);         /* mov [bp+0x14], cs */
            ii(0x18_a6b0, 3); mov(memw_a16[ss, bp + 0xa], cs);          /* mov [bp+0xa], cs */
            ii(0x18_a6b3, 5); mov(memw_a16[ss, bp + 0x10], 0xc09);      /* mov word [bp+0x10], 0xc09 */
            ii(0x18_a6b8, 3); mov(ax, 0xc04);                           /* mov ax, 0xc04 */
            ii(0x18_a6bb, 5); mov(memw_a16[ss, bp + 0x8], 0xbff);       /* mov word [bp+0x8], 0xbff */
            ii(0x18_a6c0, 1); retw(); return;                           /* ret */
        }
    }
}
