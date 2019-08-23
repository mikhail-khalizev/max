using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x17_d612-8cf6a83a")]
        public void Method_0017_d612()
        {
            ii(0x17_d612, 1); push(bp);                                 /* push bp */
            ii(0x17_d613, 2); mov(bp, sp);                              /* mov bp, sp */
            ii(0x17_d615, 3); mov(ax, 0xfc);                            /* mov ax, 0xfc */
            ii(0x17_d618, 1); push(ax);                                 /* push ax */
            ii(0x17_d619, 1); push(cs);                                 /* push cs */
            ii(0x17_d61a, 3); call(0x17_d86f, 0x252);                   /* call 0xd86f */
            ii(0x17_d61d, 5); cmp(memw[ds, 0x1c86], 0);                 /* cmp word [0x1c86], 0x0 */
            ii(0x17_d622, 2); if(jz(0x17_d628, 0x4)) goto l_0x17_d628;  /* jz 0xd628 */
            ii(0x17_d624, 4); call_far_ind(memw[ds, 0x1c84]);           /* call far word [0x1c84] */
        l_0x17_d628:
            ii(0x17_d628, 3); mov(ax, 0xff);                            /* mov ax, 0xff */
            ii(0x17_d62b, 1); push(ax);                                 /* push ax */
            ii(0x17_d62c, 1); push(cs);                                 /* push cs */
            ii(0x17_d62d, 3); call(0x17_d86f, 0x23f);                   /* call 0xd86f */
            ii(0x17_d630, 2); mov(sp, bp);                              /* mov sp, bp */
            ii(0x17_d632, 1); pop(bp);                                  /* pop bp */
            ii(0x17_d633, 1); retf();                                   /* retf */
        }
    }
}
