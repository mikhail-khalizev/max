using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("b8b964d6-f83e-4055-87e7-debae0f95fcf")]
        public void Method_0000_4fca()
        {
            ii(0x4fca, 2);    pushw(0x60);                              /* push 0x60 */
            ii(0x4fcc, 3);    mov(ax, memw_a16[ss, bp + 0x4]);          /* mov ax, [bp+0x4] */
            ii(0x4fcf, 2);    pushw(0x8);                               /* push 0x8 */
            ii(0x4fd1, 1);    popw(es);                                 /* pop es */
            ii(0x4fd2, 4);    mov(memw_a16[es, 0x62], ax);              /* mov [es:0x62], ax */
            ii(0x4fd6, 3);    mov(ax, memw_a16[ss, bp + 0x6]);          /* mov ax, [bp+0x6] */
            ii(0x4fd9, 4);    mov(memb_a16[es, 0x64], al);              /* mov [es:0x64], al */
            ii(0x4fdd, 5);    mov(memb_a16[es, 0x67], ah);              /* mov [es:0x67], ah */
            ii(0x4fe2, 1);    popw(es);                                 /* pop es */
            ii(0x4fe3, 2);    xor(di, di);                              /* xor di, di */
            ii(0x4fe5, 3);    mov(si, memw_a16[ss, bp + 0x8]);          /* mov si, [bp+0x8] */
            ii(0x4fe8, 3);    mov(cx, memw_a16[ss, bp + 0xa]);          /* mov cx, [bp+0xa] */
            ii(0x4feb, 1);    cld();                                    /* cld */
            ii(0x4fec, 2);    shr(cx, 0x1);                             /* shr cx, 1 */
            ii(0x4fee, 2);    rep_a16(() => movsw_a16());               /* rep movsw */
            ii(0x4ff0, 2);    rcl(cx, 0x1);                             /* rcl cx, 1 */
            ii(0x4ff2, 2);    rep_a16(() => movsb_a16());               /* rep movsb */
            ii(0x4ff4, 2);    pushw(0x8);                               /* push 0x8 */
            ii(0x4ff6, 1);    popw(es);                                 /* pop es */
            ii(0x4ff7, 5);    mov(memw_a16[es, 0x66], cx);              /* mov [es:0x66], cx */
            ii(0x4ffc, 3);    callw(0x46c9, -0x936);                    /* call 0x46c9 */
            ii(0x4fff, 1);    popw(di);                                 /* pop di */
            ii(0x5000, 1);    popw(si);                                 /* pop si */
            ii(0x5001, 2);    mov(sp, bp);                              /* mov sp, bp */
            ii(0x5003, 1);    popw(bp);                                 /* pop bp */
            ii(0x5004, 1);    sti();                                    /* sti */
            ii(0x5005, 1);    retw(); return;                           /* ret */
        }
    }
}
