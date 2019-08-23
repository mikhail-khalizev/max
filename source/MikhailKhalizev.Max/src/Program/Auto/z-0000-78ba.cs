using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x78ba-f0bba765")]
        public void Method_0000_78ba()
        {
            ii(0x78ba, 4);    enter(0x10, 0);                           /* enter 0x10, 0x0 */
            ii(0x78be, 1);    push(di);                                 /* push di */
            ii(0x78bf, 1);    push(si);                                 /* push si */
            ii(0x78c0, 2);    sub(ax, ax);                              /* sub ax, ax */
            ii(0x78c2, 3);    mov(memw[ds, 0xd60], ax);                 /* mov [0xd60], ax */
            ii(0x78c5, 3);    mov(memw[ds, 0xd62], ax);                 /* mov [0xd62], ax */
            ii(0x78c8, 3);    mov(ax, memw[ds, 0x990]);                 /* mov ax, [0x990] */
            ii(0x78cb, 4);    or(ax, memw[ds, 0x98e]);                  /* or ax, [0x98e] */
            ii(0x78cf, 2);    if(jnz(0x78d4, 0x3)) goto l_0x78d4;       /* jnz 0x78d4 */
            ii(0x78d1, 3);    jmp(0x79df, 0x10b); goto l_0x79df;        /* jmp 0x79df */
        l_0x78d4:
            ii(0x78d4, 3);    mov(ax, 0x938);                           /* mov ax, 0x938 */
            ii(0x78d7, 1);    push(si);                                 /* push si */
            ii(0x78d8, 2);    mov(di, ax);                              /* mov di, ax */
            ii(0x78da, 3);    mov(si, 0x8c8);                           /* mov si, 0x8c8 */
            ii(0x78dd, 1);    push(ds);                                 /* push ds */
            ii(0x78de, 1);    pop(es);                                  /* pop es */
            ii(0x78df, 1);    movsw();                                  /* movsw */
            ii(0x78e0, 1);    movsw();                                  /* movsw */
            ii(0x78e1, 1);    movsw();                                  /* movsw */
            ii(0x78e2, 1);    movsw();                                  /* movsw */
            ii(0x78e3, 1);    pop(si);                                  /* pop si */
            ii(0x78e4, 3);    mov(si, 0x8);                             /* mov si, 0x8 */
            ii(0x78e7, 5);    cmp(memb[ds, 0x11d8], 0);                 /* cmp byte [0x11d8], 0x0 */
            ii(0x78ec, 2);    if(jnz(0x7922, 0x34)) goto l_0x7922;      /* jnz 0x7922 */
            ii(0x78ee, 2);    push(0x50);                               /* push 0x50 */
            ii(0x78f0, 3);    call(0x79ef, 0xfc);                       /* call 0x79ef */
            ii(0x78f3, 1);    pop(bx);                                  /* pop bx */
            ii(0x78f4, 1);    push(si);                                 /* push si */
            ii(0x78f5, 3);    lea(di, memw[ss, bp - 0x8]);              /* lea di, [bp-0x8] */
            ii(0x78f8, 3);    mov(si, 0x11e4);                          /* mov si, 0x11e4 */
            ii(0x78fb, 1);    push(ss);                                 /* push ss */
            ii(0x78fc, 1);    pop(es);                                  /* pop es */
            ii(0x78fd, 1);    movsw();                                  /* movsw */
            ii(0x78fe, 1);    movsw();                                  /* movsw */
            ii(0x78ff, 1);    movsw();                                  /* movsw */
            ii(0x7900, 1);    movsw();                                  /* movsw */
            ii(0x7901, 1);    pop(si);                                  /* pop si */
            ii(0x7902, 3);    call(0x774a, -0x1bb);                     /* call 0x774a */
            ii(0x7905, 5);    cmp(memw[ds, 0xa14], 0);                  /* cmp word [0xa14], 0x0 */
            ii(0x790a, 2);    if(jnz(0x790f, 0x3)) goto l_0x790f;       /* jnz 0x790f */
            ii(0x790c, 3);    call(0x5f1c, -0x19f3);                    /* call 0x5f1c */
        l_0x790f:
            ii(0x790f, 3);    mov(ax, 0x910);                           /* mov ax, 0x910 */
            ii(0x7912, 1);    push(si);                                 /* push si */
            ii(0x7913, 2);    mov(di, ax);                              /* mov di, ax */
            ii(0x7915, 3);    lea(si, memw[ss, bp - 0x8]);              /* lea si, [bp-0x8] */
            ii(0x7918, 1);    push(ds);                                 /* push ds */
            ii(0x7919, 1);    pop(es);                                  /* pop es */
            ii(0x791a, 1);    movsw();                                  /* movsw */
            ii(0x791b, 1);    movsw();                                  /* movsw */
            ii(0x791c, 1);    movsw();                                  /* movsw */
            ii(0x791d, 1);    movsw();                                  /* movsw */
            ii(0x791e, 1);    pop(si);                                  /* pop si */
            ii(0x791f, 3);    mov(si, 0x78);                            /* mov si, 0x78 */
        l_0x7922:
            ii(0x7922, 5);    mov(memw[ss, bp - 0x10], 0);              /* mov word [bp-0x10], 0x0 */
            ii(0x7927, 5);    mov(memw[ss, bp - 0xe], 0x50);            /* mov word [bp-0xe], 0x50 */
            ii(0x792c, 3);    mov(ax, memw[ds, 0x938]);                 /* mov ax, [0x938] */
            ii(0x792f, 2);    and(al, 0xf8);                            /* and al, 0xf8 */
            ii(0x7931, 3);    mov(memw[ss, bp - 0xc], ax);              /* mov [bp-0xc], ax */
            ii(0x7934, 3);    mov(memw[ss, bp - 0xa], si);              /* mov [bp-0xa], si */
            ii(0x7937, 3);    call(0x773a, -0x200);                     /* call 0x773a */
            ii(0x793a, 2);    push(0x1);                                /* push 0x1 */
            ii(0x793c, 3);    call(0x7016, -0x929);                     /* call 0x7016 */
            ii(0x793f, 1);    pop(bx);                                  /* pop bx */
            ii(0x7940, 2);    jmp(0x7960, 0x1e); goto l_0x7960;         /* jmp 0x7960 */
        l_0x7942:
            ii(0x7942, 3);    mov(bx, memw[ss, bp - 0xc]);              /* mov bx, [bp-0xc] */
            ii(0x7945, 3);    shr(bx, 0x3);                             /* shr bx, 0x3 */
            ii(0x7948, 3);    les(di, memw[ss, bp - 0x10]);             /* les di, [bp-0x10] */
            ii(0x794b, 4);    test(memb[es, bx + di], 0x1);             /* test byte [es:bx+di], 0x1 */
            ii(0x794f, 2);    if(jz(0x795c, 0xb)) goto l_0x795c;        /* jz 0x795c */
            ii(0x7951, 3);    push(memw[ss, bp - 0xa]);                 /* push word [bp-0xa] */
            ii(0x7954, 3);    push(memw[ss, bp - 0xc]);                 /* push word [bp-0xc] */
            ii(0x7957, 3);    call(0x7868, -0xf2);                      /* call 0x7868 */
            ii(0x795a, 1);    pop(bx);                                  /* pop bx */
            ii(0x795b, 1);    pop(bx);                                  /* pop bx */
        l_0x795c:
            ii(0x795c, 4);    sub(memw[ss, bp - 0xc], 0x8);             /* sub word [bp-0xc], 0x8 */
        l_0x7960:
            ii(0x7960, 5);    cmp(memw[ss, bp - 0xc], 0x80);            /* cmp word [bp-0xc], 0x80 */
            ii(0x7965, 2);    if(jae(0x7942, -0x25)) goto l_0x7942;     /* jae 0x7942 */
            ii(0x7967, 5);    mov(memw[ss, bp - 0xc], 0x50);            /* mov word [bp-0xc], 0x50 */
            ii(0x796c, 3);    push(memw[ss, bp - 0xa]);                 /* push word [bp-0xa] */
            ii(0x796f, 3);    push(memw[ss, bp - 0xc]);                 /* push word [bp-0xc] */
            ii(0x7972, 3);    call(0x7868, -0x10d);                     /* call 0x7868 */
            ii(0x7975, 1);    pop(bx);                                  /* pop bx */
            ii(0x7976, 1);    pop(bx);                                  /* pop bx */
            ii(0x7977, 5);    mov(memw[ss, bp - 0xc], 0x8);             /* mov word [bp-0xc], 0x8 */
            ii(0x797c, 3);    push(memw[ss, bp - 0xa]);                 /* push word [bp-0xa] */
            ii(0x797f, 3);    push(memw[ss, bp - 0xc]);                 /* push word [bp-0xc] */
            ii(0x7982, 3);    call(0x7868, -0x11d);                     /* call 0x7868 */
            ii(0x7985, 1);    pop(bx);                                  /* pop bx */
            ii(0x7986, 1);    pop(bx);                                  /* pop bx */
            ii(0x7987, 5);    mov(memw[ss, bp - 0xc], 0x70);            /* mov word [bp-0xc], 0x70 */
            ii(0x798c, 5);    cmp(memb[ds, 0x9f8], 0);                  /* cmp byte [0x9f8], 0x0 */
            ii(0x7991, 2);    if(jnz(0x79a5, 0x12)) goto l_0x79a5;      /* jnz 0x79a5 */
            ii(0x7993, 5);    test(memb[ds, 0x47], 0x80);               /* test byte [0x47], 0x80 */
            ii(0x7998, 2);    if(jnz(0x79a5, 0xb)) goto l_0x79a5;       /* jnz 0x79a5 */
            ii(0x799a, 3);    push(memw[ss, bp - 0xa]);                 /* push word [bp-0xa] */
            ii(0x799d, 3);    push(memw[ss, bp - 0xc]);                 /* push word [bp-0xc] */
            ii(0x79a0, 3);    call(0x7868, -0x13b);                     /* call 0x7868 */
            ii(0x79a3, 1);    pop(bx);                                  /* pop bx */
            ii(0x79a4, 1);    pop(bx);                                  /* pop bx */
        l_0x79a5:
            ii(0x79a5, 3);    call(0x71e8, -0x7c0);                     /* call 0x71e8 */
            ii(0x79a8, 3);    call(0x6f71, -0xa3a);                     /* call 0x6f71 */
            ii(0x79ab, 5);    cmp(memb[ds, 0x11d8], 0);                 /* cmp byte [0x11d8], 0x0 */
            ii(0x79b0, 2);    if(jnz(0x79df, 0x2d)) goto l_0x79df;      /* jnz 0x79df */
            ii(0x79b2, 3);    mov(ax, memw[ds, 0x990]);                 /* mov ax, [0x990] */
            ii(0x79b5, 4);    or(ax, memw[ds, 0x98e]);                  /* or ax, [0x98e] */
            ii(0x79b9, 2);    if(jz(0x79df, 0x24)) goto l_0x79df;       /* jz 0x79df */
            ii(0x79bb, 5);    cmp(memw[ds, 0x990], 0x10);               /* cmp word [0x990], 0x10 */
            ii(0x79c0, 2);    if(jg(0x79df, 0x1d)) goto l_0x79df;       /* jg 0x79df */
            ii(0x79c2, 2);    if(jge(0x79df, 0x1b)) goto l_0x79df;      /* jge 0x79df */
            ii(0x79c4, 3);    mov(ax, memw[ds, 0x98e]);                 /* mov ax, [0x98e] */
            ii(0x79c7, 4);    mov(dx, memw[ds, 0x990]);                 /* mov dx, [0x990] */
            ii(0x79cb, 2);    mov(cl, 0x4);                             /* mov cl, 0x4 */
            ii(0x79cd, 3);    call(0x8560, 0xb90);                      /* call 0x8560 */
            ii(0x79d0, 1);    push(ax);                                 /* push ax */
            ii(0x79d1, 3);    call(0x7836, -0x19e);                     /* call 0x7836 */
            ii(0x79d4, 1);    pop(bx);                                  /* pop bx */
            ii(0x79d5, 2);    or(ax, ax);                               /* or ax, ax */
            ii(0x79d7, 2);    if(jnz(0x79df, 0x6)) goto l_0x79df;       /* jnz 0x79df */
            ii(0x79d9, 2);    push(0x16);                               /* push 0x16 */
            ii(0x79db, 3);    call(0x805d, 0x67f);                      /* call 0x805d */
            ii(0x79de, 1);    pop(bx);                                  /* pop bx */
        l_0x79df:
            ii(0x79df, 6);    mov(memw[ds, 0x97e], 0);                  /* mov word [0x97e], 0x0 */
            ii(0x79e5, 6);    mov(memw[ds, 0x97c], 0x2ff);              /* mov word [0x97c], 0x2ff */
            ii(0x79eb, 1);    pop(si);                                  /* pop si */
            ii(0x79ec, 1);    pop(di);                                  /* pop di */
            ii(0x79ed, 1);    leave();                                  /* leave */
            ii(0x79ee, 1);    ret();                                    /* ret */
        }
    }
}
