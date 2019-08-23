using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x6f9d-a44991aa")]
        public void Method_0000_6f9d()
        {
            ii(0x6f9d, 1);    push(bp);                                 /* push bp */
            ii(0x6f9e, 2);    mov(bp, sp);                              /* mov bp, sp */
            ii(0x6fa0, 1);    push(si);                                 /* push si */
            ii(0x6fa1, 1);    push(di);                                 /* push di */
            ii(0x6fa2, 3);    call(0x6040, -0xf65);                     /* call 0x6040 */
            ii(0x6fa5, 2);    push(0x8);                                /* push 0x8 */
            ii(0x6fa7, 1);    pop(ds);                                  /* pop ds */
            ii(0x6fa8, 3);    mov(ax, memw[ss, bp + 0x4]);              /* mov ax, [bp+0x4] */
            ii(0x6fab, 3);    mov(memw[ds, 0x62], ax);                  /* mov [0x62], ax */
            ii(0x6fae, 3);    mov(ax, memw[ss, bp + 0x6]);              /* mov ax, [bp+0x6] */
            ii(0x6fb1, 3);    mov(memb[ds, 0x64], al);                  /* mov [0x64], al */
            ii(0x6fb4, 4);    mov(memb[ds, 0x67], ah);                  /* mov [0x67], ah */
            ii(0x6fb8, 3);    mov(cx, memw[ss, bp + 0xa]);              /* mov cx, [bp+0xa] */
            ii(0x6fbb, 2);    push(0x60);                               /* push 0x60 */
            ii(0x6fbd, 1);    pop(ds);                                  /* pop ds */
            ii(0x6fbe, 2);    xor(si, si);                              /* xor si, si */
            ii(0x6fc0, 3);    mov(di, memw[ss, bp + 0x8]);              /* mov di, [bp+0x8] */
            ii(0x6fc3, 1);    cld();                                    /* cld */
            ii(0x6fc4, 2);    rep(() => movsb());                       /* rep movsb */
            ii(0x6fc6, 1);    push(ss);                                 /* push ss */
            ii(0x6fc7, 1);    pop(ds);                                  /* pop ds */
            ii(0x6fc8, 3);    call(0x66d9, -0x8f2);                     /* call 0x66d9 */
            ii(0x6fcb, 1);    pop(di);                                  /* pop di */
            ii(0x6fcc, 1);    pop(si);                                  /* pop si */
            ii(0x6fcd, 2);    mov(sp, bp);                              /* mov sp, bp */
            ii(0x6fcf, 1);    pop(bp);                                  /* pop bp */
            ii(0x6fd0, 1);    sti();                                    /* sti */
            ii(0x6fd1, 1);    ret();                                    /* ret */
        }
    }
}
