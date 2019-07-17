using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("44eca7f6-7d58-43eb-9d8c-c6f366b91f44")]
        public void Method_0000_5972()
        {
            ii(0x5972, 3);    mov(di, 0x1a2);                           /* mov di, 0x1a2 */
            ii(0x5975, 2);    mov(ss, di);                              /* mov ss, di */
            ii(0x5977, 4);    add(sp, 0x120e);                          /* add sp, 0x120e */
            ii(0x597b, 3);    mov(si, 0x35f);                           /* mov si, 0x35f */
            ii(0x597e, 2);    sub(si, di);                              /* sub si, di */
            ii(0x5980, 2);    mov(ax, si);                              /* mov ax, si */
            ii(0x5982, 2);    mov(cl, 0x4);                             /* mov cl, 0x4 */
            ii(0x5984, 2);    shl(ax, cl);                              /* shl ax, cl */
            ii(0x5986, 1);    dec(ax);                                  /* dec ax */
            ii(0x5987, 4);    mov(memw_a16[ss, 0xce6], ax);             /* mov [ss:0xce6], ax */
            ii(0x598b, 5);    mov(memw_a16[ss, 0xcdc], sp);             /* mov [ss:0xcdc], sp */
            ii(0x5990, 3);    mov(si, 0x10ca);                          /* mov si, 0x10ca */
            ii(0x5993, 1);    inc(si);                                  /* inc si */
            ii(0x5994, 4);    mov(memw_a16[ds, 0x2], si);               /* mov [0x2], si */
            ii(0x5998, 2);    mov(bx, es);                              /* mov bx, es */
            ii(0x599a, 2);    sub(bx, si);                              /* sub bx, si */
            ii(0x599c, 2);    neg(bx);                                  /* neg bx */
            ii(0x599e, 2);    mov(ah, 0x4a);                            /* mov ah, 0x4a */
            ii(0x59a0, 2);    @int(0x21);                              /* int 0x21 */
            ii(0x59a2, 5);    mov(memw_a16[ss, 0xcec], ds);             /* mov [ss:0xcec], ds */
            ii(0x59a7, 1);    pushw(ss);                                /* push ss */
            ii(0x59a8, 1);    popw(es);                                 /* pop es */
            ii(0x59a9, 1);    cld();                                    /* cld */
            ii(0x59aa, 3);    mov(di, 0x1186);                          /* mov di, 0x1186 */
            ii(0x59ad, 3);    mov(cx, 0x1210);                          /* mov cx, 0x1210 */
            ii(0x59b0, 2);    sub(cx, di);                              /* sub cx, di */
            ii(0x59b2, 2);    xor(ax, ax);                              /* xor ax, ax */
            ii(0x59b4, 2);    rep_a16(() => stosb_a16());               /* rep stosb */
            ii(0x59b6, 1);    pushw(ss);                                /* push ss */
            ii(0x59b7, 1);    popw(ds);                                 /* pop ds */
            ii(0x59b8, 2);    mov(ah, 0x30);                            /* mov ah, 0x30 */
            ii(0x59ba, 2);    @int(0x21);                              /* int 0x21 */
            ii(0x59bc, 3);    mov(memw_a16[ds, 0xcee], ax);             /* mov [0xcee], ax */
            ii(0x59bf, 3);    mov(bx, 0x4);                             /* mov bx, 0x4 */
        l_0x59c2:
            ii(0x59c2, 3);    mov(ax, 0x4400);                          /* mov ax, 0x4400 */
            ii(0x59c5, 2);    @int(0x21);                              /* int 0x21 */
            ii(0x59c7, 2);    if(jbw(0x59d3, 0xa)) goto l_0x59d3;       /* jb 0x59d3 */
            ii(0x59c9, 3);    test(dl, 0x80);                           /* test dl, 0x80 */
            ii(0x59cc, 2);    if(jzw(0x59d3, 0x5)) goto l_0x59d3;       /* jz 0x59d3 */
            ii(0x59ce, 5);    or(memb_a16[ds, bx + 0xcfa], 0x40);       /* or byte [bx+0xcfa], 0x40 */
        l_0x59d3:
            ii(0x59d3, 1);    dec(bx);                                  /* dec bx */
            ii(0x59d4, 2);    if(jnsw(0x59c2, -0x14)) goto l_0x59c2;    /* jns 0x59c2 */
            ii(0x59d6, 3);    callw(0x5a50, 0x77);                      /* call 0x5a50 */
            ii(0x59d9, 2);    xor(bp, bp);                              /* xor bp, bp */
            ii(0x59db, 1);    pushw(ss);                                /* push ss */
            ii(0x59dc, 1);    popw(ds);                                 /* pop ds */
            ii(0x59dd, 4);    pushw(memw_a16[ds, 0xcf6]);               /* push word [0xcf6] */
            ii(0x59e1, 4);    pushw(memw_a16[ds, 0xcf4]);               /* push word [0xcf4] */
            ii(0x59e5, 4);    pushw(memw_a16[ds, 0xcf2]);               /* push word [0xcf2] */
            ii(0x59e9, 3);    callw(0x638c, 0x9a0);                     /* call 0x638c */
            ii(0x59ec, 1);    retw();                                   /* ret */
        }
    }
}
