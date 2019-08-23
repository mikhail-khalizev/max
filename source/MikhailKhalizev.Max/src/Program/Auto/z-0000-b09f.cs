using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0xb09f-189de133")]
        public void Method_0000_b09f()
        {
            ii(0xb09f, 4);    enter(0xa, 0);                            /* enter 0xa, 0x0 */
            ii(0xb0a3, 1);    push(di);                                 /* push di */
            ii(0xb0a4, 1);    push(si);                                 /* push si */
            ii(0xb0a5, 5);    mov(memw[ss, bp - 0x4], 0xffe0);          /* mov word [bp-0x4], 0xffe0 */
            ii(0xb0aa, 5);    mov(memw[ss, bp - 0x2], 0xf000);          /* mov word [bp-0x2], 0xf000 */
            ii(0xb0af, 3);    mov(ax, memw[ds, 0x9c]);                  /* mov ax, [0x9c] */
            ii(0xb0b2, 4);    mov(dx, memw[ds, 0x9e]);                  /* mov dx, [0x9e] */
            ii(0xb0b6, 3);    mov(memw[ss, bp - 0x8], ax);              /* mov [bp-0x8], ax */
            ii(0xb0b9, 3);    mov(memw[ss, bp - 0x6], dx);              /* mov [bp-0x6], dx */
            ii(0xb0bc, 3);    cmp(dx, 0x1);                             /* cmp dx, 0x1 */
            ii(0xb0bf, 2);    if(jg(0xb0cd, 0xc)) goto l_0xb0cd;        /* jg 0xb0cd */
            ii(0xb0c1, 2);    if(jge(0xb0cd, 0xa)) goto l_0xb0cd;       /* jge 0xb0cd */
            ii(0xb0c3, 5);    mov(memw[ss, bp - 0x8], 0);               /* mov word [bp-0x8], 0x0 */
            ii(0xb0c8, 5);    mov(memw[ss, bp - 0x6], 0x1);             /* mov word [bp-0x6], 0x1 */
        l_0xb0cd:
            ii(0xb0cd, 3);    mov(ax, memw[ds, 0xf0c]);                 /* mov ax, [0xf0c] */
            ii(0xb0d0, 4);    mov(dx, memw[ds, 0xf0e]);                 /* mov dx, [0xf0e] */
            ii(0xb0d4, 3);    les(bx, memw[ss, bp - 0x4]);              /* les bx, [bp-0x4] */
            ii(0xb0d7, 4);    cmp(memw[es, bx + 0xa], ax);              /* cmp [es:bx+0xa], ax */
            ii(0xb0db, 2);    if(jnz(0xb10d, 0x30)) goto l_0xb10d;      /* jnz 0xb10d */
            ii(0xb0dd, 4);    cmp(memw[es, bx + 0xc], dx);              /* cmp [es:bx+0xc], dx */
            ii(0xb0e1, 2);    if(jnz(0xb10d, 0x2a)) goto l_0xb10d;      /* jnz 0xb10d */
            ii(0xb0e3, 3);    mov(ax, memw[ds, 0xf11]);                 /* mov ax, [0xf11] */
            ii(0xb0e6, 4);    cmp(memw[es, bx + 0xe], ax);              /* cmp [es:bx+0xe], ax */
            ii(0xb0ea, 2);    if(jnz(0xb10d, 0x21)) goto l_0xb10d;      /* jnz 0xb10d */
            ii(0xb0ec, 6);    cmp(memw[ds, 0xece], 0x3e00);             /* cmp word [0xece], 0x3e00 */
            ii(0xb0f2, 2);    if(jb(0xb10d, 0x19)) goto l_0xb10d;       /* jb 0xb10d */
            ii(0xb0f4, 3);    mov(ax, memw[ss, bp - 0x8]);              /* mov ax, [bp-0x8] */
            ii(0xb0f7, 3);    mov(dx, memw[ss, bp - 0x6]);              /* mov dx, [bp-0x6] */
            ii(0xb0fa, 4);    sub(ax, memw[ds, 0x98]);                  /* sub ax, [0x98] */
            ii(0xb0fe, 4);    sbb(dx, memw[ds, 0x9a]);                  /* sbb dx, [0x9a] */
            ii(0xb102, 2);    mov(cl, 0x6);                             /* mov cl, 0x6 */
            ii(0xb104, 3);    call(0xbf92, 0xe8b);                      /* call 0xbf92 */
            ii(0xb107, 4);    cmp(ax, memw[ds, 0xecc]);                 /* cmp ax, [0xecc] */
            ii(0xb10b, 2);    if(jb(0xb112, 0x5)) goto l_0xb112;        /* jb 0xb112 */
        l_0xb10d:
            ii(0xb10d, 2);    sub(ax, ax);                              /* sub ax, ax */
            ii(0xb10f, 1);    cwd();                                    /* cwd */
            ii(0xb110, 2);    jmp(0xb18c, 0x7a); goto l_0xb18c;         /* jmp 0xb18c */
        l_0xb112:
            ii(0xb112, 3);    les(bx, memw[ss, bp - 0x4]);              /* les bx, [bp-0x4] */
            ii(0xb115, 3);    mov(ax, memw[es, bx]);                    /* mov ax, [es:bx] */
            ii(0xb118, 3);    mov(memw[ss, bp - 0x4], ax);              /* mov [bp-0x4], ax */
            ii(0xb11b, 3);    mov(memw[ds, 0x11ec], ax);                /* mov [0x11ec], ax */
            ii(0xb11e, 2);    mov(bx, ax);                              /* mov bx, ax */
            ii(0xb120, 4);    cmp(memw[es, bx], -0x1 /* 0xff */);       /* cmp word [es:bx], 0xffff */
            ii(0xb124, 2);    if(jz(0xb10d, -0x19)) goto l_0xb10d;      /* jz 0xb10d */
            ii(0xb126, 4);    mov(ax, memw[es, bx + 0x4]);              /* mov ax, [es:bx+0x4] */
            ii(0xb12a, 4);    cmp(memw[es, bx + 0x2], ax);              /* cmp [es:bx+0x2], ax */
            ii(0xb12e, 2);    if(jb(0xb10d, -0x23)) goto l_0xb10d;      /* jb 0xb10d */
            ii(0xb130, 4);    cmp(ax, memw[es, bx + 0x6]);              /* cmp ax, [es:bx+0x6] */
            ii(0xb134, 2);    if(jae(0xb10d, -0x29)) goto l_0xb10d;     /* jae 0xb10d */
            ii(0xb136, 3);    mov(memw[ss, bp - 0xa], ax);              /* mov [bp-0xa], ax */
            ii(0xb139, 3);    mov(bx, memw[ss, bp + 0x4]);              /* mov bx, [bp+0x4] */
            ii(0xb13c, 2);    mov(memw[ds, bx], ax);                    /* mov [bx], ax */
            ii(0xb13e, 3);    cmp(ax, 0x1000);                          /* cmp ax, 0x1000 */
            ii(0xb141, 2);    if(jb(0xb10d, -0x36)) goto l_0xb10d;      /* jb 0xb10d */
            ii(0xb143, 3);    mov(bx, memw[ss, bp - 0x4]);              /* mov bx, [bp-0x4] */
            ii(0xb146, 4);    mov(ax, memw[es, bx + 0x6]);              /* mov ax, [es:bx+0x6] */
            ii(0xb14a, 3);    mov(dx, 0xf);                             /* mov dx, 0xf */
            ii(0xb14d, 2);    mov(cx, ax);                              /* mov cx, ax */
            ii(0xb14f, 2);    mov(bx, dx);                              /* mov bx, dx */
            ii(0xb151, 3);    sub(ax, 0x1);                             /* sub ax, 0x1 */
            ii(0xb154, 3);    sbb(dx, 0);                               /* sbb dx, 0x0 */
            ii(0xb157, 1);    push(dx);                                 /* push dx */
            ii(0xb158, 1);    push(ax);                                 /* push ax */
            ii(0xb159, 2);    mov(si, cx);                              /* mov si, cx */
            ii(0xb15b, 2);    mov(di, bx);                              /* mov di, bx */
            ii(0xb15d, 3);    call(0xadad, -0x3b3);                     /* call 0xadad */
            ii(0xb160, 1);    pop(bx);                                  /* pop bx */
            ii(0xb161, 1);    pop(bx);                                  /* pop bx */
            ii(0xb162, 2);    or(ax, ax);                               /* or ax, ax */
            ii(0xb164, 2);    if(jz(0xb10d, -0x59)) goto l_0xb10d;      /* jz 0xb10d */
            ii(0xb166, 3);    sub(si, memw[ss, bp - 0xa]);              /* sub si, [bp-0xa] */
            ii(0xb169, 3);    sbb(di, 0);                               /* sbb di, 0x0 */
            ii(0xb16c, 1);    push(di);                                 /* push di */
            ii(0xb16d, 1);    push(si);                                 /* push si */
            ii(0xb16e, 3);    call(0xadad, -0x3c4);                     /* call 0xadad */
            ii(0xb171, 1);    pop(bx);                                  /* pop bx */
            ii(0xb172, 1);    pop(bx);                                  /* pop bx */
            ii(0xb173, 2);    or(ax, ax);                               /* or ax, ax */
            ii(0xb175, 2);    if(jz(0xb10d, -0x6a)) goto l_0xb10d;      /* jz 0xb10d */
            ii(0xb177, 3);    push(memw[ss, bp - 0xa]);                 /* push word [bp-0xa] */
            ii(0xb17a, 3);    call(0x7ac1, -0x36bc);                    /* call 0x7ac1 */
            ii(0xb17d, 1);    pop(bx);                                  /* pop bx */
            ii(0xb17e, 2);    or(ax, ax);                               /* or ax, ax */
            ii(0xb180, 2);    if(jz(0xb10d, -0x75)) goto l_0xb10d;      /* jz 0xb10d */
            ii(0xb182, 3);    les(bx, memw[ss, bp - 0x4]);              /* les bx, [bp-0x4] */
            ii(0xb185, 4);    mov(ax, memw[es, bx + 0x6]);              /* mov ax, [es:bx+0x6] */
            ii(0xb189, 3);    mov(dx, 0xf);                             /* mov dx, 0xf */
        l_0xb18c:
            ii(0xb18c, 1);    pop(si);                                  /* pop si */
            ii(0xb18d, 1);    pop(di);                                  /* pop di */
            ii(0xb18e, 1);    leave();                                  /* leave */
            ii(0xb18f, 1);    ret();                                    /* ret */
        }
    }
}
