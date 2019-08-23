using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x56fd-169195b7")]
        public void Method_0000_56fd()
        {
            ii(0x56fd, 1);    push(bp);                                 /* push bp */
            ii(0x56fe, 2);    mov(bp, sp);                              /* mov bp, sp */
            ii(0x5700, 3);    sub(sp, 0x4);                             /* sub sp, 0x4 */
            ii(0x5703, 2);    jmp(0x571b, 0x16); goto l_0x571b;         /* jmp 0x571b */
        l_0x5705:
            ii(0x5705, 3);    mov(memw[ss, bp - 0x4], bx);              /* mov [bp-0x4], bx */
            ii(0x5708, 3);    inc(memw[ss, bp + 0x6]);                  /* inc word [bp+0x6] */
            ii(0x570b, 2);    mov(al, memb[ds, bx]);                    /* mov al, [bx] */
            ii(0x570d, 3);    mov(bx, memw[ss, bp + 0x4]);              /* mov bx, [bp+0x4] */
            ii(0x5710, 3);    inc(memw[ss, bp + 0x4]);                  /* inc word [bp+0x4] */
            ii(0x5713, 2);    cmp(memb[ds, bx], al);                    /* cmp [bx], al */
            ii(0x5715, 2);    if(jz(0x571b, 0x4)) goto l_0x571b;        /* jz 0x571b */
            ii(0x5717, 2);    sub(ax, ax);                              /* sub ax, ax */
            ii(0x5719, 2);    jmp(0x5726, 0xb); goto l_0x5726;          /* jmp 0x5726 */
        l_0x571b:
            ii(0x571b, 3);    mov(bx, memw[ss, bp + 0x6]);              /* mov bx, [bp+0x6] */
            ii(0x571e, 3);    cmp(memb[ds, bx], 0);                     /* cmp byte [bx], 0x0 */
            ii(0x5721, 2);    if(jnz(0x5705, -0x1e)) goto l_0x5705;     /* jnz 0x5705 */
            ii(0x5723, 3);    mov(ax, 0x1);                             /* mov ax, 0x1 */
        l_0x5726:
            ii(0x5726, 2);    mov(sp, bp);                              /* mov sp, bp */
            ii(0x5728, 1);    pop(bp);                                  /* pop bp */
            ii(0x5729, 1);    ret();                                    /* ret */
        }
    }
}
