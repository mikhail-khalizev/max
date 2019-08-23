using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x58aa-f0bba765")]
        public void Method_0000_58aa()
        {
            ii(0x58aa, 4);    enterw(0x10, 0);                          /* enter 0x10, 0x0 */
            ii(0x58ae, 1);    pushw(di);                                /* push di */
            ii(0x58af, 1);    pushw(si);                                /* push si */
            ii(0x58b0, 2);    sub(ax, ax);                              /* sub ax, ax */
            ii(0x58b2, 3);    mov(memw_a16[ds, 0xd60], ax);             /* mov [0xd60], ax */
            ii(0x58b5, 3);    mov(memw_a16[ds, 0xd62], ax);             /* mov [0xd62], ax */
            ii(0x58b8, 3);    mov(ax, memw_a16[ds, 0x990]);             /* mov ax, [0x990] */
            ii(0x58bb, 4);    or(ax, memw_a16[ds, 0x98e]);              /* or ax, [0x98e] */
            ii(0x58bf, 2);    if(jnzw(0x58c4, 0x3)) goto l_0x58c4;      /* jnz 0x58c4 */
            ii(0x58c1, 3);    jmpw(0x59cf, 0x10b); goto l_0x59cf;       /* jmp 0x59cf */
        l_0x58c4:
            ii(0x58c4, 3);    mov(ax, 0x938);                           /* mov ax, 0x938 */
            ii(0x58c7, 1);    pushw(si);                                /* push si */
            ii(0x58c8, 2);    mov(di, ax);                              /* mov di, ax */
            ii(0x58ca, 3);    mov(si, 0x8c8);                           /* mov si, 0x8c8 */
            ii(0x58cd, 1);    pushw(ds);                                /* push ds */
            ii(0x58ce, 1);    popw(es);                                 /* pop es */
            ii(0x58cf, 1);    movsw_a16();                              /* movsw */
            ii(0x58d0, 1);    movsw_a16();                              /* movsw */
            ii(0x58d1, 1);    movsw_a16();                              /* movsw */
            ii(0x58d2, 1);    movsw_a16();                              /* movsw */
            ii(0x58d3, 1);    popw(si);                                 /* pop si */
            ii(0x58d4, 3);    mov(si, 0x8);                             /* mov si, 0x8 */
            ii(0x58d7, 5);    cmp(memb_a16[ds, 0x11d8], 0);             /* cmp byte [0x11d8], 0x0 */
            ii(0x58dc, 2);    if(jnzw(0x5912, 0x34)) goto l_0x5912;     /* jnz 0x5912 */
            ii(0x58de, 2);    pushw(0x50);                              /* push 0x50 */
            ii(0x58e0, 3);    callw(0x59df, 0xfc);                      /* call 0x59df */
            ii(0x58e3, 1);    popw(bx);                                 /* pop bx */
            ii(0x58e4, 1);    pushw(si);                                /* push si */
            ii(0x58e5, 3);    lea(di, bp - 0x8);                        /* lea di, [bp-0x8] */
            ii(0x58e8, 3);    mov(si, 0x11e4);                          /* mov si, 0x11e4 */
            ii(0x58eb, 1);    pushw(ss);                                /* push ss */
            ii(0x58ec, 1);    popw(es);                                 /* pop es */
            ii(0x58ed, 1);    movsw_a16();                              /* movsw */
            ii(0x58ee, 1);    movsw_a16();                              /* movsw */
            ii(0x58ef, 1);    movsw_a16();                              /* movsw */
            ii(0x58f0, 1);    movsw_a16();                              /* movsw */
            ii(0x58f1, 1);    popw(si);                                 /* pop si */
            ii(0x58f2, 3);    callw(0x573a, -0x1bb);                    /* call 0x573a */
            ii(0x58f5, 5);    cmp(memw_a16[ds, 0xa14], 0);              /* cmp word [0xa14], 0x0 */
            ii(0x58fa, 2);    if(jnzw(0x58ff, 0x3)) goto l_0x58ff;      /* jnz 0x58ff */
            ii(0x58fc, 3);    callw(0x3f0c, -0x19f3);                   /* call 0x3f0c */
        l_0x58ff:
            ii(0x58ff, 3);    mov(ax, 0x910);                           /* mov ax, 0x910 */
            ii(0x5902, 1);    pushw(si);                                /* push si */
            ii(0x5903, 2);    mov(di, ax);                              /* mov di, ax */
            ii(0x5905, 3);    lea(si, bp - 0x8);                        /* lea si, [bp-0x8] */
            ii(0x5908, 1);    pushw(ds);                                /* push ds */
            ii(0x5909, 1);    popw(es);                                 /* pop es */
            ii(0x590a, 1);    movsw_a16();                              /* movsw */
            ii(0x590b, 1);    movsw_a16();                              /* movsw */
            ii(0x590c, 1);    movsw_a16();                              /* movsw */
            ii(0x590d, 1);    movsw_a16();                              /* movsw */
            ii(0x590e, 1);    popw(si);                                 /* pop si */
            ii(0x590f, 3);    mov(si, 0x78);                            /* mov si, 0x78 */
        l_0x5912:
            ii(0x5912, 5);    mov(memw_a16[ss, bp - 0x10], 0);          /* mov word [bp-0x10], 0x0 */
            ii(0x5917, 5);    mov(memw_a16[ss, bp - 0xe], 0x50);        /* mov word [bp-0xe], 0x50 */
            ii(0x591c, 3);    mov(ax, memw_a16[ds, 0x938]);             /* mov ax, [0x938] */
            ii(0x591f, 2);    and(al, 0xf8);                            /* and al, 0xf8 */
            ii(0x5921, 3);    mov(memw_a16[ss, bp - 0xc], ax);          /* mov [bp-0xc], ax */
            ii(0x5924, 3);    mov(memw_a16[ss, bp - 0xa], si);          /* mov [bp-0xa], si */
            ii(0x5927, 3);    callw(0x572a, -0x200);                    /* call 0x572a */
            ii(0x592a, 2);    pushw(0x1);                               /* push 0x1 */
            ii(0x592c, 3);    callw(0x5006, -0x929);                    /* call 0x5006 */
            ii(0x592f, 1);    popw(bx);                                 /* pop bx */
            ii(0x5930, 2);    jmpw(0x5950, 0x1e); goto l_0x5950;        /* jmp 0x5950 */
        l_0x5932:
            ii(0x5932, 3);    mov(bx, memw_a16[ss, bp - 0xc]);          /* mov bx, [bp-0xc] */
            ii(0x5935, 3);    shr(bx, 0x3);                             /* shr bx, 0x3 */
            ii(0x5938, 3);    les(di, ss, bp - 0x10);                   /* les di, [bp-0x10] */
            ii(0x593b, 4);    test(memb_a16[es, bx + di], 0x1);         /* test byte [es:bx+di], 0x1 */
            ii(0x593f, 2);    if(jzw(0x594c, 0xb)) goto l_0x594c;       /* jz 0x594c */
            ii(0x5941, 3);    pushw(memw_a16[ss, bp - 0xa]);            /* push word [bp-0xa] */
            ii(0x5944, 3);    pushw(memw_a16[ss, bp - 0xc]);            /* push word [bp-0xc] */
            ii(0x5947, 3);    callw(0x5858, -0xf2);                     /* call 0x5858 */
            ii(0x594a, 1);    popw(bx);                                 /* pop bx */
            ii(0x594b, 1);    popw(bx);                                 /* pop bx */
        l_0x594c:
            ii(0x594c, 4);    sub(memw_a16[ss, bp - 0xc], 0x8);         /* sub word [bp-0xc], 0x8 */
        l_0x5950:
            ii(0x5950, 5);    cmp(memw_a16[ss, bp - 0xc], 0x80);        /* cmp word [bp-0xc], 0x80 */
            ii(0x5955, 2);    if(jaew(0x5932, -0x25)) goto l_0x5932;    /* jae 0x5932 */
            ii(0x5957, 5);    mov(memw_a16[ss, bp - 0xc], 0x50);        /* mov word [bp-0xc], 0x50 */
            ii(0x595c, 3);    pushw(memw_a16[ss, bp - 0xa]);            /* push word [bp-0xa] */
            ii(0x595f, 3);    pushw(memw_a16[ss, bp - 0xc]);            /* push word [bp-0xc] */
            ii(0x5962, 3);    callw(0x5858, -0x10d);                    /* call 0x5858 */
            ii(0x5965, 1);    popw(bx);                                 /* pop bx */
            ii(0x5966, 1);    popw(bx);                                 /* pop bx */
            ii(0x5967, 5);    mov(memw_a16[ss, bp - 0xc], 0x8);         /* mov word [bp-0xc], 0x8 */
            ii(0x596c, 3);    pushw(memw_a16[ss, bp - 0xa]);            /* push word [bp-0xa] */
            ii(0x596f, 3);    pushw(memw_a16[ss, bp - 0xc]);            /* push word [bp-0xc] */
            ii(0x5972, 3);    callw(0x5858, -0x11d);                    /* call 0x5858 */
            ii(0x5975, 1);    popw(bx);                                 /* pop bx */
            ii(0x5976, 1);    popw(bx);                                 /* pop bx */
            ii(0x5977, 5);    mov(memw_a16[ss, bp - 0xc], 0x70);        /* mov word [bp-0xc], 0x70 */
            ii(0x597c, 5);    cmp(memb_a16[ds, 0x9f8], 0);              /* cmp byte [0x9f8], 0x0 */
            ii(0x5981, 2);    if(jnzw(0x5995, 0x12)) goto l_0x5995;     /* jnz 0x5995 */
            ii(0x5983, 5);    test(memb_a16[ds, 0x47], 0x80);           /* test byte [0x47], 0x80 */
            ii(0x5988, 2);    if(jnzw(0x5995, 0xb)) goto l_0x5995;      /* jnz 0x5995 */
            ii(0x598a, 3);    pushw(memw_a16[ss, bp - 0xa]);            /* push word [bp-0xa] */
            ii(0x598d, 3);    pushw(memw_a16[ss, bp - 0xc]);            /* push word [bp-0xc] */
            ii(0x5990, 3);    callw(0x5858, -0x13b);                    /* call 0x5858 */
            ii(0x5993, 1);    popw(bx);                                 /* pop bx */
            ii(0x5994, 1);    popw(bx);                                 /* pop bx */
        l_0x5995:
            ii(0x5995, 3);    callw(0x51d8, -0x7c0);                    /* call 0x51d8 */
            ii(0x5998, 3);    callw(0x4f61, -0xa3a);                    /* call 0x4f61 */
            ii(0x599b, 5);    cmp(memb_a16[ds, 0x11d8], 0);             /* cmp byte [0x11d8], 0x0 */
            ii(0x59a0, 2);    if(jnzw(0x59cf, 0x2d)) goto l_0x59cf;     /* jnz 0x59cf */
            ii(0x59a2, 3);    mov(ax, memw_a16[ds, 0x990]);             /* mov ax, [0x990] */
            ii(0x59a5, 4);    or(ax, memw_a16[ds, 0x98e]);              /* or ax, [0x98e] */
            ii(0x59a9, 2);    if(jzw(0x59cf, 0x24)) goto l_0x59cf;      /* jz 0x59cf */
            ii(0x59ab, 5);    cmp(memw_a16[ds, 0x990], 0x10);           /* cmp word [0x990], 0x10 */
            ii(0x59b0, 2);    if(jgw(0x59cf, 0x1d)) goto l_0x59cf;      /* jg 0x59cf */
            ii(0x59b2, 2);    if(jgew(0x59cf, 0x1b)) goto l_0x59cf;     /* jge 0x59cf */
            ii(0x59b4, 3);    mov(ax, memw_a16[ds, 0x98e]);             /* mov ax, [0x98e] */
            ii(0x59b7, 4);    mov(dx, memw_a16[ds, 0x990]);             /* mov dx, [0x990] */
            ii(0x59bb, 2);    mov(cl, 0x4);                             /* mov cl, 0x4 */
            ii(0x59bd, 3);    callw(0x6550, 0xb90);                     /* call 0x6550 */
            ii(0x59c0, 1);    pushw(ax);                                /* push ax */
            ii(0x59c1, 3);    callw(0x5826, -0x19e);                    /* call 0x5826 */
            ii(0x59c4, 1);    popw(bx);                                 /* pop bx */
            ii(0x59c5, 2);    or(ax, ax);                               /* or ax, ax */
            ii(0x59c7, 2);    if(jnzw(0x59cf, 0x6)) goto l_0x59cf;      /* jnz 0x59cf */
            ii(0x59c9, 2);    pushw(0x16);                              /* push 0x16 */
            ii(0x59cb, 3);    callw(0x604d, 0x67f);                     /* call 0x604d */
            ii(0x59ce, 1);    popw(bx);                                 /* pop bx */
        l_0x59cf:
            ii(0x59cf, 6);    mov(memw_a16[ds, 0x97e], 0);              /* mov word [0x97e], 0x0 */
            ii(0x59d5, 6);    mov(memw_a16[ds, 0x97c], 0x2ff);          /* mov word [0x97c], 0x2ff */
            ii(0x59db, 1);    popw(si);                                 /* pop si */
            ii(0x59dc, 1);    popw(di);                                 /* pop di */
            ii(0x59dd, 1);    leavew();                                 /* leave */
            ii(0x59de, 1);    retw();                                   /* ret */
        }
    }
}
