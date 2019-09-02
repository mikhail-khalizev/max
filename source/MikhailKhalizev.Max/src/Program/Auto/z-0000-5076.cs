using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x5076-b3d8282f")]
        public void Method_0000_5076()
        {
            ii(0x5076, 4);    enter(0x18, 0);                           /* enter 0x18, 0x0 */
            ii(0x507a, 4);    cmp(memw[ss, bp + 4], 0);                 /* cmp word [bp+0x4], 0x0 */
            ii(0x507e, 2);    if(jnz(0x5085, 5)) goto l_0x5085;         /* jnz 0x5085 */
            ii(0x5080, 3);    mov(ax, 1);                               /* mov ax, 0x1 */
            ii(0x5083, 1);    leave();                                  /* leave */
            ii(0x5084, 1);    ret(); return;                            /* ret */
        l_0x5085:
            ii(0x5085, 3);    mov(ax, memw[ss, bp + 4]);                /* mov ax, [bp+0x4] */
            ii(0x5088, 3);    mov(memw[ss, bp - 16], ax);               /* mov [bp-0x10], ax */
            ii(0x508b, 3);    mov(memw[ss, bp - 22], ax);               /* mov [bp-0x16], ax */
            ii(0x508e, 4);    mov(memb[ss, bp - 13], 0x49);             /* mov byte [bp-0xd], 0x49 */
            ii(0x5092, 3);    lea(ax, memw[ss, bp - 22]);               /* lea ax, [bp-0x16] */
            ii(0x5095, 1);    push(ax);                                 /* push ax */
            ii(0x5096, 3);    lea(ax, memw[ss, bp - 14]);               /* lea ax, [bp-0xe] */
            ii(0x5099, 1);    push(ax);                                 /* push ax */
            ii(0x509a, 1);    push(ax);                                 /* push ax */
            ii(0x509b, 3);    call(0x5d08, 0xc6a);                      /* call 0x5d08 */
            ii(0x509e, 3);    mov(ax, memw[ss, bp - 2]);                /* mov ax, [bp-0x2] */
            ii(0x50a1, 2);    not(ax);                                  /* not ax */
            ii(0x50a3, 3);    and(ax, 1);                               /* and ax, 0x1 */
            ii(0x50a6, 1);    leave();                                  /* leave */
            ii(0x50a7, 1);    ret();                                    /* ret */
        }
    }
}
