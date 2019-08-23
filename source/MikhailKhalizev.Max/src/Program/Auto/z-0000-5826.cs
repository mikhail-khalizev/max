using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x5826-b3d8282f")]
        public void Method_0000_5826()
        {
            ii(0x5826, 4);    enterw(0x18, 0);                          /* enter 0x18, 0x0 */
            ii(0x582a, 4);    cmp(memw_a16[ss, bp + 0x4], 0);           /* cmp word [bp+0x4], 0x0 */
            ii(0x582e, 2);    if(jnzw(0x5835, 0x5)) goto l_0x5835;      /* jnz 0x5835 */
            ii(0x5830, 3);    mov(ax, 0x1);                             /* mov ax, 0x1 */
            ii(0x5833, 1);    leavew();                                 /* leave */
            ii(0x5834, 1);    retw(); return;                           /* ret */
        l_0x5835:
            ii(0x5835, 3);    mov(ax, memw_a16[ss, bp + 0x4]);          /* mov ax, [bp+0x4] */
            ii(0x5838, 3);    mov(memw_a16[ss, bp - 0x10], ax);         /* mov [bp-0x10], ax */
            ii(0x583b, 3);    mov(memw_a16[ss, bp - 0x16], ax);         /* mov [bp-0x16], ax */
            ii(0x583e, 4);    mov(memb_a16[ss, bp - 0xd], 0x49);        /* mov byte [bp-0xd], 0x49 */
            ii(0x5842, 3);    lea(ax, bp - 0x16);                       /* lea ax, [bp-0x16] */
            ii(0x5845, 1);    pushw(ax);                                /* push ax */
            ii(0x5846, 3);    lea(ax, bp - 0xe);                        /* lea ax, [bp-0xe] */
            ii(0x5849, 1);    pushw(ax);                                /* push ax */
            ii(0x584a, 1);    pushw(ax);                                /* push ax */
            ii(0x584b, 3);    callw(0x64b8, 0xc6a);                     /* call 0x64b8 */
            ii(0x584e, 3);    mov(ax, memw_a16[ss, bp - 0x2]);          /* mov ax, [bp-0x2] */
            ii(0x5851, 2);    not(ax);                                  /* not ax */
            ii(0x5853, 3);    and(ax, 0x1);                             /* and ax, 0x1 */
            ii(0x5856, 1);    leavew();                                 /* leave */
            ii(0x5857, 1);    retw();                                   /* ret */
        }
    }
}
