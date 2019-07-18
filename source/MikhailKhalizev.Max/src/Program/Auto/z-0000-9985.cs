using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("30965489-c4a9-4713-8002-e543b1a98990")]
        public void Method_0000_9985()
        {
            ii(0x9985, 1);    pushw(es);                                /* push es */
            ii(0x9986, 3);    mov(di, 0x6341);                          /* mov di, 0x6341 */
        l_0x9989:
            ii(0x9989, 3);    add(di, 0xe);                             /* add di, 0xe */
            ii(0x998c, 4);    cmp(memw_a16[cs, di], 0x1);               /* cmp word [cs:di], 0x1 */
            ii(0x9990, 2);    if(jzw(0x9997, 0x5)) goto l_0x9997;       /* jz 0x9997 */
            ii(0x9992, 3);    cmp(memw_a16[cs, di], si);                /* cmp [cs:di], si */
            ii(0x9995, 2);    if(jnzw(0x9989, -0xe)) goto l_0x9989;     /* jnz 0x9989 */
        l_0x9997:
            ii(0x9997, 1);    pushw(si);                                /* push si */
            ii(0x9998, 2);    mov(si, di);                              /* mov si, di */
            ii(0x999a, 1);    pushw(ss);                                /* push ss */
            ii(0x999b, 1);    popw(es);                                 /* pop es */
            ii(0x999c, 3);    mov(di, 0x4a);                            /* mov di, 0x4a */
            ii(0x999f, 1);    cld();                                    /* cld */
            ii(0x99a0, 1);    lodsw_a16();                              /* lodsw */
            ii(0x99a1, 3);    mov(cx, 0x6);                             /* mov cx, 0x6 */
            ii(0x99a4, 3);    rep_a16(() => movsw_a16(cs)); 
            ii(0x99a7, 1);    popw(si);                                 /* pop si */
            ii(0x99a8, 5);    cmp(memb_a16[ds, 0x34], 0x15);            /* cmp byte [0x34], 0x15 */
            ii(0x99ad, 2);    if(jnzw(0x99b4, 0x5)) goto l_0x99b4;      /* jnz 0x99b4 */
            ii(0x99af, 5);    mov(memb_a16[ds, 0x34], 0x7f);            /* mov byte [0x34], 0x7f */
        l_0x99b4:
            ii(0x99b4, 3);    mov(bx, 0);                               /* mov bx, 0x0 */
            ii(0x99b7, 2);    mov(es, bx);                              /* mov es, bx */
            ii(0x99b9, 4);    mov(bl, memb_a16[ds, 0x34]);              /* mov bl, [0x34] */
            ii(0x99bd, 3);    shl(bx, 0x2);                             /* shl bx, 0x2 */
            ii(0x99c0, 3);    lds(di, es, bx);                          /* lds di, [es:bx] */
            ii(0x99c3, 2);    mov(ax, ds);                              /* mov ax, ds */
            ii(0x99c5, 4);    mov(memw_a16[ss, 0xf86], ax);             /* mov [ss:0xf86], ax */
            ii(0x99c9, 5);    mov(memw_a16[ss, 0xf84], di);             /* mov [ss:0xf84], di */
            ii(0x99ce, 3);    sub(ax, memw_a16[ds, di - 0x2]);          /* sub ax, [di-0x2] */
            ii(0x99d1, 3);    sub(di, memw_a16[ds, di - 0x4]);          /* sub di, [di-0x4] */
            ii(0x99d4, 1);    pushw(ss);                                /* push ss */
            ii(0x99d5, 1);    popw(ds);                                 /* pop ds */
            ii(0x99d6, 2);    or(ax, di);                               /* or ax, di */
            ii(0x99d8, 2);    if(jzw(0x99e3, 0x9)) goto l_0x99e3;       /* jz 0x99e3 */
            ii(0x99da, 5);    mov(memw_a16[es, bx], 0x9f9);             /* mov word [es:bx], 0x9f9 */
            ii(0x99df, 4);    mov(memw_a16[es, bx + 0x2], ds);          /* mov [es:bx+0x2], ds */
        l_0x99e3:
            ii(0x99e3, 3);    mov(al, memb_a16[ds, 0x34]);              /* mov al, [0x34] */
            ii(0x99e6, 4);    mov(memb_a16[cs, 0xef5], al);             /* mov [cs:0xef5], al */
            ii(0x99ea, 4);    mov(memb_a16[cs, -0x6781], al);           /* mov [cs:0x987f], al */
            ii(0x99ee, 1);    popw(es);                                 /* pop es */
            ii(0x99ef, 1);    retw();                                   /* ret */
        }
    }
}
