using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x805d-63204d07")]
        public void Method_0000_805d()
        {
            ii(0x805d, 1);    push(bp);                                 /* push bp */
            ii(0x805e, 2);    mov(bp, sp);                              /* mov bp, sp */
            ii(0x8060, 4);    sub(sp, 0x9c);                            /* sub sp, 0x9c */
            ii(0x8064, 1);    push(di);                                 /* push di */
            ii(0x8065, 1);    push(si);                                 /* push si */
            ii(0x8066, 5);    mov(memw[ss, bp - 0x2], 0);               /* mov word [bp-0x2], 0x0 */
            ii(0x806b, 4);    cmp(memw[ss, bp + 0x4], 0);               /* cmp word [bp+0x4], 0x0 */
            ii(0x806f, 2);    if(jge(0x8079, 0x8)) goto l_0x8079;       /* jge 0x8079 */
            ii(0x8071, 5);    mov(memw[ss, bp - 0x2], 0x1);             /* mov word [bp-0x2], 0x1 */
            ii(0x8076, 3);    neg(memw[ss, bp + 0x4]);                  /* neg word [bp+0x4] */
        l_0x8079:
            ii(0x8079, 3);    mov(ax, memw[ss, bp + 0x4]);              /* mov ax, [bp+0x4] */
            ii(0x807c, 4);    mov(memw[ss, bp - 0x9a], ax);             /* mov [bp-0x9a], ax */
            ii(0x8080, 4);    lea(si, bp - 0x98);                       /* lea si, [bp-0x98] */
            ii(0x8084, 5);    cmp(memb[ds, 0xf21], 0x1);                /* cmp byte [0xf21], 0x1 */
            ii(0x8089, 2);    if(jz(0x80dd, 0x52)) goto l_0x80dd;       /* jz 0x80dd */
            ii(0x808b, 5);    mov(memb[ss, bp - 0x98], 0x5b);           /* mov byte [bp-0x98], 0x5b */
            ii(0x8090, 4);    lea(si, bp - 0x97);                       /* lea si, [bp-0x97] */
        l_0x8094:
            ii(0x8094, 1);    inc(si);                                  /* inc si */
            ii(0x8095, 3);    mov(cx, 0xa);                             /* mov cx, 0xa */
            ii(0x8098, 4);    mov(ax, memw[ss, bp - 0x9a]);             /* mov ax, [bp-0x9a] */
            ii(0x809c, 1);    cwd();                                    /* cwd */
            ii(0x809d, 2);    idiv(cx);                                 /* idiv cx */
            ii(0x809f, 4);    mov(memw[ss, bp - 0x9a], ax);             /* mov [bp-0x9a], ax */
            ii(0x80a3, 2);    or(ax, ax);                               /* or ax, ax */
            ii(0x80a5, 2);    if(jnz(0x8094, -0x13)) goto l_0x8094;     /* jnz 0x8094 */
            ii(0x80a7, 2);    mov(di, si);                              /* mov di, si */
            ii(0x80a9, 3);    mov(ax, memw[ss, bp + 0x4]);              /* mov ax, [bp+0x4] */
            ii(0x80ac, 4);    mov(memw[ss, bp - 0x9a], ax);             /* mov [bp-0x9a], ax */
        l_0x80b0:
            ii(0x80b0, 1);    cwd();                                    /* cwd */
            ii(0x80b1, 2);    idiv(cx);                                 /* idiv cx */
            ii(0x80b3, 2);    mov(bx, dx);                              /* mov bx, dx */
            ii(0x80b5, 4);    mov(al, memb[ds, bx + 0xab0]);            /* mov al, [bx+0xab0] */
            ii(0x80b9, 1);    dec(di);                                  /* dec di */
            ii(0x80ba, 2);    mov(memb[ds, di], al);                    /* mov [di], al */
            ii(0x80bc, 4);    mov(ax, memw[ss, bp - 0x9a]);             /* mov ax, [bp-0x9a] */
            ii(0x80c0, 1);    cwd();                                    /* cwd */
            ii(0x80c1, 2);    idiv(cx);                                 /* idiv cx */
            ii(0x80c3, 4);    mov(memw[ss, bp - 0x9a], ax);             /* mov [bp-0x9a], ax */
            ii(0x80c7, 2);    or(ax, ax);                               /* or ax, ax */
            ii(0x80c9, 2);    if(jnz(0x80b0, -0x1b)) goto l_0x80b0;     /* jnz 0x80b0 */
            ii(0x80cb, 1);    inc(si);                                  /* inc si */
            ii(0x80cc, 4);    mov(memb[ds, si - 0x1], 0x5d);            /* mov byte [si-0x1], 0x5d */
            ii(0x80d0, 1);    inc(si);                                  /* inc si */
            ii(0x80d1, 4);    mov(memb[ds, si - 0x1], 0x20);            /* mov byte [si-0x1], 0x20 */
            ii(0x80d5, 1);    inc(si);                                  /* inc si */
            ii(0x80d6, 4);    mov(memb[ds, si - 0x1], 0x20);            /* mov byte [si-0x1], 0x20 */
            ii(0x80da, 3);    mov(memb[ds, si], 0);                     /* mov byte [si], 0x0 */
        l_0x80dd:
            ii(0x80dd, 3);    mov(di, 0x15e8);                          /* mov di, 0x15e8 */
            ii(0x80e0, 2);    jmp(0x80fd, 0x1b); goto l_0x80fd;         /* jmp 0x80fd */
        l_0x80e2:
            ii(0x80e2, 4);    cmp(memw[ds, 0xf22], di);                 /* cmp [0xf22], di */
            ii(0x80e6, 2);    if(jbe(0x8109, 0x21)) goto l_0x8109;      /* jbe 0x8109 */
            ii(0x80e8, 3);    cmp(ax, memw[ss, bp + 0x4]);              /* cmp ax, [bp+0x4] */
            ii(0x80eb, 2);    if(jnz(0x80f6, 0x9)) goto l_0x80f6;       /* jnz 0x80f6 */
            ii(0x80ed, 1);    push(di);                                 /* push di */
            ii(0x80ee, 1);    push(si);                                 /* push si */
            ii(0x80ef, 3);    call(0x839e, 0x2ac);                      /* call 0x839e */
            ii(0x80f2, 1);    pop(bx);                                  /* pop bx */
            ii(0x80f3, 1);    pop(bx);                                  /* pop bx */
            ii(0x80f4, 2);    jmp(0x8109, 0x13); goto l_0x8109;         /* jmp 0x8109 */
        l_0x80f6:
            ii(0x80f6, 1);    inc(di);                                  /* inc di */
            ii(0x80f7, 4);    cmp(memb[ds, di - 0x1], 0);               /* cmp byte [di-0x1], 0x0 */
            ii(0x80fb, 2);    if(jnz(0x80f6, -0x7)) goto l_0x80f6;      /* jnz 0x80f6 */
        l_0x80fd:
            ii(0x80fd, 2);    mov(ax, memw[ds, di]);                    /* mov ax, [di] */
            ii(0x80ff, 1);    inc(di);                                  /* inc di */
            ii(0x8100, 1);    inc(di);                                  /* inc di */
            ii(0x8101, 4);    mov(memw[ss, bp - 0x9a], ax);             /* mov [bp-0x9a], ax */
            ii(0x8105, 2);    or(ax, ax);                               /* or ax, ax */
            ii(0x8107, 2);    if(jge(0x80e2, -0x27)) goto l_0x80e2;     /* jge 0x80e2 */
        l_0x8109:
            ii(0x8109, 4);    cmp(memw[ss, bp - 0x2], 0);               /* cmp word [bp-0x2], 0x0 */
            ii(0x810d, 2);    if(jz(0x811e, 0xf)) goto l_0x811e;        /* jz 0x811e */
            ii(0x810f, 3);    mov(ax, 0x1190);                          /* mov ax, 0x1190 */
            ii(0x8112, 1);    push(ax);                                 /* push ax */
            ii(0x8113, 4);    lea(ax, bp - 0x98);                       /* lea ax, [bp-0x98] */
            ii(0x8117, 1);    push(ax);                                 /* push ax */
            ii(0x8118, 4);    call_abs(memw[ds, 0xe6c]);                /* call word [0xe6c] */
            ii(0x811c, 1);    pop(bx);                                  /* pop bx */
            ii(0x811d, 1);    pop(bx);                                  /* pop bx */
        l_0x811e:
            ii(0x811e, 2);    sub(ax, ax);                              /* sub ax, ax */
            ii(0x8120, 1);    push(ax);                                 /* push ax */
            ii(0x8121, 4);    lea(ax, bp - 0x98);                       /* lea ax, [bp-0x98] */
            ii(0x8125, 1);    push(ax);                                 /* push ax */
            ii(0x8126, 4);    call_abs(memw[ds, 0xe6c]);                /* call word [0xe6c] */
            ii(0x812a, 1);    pop(bx);                                  /* pop bx */
            ii(0x812b, 1);    pop(bx);                                  /* pop bx */
            ii(0x812c, 1);    pop(si);                                  /* pop si */
            ii(0x812d, 1);    pop(di);                                  /* pop di */
            ii(0x812e, 2);    mov(sp, bp);                              /* mov sp, bp */
            ii(0x8130, 1);    pop(bp);                                  /* pop bp */
            ii(0x8131, 1);    ret();                                    /* ret */
        }
    }
}
