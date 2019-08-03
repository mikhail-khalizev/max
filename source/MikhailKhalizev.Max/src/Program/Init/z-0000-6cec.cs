using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("5e93b931-7dbc-452f-b743-54a6ec9c83ad")]
        public void Method_0000_6cec()
        {
            ii(0x6cec, 1);    pushw(bp);                                /* push bp */
            ii(0x6ced, 2);    mov(bp, sp);                              /* mov bp, sp */
            ii(0x6cef, 6);    mov(memw_a16[ds, 0x97a], 0x20a0);         /* mov word [0x97a], 0x20a0 */
            ii(0x6cf5, 6);    mov(memw_a16[ds, 0x97e], 0);              /* mov word [0x97e], 0x0 */
            ii(0x6cfb, 3);    callw(0x6af2, -0x20c);                    /* call 0x6af2 */
            ii(0x6cfe, 3);    callw(0x9426, 0x2725);                    /* call 0x9426 */
            ii(0x6d01, 3);    mov(ax, memw_a16[ds, 0xcec]);             /* mov ax, [0xcec] */
            ii(0x6d04, 3);    mov(memw_a16[ds, 0x11e2], ax);            /* mov [0x11e2], ax */
            ii(0x6d07, 6);    mov(memw_a16[ds, 0x11e0], 0x80);          /* mov word [0x11e0], 0x80 */
            ii(0x6d0d, 3);    callw(0x75bd, 0x8ad);                     /* call 0x75bd */
            ii(0x6d10, 3);    callw(0x6b2b, -0x1e8);                    /* call 0x6b2b */
            ii(0x6d13, 2);    mov(ax, bp);                              /* mov ax, bp */
            ii(0x6d15, 1);    pushw(ax);                                /* push ax */
            ii(0x6d16, 3);    callw(0x6c69, -0xb0);                     /* call 0x6c69 */
            ii(0x6d19, 1);    popw(bx);                                 /* pop bx */
            ii(0x6d1a, 2);    mov(sp, bp);                              /* mov sp, bp */
            ii(0x6d1c, 1);    popw(bp);                                 /* pop bp */
            ii(0x6d1d, 1);    retw(); return;                           /* ret */
        }
    }
}
