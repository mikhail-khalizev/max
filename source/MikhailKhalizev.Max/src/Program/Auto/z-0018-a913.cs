using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x18_a913-46ed721")]
        public void Method_0018_a913()
        {
            ii(0x18_a913, 3); call(0x18_a8f3, -0x23);                   /* call 0xa8f3 */
            ii(0x18_a916, 3); call(0x18_a893, -0x86);                   /* call 0xa893 */
            ii(0x18_a919, 3); mov(ax, memw[ds, bx + 0x14]);             /* mov ax, [bx+0x14] */
            ii(0x18_a91c, 3); mov(memw[ss, bp + 0x14], ax);             /* mov [bp+0x14], ax */
            ii(0x18_a91f, 3); if(jmp_func(0x18_b03d, 0x71b)) return;    /* jmp 0xb03d */
        }
    }
}
