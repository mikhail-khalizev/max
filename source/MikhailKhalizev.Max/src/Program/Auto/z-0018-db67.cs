using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("6380fce6-c800-4c37-8d21-410b21c7b74c")]
        public void Method_0018_db67()
        {
            ii(0x18_db67, 1); pushw(bp);                                /* push bp */
            ii(0x18_db68, 2); mov(bp, sp);                              /* mov bp, sp */
            ii(0x18_db6a, 5); cmp(memb_a16[ds, 0x2f], 0x3);             /* cmp byte [0x2f], 0x3 */
            ii(0x18_db6f, 2); if(jaew_func(0x18_db2d, -0x44)) return;   /* jae 0xdb2d */
            ii(0x18_db71, 1); pushw(ds);                                /* push ds */
            ii(0x18_db72, 3); callw(0x18_db82, 0xd);                    /* call 0xdb82 */
            ii(0x18_db75, 3); mov(ax, memw_a16[ss, bp + 0xa]);          /* mov ax, [bp+0xa] */
            ii(0x18_db78, 3); mov(dx, memw_a16[ss, bp + 0xc]);          /* mov dx, [bp+0xc] */
            ii(0x18_db7b, 2); mov(memw_a16[ds, bx], ax);                /* mov [bx], ax */
            ii(0x18_db7d, 3); mov(memw_a16[ds, bx + 0x2], dx);          /* mov [bx+0x2], dx */
            ii(0x18_db80, 2); if(jmpw_func(0x18_db64, -0x1e)) return;   /* jmp 0xdb64 */
        }
    }
}
