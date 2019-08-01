using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("b3801e56-15e8-4577-b80c-dbc7c7b02439")]
        public void Method_0013_6d68()
        {
            ii(0x13_6d68, 4); enterw(0x80, 0);                          /* enter 0x80, 0x0 */
            ii(0x13_6d6c, 1); pushw(si);                                /* push si */
            ii(0x13_6d6d, 1); pushw(ds);                                /* push ds */
            ii(0x13_6d6e, 3); mov(ax, 0x3e68);                          /* mov ax, 0x3e68 */
            ii(0x13_6d71, 2); mov(ds, ax);                              /* mov ds, ax */
            ii(0x13_6d73, 5); mov(memw_a16[ss, bp - 0x5c], 0);          /* mov word [bp-0x5c], 0x0 */
            ii(0x13_6d78, 6); mov(memw_a16[ds, 0x1ea6], 0);             /* mov word [0x1ea6], 0x0 */
            ii(0x13_6d7e, 1); pushw(ds);                                /* push ds */
            ii(0x13_6d7f, 3); pushw(0x449);                             /* push 0x449 */
            ii(0x13_6d82, 1); nop();                                    /* nop */
            ii(0x13_6d83, 1); pushw(cs);                                /* push cs */
            ii(0x13_6d84, 3); callw(0x12_fb2a, -0x725d);                /* call 0xfb2a */
            ii(0x13_6d87, 3); mov(memw_a16[ss, bp - 0x7e], ax);         /* mov [bp-0x7e], ax */
            ii(0x13_6d8a, 3); mov(memw_a16[ss, bp - 0x7c], dx);         /* mov [bp-0x7c], dx */
            ii(0x13_6d8d, 2); or(dx, ax);                               /* or dx, ax */
            ii(0x13_6d8f, 2); if(jnzw(0x13_6db0, 0x1f)) goto l_0x13_6db0; /* jnz 0x6db0 */
            ii(0x13_6d91, 4); mov(es, memw_a16[ds, 0x1dc8]);            /* mov es, [0x1dc8] */
            ii(0x13_6d95, 6); test(memb_a16[es, 0x47], 0x10);           /* test byte [es:0x47], 0x10 */
            ii(0x13_6d9b, 2); if(jzw(0x13_6da8, 0xb)) goto l_0x13_6da8; /* jz 0x6da8 */
            ii(0x13_6d9d, 5); mov(memw_a16[ss, bp - 0x7e], 0x451);      /* mov word [bp-0x7e], 0x451 */
            ii(0x13_6da2, 3); mov(memw_a16[ss, bp - 0x7c], ds);         /* mov [bp-0x7c], ds */
            ii(0x13_6da5, 2); jmpw(0x13_6db0, 0x9); goto l_0x13_6db0;   /* jmp 0x6db0 */
        //  ii(0x13_6da7, 1); Недостижимый код.
l_0x13_6da8:
            ii(0x13_6da8, 3); mov(ax, 0x1);                             /* mov ax, 0x1 */
            ii(0x13_6dab, 1); popw(ds);                                 /* pop ds */
            ii(0x13_6dac, 1); popw(si);                                 /* pop si */
            ii(0x13_6dad, 1); leavew();                                 /* leave */
            ii(0x13_6dae, 1); retfw(); return;                          /* retf */
        //  ii(0x13_6daf, 1); Недостижимый код.
l_0x13_6db0:
            ii(0x13_6db0, 3); mov(ax, memw_a16[ss, bp - 0x7e]);         /* mov ax, [bp-0x7e] */
            ii(0x13_6db3, 3); mov(dx, memw_a16[ss, bp - 0x7c]);         /* mov dx, [bp-0x7c] */
            ii(0x13_6db6, 3); mov(memw_a16[ss, bp - 0x66], ax);         /* mov [bp-0x66], ax */
            ii(0x13_6db9, 3); mov(memw_a16[ss, bp - 0x64], dx);         /* mov [bp-0x64], dx */
        l_0x13_6dbc:
            ii(0x13_6dbc, 3); lea(ax, bp - 0x58);                       /* lea ax, [bp-0x58] */
            ii(0x13_6dbf, 1); pushw(ss);                                /* push ss */
            ii(0x13_6dc0, 1); pushw(ax);                                /* push ax */
            ii(0x13_6dc1, 3); pushw(memw_a16[ss, bp - 0x64]);           /* push word [bp-0x64] */
            ii(0x13_6dc4, 3); pushw(memw_a16[ss, bp - 0x66]);           /* push word [bp-0x66] */
            ii(0x13_6dc7, 1); pushw(cs);                                /* push cs */
            ii(0x13_6dc8, 3); callw(0x13_738e, 0x5c3);                  /* call 0x738e */
            ii(0x13_6dcb, 3); add(sp, 0x8);                             /* add sp, 0x8 */
            ii(0x13_6dce, 3); mov(memw_a16[ss, bp - 0x62], ax);         /* mov [bp-0x62], ax */
            ii(0x13_6dd1, 2); or(ax, ax);                               /* or ax, ax */
            ii(0x13_6dd3, 2); if(jzw(0x13_6e0a, 0x35)) goto l_0x13_6e0a; /* jz 0x6e0a */
            ii(0x13_6dd5, 3); add(memw_a16[ss, bp - 0x66], ax);         /* add [bp-0x66], ax */
            ii(0x13_6dd8, 5); mov(memw_a16[ss, bp - 0x62], 0);          /* mov word [bp-0x62], 0x0 */
        l_0x13_6ddd:
            ii(0x13_6ddd, 3); mov(si, memw_a16[ss, bp - 0x62]);         /* mov si, [bp-0x62] */
            ii(0x13_6de0, 3); mov(al, memb_a16[ss, bp + si - 0x58]);    /* mov al, [bp+si-0x58] */
            ii(0x13_6de3, 1); cbw();                                    /* cbw */
            ii(0x13_6de4, 2); mov(bx, ax);                              /* mov bx, ax */
            ii(0x13_6de6, 5); test(memb_a16[ds, bx + 0x1ca1], 0x8);     /* test byte [bx+0x1ca1], 0x8 */
            ii(0x13_6deb, 2); if(jzw(0x13_6df2, 0x5)) goto l_0x13_6df2; /* jz 0x6df2 */
            ii(0x13_6ded, 3); inc(memw_a16[ss, bp - 0x62]);             /* inc word [bp-0x62] */
            ii(0x13_6df0, 2); jmpw(0x13_6ddd, -0x15); goto l_0x13_6ddd; /* jmp 0x6ddd */
        l_0x13_6df2:
            ii(0x13_6df2, 4); cmp(memb_a16[ss, bp + si - 0x58], 0x40);  /* cmp byte [bp+si-0x58], 0x40 */
            ii(0x13_6df6, 2); if(jnzw(0x13_6e08, 0x10)) goto l_0x13_6e08; /* jnz 0x6e08 */
            ii(0x13_6df8, 3); lea(ax, bp + si - 0x57);                  /* lea ax, [bp+si-0x57] */
            ii(0x13_6dfb, 1); pushw(ss);                                /* push ss */
            ii(0x13_6dfc, 1); pushw(ax);                                /* push ax */
            ii(0x13_6dfd, 3); pushw(0x4000);                            /* push 0x4000 */
            ii(0x13_6e00, 1); nop();                                    /* nop */
            ii(0x13_6e01, 1); pushw(cs);                                /* push cs */
            ii(0x13_6e02, 3); callw(0x13_0708, -0x66fd);                /* call 0x708 */
            ii(0x13_6e05, 3); mov(memw_a16[ss, bp - 0x5c], ax);         /* mov [bp-0x5c], ax */
        l_0x13_6e08:
            ii(0x13_6e08, 2); jmpw(0x13_6dbc, -0x4e); goto l_0x13_6dbc; /* jmp 0x6dbc */
        l_0x13_6e0a:
            ii(0x13_6e0a, 4); cmp(memw_a16[ss, bp - 0x5c], 0);          /* cmp word [bp-0x5c], 0x0 */
            ii(0x13_6e0e, 2); if(jgw(0x13_6e1f, 0xf)) goto l_0x13_6e1f; /* jg 0x6e1f */
            ii(0x13_6e10, 1); pushw(ds);                                /* push ds */
            ii(0x13_6e11, 3); pushw(0x454);                             /* push 0x454 */
            ii(0x13_6e14, 3); pushw(0x4000);                            /* push 0x4000 */
            ii(0x13_6e17, 1); nop();                                    /* nop */
            ii(0x13_6e18, 1); pushw(cs);                                /* push cs */
            ii(0x13_6e19, 3); callw(0x13_0708, -0x6714);                /* call 0x708 */
            ii(0x13_6e1c, 3); mov(memw_a16[ss, bp - 0x5c], ax);         /* mov [bp-0x5c], ax */
        l_0x13_6e1f:
            ii(0x13_6e1f, 4); cmp(memw_a16[ss, bp - 0x5c], 0);          /* cmp word [bp-0x5c], 0x0 */
            ii(0x13_6e23, 2); if(jgw(0x13_6e28, 0x3)) goto l_0x13_6e28; /* jg 0x6e28 */
            ii(0x13_6e25, 3); jmpw(0x13_6ff9, 0x1d1); goto l_0x13_6ff9; /* jmp 0x6ff9 */
        l_0x13_6e28:
            ii(0x13_6e28, 3); pushw(memw_a16[ss, bp - 0x5c]);           /* push word [bp-0x5c] */
            ii(0x13_6e2b, 2); pushw(0x50);                              /* push 0x50 */
            ii(0x13_6e2d, 3); lea(ax, bp - 0x58);                       /* lea ax, [bp-0x58] */
            ii(0x13_6e30, 1); pushw(ss);                                /* push ss */
            ii(0x13_6e31, 1); pushw(ax);                                /* push ax */
            ii(0x13_6e32, 1); pushw(cs);                                /* push cs */
            ii(0x13_6e33, 3); callw(0x13_75ee, 0x7b8);                  /* call 0x75ee */
            ii(0x13_6e36, 3); add(sp, 0x8);                             /* add sp, 0x8 */
            ii(0x13_6e39, 2); or(ax, ax);                               /* or ax, ax */
            ii(0x13_6e3b, 2); if(jnzw(0x13_6e40, 0x3)) goto l_0x13_6e40; /* jnz 0x6e40 */
            ii(0x13_6e3d, 3); jmpw(0x13_6fee, 0x1ae); goto l_0x13_6fee; /* jmp 0x6fee */
        l_0x13_6e40:
            ii(0x13_6e40, 3); lea(ax, bp - 0x58);                       /* lea ax, [bp-0x58] */
            ii(0x13_6e43, 1); pushw(ss);                                /* push ss */
            ii(0x13_6e44, 1); pushw(ax);                                /* push ax */
            ii(0x13_6e45, 1); nop();                                    /* nop */
            ii(0x13_6e46, 1); pushw(cs);                                /* push cs */
            ii(0x13_6e47, 3); callw(0x13_08d7, -0x6573);                /* call 0x8d7 */
            ii(0x13_6e4a, 2); mov(si, ax);                              /* mov si, ax */
            ii(0x13_6e4c, 4); mov(memb_a16[ss, bp + si - 0x58], 0);     /* mov byte [bp+si-0x58], 0x0 */
            ii(0x13_6e50, 4); cmp(memb_a16[ss, bp - 0x58], 0x21);       /* cmp byte [bp-0x58], 0x21 */
            ii(0x13_6e54, 2); if(jnzw(0x13_6e58, 0x2)) goto l_0x13_6e58; /* jnz 0x6e58 */
            ii(0x13_6e56, 2); jmpw(0x13_6e28, -0x30); goto l_0x13_6e28; /* jmp 0x6e28 */
        l_0x13_6e58:
            ii(0x13_6e58, 3); lea(ax, bp - 0x58);                       /* lea ax, [bp-0x58] */
            ii(0x13_6e5b, 3); mov(memw_a16[ss, bp - 0x4], ax);          /* mov [bp-0x4], ax */
            ii(0x13_6e5e, 3); mov(memw_a16[ss, bp - 0x2], ss);          /* mov [bp-0x2], ss */
            ii(0x13_6e61, 2); jmpw(0x13_6e67, 0x4); goto l_0x13_6e67;   /* jmp 0x6e67 */
        //  ii(0x13_6e63, 1); Недостижимый код.
l_0x13_6e64:
            ii(0x13_6e64, 3); inc(memw_a16[ss, bp - 0x4]);              /* inc word [bp-0x4] */
        l_0x13_6e67:
            ii(0x13_6e67, 3); les(bx, ss, bp - 0x4);                    /* les bx, [bp-0x4] */
            ii(0x13_6e6a, 4); cmp(memb_a16[es, bx], 0);                 /* cmp byte [es:bx], 0x0 */
            ii(0x13_6e6e, 2); if(jzw(0x13_6e80, 0x10)) goto l_0x13_6e80; /* jz 0x6e80 */
            ii(0x13_6e70, 3); mov(al, memb_a16[es, bx]);                /* mov al, [es:bx] */
            ii(0x13_6e73, 1); cbw();                                    /* cbw */
            ii(0x13_6e74, 2); mov(bx, ax);                              /* mov bx, ax */
            ii(0x13_6e76, 5); test(memb_a16[ds, bx + 0x1ca1], 0x8);     /* test byte [bx+0x1ca1], 0x8 */
            ii(0x13_6e7b, 2); if(jzw(0x13_6e80, 0x3)) goto l_0x13_6e80; /* jz 0x6e80 */
            ii(0x13_6e7d, 2); jmpw(0x13_6e64, -0x1b); goto l_0x13_6e64; /* jmp 0x6e64 */
        //  ii(0x13_6e7f, 1); Недостижимый код.
l_0x13_6e80:
            ii(0x13_6e80, 3); mov(ax, memw_a16[ss, bp - 0x4]);          /* mov ax, [bp-0x4] */
            ii(0x13_6e83, 2); mov(dx, es);                              /* mov dx, es */
            ii(0x13_6e85, 3); mov(memw_a16[ss, bp - 0x8], ax);          /* mov [bp-0x8], ax */
            ii(0x13_6e88, 3); mov(memw_a16[ss, bp - 0x6], dx);          /* mov [bp-0x6], dx */
            ii(0x13_6e8b, 2); jmpw(0x13_6e91, 0x4); goto l_0x13_6e91;   /* jmp 0x6e91 */
        //  ii(0x13_6e8d, 1); Недостижимый код.
l_0x13_6e8e:
            ii(0x13_6e8e, 3); inc(memw_a16[ss, bp - 0x8]);              /* inc word [bp-0x8] */
        l_0x13_6e91:
            ii(0x13_6e91, 3); les(bx, ss, bp - 0x8);                    /* les bx, [bp-0x8] */
            ii(0x13_6e94, 4); cmp(memb_a16[es, bx], 0);                 /* cmp byte [es:bx], 0x0 */
            ii(0x13_6e98, 2); if(jzw(0x13_6ec2, 0x28)) goto l_0x13_6ec2; /* jz 0x6ec2 */
            ii(0x13_6e9a, 3); mov(al, memb_a16[es, bx]);                /* mov al, [es:bx] */
            ii(0x13_6e9d, 2); mov(cx, ax);                              /* mov cx, ax */
            ii(0x13_6e9f, 1); cbw();                                    /* cbw */
            ii(0x13_6ea0, 2); mov(si, ax);                              /* mov si, ax */
            ii(0x13_6ea2, 5); test(memb_a16[ds, si + 0x1ca1], 0x8);     /* test byte [si+0x1ca1], 0x8 */
            ii(0x13_6ea7, 2); if(jnzw(0x13_6ec2, 0x19)) goto l_0x13_6ec2; /* jnz 0x6ec2 */
            ii(0x13_6ea9, 3); cmp(cl, 0x3d);                            /* cmp cl, 0x3d */
            ii(0x13_6eac, 2); if(jzw(0x13_6ec2, 0x14)) goto l_0x13_6ec2; /* jz 0x6ec2 */
            ii(0x13_6eae, 3); cmp(cl, 0x23);                            /* cmp cl, 0x23 */
            ii(0x13_6eb1, 2); if(jzw(0x13_6ec2, 0xf)) goto l_0x13_6ec2; /* jz 0x6ec2 */
            ii(0x13_6eb3, 5); test(memb_a16[ds, si + 0x1ca1], 0x2);     /* test byte [si+0x1ca1], 0x2 */
            ii(0x13_6eb8, 2); if(jzw(0x13_6ec0, 0x6)) goto l_0x13_6ec0; /* jz 0x6ec0 */
            ii(0x13_6eba, 4); sub(memb_a16[es, bx], 0x20);              /* sub byte [es:bx], 0x20 */
            ii(0x13_6ebe, 2); jmpw(0x13_6ec0, 0); goto l_0x13_6ec0;     /* jmp 0x6ec0 */
        l_0x13_6ec0:
            ii(0x13_6ec0, 2); jmpw(0x13_6e8e, -0x34); goto l_0x13_6e8e; /* jmp 0x6e8e */
        l_0x13_6ec2:
            ii(0x13_6ec2, 2); jmpw(0x13_6ec7, 0x3); goto l_0x13_6ec7;   /* jmp 0x6ec7 */
        l_0x13_6ec4:
            ii(0x13_6ec4, 3); inc(memw_a16[ss, bp - 0x8]);              /* inc word [bp-0x8] */
        l_0x13_6ec7:
            ii(0x13_6ec7, 3); les(bx, ss, bp - 0x8);                    /* les bx, [bp-0x8] */
            ii(0x13_6eca, 4); cmp(memb_a16[es, bx], 0);                 /* cmp byte [es:bx], 0x0 */
            ii(0x13_6ece, 2); if(jzw(0x13_6eec, 0x1c)) goto l_0x13_6eec; /* jz 0x6eec */
            ii(0x13_6ed0, 3); mov(al, memb_a16[es, bx]);                /* mov al, [es:bx] */
            ii(0x13_6ed3, 2); mov(cx, ax);                              /* mov cx, ax */
            ii(0x13_6ed5, 1); cbw();                                    /* cbw */
            ii(0x13_6ed6, 2); mov(bx, ax);                              /* mov bx, ax */
            ii(0x13_6ed8, 5); test(memb_a16[ds, bx + 0x1ca1], 0x8);     /* test byte [bx+0x1ca1], 0x8 */
            ii(0x13_6edd, 2); if(jnzw(0x13_6ee9, 0xa)) goto l_0x13_6ee9; /* jnz 0x6ee9 */
            ii(0x13_6edf, 3); cmp(cl, 0x3d);                            /* cmp cl, 0x3d */
            ii(0x13_6ee2, 2); if(jzw(0x13_6ee9, 0x5)) goto l_0x13_6ee9; /* jz 0x6ee9 */
            ii(0x13_6ee4, 3); cmp(cl, 0x23);                            /* cmp cl, 0x23 */
            ii(0x13_6ee7, 2); if(jnzw(0x13_6eec, 0x3)) goto l_0x13_6eec; /* jnz 0x6eec */
        l_0x13_6ee9:
            ii(0x13_6ee9, 2); jmpw(0x13_6ec4, -0x27); goto l_0x13_6ec4; /* jmp 0x6ec4 */
        //  ii(0x13_6eeb, 1); Недостижимый код.
l_0x13_6eec:
            ii(0x13_6eec, 3); mov(ax, memw_a16[ss, bp - 0x4]);          /* mov ax, [bp-0x4] */
            ii(0x13_6eef, 3); mov(dx, memw_a16[ss, bp - 0x2]);          /* mov dx, [bp-0x2] */
            ii(0x13_6ef2, 3); cmp(memw_a16[ss, bp - 0x8], ax);          /* cmp [bp-0x8], ax */
            ii(0x13_6ef5, 2); if(jnzw(0x13_6f00, 0x9)) goto l_0x13_6f00; /* jnz 0x6f00 */
            ii(0x13_6ef7, 3); cmp(memw_a16[ss, bp - 0x6], dx);          /* cmp [bp-0x6], dx */
            ii(0x13_6efa, 2); if(jnzw(0x13_6f00, 0x4)) goto l_0x13_6f00; /* jnz 0x6f00 */
            ii(0x13_6efc, 3); jmpw(0x13_6e28, -0xd7); goto l_0x13_6e28; /* jmp 0x6e28 */
        //  ii(0x13_6eff, 1); Недостижимый код.
l_0x13_6f00:
            ii(0x13_6f00, 5); mov(memw_a16[ss, bp - 0x62], 0xa);        /* mov word [bp-0x62], 0xa */
        l_0x13_6f05:
            ii(0x13_6f05, 3); mov(bx, memw_a16[ss, bp - 0x62]);         /* mov bx, [bp-0x62] */
            ii(0x13_6f08, 2); shl(bx, 0x1);                             /* shl bx, 1 */
            ii(0x13_6f0a, 1); pushw(ds);                                /* push ds */
            ii(0x13_6f0b, 4); pushw(memw_a16[ds, bx + 0x45c]);          /* push word [bx+0x45c] */
            ii(0x13_6f0f, 2); mov(si, bx);                              /* mov si, bx */
            ii(0x13_6f11, 1); nop();                                    /* nop */
            ii(0x13_6f12, 1); pushw(cs);                                /* push cs */
            ii(0x13_6f13, 3); callw(0x13_08d7, -0x663f);                /* call 0x8d7 */
            ii(0x13_6f16, 3); mov(memw_a16[ss, bp - 0x68], ax);         /* mov [bp-0x68], ax */
            ii(0x13_6f19, 1); pushw(ax);                                /* push ax */
            ii(0x13_6f1a, 3); pushw(memw_a16[ss, bp - 0x2]);            /* push word [bp-0x2] */
            ii(0x13_6f1d, 3); pushw(memw_a16[ss, bp - 0x4]);            /* push word [bp-0x4] */
            ii(0x13_6f20, 1); pushw(ds);                                /* push ds */
            ii(0x13_6f21, 4); pushw(memw_a16[ds, si + 0x45c]);          /* push word [si+0x45c] */
            ii(0x13_6f25, 1); nop();                                    /* nop */
            ii(0x13_6f26, 1); pushw(cs);                                /* push cs */
            ii(0x13_6f27, 3); callw(0x13_0603, -0x6927);                /* call 0x603 */
            ii(0x13_6f2a, 3); add(sp, 0xa);                             /* add sp, 0xa */
            ii(0x13_6f2d, 2); or(ax, ax);                               /* or ax, ax */
            ii(0x13_6f2f, 2); if(jzw(0x13_6f3c, 0xb)) goto l_0x13_6f3c; /* jz 0x6f3c */
            ii(0x13_6f31, 3); dec(memw_a16[ss, bp - 0x62]);             /* dec word [bp-0x62] */
            ii(0x13_6f34, 2); if(jnsw(0x13_6f3a, 0x4)) goto l_0x13_6f3a; /* jns 0x6f3a */
            ii(0x13_6f36, 3); jmpw(0x13_6fea, 0xb1); goto l_0x13_6fea;  /* jmp 0x6fea */
        //  ii(0x13_6f39, 1); Недостижимый код.
l_0x13_6f3a:
            ii(0x13_6f3a, 2); jmpw(0x13_6f05, -0x37); goto l_0x13_6f05; /* jmp 0x6f05 */
        l_0x13_6f3c:
            ii(0x13_6f3c, 3); mov(bx, memw_a16[ss, bp - 0x62]);         /* mov bx, [bp-0x62] */
            ii(0x13_6f3f, 4); mov(al, memb_a16[ds, bx + 0x472]);        /* mov al, [bx+0x472] */
            ii(0x13_6f43, 1); cbw();                                    /* cbw */
            ii(0x13_6f44, 3); jmpw(0x13_6fd4, 0x8d); goto l_0x13_6fd4;  /* jmp 0x6fd4 */
        //  ii(0x13_6f47, 1); Недостижимый код.
l_0x13_6f48:
            ii(0x13_6f48, 3); mov(bx, memw_a16[ss, bp - 0x62]);         /* mov bx, [bp-0x62] */
            ii(0x13_6f4b, 2); shl(bx, 0x1);                             /* shl bx, 1 */
            ii(0x13_6f4d, 4); mov(ax, memw_a16[ds, bx + 0x47e]);        /* mov ax, [bx+0x47e] */
            ii(0x13_6f51, 3); mov(memw_a16[ss, bp - 0x4], ax);          /* mov [bp-0x4], ax */
            ii(0x13_6f54, 3); mov(memw_a16[ss, bp - 0x2], ds);          /* mov [bp-0x2], ds */
        l_0x13_6f57:
            ii(0x13_6f57, 3); les(bx, ss, bp - 0x8);                    /* les bx, [bp-0x8] */
            ii(0x13_6f5a, 4); cmp(memb_a16[es, bx], 0);                 /* cmp byte [es:bx], 0x0 */
            ii(0x13_6f5e, 2); if(jzw(0x13_6f90, 0x30)) goto l_0x13_6f90; /* jz 0x6f90 */
            ii(0x13_6f60, 3); mov(al, memb_a16[es, bx]);                /* mov al, [es:bx] */
            ii(0x13_6f63, 1); cbw();                                    /* cbw */
            ii(0x13_6f64, 2); mov(bx, ax);                              /* mov bx, ax */
            ii(0x13_6f66, 5); test(memb_a16[ds, bx + 0x1ca1], 0x8);     /* test byte [bx+0x1ca1], 0x8 */
            ii(0x13_6f6b, 2); if(jnzw(0x13_6f90, 0x23)) goto l_0x13_6f90; /* jnz 0x6f90 */
            ii(0x13_6f6d, 3); mov(memw_a16[ss, bp - 0x62], bx);         /* mov [bp-0x62], bx */
            ii(0x13_6f70, 3); inc(memw_a16[ss, bp - 0x8]);              /* inc word [bp-0x8] */
            ii(0x13_6f73, 5); test(memb_a16[ds, bx + 0x1ca1], 0x2);     /* test byte [bx+0x1ca1], 0x2 */
            ii(0x13_6f78, 2); if(jzw(0x13_6f82, 0x8)) goto l_0x13_6f82; /* jz 0x6f82 */
            ii(0x13_6f7a, 3); mov(al, memb_a16[ss, bp - 0x62]);         /* mov al, [bp-0x62] */
            ii(0x13_6f7d, 2); sub(al, 0x20);                            /* sub al, 0x20 */
            ii(0x13_6f7f, 2); jmpw(0x13_6f85, 0x4); goto l_0x13_6f85;   /* jmp 0x6f85 */
        //  ii(0x13_6f81, 1); Недостижимый код.
l_0x13_6f82:
            ii(0x13_6f82, 3); mov(al, memb_a16[ss, bp - 0x62]);         /* mov al, [bp-0x62] */
        l_0x13_6f85:
            ii(0x13_6f85, 3); les(bx, ss, bp - 0x4);                    /* les bx, [bp-0x4] */
            ii(0x13_6f88, 3); inc(memw_a16[ss, bp - 0x4]);              /* inc word [bp-0x4] */
            ii(0x13_6f8b, 3); mov(memb_a16[es, bx], al);                /* mov [es:bx], al */
            ii(0x13_6f8e, 2); jmpw(0x13_6f57, -0x39); goto l_0x13_6f57; /* jmp 0x6f57 */
        l_0x13_6f90:
            ii(0x13_6f90, 3); les(bx, ss, bp - 0x4);                    /* les bx, [bp-0x4] */
            ii(0x13_6f93, 4); mov(memb_a16[es, bx], 0);                 /* mov byte [es:bx], 0x0 */
            ii(0x13_6f97, 2); jmpw(0x13_6fea, 0x51); goto l_0x13_6fea;  /* jmp 0x6fea */
        //  ii(0x13_6f99, 1); Недостижимый код.
l_0x13_6f9a:
            ii(0x13_6f9a, 3); pushw(memw_a16[ss, bp - 0x6]);            /* push word [bp-0x6] */
            ii(0x13_6f9d, 3); pushw(memw_a16[ss, bp - 0x8]);            /* push word [bp-0x8] */
            ii(0x13_6fa0, 1); nop();                                    /* nop */
            ii(0x13_6fa1, 1); pushw(cs);                                /* push cs */
            ii(0x13_6fa2, 3); callw(0x13_08f7, -0x66ae);                /* call 0x8f7 */
            ii(0x13_6fa5, 3); mov(bx, memw_a16[ss, bp - 0x62]);         /* mov bx, [bp-0x62] */
            ii(0x13_6fa8, 2); shl(bx, 0x1);                             /* shl bx, 1 */
            ii(0x13_6faa, 4); mov(bx, memw_a16[ds, bx + 0x47e]);        /* mov bx, [bx+0x47e] */
            ii(0x13_6fae, 2); mov(memw_a16[ds, bx], ax);                /* mov [bx], ax */
            ii(0x13_6fb0, 3); mov(memw_a16[ds, bx + 0x2], dx);          /* mov [bx+0x2], dx */
            ii(0x13_6fb3, 2); jmpw(0x13_6fea, 0x35); goto l_0x13_6fea;  /* jmp 0x6fea */
        //  ii(0x13_6fb5, 1); Недостижимый код.
l_0x13_6fb6:
            ii(0x13_6fb6, 3); mov(bx, memw_a16[ss, bp - 0x62]);         /* mov bx, [bp-0x62] */
            ii(0x13_6fb9, 2); shl(bx, 0x1);                             /* shl bx, 1 */
            ii(0x13_6fbb, 4); mov(bx, memw_a16[ds, bx + 0x47e]);        /* mov bx, [bx+0x47e] */
            ii(0x13_6fbf, 3); mov(memb_a16[ds, bx], 0x1);               /* mov byte [bx], 0x1 */
            ii(0x13_6fc2, 2); jmpw(0x13_6fea, 0x26); goto l_0x13_6fea;  /* jmp 0x6fea */
        l_0x13_6fc4:
            ii(0x13_6fc4, 3); mov(bx, memw_a16[ss, bp - 0x62]);         /* mov bx, [bp-0x62] */
            ii(0x13_6fc7, 2); shl(bx, 0x1);                             /* shl bx, 1 */
            ii(0x13_6fc9, 4); mov(bx, memw_a16[ds, bx + 0x47e]);        /* mov bx, [bx+0x47e] */
            ii(0x13_6fcd, 3); mov(memb_a16[ds, bx], 0);                 /* mov byte [bx], 0x0 */
        l_0x13_6fd0:
            ii(0x13_6fd0, 2); jmpw(0x13_6fea, 0x18); goto l_0x13_6fea;  /* jmp 0x6fea */
        //  ii(0x13_6fd2, 2); Недостижимый код.
l_0x13_6fd4:
            ii(0x13_6fd4, 2); or(ax, ax);                               /* or ax, ax */
            ii(0x13_6fd6, 2); if(jzw(0x13_6fc4, -0x14)) goto l_0x13_6fc4; /* jz 0x6fc4 */
            ii(0x13_6fd8, 1); dec(ax);                                  /* dec ax */
            ii(0x13_6fd9, 2); if(jzw(0x13_6fb6, -0x25)) goto l_0x13_6fb6; /* jz 0x6fb6 */
            ii(0x13_6fdb, 1); dec(ax);                                  /* dec ax */
            ii(0x13_6fdc, 2); if(jzw(0x13_6f9a, -0x44)) goto l_0x13_6f9a; /* jz 0x6f9a */
            ii(0x13_6fde, 1); dec(ax);                                  /* dec ax */
            ii(0x13_6fdf, 2); if(jzw(0x13_6fd0, -0x11)) goto l_0x13_6fd0; /* jz 0x6fd0 */
            ii(0x13_6fe1, 1); dec(ax);                                  /* dec ax */
            ii(0x13_6fe2, 2); if(jnzw(0x13_6fe7, 0x3)) goto l_0x13_6fe7; /* jnz 0x6fe7 */
            ii(0x13_6fe4, 3); jmpw(0x13_6f48, -0x9f); goto l_0x13_6f48; /* jmp 0x6f48 */
        l_0x13_6fe7:
            ii(0x13_6fe7, 2); jmpw(0x13_6fea, 0x1); goto l_0x13_6fea;   /* jmp 0x6fea */
        //  ii(0x13_6fe9, 1); Недостижимый код.
l_0x13_6fea:
            ii(0x13_6fea, 3); jmpw(0x13_6e28, -0x1c5); goto l_0x13_6e28; /* jmp 0x6e28 */
        //  ii(0x13_6fed, 1); Недостижимый код.
l_0x13_6fee:
            ii(0x13_6fee, 3); pushw(memw_a16[ss, bp - 0x5c]);           /* push word [bp-0x5c] */
            ii(0x13_6ff1, 1); nop();                                    /* nop */
            ii(0x13_6ff2, 1); pushw(cs);                                /* push cs */
            ii(0x13_6ff3, 3); callw(0x13_d8fc, 0x6906);                 /* call 0xd8fc */
            ii(0x13_6ff6, 3); add(sp, 0x2);                             /* add sp, 0x2 */
        l_0x13_6ff9:
            ii(0x13_6ff9, 3); lea(ax, bp - 0x58);                       /* lea ax, [bp-0x58] */
            ii(0x13_6ffc, 1); pushw(ss);                                /* push ss */
            ii(0x13_6ffd, 1); pushw(ax);                                /* push ax */
            ii(0x13_6ffe, 3); pushw(memw_a16[ss, bp - 0x7c]);           /* push word [bp-0x7c] */
            ii(0x13_7001, 3); pushw(memw_a16[ss, bp - 0x7e]);           /* push word [bp-0x7e] */
            ii(0x13_7004, 1); pushw(cs);                                /* push cs */
            ii(0x13_7005, 3); callw(0x13_738e, 0x386);                  /* call 0x738e */
            ii(0x13_7008, 3); add(sp, 0x8);                             /* add sp, 0x8 */
            ii(0x13_700b, 3); mov(memw_a16[ss, bp - 0x62], ax);         /* mov [bp-0x62], ax */
            ii(0x13_700e, 2); or(ax, ax);                               /* or ax, ax */
            ii(0x13_7010, 2); if(jnzw(0x13_7015, 0x3)) goto l_0x13_7015; /* jnz 0x7015 */
            ii(0x13_7012, 3); jmpw(0x13_7240, 0x22b); goto l_0x13_7240; /* jmp 0x7240 */
        l_0x13_7015:
            ii(0x13_7015, 3); add(memw_a16[ss, bp - 0x7e], ax);         /* add [bp-0x7e], ax */
            ii(0x13_7018, 3); lea(ax, bp - 0x58);                       /* lea ax, [bp-0x58] */
            ii(0x13_701b, 3); mov(memw_a16[ss, bp - 0x4], ax);          /* mov [bp-0x4], ax */
            ii(0x13_701e, 3); mov(memw_a16[ss, bp - 0x2], ss);          /* mov [bp-0x2], ss */
            ii(0x13_7021, 2); jmpw(0x13_7027, 0x4); goto l_0x13_7027;   /* jmp 0x7027 */
        //  ii(0x13_7023, 1); Недостижимый код.
l_0x13_7024:
            ii(0x13_7024, 3); inc(memw_a16[ss, bp - 0x4]);              /* inc word [bp-0x4] */
        l_0x13_7027:
            ii(0x13_7027, 3); les(bx, ss, bp - 0x4);                    /* les bx, [bp-0x4] */
            ii(0x13_702a, 4); cmp(memb_a16[es, bx], 0);                 /* cmp byte [es:bx], 0x0 */
            ii(0x13_702e, 2); if(jzw(0x13_7040, 0x10)) goto l_0x13_7040; /* jz 0x7040 */
            ii(0x13_7030, 3); mov(al, memb_a16[es, bx]);                /* mov al, [es:bx] */
            ii(0x13_7033, 1); cbw();                                    /* cbw */
            ii(0x13_7034, 2); mov(bx, ax);                              /* mov bx, ax */
            ii(0x13_7036, 5); test(memb_a16[ds, bx + 0x1ca1], 0x8);     /* test byte [bx+0x1ca1], 0x8 */
            ii(0x13_703b, 2); if(jzw(0x13_7040, 0x3)) goto l_0x13_7040; /* jz 0x7040 */
            ii(0x13_703d, 2); jmpw(0x13_7024, -0x1b); goto l_0x13_7024; /* jmp 0x7024 */
        //  ii(0x13_703f, 1); Недостижимый код.
l_0x13_7040:
            ii(0x13_7040, 3); mov(ax, memw_a16[ss, bp - 0x4]);          /* mov ax, [bp-0x4] */
            ii(0x13_7043, 2); mov(dx, es);                              /* mov dx, es */
            ii(0x13_7045, 3); mov(memw_a16[ss, bp - 0x8], ax);          /* mov [bp-0x8], ax */
            ii(0x13_7048, 3); mov(memw_a16[ss, bp - 0x6], dx);          /* mov [bp-0x6], dx */
            ii(0x13_704b, 2); jmpw(0x13_7051, 0x4); goto l_0x13_7051;   /* jmp 0x7051 */
        //  ii(0x13_704d, 1); Недостижимый код.
l_0x13_704e:
            ii(0x13_704e, 3); inc(memw_a16[ss, bp - 0x8]);              /* inc word [bp-0x8] */
        l_0x13_7051:
            ii(0x13_7051, 3); les(bx, ss, bp - 0x8);                    /* les bx, [bp-0x8] */
            ii(0x13_7054, 4); cmp(memb_a16[es, bx], 0);                 /* cmp byte [es:bx], 0x0 */
            ii(0x13_7058, 2); if(jzw(0x13_7070, 0x16)) goto l_0x13_7070; /* jz 0x7070 */
            ii(0x13_705a, 3); mov(al, memb_a16[es, bx]);                /* mov al, [es:bx] */
            ii(0x13_705d, 2); mov(cx, ax);                              /* mov cx, ax */
            ii(0x13_705f, 1); cbw();                                    /* cbw */
            ii(0x13_7060, 2); mov(bx, ax);                              /* mov bx, ax */
            ii(0x13_7062, 5); test(memb_a16[ds, bx + 0x1ca1], 0x8);     /* test byte [bx+0x1ca1], 0x8 */
            ii(0x13_7067, 2); if(jnzw(0x13_7070, 0x7)) goto l_0x13_7070; /* jnz 0x7070 */
            ii(0x13_7069, 3); cmp(cl, 0x23);                            /* cmp cl, 0x23 */
            ii(0x13_706c, 2); if(jzw(0x13_7070, 0x2)) goto l_0x13_7070; /* jz 0x7070 */
            ii(0x13_706e, 2); jmpw(0x13_704e, -0x22); goto l_0x13_704e; /* jmp 0x704e */
        l_0x13_7070:
            ii(0x13_7070, 2); jmpw(0x13_7075, 0x3); goto l_0x13_7075;   /* jmp 0x7075 */
        l_0x13_7072:
            ii(0x13_7072, 3); inc(memw_a16[ss, bp - 0x8]);              /* inc word [bp-0x8] */
        l_0x13_7075:
            ii(0x13_7075, 3); les(bx, ss, bp - 0x8);                    /* les bx, [bp-0x8] */
            ii(0x13_7078, 4); cmp(memb_a16[es, bx], 0);                 /* cmp byte [es:bx], 0x0 */
            ii(0x13_707c, 2); if(jzw(0x13_7094, 0x16)) goto l_0x13_7094; /* jz 0x7094 */
            ii(0x13_707e, 3); mov(al, memb_a16[es, bx]);                /* mov al, [es:bx] */
            ii(0x13_7081, 2); mov(cx, ax);                              /* mov cx, ax */
            ii(0x13_7083, 1); cbw();                                    /* cbw */
            ii(0x13_7084, 2); mov(bx, ax);                              /* mov bx, ax */
            ii(0x13_7086, 5); test(memb_a16[ds, bx + 0x1ca1], 0x8);     /* test byte [bx+0x1ca1], 0x8 */
            ii(0x13_708b, 2); if(jnzw(0x13_7092, 0x5)) goto l_0x13_7092; /* jnz 0x7092 */
            ii(0x13_708d, 3); cmp(cl, 0x23);                            /* cmp cl, 0x23 */
            ii(0x13_7090, 2); if(jnzw(0x13_7094, 0x2)) goto l_0x13_7094; /* jnz 0x7094 */
        l_0x13_7092:
            ii(0x13_7092, 2); jmpw(0x13_7072, -0x22); goto l_0x13_7072; /* jmp 0x7072 */
        l_0x13_7094:
            ii(0x13_7094, 3); mov(ax, memw_a16[ss, bp - 0x4]);          /* mov ax, [bp-0x4] */
            ii(0x13_7097, 3); mov(dx, memw_a16[ss, bp - 0x2]);          /* mov dx, [bp-0x2] */
            ii(0x13_709a, 3); cmp(memw_a16[ss, bp - 0x8], ax);          /* cmp [bp-0x8], ax */
            ii(0x13_709d, 2); if(jnzw(0x13_70a8, 0x9)) goto l_0x13_70a8; /* jnz 0x70a8 */
            ii(0x13_709f, 3); cmp(memw_a16[ss, bp - 0x6], dx);          /* cmp [bp-0x6], dx */
            ii(0x13_70a2, 2); if(jnzw(0x13_70a8, 0x4)) goto l_0x13_70a8; /* jnz 0x70a8 */
            ii(0x13_70a4, 3); jmpw(0x13_6ff9, -0xae); goto l_0x13_6ff9; /* jmp 0x6ff9 */
        //  ii(0x13_70a7, 1); Недостижимый код.
l_0x13_70a8:
            ii(0x13_70a8, 5); mov(memw_a16[ss, bp - 0x62], 0xa);        /* mov word [bp-0x62], 0xa */
        l_0x13_70ad:
            ii(0x13_70ad, 3); mov(bx, memw_a16[ss, bp - 0x62]);         /* mov bx, [bp-0x62] */
            ii(0x13_70b0, 2); shl(bx, 0x1);                             /* shl bx, 1 */
            ii(0x13_70b2, 1); pushw(ds);                                /* push ds */
            ii(0x13_70b3, 4); pushw(memw_a16[ds, bx + 0x45c]);          /* push word [bx+0x45c] */
            ii(0x13_70b7, 2); mov(si, bx);                              /* mov si, bx */
            ii(0x13_70b9, 1); nop();                                    /* nop */
            ii(0x13_70ba, 1); pushw(cs);                                /* push cs */
            ii(0x13_70bb, 3); callw(0x13_08d7, -0x67e7);                /* call 0x8d7 */
            ii(0x13_70be, 3); mov(memw_a16[ss, bp - 0x68], ax);         /* mov [bp-0x68], ax */
            ii(0x13_70c1, 1); pushw(ax);                                /* push ax */
            ii(0x13_70c2, 3); pushw(memw_a16[ss, bp - 0x2]);            /* push word [bp-0x2] */
            ii(0x13_70c5, 3); pushw(memw_a16[ss, bp - 0x4]);            /* push word [bp-0x4] */
            ii(0x13_70c8, 1); pushw(ds);                                /* push ds */
            ii(0x13_70c9, 4); pushw(memw_a16[ds, si + 0x45c]);          /* push word [si+0x45c] */
            ii(0x13_70cd, 1); nop();                                    /* nop */
            ii(0x13_70ce, 1); pushw(cs);                                /* push cs */
            ii(0x13_70cf, 3); callw(0x13_0603, -0x6acf);                /* call 0x603 */
            ii(0x13_70d2, 3); add(sp, 0xa);                             /* add sp, 0xa */
            ii(0x13_70d5, 2); or(ax, ax);                               /* or ax, ax */
            ii(0x13_70d7, 2); if(jzw(0x13_70e2, 0x9)) goto l_0x13_70e2; /* jz 0x70e2 */
            ii(0x13_70d9, 3); dec(memw_a16[ss, bp - 0x62]);             /* dec word [bp-0x62] */
            ii(0x13_70dc, 2); if(jnsw(0x13_70e0, 0x2)) goto l_0x13_70e0; /* jns 0x70e0 */
            ii(0x13_70de, 2); jmpw(0x13_70e2, 0x2); goto l_0x13_70e2;   /* jmp 0x70e2 */
        l_0x13_70e0:
            ii(0x13_70e0, 2); jmpw(0x13_70ad, -0x35); goto l_0x13_70ad; /* jmp 0x70ad */
        l_0x13_70e2:
            ii(0x13_70e2, 3); mov(bx, memw_a16[ss, bp - 0x62]);         /* mov bx, [bp-0x62] */
            ii(0x13_70e5, 4); mov(al, memb_a16[ds, bx + 0x472]);        /* mov al, [bx+0x472] */
            ii(0x13_70e9, 1); cbw();                                    /* cbw */
            ii(0x13_70ea, 3); jmpw(0x13_7224, 0x137); goto l_0x13_7224; /* jmp 0x7224 */
        //  ii(0x13_70ed, 1); Недостижимый код.
l_0x13_70ee:
            ii(0x13_70ee, 3); mov(bx, memw_a16[ss, bp - 0x62]);         /* mov bx, [bp-0x62] */
            ii(0x13_70f1, 2); shl(bx, 0x1);                             /* shl bx, 1 */
            ii(0x13_70f3, 4); mov(ax, memw_a16[ds, bx + 0x47e]);        /* mov ax, [bx+0x47e] */
            ii(0x13_70f7, 3); mov(memw_a16[ss, bp - 0x4], ax);          /* mov [bp-0x4], ax */
            ii(0x13_70fa, 3); mov(memw_a16[ss, bp - 0x2], ds);          /* mov [bp-0x2], ds */
            ii(0x13_70fd, 3); lea(ax, bp - 0x58);                       /* lea ax, [bp-0x58] */
            ii(0x13_7100, 1); pushw(ss);                                /* push ss */
            ii(0x13_7101, 1); pushw(ax);                                /* push ax */
            ii(0x13_7102, 3); pushw(memw_a16[ss, bp - 0x7c]);           /* push word [bp-0x7c] */
            ii(0x13_7105, 3); pushw(memw_a16[ss, bp - 0x7e]);           /* push word [bp-0x7e] */
            ii(0x13_7108, 1); pushw(cs);                                /* push cs */
            ii(0x13_7109, 3); callw(0x13_738e, 0x282);                  /* call 0x738e */
            ii(0x13_710c, 3); add(sp, 0x8);                             /* add sp, 0x8 */
            ii(0x13_710f, 3); add(memw_a16[ss, bp - 0x7e], ax);         /* add [bp-0x7e], ax */
            ii(0x13_7112, 5); mov(memw_a16[ss, bp - 0x5a], 0);          /* mov word [bp-0x5a], 0x0 */
            ii(0x13_7117, 2); jmpw(0x13_711d, 0x4); goto l_0x13_711d;   /* jmp 0x711d */
        //  ii(0x13_7119, 1); Недостижимый код.
l_0x13_711a:
            ii(0x13_711a, 3); inc(memw_a16[ss, bp - 0x5a]);             /* inc word [bp-0x5a] */
        l_0x13_711d:
            ii(0x13_711d, 4); cmp(memw_a16[ss, bp - 0x5a], 0x3);        /* cmp word [bp-0x5a], 0x3 */
            ii(0x13_7121, 2); if(jgew(0x13_714c, 0x29)) goto l_0x13_714c; /* jge 0x714c */
            ii(0x13_7123, 3); lea(ax, bp - 0x58);                       /* lea ax, [bp-0x58] */
            ii(0x13_7126, 1); pushw(ss);                                /* push ss */
            ii(0x13_7127, 1); pushw(ax);                                /* push ax */
            ii(0x13_7128, 1); nop();                                    /* nop */
            ii(0x13_7129, 1); pushw(cs);                                /* push cs */
            ii(0x13_712a, 3); callw(0x13_08d7, -0x6856);                /* call 0x8d7 */
            ii(0x13_712d, 2); or(ax, ax);                               /* or ax, ax */
            ii(0x13_712f, 2); if(jzw(0x13_7134, 0x3)) goto l_0x13_7134; /* jz 0x7134 */
            ii(0x13_7131, 2); jmpw(0x13_714c, 0x19); goto l_0x13_714c;  /* jmp 0x714c */
        //  ii(0x13_7133, 1); Недостижимый код.
l_0x13_7134:
            ii(0x13_7134, 3); lea(ax, bp - 0x58);                       /* lea ax, [bp-0x58] */
            ii(0x13_7137, 1); pushw(ss);                                /* push ss */
            ii(0x13_7138, 1); pushw(ax);                                /* push ax */
            ii(0x13_7139, 3); pushw(memw_a16[ss, bp - 0x7c]);           /* push word [bp-0x7c] */
            ii(0x13_713c, 3); pushw(memw_a16[ss, bp - 0x7e]);           /* push word [bp-0x7e] */
            ii(0x13_713f, 1); pushw(cs);                                /* push cs */
            ii(0x13_7140, 3); callw(0x13_738e, 0x24b);                  /* call 0x738e */
            ii(0x13_7143, 3); add(sp, 0x8);                             /* add sp, 0x8 */
            ii(0x13_7146, 3); add(memw_a16[ss, bp - 0x7e], ax);         /* add [bp-0x7e], ax */
            ii(0x13_7149, 2); jmpw(0x13_711a, -0x31); goto l_0x13_711a; /* jmp 0x711a */
        //  ii(0x13_714b, 1); Недостижимый код.
l_0x13_714c:
            ii(0x13_714c, 3); lea(ax, bp - 0x58);                       /* lea ax, [bp-0x58] */
            ii(0x13_714f, 3); mov(memw_a16[ss, bp - 0x8], ax);          /* mov [bp-0x8], ax */
            ii(0x13_7152, 3); mov(memw_a16[ss, bp - 0x6], ss);          /* mov [bp-0x6], ss */
        l_0x13_7155:
            ii(0x13_7155, 3); les(bx, ss, bp - 0x8);                    /* les bx, [bp-0x8] */
            ii(0x13_7158, 4); cmp(memb_a16[es, bx], 0);                 /* cmp byte [es:bx], 0x0 */
            ii(0x13_715c, 2); if(jzw(0x13_718e, 0x30)) goto l_0x13_718e; /* jz 0x718e */
            ii(0x13_715e, 3); mov(al, memb_a16[es, bx]);                /* mov al, [es:bx] */
            ii(0x13_7161, 1); cbw();                                    /* cbw */
            ii(0x13_7162, 2); mov(bx, ax);                              /* mov bx, ax */
            ii(0x13_7164, 5); test(memb_a16[ds, bx + 0x1ca1], 0x8);     /* test byte [bx+0x1ca1], 0x8 */
            ii(0x13_7169, 2); if(jnzw(0x13_718e, 0x23)) goto l_0x13_718e; /* jnz 0x718e */
            ii(0x13_716b, 3); mov(memw_a16[ss, bp - 0x62], bx);         /* mov [bp-0x62], bx */
            ii(0x13_716e, 3); inc(memw_a16[ss, bp - 0x8]);              /* inc word [bp-0x8] */
            ii(0x13_7171, 5); test(memb_a16[ds, bx + 0x1ca1], 0x2);     /* test byte [bx+0x1ca1], 0x2 */
            ii(0x13_7176, 2); if(jzw(0x13_7180, 0x8)) goto l_0x13_7180; /* jz 0x7180 */
            ii(0x13_7178, 3); mov(al, memb_a16[ss, bp - 0x62]);         /* mov al, [bp-0x62] */
            ii(0x13_717b, 2); sub(al, 0x20);                            /* sub al, 0x20 */
            ii(0x13_717d, 2); jmpw(0x13_7183, 0x4); goto l_0x13_7183;   /* jmp 0x7183 */
        //  ii(0x13_717f, 1); Недостижимый код.
l_0x13_7180:
            ii(0x13_7180, 3); mov(al, memb_a16[ss, bp - 0x62]);         /* mov al, [bp-0x62] */
        l_0x13_7183:
            ii(0x13_7183, 3); les(bx, ss, bp - 0x4);                    /* les bx, [bp-0x4] */
            ii(0x13_7186, 3); inc(memw_a16[ss, bp - 0x4]);              /* inc word [bp-0x4] */
            ii(0x13_7189, 3); mov(memb_a16[es, bx], al);                /* mov [es:bx], al */
            ii(0x13_718c, 2); jmpw(0x13_7155, -0x39); goto l_0x13_7155; /* jmp 0x7155 */
        l_0x13_718e:
            ii(0x13_718e, 3); les(bx, ss, bp - 0x4);                    /* les bx, [bp-0x4] */
            ii(0x13_7191, 4); mov(memb_a16[es, bx], 0);                 /* mov byte [es:bx], 0x0 */
            ii(0x13_7195, 3); jmpw(0x13_723c, 0xa4); goto l_0x13_723c;  /* jmp 0x723c */
        l_0x13_7198:
            ii(0x13_7198, 3); lea(ax, bp - 0x58);                       /* lea ax, [bp-0x58] */
            ii(0x13_719b, 1); pushw(ss);                                /* push ss */
            ii(0x13_719c, 1); pushw(ax);                                /* push ax */
            ii(0x13_719d, 3); pushw(memw_a16[ss, bp - 0x7c]);           /* push word [bp-0x7c] */
            ii(0x13_71a0, 3); pushw(memw_a16[ss, bp - 0x7e]);           /* push word [bp-0x7e] */
            ii(0x13_71a3, 1); pushw(cs);                                /* push cs */
            ii(0x13_71a4, 3); callw(0x13_738e, 0x1e7);                  /* call 0x738e */
            ii(0x13_71a7, 3); add(sp, 0x8);                             /* add sp, 0x8 */
            ii(0x13_71aa, 3); add(memw_a16[ss, bp - 0x7e], ax);         /* add [bp-0x7e], ax */
            ii(0x13_71ad, 5); mov(memw_a16[ss, bp - 0x5a], 0);          /* mov word [bp-0x5a], 0x0 */
            ii(0x13_71b2, 2); jmpw(0x13_71b7, 0x3); goto l_0x13_71b7;   /* jmp 0x71b7 */
        l_0x13_71b4:
            ii(0x13_71b4, 3); inc(memw_a16[ss, bp - 0x5a]);             /* inc word [bp-0x5a] */
        l_0x13_71b7:
            ii(0x13_71b7, 4); cmp(memw_a16[ss, bp - 0x5a], 0x3);        /* cmp word [bp-0x5a], 0x3 */
            ii(0x13_71bb, 2); if(jgew(0x13_71e6, 0x29)) goto l_0x13_71e6; /* jge 0x71e6 */
            ii(0x13_71bd, 3); lea(ax, bp - 0x58);                       /* lea ax, [bp-0x58] */
            ii(0x13_71c0, 1); pushw(ss);                                /* push ss */
            ii(0x13_71c1, 1); pushw(ax);                                /* push ax */
            ii(0x13_71c2, 1); nop();                                    /* nop */
            ii(0x13_71c3, 1); pushw(cs);                                /* push cs */
            ii(0x13_71c4, 3); callw(0x13_08d7, -0x68f0);                /* call 0x8d7 */
            ii(0x13_71c7, 2); or(ax, ax);                               /* or ax, ax */
            ii(0x13_71c9, 2); if(jzw(0x13_71ce, 0x3)) goto l_0x13_71ce; /* jz 0x71ce */
            ii(0x13_71cb, 2); jmpw(0x13_71e6, 0x19); goto l_0x13_71e6;  /* jmp 0x71e6 */
        //  ii(0x13_71cd, 1); Недостижимый код.
l_0x13_71ce:
            ii(0x13_71ce, 3); lea(ax, bp - 0x58);                       /* lea ax, [bp-0x58] */
            ii(0x13_71d1, 1); pushw(ss);                                /* push ss */
            ii(0x13_71d2, 1); pushw(ax);                                /* push ax */
            ii(0x13_71d3, 3); pushw(memw_a16[ss, bp - 0x7c]);           /* push word [bp-0x7c] */
            ii(0x13_71d6, 3); pushw(memw_a16[ss, bp - 0x7e]);           /* push word [bp-0x7e] */
            ii(0x13_71d9, 1); pushw(cs);                                /* push cs */
            ii(0x13_71da, 3); callw(0x13_738e, 0x1b1);                  /* call 0x738e */
            ii(0x13_71dd, 3); add(sp, 0x8);                             /* add sp, 0x8 */
            ii(0x13_71e0, 3); add(memw_a16[ss, bp - 0x7e], ax);         /* add [bp-0x7e], ax */
            ii(0x13_71e3, 2); jmpw(0x13_71b4, -0x31); goto l_0x13_71b4; /* jmp 0x71b4 */
        //  ii(0x13_71e5, 1); Недостижимый код.
l_0x13_71e6:
            ii(0x13_71e6, 3); lea(ax, bp - 0x58);                       /* lea ax, [bp-0x58] */
            ii(0x13_71e9, 3); mov(memw_a16[ss, bp - 0x8], ax);          /* mov [bp-0x8], ax */
            ii(0x13_71ec, 3); mov(memw_a16[ss, bp - 0x6], ss);          /* mov [bp-0x6], ss */
            ii(0x13_71ef, 1); pushw(ss);                                /* push ss */
            ii(0x13_71f0, 1); pushw(ax);                                /* push ax */
            ii(0x13_71f1, 1); nop();                                    /* nop */
            ii(0x13_71f2, 1); pushw(cs);                                /* push cs */
            ii(0x13_71f3, 3); callw(0x13_08f7, -0x68ff);                /* call 0x8f7 */
            ii(0x13_71f6, 3); mov(bx, memw_a16[ss, bp - 0x62]);         /* mov bx, [bp-0x62] */
            ii(0x13_71f9, 2); shl(bx, 0x1);                             /* shl bx, 1 */
            ii(0x13_71fb, 4); mov(bx, memw_a16[ds, bx + 0x47e]);        /* mov bx, [bx+0x47e] */
            ii(0x13_71ff, 2); mov(memw_a16[ds, bx], ax);                /* mov [bx], ax */
            ii(0x13_7201, 3); mov(memw_a16[ds, bx + 0x2], dx);          /* mov [bx+0x2], dx */
            ii(0x13_7204, 2); jmpw(0x13_723c, 0x36); goto l_0x13_723c;  /* jmp 0x723c */
        l_0x13_7206:
            ii(0x13_7206, 3); mov(bx, memw_a16[ss, bp - 0x62]);         /* mov bx, [bp-0x62] */
            ii(0x13_7209, 2); shl(bx, 0x1);                             /* shl bx, 1 */
            ii(0x13_720b, 4); mov(bx, memw_a16[ds, bx + 0x47e]);        /* mov bx, [bx+0x47e] */
            ii(0x13_720f, 3); mov(memb_a16[ds, bx], 0x1);               /* mov byte [bx], 0x1 */
            ii(0x13_7212, 2); jmpw(0x13_723c, 0x28); goto l_0x13_723c;  /* jmp 0x723c */
        l_0x13_7214:
            ii(0x13_7214, 3); mov(bx, memw_a16[ss, bp - 0x62]);         /* mov bx, [bp-0x62] */
            ii(0x13_7217, 2); shl(bx, 0x1);                             /* shl bx, 1 */
            ii(0x13_7219, 4); mov(bx, memw_a16[ds, bx + 0x47e]);        /* mov bx, [bx+0x47e] */
            ii(0x13_721d, 3); mov(memb_a16[ds, bx], 0);                 /* mov byte [bx], 0x0 */
        l_0x13_7220:
            ii(0x13_7220, 2); jmpw(0x13_723c, 0x1a); goto l_0x13_723c;  /* jmp 0x723c */
        //  ii(0x13_7222, 2); Недостижимый код.
l_0x13_7224:
            ii(0x13_7224, 2); or(ax, ax);                               /* or ax, ax */
            ii(0x13_7226, 2); if(jzw(0x13_7214, -0x14)) goto l_0x13_7214; /* jz 0x7214 */
            ii(0x13_7228, 1); dec(ax);                                  /* dec ax */
            ii(0x13_7229, 2); if(jzw(0x13_7206, -0x25)) goto l_0x13_7206; /* jz 0x7206 */
            ii(0x13_722b, 1); dec(ax);                                  /* dec ax */
            ii(0x13_722c, 2); if(jnzw(0x13_7231, 0x3)) goto l_0x13_7231; /* jnz 0x7231 */
            ii(0x13_722e, 3); jmpw(0x13_7198, -0x99); goto l_0x13_7198; /* jmp 0x7198 */
        l_0x13_7231:
            ii(0x13_7231, 1); dec(ax);                                  /* dec ax */
            ii(0x13_7232, 2); if(jzw(0x13_7220, -0x14)) goto l_0x13_7220; /* jz 0x7220 */
            ii(0x13_7234, 1); dec(ax);                                  /* dec ax */
            ii(0x13_7235, 2); if(jnzw(0x13_723a, 0x3)) goto l_0x13_723a; /* jnz 0x723a */
            ii(0x13_7237, 3); jmpw(0x13_70ee, -0x14c); goto l_0x13_70ee; /* jmp 0x70ee */
        l_0x13_723a:
            ii(0x13_723a, 2); jmpw(0x13_723c, 0); goto l_0x13_723c;     /* jmp 0x723c */
        l_0x13_723c:
            ii(0x13_723c, 3); jmpw(0x13_6ff9, -0x246); goto l_0x13_6ff9; /* jmp 0x6ff9 */
        //  ii(0x13_723f, 1); Недостижимый код.
l_0x13_7240:
            ii(0x13_7240, 5); cmp(memw_a16[ds, 0x1ea6], 0);             /* cmp word [0x1ea6], 0x0 */
            ii(0x13_7245, 2); if(jzw(0x13_724c, 0x5)) goto l_0x13_724c; /* jz 0x724c */
            ii(0x13_7247, 5); or(memb_a16[ds, 0x19a2], 0x1);            /* or byte [0x19a2], 0x1 */
        l_0x13_724c:
            ii(0x13_724c, 1); nop();                                    /* nop */
            ii(0x13_724d, 1); pushw(cs);                                /* push cs */
            ii(0x13_724e, 3); callw(0x13_e82c, 0x75db);                 /* call 0xe82c */
            ii(0x13_7251, 2); mov(al, ah);                              /* mov al, ah */
            ii(0x13_7253, 2); mov(ah, dl);                              /* mov ah, dl */
            ii(0x13_7255, 2); mov(dl, dh);                              /* mov dl, dh */
            ii(0x13_7257, 2); shl(dh, 0x1);                             /* shl dh, 1 */
            ii(0x13_7259, 2); sbb(dh, dh);                              /* sbb dh, dh */
            ii(0x13_725b, 2); sar(dx, 0x1);                             /* sar dx, 1 */
            ii(0x13_725d, 2); rcr(ax, 0x1);                             /* rcr ax, 1 */
            ii(0x13_725f, 2); sar(dx, 0x1);                             /* sar dx, 1 */
            ii(0x13_7261, 2); rcr(ax, 0x1);                             /* rcr ax, 1 */
            ii(0x13_7263, 4); cmp(dx, memw_a16[ds, 0x22]);              /* cmp dx, [0x22] */
            ii(0x13_7267, 2); if(jbw(0x13_7278, 0xf)) goto l_0x13_7278; /* jb 0x7278 */
            ii(0x13_7269, 2); if(jaw(0x13_7271, 0x6)) goto l_0x13_7271; /* ja 0x7271 */
            ii(0x13_726b, 4); cmp(ax, memw_a16[ds, 0x20]);              /* cmp ax, [0x20] */
            ii(0x13_726f, 2); if(jbew(0x13_7278, 0x7)) goto l_0x13_7278; /* jbe 0x7278 */
        l_0x13_7271:
            ii(0x13_7271, 3); mov(ax, 0x2);                             /* mov ax, 0x2 */
            ii(0x13_7274, 1); popw(ds);                                 /* pop ds */
            ii(0x13_7275, 1); popw(si);                                 /* pop si */
            ii(0x13_7276, 1); leavew();                                 /* leave */
            ii(0x13_7277, 1); retfw(); return;                          /* retf */
        l_0x13_7278:
            ii(0x13_7278, 5); cmp(memw_a16[ds, 0x32], 0x1);             /* cmp word [0x32], 0x1 */
            ii(0x13_727d, 2); if(jlw(0x13_728d, 0xe)) goto l_0x13_728d; /* jl 0x728d */
            ii(0x13_727f, 2); if(jgw(0x13_7281, 0)) goto l_0x13_7281;   /* jg 0x7281 */
        l_0x13_7281:
            ii(0x13_7281, 6); mov(memw_a16[ds, 0x30], 0xffff);          /* mov word [0x30], 0xffff */
            ii(0x13_7287, 6); mov(memw_a16[ds, 0x32], 0);               /* mov word [0x32], 0x0 */
        l_0x13_728d:
            ii(0x13_728d, 3); mov(ax, memw_a16[ds, 0x30]);              /* mov ax, [0x30] */
            ii(0x13_7290, 4); mov(dx, memw_a16[ds, 0x32]);              /* mov dx, [0x32] */
            ii(0x13_7294, 4); cmp(memw_a16[ds, 0x36], dx);              /* cmp [0x36], dx */
            ii(0x13_7298, 2); if(jlw(0x13_72b0, 0x16)) goto l_0x13_72b0; /* jl 0x72b0 */
            ii(0x13_729a, 2); if(jgw(0x13_72a2, 0x6)) goto l_0x13_72a2; /* jg 0x72a2 */
            ii(0x13_729c, 4); cmp(memw_a16[ds, 0x34], ax);              /* cmp [0x34], ax */
            ii(0x13_72a0, 2); if(jbew(0x13_72b0, 0xe)) goto l_0x13_72b0; /* jbe 0x72b0 */
        l_0x13_72a2:
            ii(0x13_72a2, 3); mov(ax, memw_a16[ds, 0x34]);              /* mov ax, [0x34] */
            ii(0x13_72a5, 4); mov(dx, memw_a16[ds, 0x36]);              /* mov dx, [0x36] */
            ii(0x13_72a9, 3); mov(memw_a16[ds, 0x30], ax);              /* mov [0x30], ax */
            ii(0x13_72ac, 4); mov(memw_a16[ds, 0x32], dx);              /* mov [0x32], dx */
        l_0x13_72b0:
            ii(0x13_72b0, 1); pushw(cs);                                /* push cs */
            ii(0x13_72b1, 3); callw(0x13_7458, 0x1a4);                  /* call 0x7458 */
            ii(0x13_72b4, 3); mov(memw_a16[ds, 0x51a0], ax);            /* mov [0x51a0], ax */
            ii(0x13_72b7, 2); pushw(0);                                 /* push 0x0 */
            ii(0x13_72b9, 2); pushw(0x4);                               /* push 0x4 */
            ii(0x13_72bb, 4); pushw(memw_a16[ds, 0x26]);                /* push word [0x26] */
            ii(0x13_72bf, 4); pushw(memw_a16[ds, 0x24]);                /* push word [0x24] */
            ii(0x13_72c3, 1); nop();                                    /* nop */
            ii(0x13_72c4, 1); pushw(cs);                                /* push cs */
            ii(0x13_72c5, 3); callw(0x13_dddc, 0x6b14);                 /* call 0xdddc */
            ii(0x13_72c8, 3); mov(memw_a16[ds, 0x201c], ax);            /* mov [0x201c], ax */
            ii(0x13_72cb, 4); mov(memw_a16[ds, 0x201e], dx);            /* mov [0x201e], dx */
            ii(0x13_72cf, 6); mov(memw_a16[ds, 0x1fa4], 0x1000);        /* mov word [0x1fa4], 0x1000 */
            ii(0x13_72d5, 6); mov(memw_a16[ds, 0x1fa6], 0);             /* mov word [0x1fa6], 0x0 */
            ii(0x13_72db, 3); add(ax, 0x808);                           /* add ax, 0x808 */
            ii(0x13_72de, 3); adc(dx, 0);                               /* adc dx, 0x0 */
            ii(0x13_72e1, 2); shl(ax, 0x1);                             /* shl ax, 1 */
            ii(0x13_72e3, 2); rcl(dx, 0x1);                             /* rcl dx, 1 */
            ii(0x13_72e5, 3); mov(memw_a16[ds, 0x4ff4], ax);            /* mov [0x4ff4], ax */
            ii(0x13_72e8, 4); mov(memw_a16[ds, 0x4ff6], dx);            /* mov [0x4ff6], dx */
            ii(0x13_72ec, 4); mov(cx, memw_a16[ds, 0x201c]);            /* mov cx, [0x201c] */
            ii(0x13_72f0, 4); mov(bx, memw_a16[ds, 0x201e]);            /* mov bx, [0x201e] */
            ii(0x13_72f4, 3); add(cx, 0x8);                             /* add cx, 0x8 */
            ii(0x13_72f7, 3); adc(bx, 0);                               /* adc bx, 0x0 */
            ii(0x13_72fa, 2); shl(cx, 0x1);                             /* shl cx, 1 */
            ii(0x13_72fc, 2); rcl(bx, 0x1);                             /* rcl bx, 1 */
            ii(0x13_72fe, 2); add(ax, cx);                              /* add ax, cx */
            ii(0x13_7300, 2); adc(dx, bx);                              /* adc dx, bx */
            ii(0x13_7302, 3); mov(memw_a16[ds, 0x4fb4], ax);            /* mov [0x4fb4], ax */
            ii(0x13_7305, 4); mov(memw_a16[ds, 0x4fb6], dx);            /* mov [0x4fb6], dx */
            ii(0x13_7309, 4); mov(cx, memw_a16[ds, 0x201c]);            /* mov cx, [0x201c] */
            ii(0x13_730d, 4); mov(bx, memw_a16[ds, 0x201e]);            /* mov bx, [0x201e] */
            ii(0x13_7311, 3); add(cx, 0x4);                             /* add cx, 0x4 */
            ii(0x13_7314, 3); adc(bx, 0);                               /* adc bx, 0x0 */
            ii(0x13_7317, 2); shl(cx, 0x1);                             /* shl cx, 1 */
            ii(0x13_7319, 2); rcl(bx, 0x1);                             /* rcl bx, 1 */
            ii(0x13_731b, 2); shl(cx, 0x1);                             /* shl cx, 1 */
            ii(0x13_731d, 2); rcl(bx, 0x1);                             /* rcl bx, 1 */
            ii(0x13_731f, 2); add(ax, cx);                              /* add ax, cx */
            ii(0x13_7321, 2); adc(dx, bx);                              /* adc dx, bx */
            ii(0x13_7323, 3); mov(memw_a16[ds, 0x4f8c], ax);            /* mov [0x4f8c], ax */
            ii(0x13_7326, 4); mov(memw_a16[ds, 0x4f8e], dx);            /* mov [0x4f8e], dx */
            ii(0x13_732a, 3); test(ax, 0xfff);                          /* test ax, 0xfff */
            ii(0x13_732d, 2); if(jzw(0x13_733f, 0x10)) goto l_0x13_733f; /* jz 0x733f */
            ii(0x13_732f, 3); add(ax, 0x1000);                          /* add ax, 0x1000 */
            ii(0x13_7332, 3); adc(dx, 0);                               /* adc dx, 0x0 */
            ii(0x13_7335, 3); and(ax, 0xf000);                          /* and ax, 0xf000 */
            ii(0x13_7338, 3); mov(memw_a16[ds, 0x4f8c], ax);            /* mov [0x4f8c], ax */
            ii(0x13_733b, 4); mov(memw_a16[ds, 0x4f8e], dx);            /* mov [0x4f8e], dx */
        l_0x13_733f:
            ii(0x13_733f, 3); mov(ax, memw_a16[ds, 0x201c]);            /* mov ax, [0x201c] */
            ii(0x13_7342, 4); mov(dx, memw_a16[ds, 0x201e]);            /* mov dx, [0x201e] */
            ii(0x13_7346, 2); shl(ax, 0x1);                             /* shl ax, 1 */
            ii(0x13_7348, 2); rcl(dx, 0x1);                             /* rcl dx, 1 */
            ii(0x13_734a, 2); shl(ax, 0x1);                             /* shl ax, 1 */
            ii(0x13_734c, 2); rcl(dx, 0x1);                             /* rcl dx, 1 */
            ii(0x13_734e, 4); add(ax, memw_a16[ds, 0x4f8c]);            /* add ax, [0x4f8c] */
            ii(0x13_7352, 4); adc(dx, memw_a16[ds, 0x4f8e]);            /* adc dx, [0x4f8e] */
            ii(0x13_7356, 3); mov(memw_a16[ds, 0x4f90], ax);            /* mov [0x4f90], ax */
            ii(0x13_7359, 4); mov(memw_a16[ds, 0x4f92], dx);            /* mov [0x4f92], dx */
            ii(0x13_735d, 2); mov(al, ah);                              /* mov al, ah */
            ii(0x13_735f, 2); mov(ah, dl);                              /* mov ah, dl */
            ii(0x13_7361, 2); mov(dl, dh);                              /* mov dl, dh */
            ii(0x13_7363, 2); sub(dh, dh);                              /* sub dh, dh */
            ii(0x13_7365, 2); shr(dx, 0x1);                             /* shr dx, 1 */
            ii(0x13_7367, 2); rcr(ax, 0x1);                             /* rcr ax, 1 */
            ii(0x13_7369, 2); shr(dx, 0x1);                             /* shr dx, 1 */
            ii(0x13_736b, 2); rcr(ax, 0x1);                             /* rcr ax, 1 */
            ii(0x13_736d, 2); shr(dx, 0x1);                             /* shr dx, 1 */
            ii(0x13_736f, 2); rcr(ax, 0x1);                             /* rcr ax, 1 */
            ii(0x13_7371, 2); shr(dx, 0x1);                             /* shr dx, 1 */
            ii(0x13_7373, 2); rcr(ax, 0x1);                             /* rcr ax, 1 */
            ii(0x13_7375, 3); mov(memw_a16[ds, 0x519c], ax);            /* mov [0x519c], ax */
            ii(0x13_7378, 6); test(memw_a16[ds, 0x4f90], 0xfff);        /* test word [0x4f90], 0xfff */
            ii(0x13_737e, 2); if(jzw(0x13_7384, 0x4)) goto l_0x13_7384; /* jz 0x7384 */
            ii(0x13_7380, 1); inc(ax);                                  /* inc ax */
            ii(0x13_7381, 3); mov(memw_a16[ds, 0x519c], ax);            /* mov [0x519c], ax */
        l_0x13_7384:
            ii(0x13_7384, 2); sub(ax, ax);                              /* sub ax, ax */
            ii(0x13_7386, 1); popw(ds);                                 /* pop ds */
            ii(0x13_7387, 1); popw(si);                                 /* pop si */
            ii(0x13_7388, 1); leavew();                                 /* leave */
            ii(0x13_7389, 1); retfw(); return;                          /* retf */
        }
    }
}
