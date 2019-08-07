using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("020e229f-2fa5-483f-82c7-20e8fe73e08f")]
        public void Method_0014_a913()
        {
            ii(0x14_a913, 3); callw(0x14_a8f3, -0x23);                  /* call 0xa8f3 */
            ii(0x14_a916, 3); callw(0x14_a893, -0x86);                  /* call 0xa893 */
            ii(0x14_a919, 3); mov(ax, memw_a16[ds, bx + 0x14]);         /* mov ax, [bx+0x14] */
            ii(0x14_a91c, 3); mov(memw_a16[ss, bp + 0x14], ax);         /* mov [bp+0x14], ax */
            ii(0x14_a91f, 3); jmpw_func(0x14_b03d, 0x71b); return;      /* jmp 0xb03d */
        }
    }
}
