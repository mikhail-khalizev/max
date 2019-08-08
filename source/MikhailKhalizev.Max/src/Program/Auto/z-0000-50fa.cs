using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("ad41d647-9c57-4164-9fef-110b9b866ba2")]
        public void Method_0000_50fa()
        {
            ii(0x50fa, 4);    enterw(0x10, 0);                          /* enter 0x10, 0x0 */
            ii(0x50fe, 1);    pushw(di);                                /* push di */
            ii(0x50ff, 1);    pushw(si);                                /* push si */
            ii(0x5100, 2);    sub(ax, ax);                              /* sub ax, ax */
            ii(0x5102, 3);    mov(memw_a16[ds, 0xd60], ax);             /* mov [0xd60], ax */
            ii(0x5105, 3);    mov(memw_a16[ds, 0xd62], ax);             /* mov [0xd62], ax */
            ii(0x5108, 3);    mov(ax, memw_a16[ds, 0x990]);             /* mov ax, [0x990] */
            ii(0x510b, 4);    or(ax, memw_a16[ds, 0x98e]);              /* or ax, [0x98e] */
            ii(0x510f, 2);    if(jnzw(0x5114, 0x3)) goto l_0x5114;      /* jnz 0x5114 */
            ii(0x5111, 3);    jmpw(0x521f, 0x10b); goto l_0x521f;       /* jmp 0x521f */
        l_0x5114:
            ii(0x5114, 3);    mov(ax, 0x938);                           /* mov ax, 0x938 */
            ii(0x5117, 1);    pushw(si);                                /* push si */
            ii(0x5118, 2);    mov(di, ax);                              /* mov di, ax */
            ii(0x511a, 3);    mov(si, 0x8c8);                           /* mov si, 0x8c8 */
            ii(0x511d, 1);    pushw(ds);                                /* push ds */
            ii(0x511e, 1);    popw(es);                                 /* pop es */
            ii(0x511f, 1);    movsw_a16();                              /* movsw */
            ii(0x5120, 1);    movsw_a16();                              /* movsw */
            ii(0x5121, 1);    movsw_a16();                              /* movsw */
            ii(0x5122, 1);    movsw_a16();                              /* movsw */
            ii(0x5123, 1);    popw(si);                                 /* pop si */
            ii(0x5124, 3);    mov(si, 0x8);                             /* mov si, 0x8 */
            ii(0x5127, 5);    cmp(memb_a16[ds, 0x11d8], 0);             /* cmp byte [0x11d8], 0x0 */
            ii(0x512c, 2);    if(jnzw(0x5162, 0x34)) goto l_0x5162;     /* jnz 0x5162 */
            ii(0x512e, 2);    pushw(0x50);                              /* push 0x50 */
            ii(0x5130, 3);    callw(0x522f, 0xfc);                      /* call 0x522f */
            ii(0x5133, 1);    popw(bx);                                 /* pop bx */
            ii(0x5134, 1);    pushw(si);                                /* push si */
            ii(0x5135, 3);    lea(di, bp - 0x8);                        /* lea di, [bp-0x8] */
            ii(0x5138, 3);    mov(si, 0x11e4);                          /* mov si, 0x11e4 */
            ii(0x513b, 1);    pushw(ss);                                /* push ss */
            ii(0x513c, 1);    popw(es);                                 /* pop es */
            ii(0x513d, 1);    movsw_a16();                              /* movsw */
            ii(0x513e, 1);    movsw_a16();                              /* movsw */
            ii(0x513f, 1);    movsw_a16();                              /* movsw */
            ii(0x5140, 1);    movsw_a16();                              /* movsw */
            ii(0x5141, 1);    popw(si);                                 /* pop si */
            ii(0x5142, 3);    callw(0x4f8a, -0x1bb);                    /* call 0x4f8a */
            ii(0x5145, 5);    cmp(memw_a16[ds, 0xa14], 0);              /* cmp word [0xa14], 0x0 */
            ii(0x514a, 2);    if(jnzw(0x514f, 0x3)) goto l_0x514f;      /* jnz 0x514f */
            ii(0x514c, 3);    callw(0x375c, -0x19f3);                   /* call 0x375c */
        l_0x514f:
            ii(0x514f, 3);    mov(ax, 0x910);                           /* mov ax, 0x910 */
            ii(0x5152, 1);    pushw(si);                                /* push si */
            ii(0x5153, 2);    mov(di, ax);                              /* mov di, ax */
            ii(0x5155, 3);    lea(si, bp - 0x8);                        /* lea si, [bp-0x8] */
            ii(0x5158, 1);    pushw(ds);                                /* push ds */
            ii(0x5159, 1);    popw(es);                                 /* pop es */
            ii(0x515a, 1);    movsw_a16();                              /* movsw */
            ii(0x515b, 1);    movsw_a16();                              /* movsw */
            ii(0x515c, 1);    movsw_a16();                              /* movsw */
            ii(0x515d, 1);    movsw_a16();                              /* movsw */
            ii(0x515e, 1);    popw(si);                                 /* pop si */
            ii(0x515f, 3);    mov(si, 0x78);                            /* mov si, 0x78 */
        l_0x5162:
            ii(0x5162, 5);    mov(memw_a16[ss, bp - 0x10], 0);          /* mov word [bp-0x10], 0x0 */
            ii(0x5167, 5);    mov(memw_a16[ss, bp - 0xe], 0x50);        /* mov word [bp-0xe], 0x50 */
            ii(0x516c, 3);    mov(ax, memw_a16[ds, 0x938]);             /* mov ax, [0x938] */
            ii(0x516f, 2);    and(al, 0xf8);                            /* and al, 0xf8 */
            ii(0x5171, 3);    mov(memw_a16[ss, bp - 0xc], ax);          /* mov [bp-0xc], ax */
            ii(0x5174, 3);    mov(memw_a16[ss, bp - 0xa], si);          /* mov [bp-0xa], si */
            ii(0x5177, 3);    callw(0x4f7a, -0x200);                    /* call 0x4f7a */
            ii(0x517a, 2);    pushw(0x1);                               /* push 0x1 */
            ii(0x517c, 3);    callw(0x4856, -0x929);                    /* call 0x4856 */
            ii(0x517f, 1);    popw(bx);                                 /* pop bx */
            ii(0x5180, 2);    jmpw(0x51a0, 0x1e); goto l_0x51a0;        /* jmp 0x51a0 */
        l_0x5182:
            ii(0x5182, 3);    mov(bx, memw_a16[ss, bp - 0xc]);          /* mov bx, [bp-0xc] */
            ii(0x5185, 3);    shr(bx, 0x3);                             /* shr bx, 0x3 */
            ii(0x5188, 3);    les(di, ss, bp - 0x10);                   /* les di, [bp-0x10] */
            ii(0x518b, 4);    test(memb_a16[es, bx + di], 0x1);         /* test byte [es:bx+di], 0x1 */
            ii(0x518f, 2);    if(jzw(0x519c, 0xb)) goto l_0x519c;       /* jz 0x519c */
            ii(0x5191, 3);    pushw(memw_a16[ss, bp - 0xa]);            /* push word [bp-0xa] */
            ii(0x5194, 3);    pushw(memw_a16[ss, bp - 0xc]);            /* push word [bp-0xc] */
            ii(0x5197, 3);    callw(0x50a8, -0xf2);                     /* call 0x50a8 */
            ii(0x519a, 1);    popw(bx);                                 /* pop bx */
            ii(0x519b, 1);    popw(bx);                                 /* pop bx */
        l_0x519c:
            ii(0x519c, 4);    sub(memw_a16[ss, bp - 0xc], 0x8);         /* sub word [bp-0xc], 0x8 */
        l_0x51a0:
            ii(0x51a0, 5);    cmp(memw_a16[ss, bp - 0xc], 0x80);        /* cmp word [bp-0xc], 0x80 */
            ii(0x51a5, 2);    if(jaew(0x5182, -0x25)) goto l_0x5182;    /* jae 0x5182 */
            ii(0x51a7, 5);    mov(memw_a16[ss, bp - 0xc], 0x50);        /* mov word [bp-0xc], 0x50 */
            ii(0x51ac, 3);    pushw(memw_a16[ss, bp - 0xa]);            /* push word [bp-0xa] */
            ii(0x51af, 3);    pushw(memw_a16[ss, bp - 0xc]);            /* push word [bp-0xc] */
            ii(0x51b2, 3);    callw(0x50a8, -0x10d);                    /* call 0x50a8 */
            ii(0x51b5, 1);    popw(bx);                                 /* pop bx */
            ii(0x51b6, 1);    popw(bx);                                 /* pop bx */
            ii(0x51b7, 5);    mov(memw_a16[ss, bp - 0xc], 0x8);         /* mov word [bp-0xc], 0x8 */
            ii(0x51bc, 3);    pushw(memw_a16[ss, bp - 0xa]);            /* push word [bp-0xa] */
            ii(0x51bf, 3);    pushw(memw_a16[ss, bp - 0xc]);            /* push word [bp-0xc] */
            ii(0x51c2, 3);    callw(0x50a8, -0x11d);                    /* call 0x50a8 */
            ii(0x51c5, 1);    popw(bx);                                 /* pop bx */
            ii(0x51c6, 1);    popw(bx);                                 /* pop bx */
            ii(0x51c7, 5);    mov(memw_a16[ss, bp - 0xc], 0x70);        /* mov word [bp-0xc], 0x70 */
            ii(0x51cc, 5);    cmp(memb_a16[ds, 0x9f8], 0);              /* cmp byte [0x9f8], 0x0 */
            ii(0x51d1, 2);    if(jnzw(0x51e5, 0x12)) goto l_0x51e5;     /* jnz 0x51e5 */
            ii(0x51d3, 5);    test(memb_a16[ds, 0x47], 0x80);           /* test byte [0x47], 0x80 */
            ii(0x51d8, 2);    if(jnzw(0x51e5, 0xb)) goto l_0x51e5;      /* jnz 0x51e5 */
            ii(0x51da, 3);    pushw(memw_a16[ss, bp - 0xa]);            /* push word [bp-0xa] */
            ii(0x51dd, 3);    pushw(memw_a16[ss, bp - 0xc]);            /* push word [bp-0xc] */
            ii(0x51e0, 3);    callw(0x50a8, -0x13b);                    /* call 0x50a8 */
            ii(0x51e3, 1);    popw(bx);                                 /* pop bx */
            ii(0x51e4, 1);    popw(bx);                                 /* pop bx */
        l_0x51e5:
            ii(0x51e5, 3);    callw(0x4a28, -0x7c0);                    /* call 0x4a28 */
            ii(0x51e8, 3);    callw(0x47b1, -0xa3a);                    /* call 0x47b1 */
            ii(0x51eb, 5);    cmp(memb_a16[ds, 0x11d8], 0);             /* cmp byte [0x11d8], 0x0 */
            ii(0x51f0, 2);    if(jnzw(0x521f, 0x2d)) goto l_0x521f;     /* jnz 0x521f */
            ii(0x51f2, 3);    mov(ax, memw_a16[ds, 0x990]);             /* mov ax, [0x990] */
            ii(0x51f5, 4);    or(ax, memw_a16[ds, 0x98e]);              /* or ax, [0x98e] */
            ii(0x51f9, 2);    if(jzw(0x521f, 0x24)) goto l_0x521f;      /* jz 0x521f */
            ii(0x51fb, 5);    cmp(memw_a16[ds, 0x990], 0x10);           /* cmp word [0x990], 0x10 */
            ii(0x5200, 2);    if(jgw(0x521f, 0x1d)) goto l_0x521f;      /* jg 0x521f */
            ii(0x5202, 2);    if(jgew(0x521f, 0x1b)) goto l_0x521f;     /* jge 0x521f */
            ii(0x5204, 3);    mov(ax, memw_a16[ds, 0x98e]);             /* mov ax, [0x98e] */
            ii(0x5207, 4);    mov(dx, memw_a16[ds, 0x990]);             /* mov dx, [0x990] */
            ii(0x520b, 2);    mov(cl, 0x4);                             /* mov cl, 0x4 */
            ii(0x520d, 3);    callw(0x5da0, 0xb90);                     /* call 0x5da0 */
            ii(0x5210, 1);    pushw(ax);                                /* push ax */
            ii(0x5211, 3);    callw(0x5076, -0x19e);                    /* call 0x5076 */
            ii(0x5214, 1);    popw(bx);                                 /* pop bx */
            ii(0x5215, 2);    or(ax, ax);                               /* or ax, ax */
            ii(0x5217, 2);    if(jnzw(0x521f, 0x6)) goto l_0x521f;      /* jnz 0x521f */
            ii(0x5219, 2);    pushw(0x16);                              /* push 0x16 */
            ii(0x521b, 3);    callw(0x589d, 0x67f);                     /* call 0x589d */
            ii(0x521e, 1);    popw(bx);                                 /* pop bx */
        l_0x521f:
            ii(0x521f, 6);    mov(memw_a16[ds, 0x97e], 0);              /* mov word [0x97e], 0x0 */
            ii(0x5225, 6);    mov(memw_a16[ds, 0x97c], 0x2ff);          /* mov word [0x97c], 0x2ff */
            ii(0x522b, 1);    popw(si);                                 /* pop si */
            ii(0x522c, 1);    popw(di);                                 /* pop di */
            ii(0x522d, 1);    leavew();                                 /* leave */
            ii(0x522e, 1);    retw(); return;                           /* ret */
        }
    }
}
