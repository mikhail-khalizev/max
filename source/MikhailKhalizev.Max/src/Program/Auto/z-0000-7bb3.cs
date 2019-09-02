using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x7bb3-dd8da5b8")]
        public void Method_0000_7bb3()
        {
            ii(0x7bb3, 1);    push(bp);                                 /* push bp */
            ii(0x7bb4, 2);    mov(bp, sp);                              /* mov bp, sp */
            ii(0x7bb6, 3);    sub(sp, 2);                               /* sub sp, 0x2 */
            ii(0x7bb9, 1);    push(di);                                 /* push di */
            ii(0x7bba, 1);    push(si);                                 /* push si */
            ii(0x7bbb, 3);    mov(si, memw[ss, bp + 4]);                /* mov si, [bp+0x4] */
            ii(0x7bbe, 2);    sub(di, di);                              /* sub di, di */
            ii(0x7bc0, 3);    mov(ax, 0xed1);                           /* mov ax, 0xed1 */
            ii(0x7bc3, 1);    push(ax);                                 /* push ax */
            ii(0x7bc4, 3);    lea(ax, memw[ds, si + 1]);                /* lea ax, [si+0x1] */
            ii(0x7bc7, 1);    push(ax);                                 /* push ax */
            ii(0x7bc8, 3);    call(0x7c35, 0x6a);                       /* call 0x7c35 */
            ii(0x7bcb, 1);    pop(bx);                                  /* pop bx */
            ii(0x7bcc, 2);    mov(si, ax);                              /* mov si, ax */
            ii(0x7bce, 1);    push(si);                                 /* push si */
            ii(0x7bcf, 3);    call(0x4f4d, -0x2c85);                    /* call 0x4f4d */
            ii(0x7bd2, 1);    pop(bx);                                  /* pop bx */
            ii(0x7bd3, 1);    pop(bx);                                  /* pop bx */
            ii(0x7bd4, 2);    or(ax, ax);                               /* or ax, ax */
            ii(0x7bd6, 2);    if(jnz(0x7bee, 0x16)) goto l_0x7bee;      /* jnz 0x7bee */
            ii(0x7bd8, 1);    push(si);                                 /* push si */
            ii(0x7bd9, 3);    call(0x9670, 0x1a94);                     /* call 0x9670 */
            ii(0x7bdc, 1);    pop(bx);                                  /* pop bx */
            ii(0x7bdd, 2);    mov(di, ax);                              /* mov di, ax */
        l_0x7bdf:
            ii(0x7bdf, 2);    mov(al, memb[ds, si]);                    /* mov al, [si] */
            ii(0x7be1, 1);    cbw();                                    /* cbw */
            ii(0x7be2, 1);    push(ax);                                 /* push ax */
            ii(0x7be3, 3);    call(0x7b9b, -0x4b);                      /* call 0x7b9b */
            ii(0x7be6, 1);    pop(bx);                                  /* pop bx */
            ii(0x7be7, 2);    or(ax, ax);                               /* or ax, ax */
            ii(0x7be9, 2);    if(jz(0x7c12, 0x27)) goto l_0x7c12;       /* jz 0x7c12 */
            ii(0x7beb, 1);    inc(si);                                  /* inc si */
            ii(0x7bec, 2);    jmp(0x7bdf, -0xf); goto l_0x7bdf;         /* jmp 0x7bdf */
        l_0x7bee:
            ii(0x7bee, 1);    inc(si);                                  /* inc si */
            ii(0x7bef, 1);    inc(si);                                  /* inc si */
            ii(0x7bf0, 2);    jmp(0x7c0d, 0x1b); goto l_0x7c0d;         /* jmp 0x7c0d */
        l_0x7bf2:
            ii(0x7bf2, 2);    mov(al, memb[ds, si]);                    /* mov al, [si] */
            ii(0x7bf4, 1);    cbw();                                    /* cbw */
            ii(0x7bf5, 1);    push(ax);                                 /* push ax */
            ii(0x7bf6, 3);    mov(ax, 0xab0);                           /* mov ax, 0xab0 */
            ii(0x7bf9, 1);    push(ax);                                 /* push ax */
            ii(0x7bfa, 3);    call(0x9710, 0x1b13);                     /* call 0x9710 */
            ii(0x7bfd, 1);    pop(bx);                                  /* pop bx */
            ii(0x7bfe, 1);    pop(bx);                                  /* pop bx */
            ii(0x7bff, 2);    or(ax, ax);                               /* or ax, ax */
            ii(0x7c01, 2);    if(jz(0x7c12, 0xf)) goto l_0x7c12;        /* jz 0x7c12 */
            ii(0x7c03, 2);    mov(cl, 4);                               /* mov cl, 0x4 */
            ii(0x7c05, 2);    shl(di, cl);                              /* shl di, cl */
            ii(0x7c07, 3);    sub(ax, 0xab0);                           /* sub ax, 0xab0 */
            ii(0x7c0a, 2);    add(di, ax);                              /* add di, ax */
            ii(0x7c0c, 1);    inc(si);                                  /* inc si */
        l_0x7c0d:
            ii(0x7c0d, 3);    cmp(memb[ds, si], 0);                     /* cmp byte [si], 0x0 */
            ii(0x7c10, 2);    if(jnz(0x7bf2, -0x20)) goto l_0x7bf2;     /* jnz 0x7bf2 */
        l_0x7c12:
            ii(0x7c12, 1);    push(si);                                 /* push si */
            ii(0x7c13, 3);    call(0x7c35, 0x1f);                       /* call 0x7c35 */
            ii(0x7c16, 1);    pop(bx);                                  /* pop bx */
            ii(0x7c17, 2);    mov(bx, ax);                              /* mov bx, ax */
            ii(0x7c19, 3);    cmp(memb[ds, bx], 0x4d);                  /* cmp byte [bx], 0x4d */
            ii(0x7c1c, 2);    if(jnz(0x7c2d, 0xf)) goto l_0x7c2d;       /* jnz 0x7c2d */
            ii(0x7c1e, 4);    test(di, 0xffc0);                         /* test di, 0xffc0 */
            ii(0x7c22, 2);    if(jz(0x7c29, 5)) goto l_0x7c29;          /* jz 0x7c29 */
            ii(0x7c24, 3);    mov(di, 0xffff);                          /* mov di, 0xffff */
            ii(0x7c27, 2);    jmp(0x7c2d, 4); goto l_0x7c2d;            /* jmp 0x7c2d */
        l_0x7c29:
            ii(0x7c29, 2);    mov(cl, 0xa);                             /* mov cl, 0xa */
            ii(0x7c2b, 2);    shl(di, cl);                              /* shl di, cl */
        l_0x7c2d:
            ii(0x7c2d, 2);    mov(ax, di);                              /* mov ax, di */
            ii(0x7c2f, 1);    pop(si);                                  /* pop si */
            ii(0x7c30, 1);    pop(di);                                  /* pop di */
            ii(0x7c31, 2);    mov(sp, bp);                              /* mov sp, bp */
            ii(0x7c33, 1);    pop(bp);                                  /* pop bp */
            ii(0x7c34, 1);    ret();                                    /* ret */
        }
    }
}
