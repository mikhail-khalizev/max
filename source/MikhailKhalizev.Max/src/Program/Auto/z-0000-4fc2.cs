using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x4fc2-5cb3a890")]
        public void Method_0000_4fc2()
        {
            ii(0x4fc2, 1);    push(bp);                                 /* push bp */
            ii(0x4fc3, 2);    mov(bp, sp);                              /* mov bp, sp */
            ii(0x4fc5, 1);    push(si);                                 /* push si */
            ii(0x4fc6, 1);    push(di);                                 /* push di */
            ii(0x4fc7, 3);    call(0x4030, -0xf9a);                     /* call 0x4030 */
            ii(0x4fca, 2);    push(0x60);                               /* push 0x60 */
            ii(0x4fcc, 3);    mov(ax, memw[ss, bp + 4]);                /* mov ax, [bp+0x4] */
            ii(0x4fcf, 2);    push(8);                                  /* push 0x8 */
            ii(0x4fd1, 1);    pop(es);                                  /* pop es */
            ii(0x4fd2, 4);    mov(memw[es, 0x62], ax);                  /* mov [es:0x62], ax */
            ii(0x4fd6, 3);    mov(ax, memw[ss, bp + 6]);                /* mov ax, [bp+0x6] */
            ii(0x4fd9, 4);    mov(memb[es, 0x64], al);                  /* mov [es:0x64], al */
            ii(0x4fdd, 5);    mov(memb[es, 0x67], ah);                  /* mov [es:0x67], ah */
            ii(0x4fe2, 1);    pop(es);                                  /* pop es */
            ii(0x4fe3, 2);    xor(di, di);                              /* xor di, di */
            ii(0x4fe5, 3);    mov(si, memw[ss, bp + 8]);                /* mov si, [bp+0x8] */
            ii(0x4fe8, 3);    mov(cx, memw[ss, bp + 10]);               /* mov cx, [bp+0xa] */
            ii(0x4feb, 1);    cld();                                    /* cld */
            ii(0x4fec, 2);    shr(cx, 1);                               /* shr cx, 1 */
            ii(0x4fee, 2);    rep(() => movsw());                       /* rep movsw */
            ii(0x4ff0, 2);    rcl(cx, 1);                               /* rcl cx, 1 */
            ii(0x4ff2, 2);    rep(() => movsb());                       /* rep movsb */
            ii(0x4ff4, 2);    push(8);                                  /* push 0x8 */
            ii(0x4ff6, 1);    pop(es);                                  /* pop es */
            ii(0x4ff7, 5);    mov(memw[es, 0x66], cx);                  /* mov [es:0x66], cx */
            ii(0x4ffc, 3);    call(0x46c9, -0x936);                     /* call 0x46c9 */
            ii(0x4fff, 1);    pop(di);                                  /* pop di */
            ii(0x5000, 1);    pop(si);                                  /* pop si */
            ii(0x5001, 2);    mov(sp, bp);                              /* mov sp, bp */
            ii(0x5003, 1);    pop(bp);                                  /* pop bp */
            ii(0x5004, 1);    sti();                                    /* sti */
            ii(0x5005, 1);    ret();                                    /* ret */
        }
    }
}
