using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x88df-189de133")]
        public void Method_0000_88df()
        {
            ii(0x88df, 4);    enterw(0xa, 0);                           /* enter 0xa, 0x0 */
            ii(0x88e3, 1);    pushw(di);                                /* push di */
            ii(0x88e4, 1);    pushw(si);                                /* push si */
            ii(0x88e5, 5);    mov(memw_a16[ss, bp - 0x4], 0xffe0);      /* mov word [bp-0x4], 0xffe0 */
            ii(0x88ea, 5);    mov(memw_a16[ss, bp - 0x2], 0xf000);      /* mov word [bp-0x2], 0xf000 */
            ii(0x88ef, 3);    mov(ax, memw_a16[ds, 0x9c]);              /* mov ax, [0x9c] */
            ii(0x88f2, 4);    mov(dx, memw_a16[ds, 0x9e]);              /* mov dx, [0x9e] */
            ii(0x88f6, 3);    mov(memw_a16[ss, bp - 0x8], ax);          /* mov [bp-0x8], ax */
            ii(0x88f9, 3);    mov(memw_a16[ss, bp - 0x6], dx);          /* mov [bp-0x6], dx */
            ii(0x88fc, 3);    cmp(dx, 0x1);                             /* cmp dx, 0x1 */
            ii(0x88ff, 2);    if(jgw(0x890d, 0xc)) goto l_0x890d;       /* jg 0x890d */
            ii(0x8901, 2);    if(jgew(0x890d, 0xa)) goto l_0x890d;      /* jge 0x890d */
            ii(0x8903, 5);    mov(memw_a16[ss, bp - 0x8], 0);           /* mov word [bp-0x8], 0x0 */
            ii(0x8908, 5);    mov(memw_a16[ss, bp - 0x6], 0x1);         /* mov word [bp-0x6], 0x1 */
        l_0x890d:
            ii(0x890d, 3);    mov(ax, memw_a16[ds, 0xf0c]);             /* mov ax, [0xf0c] */
            ii(0x8910, 4);    mov(dx, memw_a16[ds, 0xf0e]);             /* mov dx, [0xf0e] */
            ii(0x8914, 3);    les(bx, ss, bp - 0x4);                    /* les bx, [bp-0x4] */
            ii(0x8917, 4);    cmp(memw_a16[es, bx + 0xa], ax);          /* cmp [es:bx+0xa], ax */
            ii(0x891b, 2);    if(jnzw(0x894d, 0x30)) goto l_0x894d;     /* jnz 0x894d */
            ii(0x891d, 4);    cmp(memw_a16[es, bx + 0xc], dx);          /* cmp [es:bx+0xc], dx */
            ii(0x8921, 2);    if(jnzw(0x894d, 0x2a)) goto l_0x894d;     /* jnz 0x894d */
            ii(0x8923, 3);    mov(ax, memw_a16[ds, 0xf11]);             /* mov ax, [0xf11] */
            ii(0x8926, 4);    cmp(memw_a16[es, bx + 0xe], ax);          /* cmp [es:bx+0xe], ax */
            ii(0x892a, 2);    if(jnzw(0x894d, 0x21)) goto l_0x894d;     /* jnz 0x894d */
            ii(0x892c, 6);    cmp(memw_a16[ds, 0xece], 0x3e00);         /* cmp word [0xece], 0x3e00 */
            ii(0x8932, 2);    if(jbw(0x894d, 0x19)) goto l_0x894d;      /* jb 0x894d */
            ii(0x8934, 3);    mov(ax, memw_a16[ss, bp - 0x8]);          /* mov ax, [bp-0x8] */
            ii(0x8937, 3);    mov(dx, memw_a16[ss, bp - 0x6]);          /* mov dx, [bp-0x6] */
            ii(0x893a, 4);    sub(ax, memw_a16[ds, 0x98]);              /* sub ax, [0x98] */
            ii(0x893e, 4);    sbb(dx, memw_a16[ds, 0x9a]);              /* sbb dx, [0x9a] */
            ii(0x8942, 2);    mov(cl, 0x6);                             /* mov cl, 0x6 */
            ii(0x8944, 3);    callw(0x97d2, 0xe8b);                     /* call 0x97d2 */
            ii(0x8947, 4);    cmp(ax, memw_a16[ds, 0xecc]);             /* cmp ax, [0xecc] */
            ii(0x894b, 2);    if(jbw(0x8952, 0x5)) goto l_0x8952;       /* jb 0x8952 */
        l_0x894d:
            ii(0x894d, 2);    sub(ax, ax);                              /* sub ax, ax */
            ii(0x894f, 1);    cwd();                                    /* cwd */
            ii(0x8950, 2);    jmpw(0x89cc, 0x7a); goto l_0x89cc;        /* jmp 0x89cc */
        l_0x8952:
            ii(0x8952, 3);    les(bx, ss, bp - 0x4);                    /* les bx, [bp-0x4] */
            ii(0x8955, 3);    mov(ax, memw_a16[es, bx]);                /* mov ax, [es:bx] */
            ii(0x8958, 3);    mov(memw_a16[ss, bp - 0x4], ax);          /* mov [bp-0x4], ax */
            ii(0x895b, 3);    mov(memw_a16[ds, 0x11ec], ax);            /* mov [0x11ec], ax */
            ii(0x895e, 2);    mov(bx, ax);                              /* mov bx, ax */
            ii(0x8960, 4);    cmp(memw_a16[es, bx], -0x1 /* 0xff */);   /* cmp word [es:bx], 0xffff */
            ii(0x8964, 2);    if(jzw(0x894d, -0x19)) goto l_0x894d;     /* jz 0x894d */
            ii(0x8966, 4);    mov(ax, memw_a16[es, bx + 0x4]);          /* mov ax, [es:bx+0x4] */
            ii(0x896a, 4);    cmp(memw_a16[es, bx + 0x2], ax);          /* cmp [es:bx+0x2], ax */
            ii(0x896e, 2);    if(jbw(0x894d, -0x23)) goto l_0x894d;     /* jb 0x894d */
            ii(0x8970, 4);    cmp(ax, memw_a16[es, bx + 0x6]);          /* cmp ax, [es:bx+0x6] */
            ii(0x8974, 2);    if(jaew(0x894d, -0x29)) goto l_0x894d;    /* jae 0x894d */
            ii(0x8976, 3);    mov(memw_a16[ss, bp - 0xa], ax);          /* mov [bp-0xa], ax */
            ii(0x8979, 3);    mov(bx, memw_a16[ss, bp + 0x4]);          /* mov bx, [bp+0x4] */
            ii(0x897c, 2);    mov(memw_a16[ds, bx], ax);                /* mov [bx], ax */
            ii(0x897e, 3);    cmp(ax, 0x1000);                          /* cmp ax, 0x1000 */
            ii(0x8981, 2);    if(jbw(0x894d, -0x36)) goto l_0x894d;     /* jb 0x894d */
            ii(0x8983, 3);    mov(bx, memw_a16[ss, bp - 0x4]);          /* mov bx, [bp-0x4] */
            ii(0x8986, 4);    mov(ax, memw_a16[es, bx + 0x6]);          /* mov ax, [es:bx+0x6] */
            ii(0x898a, 3);    mov(dx, 0xf);                             /* mov dx, 0xf */
            ii(0x898d, 2);    mov(cx, ax);                              /* mov cx, ax */
            ii(0x898f, 2);    mov(bx, dx);                              /* mov bx, dx */
            ii(0x8991, 3);    sub(ax, 0x1);                             /* sub ax, 0x1 */
            ii(0x8994, 3);    sbb(dx, 0);                               /* sbb dx, 0x0 */
            ii(0x8997, 1);    pushw(dx);                                /* push dx */
            ii(0x8998, 1);    pushw(ax);                                /* push ax */
            ii(0x8999, 2);    mov(si, cx);                              /* mov si, cx */
            ii(0x899b, 2);    mov(di, bx);                              /* mov di, bx */
            ii(0x899d, 3);    callw(0x85ed, -0x3b3);                    /* call 0x85ed */
            ii(0x89a0, 1);    popw(bx);                                 /* pop bx */
            ii(0x89a1, 1);    popw(bx);                                 /* pop bx */
            ii(0x89a2, 2);    or(ax, ax);                               /* or ax, ax */
            ii(0x89a4, 2);    if(jzw(0x894d, -0x59)) goto l_0x894d;     /* jz 0x894d */
            ii(0x89a6, 3);    sub(si, memw_a16[ss, bp - 0xa]);          /* sub si, [bp-0xa] */
            ii(0x89a9, 3);    sbb(di, 0);                               /* sbb di, 0x0 */
            ii(0x89ac, 1);    pushw(di);                                /* push di */
            ii(0x89ad, 1);    pushw(si);                                /* push si */
            ii(0x89ae, 3);    callw(0x85ed, -0x3c4);                    /* call 0x85ed */
            ii(0x89b1, 1);    popw(bx);                                 /* pop bx */
            ii(0x89b2, 1);    popw(bx);                                 /* pop bx */
            ii(0x89b3, 2);    or(ax, ax);                               /* or ax, ax */
            ii(0x89b5, 2);    if(jzw(0x894d, -0x6a)) goto l_0x894d;     /* jz 0x894d */
            ii(0x89b7, 3);    pushw(memw_a16[ss, bp - 0xa]);            /* push word [bp-0xa] */
            ii(0x89ba, 3);    callw(0x5301, -0x36bc);                   /* call 0x5301 */
            ii(0x89bd, 1);    popw(bx);                                 /* pop bx */
            ii(0x89be, 2);    or(ax, ax);                               /* or ax, ax */
            ii(0x89c0, 2);    if(jzw(0x894d, -0x75)) goto l_0x894d;     /* jz 0x894d */
            ii(0x89c2, 3);    les(bx, ss, bp - 0x4);                    /* les bx, [bp-0x4] */
            ii(0x89c5, 4);    mov(ax, memw_a16[es, bx + 0x6]);          /* mov ax, [es:bx+0x6] */
            ii(0x89c9, 3);    mov(dx, 0xf);                             /* mov dx, 0xf */
        l_0x89cc:
            ii(0x89cc, 1);    popw(si);                                 /* pop si */
            ii(0x89cd, 1);    popw(di);                                 /* pop di */
            ii(0x89ce, 1);    leavew();                                 /* leave */
            ii(0x89cf, 1);    retw(); return;                           /* ret */
        }
    }
}
