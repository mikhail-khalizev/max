using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x18_db67-3dbc1da9")]
        public void Method_0018_db67()
        {
            ii(0x18_db67, 1); push(bp);                                 /* push bp */
            ii(0x18_db68, 2); mov(bp, sp);                              /* mov bp, sp */
            ii(0x18_db6a, 5); cmp(memb[ds, 0x2f], 0x3);                 /* cmp byte [0x2f], 0x3 */
            ii(0x18_db6f, 2); if(jae_func(0x18_db2d, -0x44)) return;    /* jae 0xdb2d */
            ii(0x18_db71, 1); push(ds);                                 /* push ds */
            ii(0x18_db72, 3); call(0x18_db82, 0xd);                     /* call 0xdb82 */
            ii(0x18_db75, 3); mov(ax, memw[ss, bp + 0xa]);              /* mov ax, [bp+0xa] */
            ii(0x18_db78, 3); mov(dx, memw[ss, bp + 0xc]);              /* mov dx, [bp+0xc] */
            ii(0x18_db7b, 2); mov(memw[ds, bx], ax);                    /* mov [bx], ax */
            ii(0x18_db7d, 3); mov(memw[ds, bx + 0x2], dx);              /* mov [bx+0x2], dx */
            ii(0x18_db80, 2); if(jmp_func(0x18_db64, -0x1e)) return;    /* jmp 0xdb64 */
        }
    }
}
