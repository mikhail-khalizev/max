using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x8d56-1724da6f")]
        public void Method_0000_8d56()
        {
            ii(0x8d56, 1);    pushw(bp);                                /* push bp */
            ii(0x8d57, 2);    mov(bp, sp);                              /* mov bp, sp */
            ii(0x8d59, 3);    mov(ax, memw_a16[ds, 0x97c]);             /* mov ax, [0x97c] */
            ii(0x8d5c, 3);    cmp(memw_a16[ss, bp + 0x4], ax);          /* cmp [bp+0x4], ax */
            ii(0x8d5f, 2);    if(jaew(0x8d75, 0x14)) goto l_0x8d75;     /* jae 0x8d75 */
            ii(0x8d61, 3);    pushw(memw_a16[ss, bp + 0x6]);            /* push word [bp+0x6] */
            ii(0x8d64, 2);    pushw(-0x1 /* 0xff */);                   /* push 0xffff */
            ii(0x8d66, 2);    pushw(0);                                 /* push 0x0 */
            ii(0x8d68, 3);    pushw(memw_a16[ss, bp + 0x4]);            /* push word [bp+0x4] */
            ii(0x8d6b, 3);    mov(ax, memw_a16[ss, bp + 0x4]);          /* mov ax, [bp+0x4] */
            ii(0x8d6e, 3);    shr(ax, 0x3);                             /* shr ax, 0x3 */
            ii(0x8d71, 1);    pushw(ax);                                /* push ax */
            ii(0x8d72, 3);    callw(0x7a5a, -0x131b);                   /* call 0x7a5a */
        l_0x8d75:
            ii(0x8d75, 1);    leavew();                                 /* leave */
            ii(0x8d76, 1);    retw();                                   /* ret */
        }
    }
}
