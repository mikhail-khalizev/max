using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x93a2-44762ffe")]
        public void Method_0000_93a2()
        {
            ii(0x93a2, 1);    push(bp);                                 /* push bp */
            ii(0x93a3, 2);    mov(bp, sp);                              /* mov bp, sp */
            ii(0x93a5, 3);    sub(sp, 0x16);                            /* sub sp, 0x16 */
            ii(0x93a8, 4);    mov(memb[ss, bp - 0xd], 0x49);            /* mov byte [bp-0xd], 0x49 */
            ii(0x93ac, 3);    mov(ax, memw[ss, bp + 0x4]);              /* mov ax, [bp+0x4] */
            ii(0x93af, 3);    mov(memw[ss, bp - 0x16], ax);             /* mov [bp-0x16], ax */
            ii(0x93b2, 3);    lea(ax, bp - 0x16);                       /* lea ax, [bp-0x16] */
            ii(0x93b5, 1);    push(ax);                                 /* push ax */
            ii(0x93b6, 3);    lea(ax, bp - 0xe);                        /* lea ax, [bp-0xe] */
            ii(0x93b9, 1);    push(ax);                                 /* push ax */
            ii(0x93ba, 1);    push(ax);                                 /* push ax */
            ii(0x93bb, 3);    call(0x5d08, -0x36b6);                    /* call 0x5d08 */
            ii(0x93be, 2);    mov(sp, bp);                              /* mov sp, bp */
            ii(0x93c0, 1);    pop(bp);                                  /* pop bp */
            ii(0x93c1, 1);    ret();                                    /* ret */
        }
    }
}
