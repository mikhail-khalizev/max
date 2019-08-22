using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x6fd2-5cb3a890")]
        public void Method_0000_6fd2()
        {
            ii(0x6fd2, 1);    pushw(bp);                                /* push bp */
            ii(0x6fd3, 2);    mov(bp, sp);                              /* mov bp, sp */
            ii(0x6fd5, 1);    pushw(si);                                /* push si */
            ii(0x6fd6, 1);    pushw(di);                                /* push di */
            ii(0x6fd7, 3);    callw(0x6040, -0xf9a);                    /* call 0x6040 */
            ii(0x6fda, 2);    pushw(0x60);                              /* push 0x60 */
            ii(0x6fdc, 3);    mov(ax, memw_a16[ss, bp + 0x4]);          /* mov ax, [bp+0x4] */
            ii(0x6fdf, 2);    pushw(0x8);                               /* push 0x8 */
            ii(0x6fe1, 1);    popw(es);                                 /* pop es */
            ii(0x6fe2, 4);    mov(memw_a16[es, 0x62], ax);              /* mov [es:0x62], ax */
            ii(0x6fe6, 3);    mov(ax, memw_a16[ss, bp + 0x6]);          /* mov ax, [bp+0x6] */
            ii(0x6fe9, 4);    mov(memb_a16[es, 0x64], al);              /* mov [es:0x64], al */
            ii(0x6fed, 5);    mov(memb_a16[es, 0x67], ah);              /* mov [es:0x67], ah */
            ii(0x6ff2, 1);    popw(es);                                 /* pop es */
            ii(0x6ff3, 2);    xor(di, di);                              /* xor di, di */
            ii(0x6ff5, 3);    mov(si, memw_a16[ss, bp + 0x8]);          /* mov si, [bp+0x8] */
            ii(0x6ff8, 3);    mov(cx, memw_a16[ss, bp + 0xa]);          /* mov cx, [bp+0xa] */
            ii(0x6ffb, 1);    cld();                                    /* cld */
            ii(0x6ffc, 2);    shr(cx, 0x1);                             /* shr cx, 1 */
            ii(0x6ffe, 2);    rep_a16(() => movsw_a16());               /* rep movsw */
            ii(0x7000, 2);    rcl(cx, 0x1);                             /* rcl cx, 1 */
            ii(0x7002, 2);    rep_a16(() => movsb_a16());               /* rep movsb */
            ii(0x7004, 2);    pushw(0x8);                               /* push 0x8 */
            ii(0x7006, 1);    popw(es);                                 /* pop es */
            ii(0x7007, 5);    mov(memw_a16[es, 0x66], cx);              /* mov [es:0x66], cx */
            ii(0x700c, 3);    callw(0x66d9, -0x936);                    /* call 0x66d9 */
            ii(0x700f, 1);    popw(di);                                 /* pop di */
            ii(0x7010, 1);    popw(si);                                 /* pop si */
            ii(0x7011, 2);    mov(sp, bp);                              /* mov sp, bp */
            ii(0x7013, 1);    popw(bp);                                 /* pop bp */
            ii(0x7014, 1);    sti();                                    /* sti */
            ii(0x7015, 1);    retw(); return;                           /* ret */
        }
    }
}