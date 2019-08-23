using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x17_c76a-86a9a1ed")]
        public void Method_0017_c76a()
        {
            ii(0x17_c76a, 4); enterw(0x6, 0);                           /* enter 0x6, 0x0 */
            ii(0x17_c76e, 1); pushw(ds);                                /* push ds */
            ii(0x17_c76f, 3); mov(ax, 0x3e68);                          /* mov ax, 0x3e68 */
            ii(0x17_c772, 2); mov(ds, ax);                              /* mov ds, ax */
            ii(0x17_c774, 3); mov(al, memb_a16[ss, bp + 0x6]);          /* mov al, [bp+0x6] */
            ii(0x17_c777, 3); and(ax, 0xf);                             /* and ax, 0xf */
            ii(0x17_c77a, 3); mov(memw_a16[ss, bp - 0x6], ax);          /* mov [bp-0x6], ax */
            ii(0x17_c77d, 2); mov(cx, ax);                              /* mov cx, ax */
            ii(0x17_c77f, 3); mov(ax, 0x1);                             /* mov ax, 0x1 */
            ii(0x17_c782, 2); shl(ax, cl);                              /* shl ax, cl */
            ii(0x17_c784, 2); not(ax);                                  /* not ax */
            ii(0x17_c786, 3); mov(memw_a16[ss, bp - 0x4], ax);          /* mov [bp-0x4], ax */
            ii(0x17_c789, 3); mov(bx, memw_a16[ss, bp + 0x6]);          /* mov bx, [bp+0x6] */
            ii(0x17_c78c, 3); shr(bx, 0x4);                             /* shr bx, 0x4 */
            ii(0x17_c78f, 3); mov(memw_a16[ss, bp - 0x2], bx);          /* mov [bp-0x2], bx */
            ii(0x17_c792, 2); shl(bx, 0x1);                             /* shl bx, 1 */
            ii(0x17_c794, 4); and(memw_a16[ds, bx + 0xaca], ax);        /* and [bx+0xaca], ax */
            ii(0x17_c798, 1); popw(ds);                                 /* pop ds */
            ii(0x17_c799, 1); leavew();                                 /* leave */
            ii(0x17_c79a, 1); retfw();                                  /* retf */
        }
    }
}
