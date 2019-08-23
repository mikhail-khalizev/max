using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x908f-189de133")]
        public void Method_0000_908f()
        {
            ii(0x908f, 4);    enterw(0xa, 0);                           /* enter 0xa, 0x0 */
            ii(0x9093, 1);    pushw(di);                                /* push di */
            ii(0x9094, 1);    pushw(si);                                /* push si */
            ii(0x9095, 5);    mov(memw_a16[ss, bp - 0x4], 0xffe0);      /* mov word [bp-0x4], 0xffe0 */
            ii(0x909a, 5);    mov(memw_a16[ss, bp - 0x2], 0xf000);      /* mov word [bp-0x2], 0xf000 */
            ii(0x909f, 3);    mov(ax, memw_a16[ds, 0x9c]);              /* mov ax, [0x9c] */
            ii(0x90a2, 4);    mov(dx, memw_a16[ds, 0x9e]);              /* mov dx, [0x9e] */
            ii(0x90a6, 3);    mov(memw_a16[ss, bp - 0x8], ax);          /* mov [bp-0x8], ax */
            ii(0x90a9, 3);    mov(memw_a16[ss, bp - 0x6], dx);          /* mov [bp-0x6], dx */
            ii(0x90ac, 3);    cmp(dx, 0x1);                             /* cmp dx, 0x1 */
            ii(0x90af, 2);    if(jgw(0x90bd, 0xc)) goto l_0x90bd;       /* jg 0x90bd */
            ii(0x90b1, 2);    if(jgew(0x90bd, 0xa)) goto l_0x90bd;      /* jge 0x90bd */
            ii(0x90b3, 5);    mov(memw_a16[ss, bp - 0x8], 0);           /* mov word [bp-0x8], 0x0 */
            ii(0x90b8, 5);    mov(memw_a16[ss, bp - 0x6], 0x1);         /* mov word [bp-0x6], 0x1 */
        l_0x90bd:
            ii(0x90bd, 3);    mov(ax, memw_a16[ds, 0xf0c]);             /* mov ax, [0xf0c] */
            ii(0x90c0, 4);    mov(dx, memw_a16[ds, 0xf0e]);             /* mov dx, [0xf0e] */
            ii(0x90c4, 3);    les(bx, ss, bp - 0x4);                    /* les bx, [bp-0x4] */
            ii(0x90c7, 4);    cmp(memw_a16[es, bx + 0xa], ax);          /* cmp [es:bx+0xa], ax */
            ii(0x90cb, 2);    if(jnzw(0x90fd, 0x30)) goto l_0x90fd;     /* jnz 0x90fd */
            ii(0x90cd, 4);    cmp(memw_a16[es, bx + 0xc], dx);          /* cmp [es:bx+0xc], dx */
            ii(0x90d1, 2);    if(jnzw(0x90fd, 0x2a)) goto l_0x90fd;     /* jnz 0x90fd */
            ii(0x90d3, 3);    mov(ax, memw_a16[ds, 0xf11]);             /* mov ax, [0xf11] */
            ii(0x90d6, 4);    cmp(memw_a16[es, bx + 0xe], ax);          /* cmp [es:bx+0xe], ax */
            ii(0x90da, 2);    if(jnzw(0x90fd, 0x21)) goto l_0x90fd;     /* jnz 0x90fd */
            ii(0x90dc, 6);    cmp(memw_a16[ds, 0xece], 0x3e00);         /* cmp word [0xece], 0x3e00 */
            ii(0x90e2, 2);    if(jbw(0x90fd, 0x19)) goto l_0x90fd;      /* jb 0x90fd */
            ii(0x90e4, 3);    mov(ax, memw_a16[ss, bp - 0x8]);          /* mov ax, [bp-0x8] */
            ii(0x90e7, 3);    mov(dx, memw_a16[ss, bp - 0x6]);          /* mov dx, [bp-0x6] */
            ii(0x90ea, 4);    sub(ax, memw_a16[ds, 0x98]);              /* sub ax, [0x98] */
            ii(0x90ee, 4);    sbb(dx, memw_a16[ds, 0x9a]);              /* sbb dx, [0x9a] */
            ii(0x90f2, 2);    mov(cl, 0x6);                             /* mov cl, 0x6 */
            ii(0x90f4, 3);    callw(0x9f82, 0xe8b);                     /* call 0x9f82 */
            ii(0x90f7, 4);    cmp(ax, memw_a16[ds, 0xecc]);             /* cmp ax, [0xecc] */
            ii(0x90fb, 2);    if(jbw(0x9102, 0x5)) goto l_0x9102;       /* jb 0x9102 */
        l_0x90fd:
            ii(0x90fd, 2);    sub(ax, ax);                              /* sub ax, ax */
            ii(0x90ff, 1);    cwd();                                    /* cwd */
            ii(0x9100, 2);    jmpw(0x917c, 0x7a); goto l_0x917c;        /* jmp 0x917c */
        l_0x9102:
            ii(0x9102, 3);    les(bx, ss, bp - 0x4);                    /* les bx, [bp-0x4] */
            ii(0x9105, 3);    mov(ax, memw_a16[es, bx]);                /* mov ax, [es:bx] */
            ii(0x9108, 3);    mov(memw_a16[ss, bp - 0x4], ax);          /* mov [bp-0x4], ax */
            ii(0x910b, 3);    mov(memw_a16[ds, 0x11ec], ax);            /* mov [0x11ec], ax */
            ii(0x910e, 2);    mov(bx, ax);                              /* mov bx, ax */
            ii(0x9110, 4);    cmp(memw_a16[es, bx], -0x1 /* 0xff */);   /* cmp word [es:bx], 0xffff */
            ii(0x9114, 2);    if(jzw(0x90fd, -0x19)) goto l_0x90fd;     /* jz 0x90fd */
            ii(0x9116, 4);    mov(ax, memw_a16[es, bx + 0x4]);          /* mov ax, [es:bx+0x4] */
            ii(0x911a, 4);    cmp(memw_a16[es, bx + 0x2], ax);          /* cmp [es:bx+0x2], ax */
            ii(0x911e, 2);    if(jbw(0x90fd, -0x23)) goto l_0x90fd;     /* jb 0x90fd */
            ii(0x9120, 4);    cmp(ax, memw_a16[es, bx + 0x6]);          /* cmp ax, [es:bx+0x6] */
            ii(0x9124, 2);    if(jaew(0x90fd, -0x29)) goto l_0x90fd;    /* jae 0x90fd */
            ii(0x9126, 3);    mov(memw_a16[ss, bp - 0xa], ax);          /* mov [bp-0xa], ax */
            ii(0x9129, 3);    mov(bx, memw_a16[ss, bp + 0x4]);          /* mov bx, [bp+0x4] */
            ii(0x912c, 2);    mov(memw_a16[ds, bx], ax);                /* mov [bx], ax */
            ii(0x912e, 3);    cmp(ax, 0x1000);                          /* cmp ax, 0x1000 */
            ii(0x9131, 2);    if(jbw(0x90fd, -0x36)) goto l_0x90fd;     /* jb 0x90fd */
            ii(0x9133, 3);    mov(bx, memw_a16[ss, bp - 0x4]);          /* mov bx, [bp-0x4] */
            ii(0x9136, 4);    mov(ax, memw_a16[es, bx + 0x6]);          /* mov ax, [es:bx+0x6] */
            ii(0x913a, 3);    mov(dx, 0xf);                             /* mov dx, 0xf */
            ii(0x913d, 2);    mov(cx, ax);                              /* mov cx, ax */
            ii(0x913f, 2);    mov(bx, dx);                              /* mov bx, dx */
            ii(0x9141, 3);    sub(ax, 0x1);                             /* sub ax, 0x1 */
            ii(0x9144, 3);    sbb(dx, 0);                               /* sbb dx, 0x0 */
            ii(0x9147, 1);    pushw(dx);                                /* push dx */
            ii(0x9148, 1);    pushw(ax);                                /* push ax */
            ii(0x9149, 2);    mov(si, cx);                              /* mov si, cx */
            ii(0x914b, 2);    mov(di, bx);                              /* mov di, bx */
            ii(0x914d, 3);    callw(0x8d9d, -0x3b3);                    /* call 0x8d9d */
            ii(0x9150, 1);    popw(bx);                                 /* pop bx */
            ii(0x9151, 1);    popw(bx);                                 /* pop bx */
            ii(0x9152, 2);    or(ax, ax);                               /* or ax, ax */
            ii(0x9154, 2);    if(jzw(0x90fd, -0x59)) goto l_0x90fd;     /* jz 0x90fd */
            ii(0x9156, 3);    sub(si, memw_a16[ss, bp - 0xa]);          /* sub si, [bp-0xa] */
            ii(0x9159, 3);    sbb(di, 0);                               /* sbb di, 0x0 */
            ii(0x915c, 1);    pushw(di);                                /* push di */
            ii(0x915d, 1);    pushw(si);                                /* push si */
            ii(0x915e, 3);    callw(0x8d9d, -0x3c4);                    /* call 0x8d9d */
            ii(0x9161, 1);    popw(bx);                                 /* pop bx */
            ii(0x9162, 1);    popw(bx);                                 /* pop bx */
            ii(0x9163, 2);    or(ax, ax);                               /* or ax, ax */
            ii(0x9165, 2);    if(jzw(0x90fd, -0x6a)) goto l_0x90fd;     /* jz 0x90fd */
            ii(0x9167, 3);    pushw(memw_a16[ss, bp - 0xa]);            /* push word [bp-0xa] */
            ii(0x916a, 3);    callw(0x5ab1, -0x36bc);                   /* call 0x5ab1 */
            ii(0x916d, 1);    popw(bx);                                 /* pop bx */
            ii(0x916e, 2);    or(ax, ax);                               /* or ax, ax */
            ii(0x9170, 2);    if(jzw(0x90fd, -0x75)) goto l_0x90fd;     /* jz 0x90fd */
            ii(0x9172, 3);    les(bx, ss, bp - 0x4);                    /* les bx, [bp-0x4] */
            ii(0x9175, 4);    mov(ax, memw_a16[es, bx + 0x6]);          /* mov ax, [es:bx+0x6] */
            ii(0x9179, 3);    mov(dx, 0xf);                             /* mov dx, 0xf */
        l_0x917c:
            ii(0x917c, 1);    popw(si);                                 /* pop si */
            ii(0x917d, 1);    popw(di);                                 /* pop di */
            ii(0x917e, 1);    leavew();                                 /* leave */
            ii(0x917f, 1);    retw();                                   /* ret */
        }
    }
}
