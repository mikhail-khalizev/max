using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x7c70-2b40e281")]
        public void Method_0000_7c70()
        {
            ii(0x7c70, 1);    push(ds);                                 /* push ds */
            ii(0x7c71, 2);    adc(memb[ss, bp + si], cl);               /* adc [bp+si], cl */
            ii(0x7c73, 2);    mov(dx, cs);                              /* mov dx, cs */
            ii(0x7c75, 2);    sub(bx, dx);                              /* sub bx, dx */
            ii(0x7c77, 2);    sub(bx, ax);                              /* sub bx, ax */
            ii(0x7c79, 2);    add(ax, dx);                              /* add ax, dx */
            ii(0x7c7b, 1);    cld();                                    /* cld */
            ii(0x7c7c, 4);    xchg(memw[ds, 0xa10], ax);                /* xchg [0xa10], ax */
            ii(0x7c80, 2);    xor(si, si);                              /* xor si, si */
            ii(0x7c82, 2);    mov(ds, ax);                              /* mov ds, ax */
            ii(0x7c84, 2);    mov(es, dx);                              /* mov es, dx */
            ii(0x7c86, 2);    rep(() => movsw());                       /* rep movsw */
            ii(0x7c88, 1);    push(ss);                                 /* push ss */
            ii(0x7c89, 1);    pop(ds);                                  /* pop ds */
            ii(0x7c8a, 1);    push(bx);                                 /* push bx */
            ii(0x7c8b, 3);    call(0x7cde, 0x50);                       /* call 0x7cde */
            ii(0x7c8e, 1);    pop(cx);                                  /* pop cx */
            ii(0x7c8f, 3);    shl(cx, 3);                               /* shl cx, 0x3 */
            ii(0x7c92, 1);    push(cs);                                 /* push cs */
            ii(0x7c93, 1);    pop(es);                                  /* pop es */
            ii(0x7c94, 3);    mov(ax, 0xcccc);                          /* mov ax, 0xcccc */
            ii(0x7c97, 2);    mov(bx, di);                              /* mov bx, di */
            ii(0x7c99, 2);    rep(() => stosw());                       /* rep stosw */
            ii(0x7c9b, 3);    add(bx, 0xf);                             /* add bx, 0xf */
            ii(0x7c9e, 3);    shr(bx, 4);                               /* shr bx, 0x4 */
            ii(0x7ca1, 4);    add(bx, memw[ds, 0x9b6]);                 /* add bx, [0x9b6] */
            ii(0x7ca5, 3);    mov(ax, memw[ds, 0xcec]);                 /* mov ax, [0xcec] */
            ii(0x7ca8, 2);    sub(bx, ax);                              /* sub bx, ax */
            ii(0x7caa, 4);    mov(memw[ds, 0x5a], bx);                  /* mov [0x5a], bx */
            ii(0x7cae, 2);    mov(es, ax);                              /* mov es, ax */
            ii(0x7cb0, 2);    mov(ah, 0x4a);                            /* mov ah, 0x4a */
            ii(0x7cb2, 2);    @int(0x21);                               /* int 0x21 */
            ii(0x7cb4, 1);    pop(si);                                  /* pop si */
            ii(0x7cb5, 1);    pop(di);                                  /* pop di */
            ii(0x7cb6, 1);    pop(ax);                                  /* pop ax */
            ii(0x7cb7, 1);    pop(sp);                                  /* pop sp */
            ii(0x7cb8, 1);    pop(bp);                                  /* pop bp */
            ii(0x7cb9, 1);    ret();                                    /* ret */
        }
    }
}
