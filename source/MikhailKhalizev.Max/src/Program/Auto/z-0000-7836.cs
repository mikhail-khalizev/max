using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x7836-b3d8282f")]
        public void Method_0000_7836()
        {
            ii(0x7836, 4);    enter(0x18, 0);                           /* enter 0x18, 0x0 */
            ii(0x783a, 4);    cmp(memw[ss, bp + 0x4], 0);               /* cmp word [bp+0x4], 0x0 */
            ii(0x783e, 2);    if(jnz(0x7845, 0x5)) goto l_0x7845;       /* jnz 0x7845 */
            ii(0x7840, 3);    mov(ax, 0x1);                             /* mov ax, 0x1 */
            ii(0x7843, 1);    leave();                                  /* leave */
            ii(0x7844, 1);    ret(); return;                            /* ret */
        l_0x7845:
            ii(0x7845, 3);    mov(ax, memw[ss, bp + 0x4]);              /* mov ax, [bp+0x4] */
            ii(0x7848, 3);    mov(memw[ss, bp - 0x10], ax);             /* mov [bp-0x10], ax */
            ii(0x784b, 3);    mov(memw[ss, bp - 0x16], ax);             /* mov [bp-0x16], ax */
            ii(0x784e, 4);    mov(memb[ss, bp - 0xd], 0x49);            /* mov byte [bp-0xd], 0x49 */
            ii(0x7852, 3);    lea(ax, bp - 0x16);                       /* lea ax, [bp-0x16] */
            ii(0x7855, 1);    push(ax);                                 /* push ax */
            ii(0x7856, 3);    lea(ax, bp - 0xe);                        /* lea ax, [bp-0xe] */
            ii(0x7859, 1);    push(ax);                                 /* push ax */
            ii(0x785a, 1);    push(ax);                                 /* push ax */
            ii(0x785b, 3);    call(0x84c8, 0xc6a);                      /* call 0x84c8 */
            ii(0x785e, 3);    mov(ax, memw[ss, bp - 0x2]);              /* mov ax, [bp-0x2] */
            ii(0x7861, 2);    not(ax);                                  /* not ax */
            ii(0x7863, 3);    and(ax, 0x1);                             /* and ax, 0x1 */
            ii(0x7866, 1);    leave();                                  /* leave */
            ii(0x7867, 1);    ret();                                    /* ret */
        }
    }
}
