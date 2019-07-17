using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("5a9d7950-0690-40e5-b231-201d42a49edb")]
        public void Method_0000_a1bd()
        {
            ii(0xa1bd, 4);    lsl(ax, memw_a16[ss, bp + 0x22]);         /* lsl ax, [bp+0x22] */
            ii(0xa1c1, 3);    sub(ax, memw_a16[ss, bp + 0x1e]);         /* sub ax, [bp+0x1e] */
            ii(0xa1c4, 2);    jbew_func(0xa1b8, -0xe);                  /* jbe 0xa1b8 */
            ii(0xa1c6, 4);    cmp(memw_a16[ss, bp + 0x1a], 0);          /* cmp word [bp+0x1a], 0x0 */
            ii(0xa1ca, 2);    jnzw_func(0xa187, -0x45);                 /* jnz 0xa187 */
            ii(0xa1cc, 3);    sub(ax, 0x4);                             /* sub ax, 0x4 */
            ii(0xa1cf, 2);    jbew_func(0xa1b8, -0x19);                 /* jbe 0xa1b8 */
            ii(0xa1d1, 3);    mov(cx, memw_a16[ss, bp + 0x4]);          /* mov cx, [bp+0x4] */
            ii(0xa1d4, 2);    jcxzw_func(0xa1b8, -0x1e);                /* jcxz 0xa1b8 */
            ii(0xa1d6, 3);    lsl(bx, cx);                              /* lsl bx, cx */
            ii(0xa1d9, 2);    mov(es, cx);                              /* mov es, cx */
            ii(0xa1db, 3);    mov(si, memw_a16[ss, bp + 0x1e]);         /* mov si, [bp+0x1e] */
            ii(0xa1de, 3);    mov(ds, memw_a16[ss, bp + 0x22]);         /* mov ds, [bp+0x22] */
            ii(0xa1e1, 1);    cld();                                    /* cld */
            ii(0xa1e2, 1);    lodsw_a16();                              /* lodsw */
            ii(0xa1e3, 3);    mov(cx, 0x2);                             /* mov cx, 0x2 */
            ii(0xa1e6, 3);    mov(di, memw_a16[ss, bp + 0xa]);          /* mov di, [bp+0xa] */
            ii(0xa1e9, 2);    cmp(bx, di);                              /* cmp bx, di */
            ii(0xa1eb, 2);    jbew_func(0xa1b8, -0x35);                 /* jbe 0xa1b8 */
            ii(0xa1ed, 3);    mov(bx, memw_a16[es, di]);                /* mov bx, [es:di] */
            ii(0xa1f0, 3);    mov(dx, memw_a16[ss, bp + 0x16]);         /* mov dx, [bp+0x16] */
            ii(0xa1f3, 3);    cmp(ax, 0x489);                           /* cmp ax, 0x489 */
            ii(0xa1f6, 2);    if(jzw(0xa21a, 0x22)) goto l_0xa21a;      /* jz 0xa21a */
            ii(0xa1f8, 2);    sub(dx, bx);                              /* sub dx, bx */
            ii(0xa1fa, 2);    neg(dx);                                  /* neg dx */
            ii(0xa1fc, 3);    cmp(ax, 0x429);                           /* cmp ax, 0x429 */
            ii(0xa1ff, 2);    if(jzw(0xa21a, 0x19)) goto l_0xa21a;      /* jz 0xa21a */
            ii(0xa201, 1);    inc(cx);                                  /* inc cx */
            ii(0xa202, 2);    mov(dx, bx);                              /* mov dx, bx */
            ii(0xa204, 2);    mov(dl, memb_a16[ds, si]);                /* mov dl, [si] */
            ii(0xa206, 3);    cmp(ax, 0x4c6);                           /* cmp ax, 0x4c6 */
            ii(0xa209, 2);    if(jzw(0xa21a, 0xf)) goto l_0xa21a;       /* jz 0xa21a */
            ii(0xa20b, 2);    or(dl, bl);                               /* or dl, bl */
            ii(0xa20d, 3);    cmp(ax, 0xc80);                           /* cmp ax, 0xc80 */
            ii(0xa210, 2);    if(jzw(0xa21a, 0x8)) goto l_0xa21a;       /* jz 0xa21a */
            ii(0xa212, 1);    inc(cx);                                  /* inc cx */
            ii(0xa213, 2);    mov(dx, memw_a16[ds, si]);                /* mov dx, [si] */
            ii(0xa215, 3);    cmp(ax, 0x4c7);                           /* cmp ax, 0x4c7 */
            ii(0xa218, 2);    jnzw_func(0xa1b8, -0x62);                 /* jnz 0xa1b8 */
        l_0xa21a:
            ii(0xa21a, 3);    add(memw_a16[ss, bp + 0x1e], cx);         /* add [bp+0x1e], cx */
            ii(0xa21d, 3);    mov(bx, memw_a16[ss, bp + 0x4]);          /* mov bx, [bp+0x4] */
            ii(0xa220, 3);    mov(ax, 0xa);                             /* mov ax, 0xa */
            ii(0xa223, 2);    @int(0x31);                              /* int 0x31 */
            ii(0xa225, 2);    jbw_func(0xa1b8, -0x6f);                  /* jb 0xa1b8 */
            ii(0xa227, 2);    mov(es, ax);                              /* mov es, ax */
            ii(0xa229, 2);    mov(bx, ax);                              /* mov bx, ax */
            ii(0xa22b, 3);    mov(di, memw_a16[ss, bp + 0xa]);          /* mov di, [bp+0xa] */
            ii(0xa22e, 3);    mov(memw_a16[es, di], dx);                /* mov [es:di], dx */
            ii(0xa231, 3);    mov(ax, 0x1);                             /* mov ax, 0x1 */
            ii(0xa234, 2);    @int(0x31);                              /* int 0x31 */
            ii(0xa236, 0);    jmpd_func(0xa236, 0);                     /* Принудительное завершение функции. */
        }
    }
}
