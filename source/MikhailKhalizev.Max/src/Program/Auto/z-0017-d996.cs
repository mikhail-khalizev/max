using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x17_d996-4c3dada5")]
        public void Method_0017_d996()
        {
            ii(0x17_d996, 1); push(bp);                                 /* push bp */
            ii(0x17_d997, 2); mov(bp, sp);                              /* mov bp, sp */
            ii(0x17_d999, 3); sub(sp, 0x8);                             /* sub sp, 0x8 */
            ii(0x17_d99c, 3); mov(bx, memw[ss, bp + 0x6]);              /* mov bx, [bp+0x6] */
            ii(0x17_d99f, 4); cmp(bx, memw[ds, 0x1c5b]);                /* cmp bx, [0x1c5b] */
            ii(0x17_d9a3, 2); if(jb(0x17_d9ac, 0x7)) goto l_0x17_d9ac;  /* jb 0xd9ac */
            ii(0x17_d9a5, 3); mov(ax, 0x900);                           /* mov ax, 0x900 */
            ii(0x17_d9a8, 1); stc();                                    /* stc */
        l_0x17_d9a9:
            ii(0x17_d9a9, 3); if(jmp_func(0x17_d8bb, -0xf1)) return;    /* jmp 0xd8bb */
        l_0x17_d9ac:
            ii(0x17_d9ac, 6); cmp(memw[ds, 0x1dac], 0xd6d6);            /* cmp word [0x1dac], 0xd6d6 */
            ii(0x17_d9b2, 2); if(jnz(0x17_d9b8, 0x4)) goto l_0x17_d9b8; /* jnz 0xd9b8 */
            ii(0x17_d9b4, 4); call_abs(memw[ds, 0x1dae]);               /* call word [0x1dae] */
        l_0x17_d9b8:
            ii(0x17_d9b8, 5); test(memb[ds, bx + 0x1c5d], 0x20);        /* test byte [bx+0x1c5d], 0x20 */
            ii(0x17_d9bd, 2); if(jz(0x17_d9ca, 0xb)) goto l_0x17_d9ca;  /* jz 0xd9ca */
            ii(0x17_d9bf, 3); mov(ax, 0x4202);                          /* mov ax, 0x4202 */
            ii(0x17_d9c2, 2); xor(cx, cx);                              /* xor cx, cx */
            ii(0x17_d9c4, 2); mov(dx, cx);                              /* mov dx, cx */
            ii(0x17_d9c6, 2); @int(0x21);                               /* int 0x21 */
            ii(0x17_d9c8, 2); if(jb(0x17_d9a9, -0x21)) goto l_0x17_d9a9; /* jb 0xd9a9 */
        l_0x17_d9ca:
            ii(0x17_d9ca, 5); test(memb[ds, bx + 0x1c5d], 0x80);        /* test byte [bx+0x1c5d], 0x80 */
            ii(0x17_d9cf, 2); if(jz(0x17_da41, 0x70)) goto l_0x17_da41; /* jz 0xda41 */
            ii(0x17_d9d1, 3); mov(dx, memw[ss, bp + 0x8]);              /* mov dx, [bp+0x8] */
            ii(0x17_d9d4, 1); push(ds);                                 /* push ds */
            ii(0x17_d9d5, 1); pop(es);                                  /* pop es */
            ii(0x17_d9d6, 2); xor(ax, ax);                              /* xor ax, ax */
            ii(0x17_d9d8, 3); mov(memw[ss, bp - 0x2], ax);              /* mov [bp-0x2], ax */
            ii(0x17_d9db, 3); mov(memw[ss, bp - 0x4], ax);              /* mov [bp-0x4], ax */
            ii(0x17_d9de, 1); cld();                                    /* cld */
            ii(0x17_d9df, 1); push(di);                                 /* push di */
            ii(0x17_d9e0, 1); push(si);                                 /* push si */
            ii(0x17_d9e1, 2); mov(di, dx);                              /* mov di, dx */
            ii(0x17_d9e3, 2); mov(si, dx);                              /* mov si, dx */
            ii(0x17_d9e5, 3); mov(memw[ss, bp - 0x8], sp);              /* mov [bp-0x8], sp */
            ii(0x17_d9e8, 3); mov(cx, memw[ss, bp + 0xa]);              /* mov cx, [bp+0xa] */
            ii(0x17_d9eb, 2); if(jcxz(0x17_da27, 0x3a)) goto l_0x17_da27; /* jcxz 0xda27 */
            ii(0x17_d9ed, 2); mov(al, 0xa);                             /* mov al, 0xa */
            ii(0x17_d9ef, 2); repne(() => scasb());                     /* repne scasb */
            ii(0x17_d9f1, 2); if(jnz(0x17_da3f, 0x4c)) goto l_0x17_da3f; /* jnz 0xda3f */
            ii(0x17_d9f3, 1); nop();                                    /* nop */
            ii(0x17_d9f4, 1); push(cs);                                 /* push cs */
            ii(0x17_d9f5, 3); call(0x17_e262, 0x86a);                   /* call 0xe262 */
            ii(0x17_d9f8, 3); cmp(ax, 0xa8);                            /* cmp ax, 0xa8 */
            ii(0x17_d9fb, 2); if(jbe(0x17_da43, 0x46)) goto l_0x17_da43; /* jbe 0xda43 */
            ii(0x17_d9fd, 3); sub(sp, 0x2);                             /* sub sp, 0x2 */
            ii(0x17_da00, 2); mov(bx, sp);                              /* mov bx, sp */
            ii(0x17_da02, 3); mov(dx, 0x200);                           /* mov dx, 0x200 */
            ii(0x17_da05, 3); cmp(ax, 0x228);                           /* cmp ax, 0x228 */
            ii(0x17_da08, 2); if(jae(0x17_da0d, 0x3)) goto l_0x17_da0d; /* jae 0xda0d */
            ii(0x17_da0a, 3); mov(dx, 0x80);                            /* mov dx, 0x80 */
        l_0x17_da0d:
            ii(0x17_da0d, 2); sub(sp, dx);                              /* sub sp, dx */
            ii(0x17_da0f, 2); mov(dx, sp);                              /* mov dx, sp */
            ii(0x17_da11, 2); mov(di, dx);                              /* mov di, dx */
            ii(0x17_da13, 1); push(ss);                                 /* push ss */
            ii(0x17_da14, 1); pop(es);                                  /* pop es */
            ii(0x17_da15, 3); mov(cx, memw[ss, bp + 0xa]);              /* mov cx, [bp+0xa] */
        l_0x17_da18:
            ii(0x17_da18, 1); lodsb();                                  /* lodsb */
            ii(0x17_da19, 2); cmp(al, 0xa);                             /* cmp al, 0xa */
            ii(0x17_da1b, 2); if(jz(0x17_da29, 0xc)) goto l_0x17_da29;  /* jz 0xda29 */
        l_0x17_da1d:
            ii(0x17_da1d, 2); cmp(di, bx);                              /* cmp di, bx */
            ii(0x17_da1f, 2); if(jz(0x17_da3a, 0x19)) goto l_0x17_da3a; /* jz 0xda3a */
        l_0x17_da21:
            ii(0x17_da21, 1); stosb();                                  /* stosb */
            ii(0x17_da22, 2); if(loop(0x17_da18, -0xc)) goto l_0x17_da18; /* loop 0xda18 */
            ii(0x17_da24, 3); call(0x17_da4a, 0x23);                    /* call 0xda4a */
        l_0x17_da27:
            ii(0x17_da27, 2); if(jmp_func(0x17_da94, 0x6b)) return;     /* jmp 0xda94 */
        l_0x17_da29:
            ii(0x17_da29, 2); mov(al, 0xd);                             /* mov al, 0xd */
            ii(0x17_da2b, 2); cmp(di, bx);                              /* cmp di, bx */
            ii(0x17_da2d, 2); if(jnz(0x17_da32, 0x3)) goto l_0x17_da32; /* jnz 0xda32 */
            ii(0x17_da2f, 3); call(0x17_da4a, 0x18);                    /* call 0xda4a */
        l_0x17_da32:
            ii(0x17_da32, 1); stosb();                                  /* stosb */
            ii(0x17_da33, 2); mov(al, 0xa);                             /* mov al, 0xa */
            ii(0x17_da35, 3); inc(memw[ss, bp - 0x4]);                  /* inc word [bp-0x4] */
            ii(0x17_da38, 2); jmp(0x17_da1d, -0x1d); goto l_0x17_da1d;  /* jmp 0xda1d */
        l_0x17_da3a:
            ii(0x17_da3a, 3); call(0x17_da4a, 0xd);                     /* call 0xda4a */
            ii(0x17_da3d, 2); jmp(0x17_da21, -0x1e); goto l_0x17_da21;  /* jmp 0xda21 */
        l_0x17_da3f:
            ii(0x17_da3f, 1); pop(si);                                  /* pop si */
            ii(0x17_da40, 1); pop(di);                                  /* pop di */
        l_0x17_da41:
            ii(0x17_da41, 2); if(jmp_func(0x17_daa2, 0x5f)) return;     /* jmp 0xdaa2 */
        l_0x17_da43:
            ii(0x17_da43, 3); mov(ax, 0xfffc);                          /* mov ax, 0xfffc */
            ii(0x17_da46, 1); push(cs);                                 /* push cs */
            ii(0x17_da47, 3); call(0x17_e218, 0x7ce);                   /* call 0xe218 */
        }
    }
}
