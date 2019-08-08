using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("1029111a-85fd-4387-b84e-65fe56cabd51")]
        public void Method_0000_979a()
        {
            ii(0x979a, 1);    pushw(bp);                                /* push bp */
            ii(0x979b, 2);    mov(bp, sp);                              /* mov bp, sp */
            ii(0x979d, 1);    pushw(bx);                                /* push bx */
            ii(0x979e, 3);    mov(bx, memw_a16[ss, bp + 0x4]);          /* mov bx, [bp+0x4] */
            ii(0x97a1, 2);    mov(ax, memw_a16[ds, bx]);                /* mov ax, [bx] */
            ii(0x97a3, 3);    mov(dx, memw_a16[ds, bx + 0x2]);          /* mov dx, [bx+0x2] */
            ii(0x97a6, 3);    mov(cx, memw_a16[ss, bp + 0x6]);          /* mov cx, [bp+0x6] */
            ii(0x97a9, 3);    callw(0x5d94, -0x3a18);                   /* call 0x5d94 */
            ii(0x97ac, 2);    mov(memw_a16[ds, bx], ax);                /* mov [bx], ax */
            ii(0x97ae, 3);    mov(memw_a16[ds, bx + 0x2], dx);          /* mov [bx+0x2], dx */
            ii(0x97b1, 1);    popw(bx);                                 /* pop bx */
            ii(0x97b2, 1);    popw(bp);                                 /* pop bp */
            ii(0x97b3, 3);    retw(0x4); return;                        /* ret 0x4 */
        }
    }
}
