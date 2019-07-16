using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("03ca48ef-ab14-425b-b250-0b20888a0ce2")]
        public void Method_0000_93a2()
        {
            ii(0x93a2, 1);    pushw(bp);                                /* push bp */
            ii(0x93a3, 2);    mov(bp, sp);                              /* mov bp, sp */
            ii(0x93a5, 3);    sub(sp, 0x16);                            /* sub sp, 0x16 */
            ii(0x93a8, 4);    mov(memb_a16[ss, bp - 0xd], 0x49);        /* mov byte [bp-0xd], 0x49 */
            ii(0x93ac, 3);    mov(ax, memw_a16[ss, bp + 0x4]);          /* mov ax, [bp+0x4] */
            ii(0x93af, 3);    mov(memw_a16[ss, bp - 0x16], ax);         /* mov [bp-0x16], ax */
            ii(0x93b2, 3);    lea(ax, bp - 0x16);                       /* lea ax, [bp-0x16] */
            ii(0x93b5, 1);    pushw(ax);                                /* push ax */
            ii(0x93b6, 3);    lea(ax, bp - 0xe);                        /* lea ax, [bp-0xe] */
            ii(0x93b9, 1);    pushw(ax);                                /* push ax */
            ii(0x93ba, 1);    pushw(ax);                                /* push ax */
            ii(0x93bb, 3);    callw(0x5d08, -0x36b6);                   /* call 0x5d08 */
            ii(0x93be, 2);    mov(sp, bp);                              /* mov sp, bp */
            ii(0x93c0, 1);    popw(bp);                                 /* pop bp */
            ii(0x93c1, 1);    retw();                                   /* ret */
        }
    }
}
