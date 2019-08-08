using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("23b467f9-475a-4521-a016-f07a4fa26f2e")]
        public void Method_0013_d612()
        {
            ii(0x13_d612, 1); pushw(bp);                                /* push bp */
            ii(0x13_d613, 2); mov(bp, sp);                              /* mov bp, sp */
            ii(0x13_d615, 3); mov(ax, 0xfc);                            /* mov ax, 0xfc */
            ii(0x13_d618, 1); pushw(ax);                                /* push ax */
            ii(0x13_d619, 1); pushw(cs);                                /* push cs */
            ii(0x13_d61a, 3); callw(0x13_d86f, 0x252);                  /* call 0xd86f */
            ii(0x13_d61d, 5); cmp(memw_a16[ds, 0x1c86], 0);             /* cmp word [0x1c86], 0x0 */
            ii(0x13_d622, 2); if(jzw(0x13_d628, 0x4)) goto l_0x13_d628; /* jz 0xd628 */
            ii(0x13_d624, 4); callw_a16_far_ind(ds, 0x1c84);            /* call far word [0x1c84] */
        l_0x13_d628:
            ii(0x13_d628, 3); mov(ax, 0xff);                            /* mov ax, 0xff */
            ii(0x13_d62b, 1); pushw(ax);                                /* push ax */
            ii(0x13_d62c, 1); pushw(cs);                                /* push cs */
            ii(0x13_d62d, 3); callw(0x13_d86f, 0x23f);                  /* call 0xd86f */
            ii(0x13_d630, 2); mov(sp, bp);                              /* mov sp, bp */
            ii(0x13_d632, 1); popw(bp);                                 /* pop bp */
            ii(0x13_d633, 1); retfw(); return;                          /* retf */
        }
    }
}
