using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("11eb1511-1872-44e3-a0ea-f85ebd64f063")]
        public void Method_0015_3c42()
        {
            ii(0x15_3c42, 3); mov(cx, memw_a16[ss, bp + 0xe]);          /* mov cx, [bp+0xe] */
            ii(0x15_3c45, 3); mov(ax, memw_a16[ss, bp + 0x6]);          /* mov ax, [bp+0x6] */
            ii(0x15_3c48, 3); mov(dx, memw_a16[ss, bp + 0x8]);          /* mov dx, [bp+0x8] */
            ii(0x15_3c4b, 1); pushw(ds);                                /* push ds */
            ii(0x15_3c4c, 3); lds(di, ss, bp + 0xa);                    /* lds di, [bp+0xa] */
            ii(0x15_3c4f, 1); pushw(di);                                /* push di */
            ii(0x15_3c50, 1); pushw(ds);                                /* push ds */
            ii(0x15_3c51, 1); popw(es);                                 /* pop es */
            ii(0x15_3c52, 1); cld();                                    /* cld */
            ii(0x15_3c53, 1); xchg(bx, ax);                             /* xchg bx, ax */
            ii(0x15_3c54, 2); or(al, al);                               /* or al, al */
            ii(0x15_3c56, 2); if(jzw(0x15_3c6b, 0x13)) goto l_0x15_3c6b; /* jz 0x3c6b */
            ii(0x15_3c58, 3); cmp(cx, 0xa);                             /* cmp cx, 0xa */
            ii(0x15_3c5b, 2); if(jnzw(0x15_3c6b, 0xe)) goto l_0x15_3c6b; /* jnz 0x3c6b */
            ii(0x15_3c5d, 2); or(dx, dx);                               /* or dx, dx */
            ii(0x15_3c5f, 2); if(jnsw(0x15_3c6b, 0xa)) goto l_0x15_3c6b; /* jns 0x3c6b */
            ii(0x15_3c61, 2); mov(al, 0x2d);                            /* mov al, 0x2d */
            ii(0x15_3c63, 1); stosb_a16();                              /* stosb */
            ii(0x15_3c64, 2); neg(bx);                                  /* neg bx */
            ii(0x15_3c66, 3); adc(dx, 0);                               /* adc dx, 0x0 */
            ii(0x15_3c69, 2); neg(dx);                                  /* neg dx */
        l_0x15_3c6b:
            ii(0x15_3c6b, 2); mov(si, di);                              /* mov si, di */
        l_0x15_3c6d:
            ii(0x15_3c6d, 1); xchg(dx, ax);                             /* xchg dx, ax */
            ii(0x15_3c6e, 2); xor(dx, dx);                              /* xor dx, dx */
            ii(0x15_3c70, 2); or(ax, ax);                               /* or ax, ax */
            ii(0x15_3c72, 2); if(jzw(0x15_3c76, 0x2)) goto l_0x15_3c76; /* jz 0x3c76 */
            ii(0x15_3c74, 2); div(cx);                                  /* div cx */
        l_0x15_3c76:
            ii(0x15_3c76, 1); xchg(bx, ax);                             /* xchg bx, ax */
            ii(0x15_3c77, 2); div(cx);                                  /* div cx */
            ii(0x15_3c79, 1); xchg(dx, ax);                             /* xchg dx, ax */
            ii(0x15_3c7a, 2); xchg(bx, dx);                             /* xchg bx, dx */
            ii(0x15_3c7c, 2); add(al, 0x30);                            /* add al, 0x30 */
            ii(0x15_3c7e, 2); cmp(al, 0x39);                            /* cmp al, 0x39 */
            ii(0x15_3c80, 2); if(jbew(0x15_3c84, 0x2)) goto l_0x15_3c84; /* jbe 0x3c84 */
            ii(0x15_3c82, 2); add(al, 0x27);                            /* add al, 0x27 */
        l_0x15_3c84:
            ii(0x15_3c84, 1); stosb_a16();                              /* stosb */
            ii(0x15_3c85, 2); mov(ax, dx);                              /* mov ax, dx */
            ii(0x15_3c87, 2); or(ax, bx);                               /* or ax, bx */
            ii(0x15_3c89, 2); if(jnzw(0x15_3c6d, -0x1e)) goto l_0x15_3c6d; /* jnz 0x3c6d */
            ii(0x15_3c8b, 2); mov(memb_a16[ds, di], al);                /* mov [di], al */
        l_0x15_3c8d:
            ii(0x15_3c8d, 1); dec(di);                                  /* dec di */
            ii(0x15_3c8e, 1); lodsb_a16();                              /* lodsb */
            ii(0x15_3c8f, 2); xchg(memb_a16[ds, di], al);               /* xchg [di], al */
            ii(0x15_3c91, 3); mov(memb_a16[ds, si - 0x1], al);          /* mov [si-0x1], al */
            ii(0x15_3c94, 3); lea(ax, si + 0x1);                        /* lea ax, [si+0x1] */
            ii(0x15_3c97, 2); cmp(ax, di);                              /* cmp ax, di */
            ii(0x15_3c99, 2); if(jbw(0x15_3c8d, -0xe)) goto l_0x15_3c8d; /* jb 0x3c8d */
            ii(0x15_3c9b, 2); mov(dx, ds);                              /* mov dx, ds */
            ii(0x15_3c9d, 1); popw(ax);                                 /* pop ax */
            ii(0x15_3c9e, 1); popw(ds);                                 /* pop ds */
            ii(0x15_3c9f, 1); popw(di);                                 /* pop di */
            ii(0x15_3ca0, 1); popw(si);                                 /* pop si */
            ii(0x15_3ca1, 2); mov(sp, bp);                              /* mov sp, bp */
            ii(0x15_3ca3, 1); popw(bp);                                 /* pop bp */
            ii(0x15_3ca4, 1); retfw(); return;                          /* retf */
        }
    }
}