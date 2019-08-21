using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x95ca-72b058c2")]
        public void Method_0000_95ca()
        {
            ii(0x95ca, 1);    clc();                                    /* clc */
            ii(0x95cb, 3);    add(ax, 0x13);                            /* add ax, 0x13 */
            ii(0x95ce, 3);    callw(0xe0da, 0x4b09);                    /* call 0xe0da */
            ii(0x95d1, 1);    std();                                    /* std */
            ii(0x95d2, 4);    dec(memw_a16[ss, bp + di - 0x7ab]);       /* dec word [bp+di-0x7ab] */
            ii(0x95d6, 3);    mov(ax, memw_a16[ds, di - 0x4]);          /* mov ax, [di-0x4] */
            ii(0x95d9, 3);    callw(0x5dab, -0x3831);                   /* call 0x5dab */
            ii(0x95dc, 2);    or(memw_a16[ds, bx + si], ax);            /* or [bx+si], ax */
            ii(0x95de, 3);    callw(0xe6a2, 0x50c1);                    /* call 0xe6a2 */
            ii(0x95e1, 1);    std();                                    /* std */
            ii(0x95e2, 2);    pushw(memw_a16[ds, bx + di]);             /* push word [bx+di] */
            ii(0x95e4, 4);    ror(memb_a16[ds, bx + si - 0x743e], cl);  /* ror byte [bx+si-0x743e], cl */
            ii(0x95e8, 1);    inc(bp);                                  /* inc bp */
            ii(0x95e9, 1);    cld();                                    /* cld */
            ii(0x95ea, 3);    callw(0x5f3b, -0x36b2);                   /* call 0x5f3b */
        }
    }
}
