using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("4887c00d-0e4f-4758-91c4-8a6c40aa7813")]
        public void Method_0015_f15e()
        {
            ii(0x15_f15e, 4); enterw(0x24, 0);                          /* enter 0x24, 0x0 */
            ii(0x15_f162, 1); pushw(di);                                /* push di */
            ii(0x15_f163, 1); pushw(si);                                /* push si */
            ii(0x15_f164, 4); mov(es, memw_a16[ds, 0x3fd6]);            /* mov es, [0x3fd6] */
            ii(0x15_f168, 4); mov(ax, memw_a16[es, 0x3b78]);            /* mov ax, [es:0x3b78] */
            ii(0x15_f16c, 5); mov(memw_a16[ss, bp - 0xa], 0);           /* mov word [bp-0xa], 0x0 */
            ii(0x15_f171, 3); mov(memw_a16[ss, bp - 0x8], ax);          /* mov [bp-0x8], ax */
            ii(0x15_f174, 3); les(bx, ss, bp - 0xa);                    /* les bx, [bp-0xa] */
            ii(0x15_f177, 5); cmp(memb_a16[es, bx + 0x2f], 0x3);        /* cmp byte [es:bx+0x2f], 0x3 */
            ii(0x15_f17c, 2); if(jlw(0x15_f181, 0x3)) goto l_0x15_f181; /* jl 0xf181 */
            ii(0x15_f17e, 3); jmpw(0x15_f187, 0x6); goto l_0x15_f187;   /* jmp 0xf187 */
        l_0x15_f181:
            ii(0x15_f181, 3); mov(ax, 0);                               /* mov ax, 0x0 */
            ii(0x15_f184, 3); jmpw(0x15_f578, 0x3f1); goto l_0x15_f578; /* jmp 0xf578 */
        l_0x15_f187:
            ii(0x15_f187, 4); cmp(memw_a16[ss, bp + 0x6], 0);           /* cmp word [bp+0x6], 0x0 */
            ii(0x15_f18b, 2); if(jnzw(0x15_f190, 0x3)) goto l_0x15_f190; /* jnz 0xf190 */
            ii(0x15_f18d, 3); jmpw(0x15_f2c9, 0x139); goto l_0x15_f2c9; /* jmp 0xf2c9 */
        l_0x15_f190:
            ii(0x15_f190, 2); sub(ax, ax);                              /* sub ax, ax */
            ii(0x15_f192, 3); mov(memw_a16[ss, bp - 0x12], ax);         /* mov [bp-0x12], ax */
            ii(0x15_f195, 3); mov(memw_a16[ss, bp - 0x14], ax);         /* mov [bp-0x14], ax */
            ii(0x15_f198, 3); mov(si, 0x4);                             /* mov si, 0x4 */
        l_0x15_f19b:
            ii(0x15_f19b, 1); dec(si);                                  /* dec si */
            ii(0x15_f19c, 3); cmp(si, 0);                               /* cmp si, 0x0 */
            ii(0x15_f19f, 2); if(jgew(0x15_f1a4, 0x3)) goto l_0x15_f1a4; /* jge 0xf1a4 */
            ii(0x15_f1a1, 3); jmpw(0x15_f290, 0xec); goto l_0x15_f290;  /* jmp 0xf290 */
        l_0x15_f1a4:
            ii(0x15_f1a4, 3); imul(bx, si, 0x1b);                       /* imul bx, si, 0x1b */
            ii(0x15_f1a7, 4); add(bx, 0x2e3c);                          /* add bx, 0x2e3c */
            ii(0x15_f1ab, 3); mov(memw_a16[ss, bp - 0x18], bx);         /* mov [bp-0x18], bx */
            ii(0x15_f1ae, 3); mov(memw_a16[ss, bp - 0x16], ds);         /* mov [bp-0x16], ds */
            ii(0x15_f1b1, 4); cmp(memb_a16[ds, bx + 0x17], 0);          /* cmp byte [bx+0x17], 0x0 */
            ii(0x15_f1b5, 2); if(jnzw(0x15_f1ba, 0x3)) goto l_0x15_f1ba; /* jnz 0xf1ba */
            ii(0x15_f1b7, 3); jmpw(0x15_f28d, 0xd3); goto l_0x15_f28d;  /* jmp 0xf28d */
        l_0x15_f1ba:
            ii(0x15_f1ba, 4); inc(memb_a16[ds, 0x2ea8]);                /* inc byte [0x2ea8] */
            ii(0x15_f1be, 3); lea(ax, bp - 0x1c);                       /* lea ax, [bp-0x1c] */
            ii(0x15_f1c1, 1); pushw(ss);                                /* push ss */
            ii(0x15_f1c2, 1); pushw(ax);                                /* push ax */
            ii(0x15_f1c3, 3); les(bx, ss, bp - 0x18);                   /* les bx, [bp-0x18] */
            ii(0x15_f1c6, 4); pushw(memw_a16[es, bx + 0x12]);           /* push word [es:bx+0x12] */
            ii(0x15_f1ca, 4); pushw(memw_a16[es, bx + 0x10]);           /* push word [es:bx+0x10] */
            ii(0x15_f1ce, 3); les(bx, ss, bp - 0x18);                   /* les bx, [bp-0x18] */
            ii(0x15_f1d1, 4); pushw(memw_a16[es, bx + 0x14]);           /* push word [es:bx+0x14] */
            ii(0x15_f1d5, 3); callw(0x15_f0ce, -0x10a);                 /* call 0xf0ce */
            ii(0x15_f1d8, 3); add(sp, 0xa);                             /* add sp, 0xa */
            ii(0x15_f1db, 3); cmp(ax, 0);                               /* cmp ax, 0x0 */
            ii(0x15_f1de, 2); if(jnzw(0x15_f1e3, 0x3)) goto l_0x15_f1e3; /* jnz 0xf1e3 */
            ii(0x15_f1e0, 3); jmpw(0x15_f1e6, 0x3); goto l_0x15_f1e6;   /* jmp 0xf1e6 */
        l_0x15_f1e3:
            ii(0x15_f1e3, 3); jmpw(0x15_f19b, -0x4b); goto l_0x15_f19b; /* jmp 0xf19b */
        l_0x15_f1e6:
            ii(0x15_f1e6, 3); pushw(memw_a16[ss, bp - 0x1a]);           /* push word [bp-0x1a] */
            ii(0x15_f1e9, 3); pushw(memw_a16[ss, bp - 0x1c]);           /* push word [bp-0x1c] */
            ii(0x15_f1ec, 1); pushw(si);                                /* push si */
            ii(0x15_f1ed, 5); callw_far_abs(0x80, 0x1749);              /* call word 0x80:0x1749 */
            ii(0x15_f1f2, 3); add(sp, 0x6);                             /* add sp, 0x6 */
            ii(0x15_f1f5, 2); mov(cx, si);                              /* mov cx, si */
            ii(0x15_f1f7, 2); shl(cl, 0x1);                             /* shl cl, 1 */
            ii(0x15_f1f9, 3); mov(ax, 0x3);                             /* mov ax, 0x3 */
            ii(0x15_f1fc, 2); shl(ax, cl);                              /* shl ax, cl */
            ii(0x15_f1fe, 3); or(memw_a16[ss, bp - 0x14], ax);          /* or [bp-0x14], ax */
            ii(0x15_f201, 3); les(bx, ss, bp - 0x18);                   /* les bx, [bp-0x18] */
            ii(0x15_f204, 4); mov(al, memb_a16[es, bx + 0x16]);         /* mov al, [es:bx+0x16] */
            ii(0x15_f208, 1); cbw();                                    /* cbw */
            ii(0x15_f209, 3); mov(memw_a16[ss, bp - 0xc], ax);          /* mov [bp-0xc], ax */
            ii(0x15_f20c, 4); cmp(memw_a16[ss, bp - 0xc], 0x2);         /* cmp word [bp-0xc], 0x2 */
            ii(0x15_f210, 2); if(jnzw(0x15_f215, 0x3)) goto l_0x15_f215; /* jnz 0xf215 */
            ii(0x15_f212, 3); jmpw(0x15_f230, 0x1b); goto l_0x15_f230;  /* jmp 0xf230 */
        l_0x15_f215:
            ii(0x15_f215, 4); cmp(memw_a16[ss, bp - 0xc], 0x5);         /* cmp word [bp-0xc], 0x5 */
            ii(0x15_f219, 2); if(jnzw(0x15_f21e, 0x3)) goto l_0x15_f21e; /* jnz 0xf21e */
            ii(0x15_f21b, 3); jmpw(0x15_f230, 0x12); goto l_0x15_f230;  /* jmp 0xf230 */
        l_0x15_f21e:
            ii(0x15_f21e, 4); cmp(memw_a16[ss, bp - 0xc], 0x4);         /* cmp word [bp-0xc], 0x4 */
            ii(0x15_f222, 2); if(jnzw(0x15_f227, 0x3)) goto l_0x15_f227; /* jnz 0xf227 */
            ii(0x15_f224, 3); jmpw(0x15_f230, 0x9); goto l_0x15_f230;   /* jmp 0xf230 */
        l_0x15_f227:
            ii(0x15_f227, 4); cmp(memw_a16[ss, bp - 0xc], 0x6);         /* cmp word [bp-0xc], 0x6 */
            ii(0x15_f22b, 2); if(jzw(0x15_f230, 0x3)) goto l_0x15_f230; /* jz 0xf230 */
            ii(0x15_f22d, 3); jmpw(0x15_f235, 0x5); goto l_0x15_f235;   /* jmp 0xf235 */
        l_0x15_f230:
            ii(0x15_f230, 5); mov(memw_a16[ss, bp - 0xc], 0x1);         /* mov word [bp-0xc], 0x1 */
        l_0x15_f235:
            ii(0x15_f235, 2); mov(cx, si);                              /* mov cx, si */
            ii(0x15_f237, 3); shl(cl, 0x2);                             /* shl cl, 0x2 */
            ii(0x15_f23a, 3); mov(ax, memw_a16[ss, bp - 0xc]);          /* mov ax, [bp-0xc] */
            ii(0x15_f23d, 2); shl(ax, cl);                              /* shl ax, cl */
            ii(0x15_f23f, 3); or(memw_a16[ss, bp - 0x12], ax);          /* or [bp-0x12], ax */
            ii(0x15_f242, 3); les(bx, ss, bp - 0x18);                   /* les bx, [bp-0x18] */
            ii(0x15_f245, 4); mov(al, memb_a16[es, bx + 0x17]);         /* mov al, [es:bx+0x17] */
            ii(0x15_f249, 1); cbw();                                    /* cbw */
            ii(0x15_f24a, 1); dec(ax);                                  /* dec ax */
            ii(0x15_f24b, 2); mov(cx, si);                              /* mov cx, si */
            ii(0x15_f24d, 3); shl(cl, 0x2);                             /* shl cl, 0x2 */
            ii(0x15_f250, 3); add(cl, 0x2);                             /* add cl, 0x2 */
            ii(0x15_f253, 2); shl(ax, cl);                              /* shl ax, cl */
            ii(0x15_f255, 3); or(memw_a16[ss, bp - 0x12], ax);          /* or [bp-0x12], ax */
            ii(0x15_f258, 3); les(bx, ss, bp - 0x18);                   /* les bx, [bp-0x18] */
            ii(0x15_f25b, 2); sub(ax, ax);                              /* sub ax, ax */
            ii(0x15_f25d, 4); mov(memw_a16[es, bx + 0x2], ax);          /* mov [es:bx+0x2], ax */
            ii(0x15_f261, 3); mov(memw_a16[es, bx], ax);                /* mov [es:bx], ax */
            ii(0x15_f264, 3); les(bx, ss, bp - 0x18);                   /* les bx, [bp-0x18] */
            ii(0x15_f267, 4); mov(al, memb_a16[es, bx + 0x17]);         /* mov al, [es:bx+0x17] */
            ii(0x15_f26b, 1); cbw();                                    /* cbw */
            ii(0x15_f26c, 1); pushw(ax);                                /* push ax */
            ii(0x15_f26d, 3); pushw(memw_a16[ss, bp - 0x16]);           /* push word [bp-0x16] */
            ii(0x15_f270, 3); pushw(memw_a16[ss, bp - 0x18]);           /* push word [bp-0x18] */
            ii(0x15_f273, 3); les(bx, ss, bp - 0x18);                   /* les bx, [bp-0x18] */
            ii(0x15_f276, 4); pushw(memw_a16[es, bx + 0x14]);           /* push word [es:bx+0x14] */
            ii(0x15_f27a, 3); les(bx, ss, bp - 0x18);                   /* les bx, [bp-0x18] */
            ii(0x15_f27d, 4); pushw(memw_a16[es, bx + 0x12]);           /* push word [es:bx+0x12] */
            ii(0x15_f281, 4); pushw(memw_a16[es, bx + 0x10]);           /* push word [es:bx+0x10] */
            ii(0x15_f285, 5); callw_far_abs(0x80, 0x1534);              /* call word 0x80:0x1534 */
            ii(0x15_f28a, 3); add(sp, 0xc);                             /* add sp, 0xc */
        l_0x15_f28d:
            ii(0x15_f28d, 3); jmpw(0x15_f19b, -0xf5); goto l_0x15_f19b; /* jmp 0xf19b */
        l_0x15_f290:
            ii(0x15_f290, 5); cmp(memb_a16[ds, 0x2ea8], 0);             /* cmp byte [0x2ea8], 0x0 */
            ii(0x15_f295, 2); if(jzw(0x15_f29a, 0x3)) goto l_0x15_f29a; /* jz 0xf29a */
            ii(0x15_f297, 3); jmpw(0x15_f2a0, 0x6); goto l_0x15_f2a0;   /* jmp 0xf2a0 */
        l_0x15_f29a:
            ii(0x15_f29a, 3); mov(ax, 0);                               /* mov ax, 0x0 */
            ii(0x15_f29d, 3); jmpw(0x15_f578, 0x2d8); goto l_0x15_f578; /* jmp 0xf578 */
        l_0x15_f2a0:
            ii(0x15_f2a0, 5); or(memw_a16[ss, bp - 0x14], 0x300);       /* or word [bp-0x14], 0x300 */
            ii(0x15_f2a5, 3); pushw(memw_a16[ss, bp - 0x12]);           /* push word [bp-0x12] */
            ii(0x15_f2a8, 3); pushw(memw_a16[ss, bp - 0x14]);           /* push word [bp-0x14] */
            ii(0x15_f2ab, 2); pushw(0x7);                               /* push 0x7 */
            ii(0x15_f2ad, 5); callw_far_abs(0x80, 0x1749);              /* call word 0x80:0x1749 */
            ii(0x15_f2b2, 3); add(sp, 0x6);                             /* add sp, 0x6 */
            ii(0x15_f2b5, 2); pushw(0);                                 /* push 0x0 */
            ii(0x15_f2b7, 2); pushw(0);                                 /* push 0x0 */
            ii(0x15_f2b9, 2); pushw(0x6);                               /* push 0x6 */
            ii(0x15_f2bb, 5); callw_far_abs(0x80, 0x1749);              /* call word 0x80:0x1749 */
            ii(0x15_f2c0, 3); add(sp, 0x6);                             /* add sp, 0x6 */
            ii(0x15_f2c3, 3); mov(ax, 0);                               /* mov ax, 0x0 */
            ii(0x15_f2c6, 3); jmpw(0x15_f578, 0x2af); goto l_0x15_f578; /* jmp 0xf578 */
        l_0x15_f2c9:
            ii(0x15_f2c9, 5); cmp(memb_a16[ds, 0x2ea8], 0);             /* cmp byte [0x2ea8], 0x0 */
            ii(0x15_f2ce, 2); if(jzw(0x15_f2d3, 0x3)) goto l_0x15_f2d3; /* jz 0xf2d3 */
            ii(0x15_f2d0, 3); jmpw(0x15_f2d9, 0x6); goto l_0x15_f2d9;   /* jmp 0xf2d9 */
        l_0x15_f2d3:
            ii(0x15_f2d3, 3); mov(ax, 0);                               /* mov ax, 0x0 */
            ii(0x15_f2d6, 3); jmpw(0x15_f578, 0x29f); goto l_0x15_f578; /* jmp 0xf578 */
        l_0x15_f2d9:
            ii(0x15_f2d9, 2); sub(ax, ax);                              /* sub ax, ax */
            ii(0x15_f2db, 3); mov(memw_a16[ss, bp - 0x12], ax);         /* mov [bp-0x12], ax */
            ii(0x15_f2de, 3); mov(memw_a16[ss, bp - 0x14], ax);         /* mov [bp-0x14], ax */
            ii(0x15_f2e1, 5); mov(memb_a16[ds, 0x2ea8], 0);             /* mov byte [0x2ea8], 0x0 */
            ii(0x15_f2e6, 3); mov(ax, 0);                               /* mov ax, 0x0 */
            ii(0x15_f2e9, 3); mov(memw_a16[ss, bp - 0x2], ax);          /* mov [bp-0x2], ax */
            ii(0x15_f2ec, 3); mov(memw_a16[ss, bp - 0xc], ax);          /* mov [bp-0xc], ax */
            ii(0x15_f2ef, 5); callw_far_abs(0x80, 0x1729);              /* call word 0x80:0x1729 */
            ii(0x15_f2f4, 3); mov(memw_a16[ss, bp - 0x10], ax);         /* mov [bp-0x10], ax */
            ii(0x15_f2f7, 3); mov(memw_a16[ss, bp - 0xe], dx);          /* mov [bp-0xe], dx */
            ii(0x15_f2fa, 3); pushw(memw_a16[ss, bp - 0x12]);           /* push word [bp-0x12] */
            ii(0x15_f2fd, 3); pushw(memw_a16[ss, bp - 0x14]);           /* push word [bp-0x14] */
            ii(0x15_f300, 2); pushw(0x7);                               /* push 0x7 */
            ii(0x15_f302, 5); callw_far_abs(0x80, 0x1749);              /* call word 0x80:0x1749 */
            ii(0x15_f307, 3); add(sp, 0x6);                             /* add sp, 0x6 */
            ii(0x15_f30a, 2); pushw(0);                                 /* push 0x0 */
            ii(0x15_f30c, 2); pushw(0);                                 /* push 0x0 */
            ii(0x15_f30e, 2); pushw(0x6);                               /* push 0x6 */
            ii(0x15_f310, 5); callw_far_abs(0x80, 0x1749);              /* call word 0x80:0x1749 */
            ii(0x15_f315, 3); add(sp, 0x6);                             /* add sp, 0x6 */
            ii(0x15_f318, 3); mov(si, 0);                               /* mov si, 0x0 */
            ii(0x15_f31b, 3); jmpw(0x15_f31f, 0x1); goto l_0x15_f31f;   /* jmp 0xf31f */
        l_0x15_f31e:
            ii(0x15_f31e, 1); inc(si);                                  /* inc si */
        l_0x15_f31f:
            ii(0x15_f31f, 3); cmp(si, 0x4);                             /* cmp si, 0x4 */
            ii(0x15_f322, 2); if(jlw(0x15_f327, 0x3)) goto l_0x15_f327; /* jl 0xf327 */
            ii(0x15_f324, 3); jmpw(0x15_f55a, 0x233); goto l_0x15_f55a; /* jmp 0xf55a */
        l_0x15_f327:
            ii(0x15_f327, 3); imul(ax, si, 0x1b);                       /* imul ax, si, 0x1b */
            ii(0x15_f32a, 3); add(ax, 0x2e3c);                          /* add ax, 0x2e3c */
            ii(0x15_f32d, 3); mov(memw_a16[ss, bp - 0x18], ax);         /* mov [bp-0x18], ax */
            ii(0x15_f330, 3); mov(memw_a16[ss, bp - 0x16], ds);         /* mov [bp-0x16], ds */
            ii(0x15_f333, 3); mov(al, memb_a16[ss, bp - 0x10]);         /* mov al, [bp-0x10] */
            ii(0x15_f336, 2); and(al, 0x1);                             /* and al, 0x1 */
            ii(0x15_f338, 3); les(bx, ss, bp - 0x18);                   /* les bx, [bp-0x18] */
            ii(0x15_f33b, 4); mov(memb_a16[es, bx + 0x18], al);         /* mov [es:bx+0x18], al */
            ii(0x15_f33f, 2); cmp(al, 0);                               /* cmp al, 0x0 */
            ii(0x15_f341, 2); if(jnzw(0x15_f346, 0x3)) goto l_0x15_f346; /* jnz 0xf346 */
            ii(0x15_f343, 3); jmpw(0x15_f551, 0x20b); goto l_0x15_f551; /* jmp 0xf551 */
        l_0x15_f346:
            ii(0x15_f346, 2); sub(ax, ax);                              /* sub ax, ax */
            ii(0x15_f348, 3); mov(memw_a16[ss, bp - 0x4], ax);          /* mov [bp-0x4], ax */
            ii(0x15_f34b, 3); mov(memw_a16[ss, bp - 0x6], ax);          /* mov [bp-0x6], ax */
            ii(0x15_f34e, 3); les(bx, ss, bp - 0x18);                   /* les bx, [bp-0x18] */
            ii(0x15_f351, 4); mov(al, memb_a16[es, bx + 0x17]);         /* mov al, [es:bx+0x17] */
            ii(0x15_f355, 1); cbw();                                    /* cbw */
            ii(0x15_f356, 1); pushw(ax);                                /* push ax */
            ii(0x15_f357, 3); lea(ax, bp - 0x6);                        /* lea ax, [bp-0x6] */
            ii(0x15_f35a, 1); pushw(ss);                                /* push ss */
            ii(0x15_f35b, 1); pushw(ax);                                /* push ax */
            ii(0x15_f35c, 3); les(bx, ss, bp - 0x18);                   /* les bx, [bp-0x18] */
            ii(0x15_f35f, 4); pushw(memw_a16[es, bx + 0x14]);           /* push word [es:bx+0x14] */
            ii(0x15_f363, 3); les(bx, ss, bp - 0x18);                   /* les bx, [bp-0x18] */
            ii(0x15_f366, 4); pushw(memw_a16[es, bx + 0x12]);           /* push word [es:bx+0x12] */
            ii(0x15_f36a, 4); pushw(memw_a16[es, bx + 0x10]);           /* push word [es:bx+0x10] */
            ii(0x15_f36e, 5); callw_far_abs(0x80, 0x1534);              /* call word 0x80:0x1534 */
            ii(0x15_f373, 3); add(sp, 0xc);                             /* add sp, 0xc */
            ii(0x15_f376, 3); les(bx, ss, bp - 0x18);                   /* les bx, [bp-0x18] */
            ii(0x15_f379, 4); mov(al, memb_a16[es, bx + 0x16]);         /* mov al, [es:bx+0x16] */
            ii(0x15_f37d, 1); cbw();                                    /* cbw */
            ii(0x15_f37e, 3); jmpw(0x15_f534, 0x1b3); goto l_0x15_f534; /* jmp 0xf534 */
        l_0x15_f381:
            ii(0x15_f381, 3); les(bx, ss, bp - 0x18);                   /* les bx, [bp-0x18] */
            ii(0x15_f384, 3); mov(ax, memw_a16[es, bx]);                /* mov ax, [es:bx] */
            ii(0x15_f387, 4); mov(dx, memw_a16[es, bx + 0x2]);          /* mov dx, [es:bx+0x2] */
            ii(0x15_f38b, 3); xor(memw_a16[ss, bp - 0x6], ax);          /* xor [bp-0x6], ax */
            ii(0x15_f38e, 3); xor(memw_a16[ss, bp - 0x4], dx);          /* xor [bp-0x4], dx */
            ii(0x15_f391, 3); mov(ax, memw_a16[ss, bp - 0x4]);          /* mov ax, [bp-0x4] */
            ii(0x15_f394, 3); or(ax, memw_a16[ss, bp - 0x6]);           /* or ax, [bp-0x6] */
            ii(0x15_f397, 2); if(jzw(0x15_f39c, 0x3)) goto l_0x15_f39c; /* jz 0xf39c */
            ii(0x15_f399, 3); jmpw(0x15_f3aa, 0xe); goto l_0x15_f3aa;   /* jmp 0xf3aa */
        l_0x15_f39c:
            ii(0x15_f39c, 3); les(bx, ss, bp - 0x18);                   /* les bx, [bp-0x18] */
            ii(0x15_f39f, 5); mov(memb_a16[es, bx + 0x18], 0);          /* mov byte [es:bx+0x18], 0x0 */
            ii(0x15_f3a4, 3); inc(memw_a16[ss, bp - 0x2]);              /* inc word [bp-0x2] */
            ii(0x15_f3a7, 3); jmpw(0x15_f3ad, 0x3); goto l_0x15_f3ad;   /* jmp 0xf3ad */
        l_0x15_f3aa:
            ii(0x15_f3aa, 3); inc(memw_a16[ss, bp - 0xc]);              /* inc word [bp-0xc] */
        l_0x15_f3ad:
            ii(0x15_f3ad, 3); jmpw(0x15_f551, 0x1a1); goto l_0x15_f551; /* jmp 0xf551 */
        l_0x15_f3b0:
            ii(0x15_f3b0, 3); les(bx, ss, bp - 0x18);                   /* les bx, [bp-0x18] */
            ii(0x15_f3b3, 3); mov(ax, memw_a16[es, bx]);                /* mov ax, [es:bx] */
            ii(0x15_f3b6, 4); mov(dx, memw_a16[es, bx + 0x2]);          /* mov dx, [es:bx+0x2] */
            ii(0x15_f3ba, 3); xor(ax, memw_a16[ss, bp - 0x6]);          /* xor ax, [bp-0x6] */
            ii(0x15_f3bd, 3); xor(dx, memw_a16[ss, bp - 0x4]);          /* xor dx, [bp-0x4] */
            ii(0x15_f3c0, 2); or(dx, ax);                               /* or dx, ax */
            ii(0x15_f3c2, 2); if(jnzw(0x15_f3c7, 0x3)) goto l_0x15_f3c7; /* jnz 0xf3c7 */
            ii(0x15_f3c4, 3); jmpw(0x15_f426, 0x5f); goto l_0x15_f426;  /* jmp 0xf426 */
        l_0x15_f3c7:
            ii(0x15_f3c7, 5); mov(memw_a16[ss, bp - 0x20], 0xffff);     /* mov word [bp-0x20], 0xffff */
            ii(0x15_f3cc, 5); mov(memw_a16[ss, bp - 0x1e], 0xffff);     /* mov word [bp-0x1e], 0xffff */
            ii(0x15_f3d1, 2); mov(al, 0x4);                             /* mov al, 0x4 */
            ii(0x15_f3d3, 3); les(bx, ss, bp - 0x18);                   /* les bx, [bp-0x18] */
            ii(0x15_f3d6, 4); sub(al, memb_a16[es, bx + 0x17]);         /* sub al, [es:bx+0x17] */
            ii(0x15_f3da, 3); shl(al, 0x3);                             /* shl al, 0x3 */
            ii(0x15_f3dd, 1); pushw(ax);                                /* push ax */
            ii(0x15_f3de, 3); lea(ax, bp - 0x20);                       /* lea ax, [bp-0x20] */
            ii(0x15_f3e1, 1); pushw(ax);                                /* push ax */
            ii(0x15_f3e2, 5); callw_far_abs(0x80, 0x435a);              /* call word 0x80:0x435a */
            ii(0x15_f3e7, 3); les(bx, ss, bp - 0x18);                   /* les bx, [bp-0x18] */
            ii(0x15_f3ea, 4); mov(ax, memw_a16[es, bx + 0x4]);          /* mov ax, [es:bx+0x4] */
            ii(0x15_f3ee, 4); mov(dx, memw_a16[es, bx + 0x6]);          /* mov dx, [es:bx+0x6] */
            ii(0x15_f3f2, 3); and(ax, memw_a16[ss, bp - 0x20]);         /* and ax, [bp-0x20] */
            ii(0x15_f3f5, 3); and(dx, memw_a16[ss, bp - 0x1e]);         /* and dx, [bp-0x1e] */
            ii(0x15_f3f8, 3); mov(cx, memw_a16[ss, bp - 0x20]);         /* mov cx, [bp-0x20] */
            ii(0x15_f3fb, 3); mov(bx, memw_a16[ss, bp - 0x1e]);         /* mov bx, [bp-0x1e] */
            ii(0x15_f3fe, 3); and(cx, memw_a16[ss, bp - 0x6]);          /* and cx, [bp-0x6] */
            ii(0x15_f401, 3); and(bx, memw_a16[ss, bp - 0x4]);          /* and bx, [bp-0x4] */
            ii(0x15_f404, 2); cmp(ax, cx);                              /* cmp ax, cx */
            ii(0x15_f406, 2); if(jzw(0x15_f40b, 0x3)) goto l_0x15_f40b; /* jz 0xf40b */
            ii(0x15_f408, 3); jmpw(0x15_f418, 0xd); goto l_0x15_f418;   /* jmp 0xf418 */
        l_0x15_f40b:
            ii(0x15_f40b, 2); cmp(dx, bx);                              /* cmp dx, bx */
            ii(0x15_f40d, 2); if(jzw(0x15_f412, 0x3)) goto l_0x15_f412; /* jz 0xf412 */
            ii(0x15_f40f, 3); jmpw(0x15_f418, 0x6); goto l_0x15_f418;   /* jmp 0xf418 */
        l_0x15_f412:
            ii(0x15_f412, 3); inc(memw_a16[ss, bp - 0xc]);              /* inc word [bp-0xc] */
            ii(0x15_f415, 3); jmpw(0x15_f423, 0xb); goto l_0x15_f423;   /* jmp 0xf423 */
        l_0x15_f418:
            ii(0x15_f418, 3); les(bx, ss, bp - 0x18);                   /* les bx, [bp-0x18] */
            ii(0x15_f41b, 5); mov(memb_a16[es, bx + 0x18], 0);          /* mov byte [es:bx+0x18], 0x0 */
            ii(0x15_f420, 3); inc(memw_a16[ss, bp - 0x2]);              /* inc word [bp-0x2] */
        l_0x15_f423:
            ii(0x15_f423, 3); jmpw(0x15_f431, 0xb); goto l_0x15_f431;   /* jmp 0xf431 */
        l_0x15_f426:
            ii(0x15_f426, 3); les(bx, ss, bp - 0x18);                   /* les bx, [bp-0x18] */
            ii(0x15_f429, 5); mov(memb_a16[es, bx + 0x18], 0);          /* mov byte [es:bx+0x18], 0x0 */
            ii(0x15_f42e, 3); inc(memw_a16[ss, bp - 0x2]);              /* inc word [bp-0x2] */
        l_0x15_f431:
            ii(0x15_f431, 3); jmpw(0x15_f551, 0x11d); goto l_0x15_f551; /* jmp 0xf551 */
        l_0x15_f434:
            ii(0x15_f434, 3); les(bx, ss, bp - 0x18);                   /* les bx, [bp-0x18] */
            ii(0x15_f437, 3); mov(ax, memw_a16[es, bx]);                /* mov ax, [es:bx] */
            ii(0x15_f43a, 4); mov(dx, memw_a16[es, bx + 0x2]);          /* mov dx, [es:bx+0x2] */
            ii(0x15_f43e, 3); xor(ax, memw_a16[ss, bp - 0x6]);          /* xor ax, [bp-0x6] */
            ii(0x15_f441, 3); xor(dx, memw_a16[ss, bp - 0x4]);          /* xor dx, [bp-0x4] */
            ii(0x15_f444, 2); or(dx, ax);                               /* or dx, ax */
            ii(0x15_f446, 2); if(jnzw(0x15_f44b, 0x3)) goto l_0x15_f44b; /* jnz 0xf44b */
            ii(0x15_f448, 3); jmpw(0x15_f51d, 0xd2); goto l_0x15_f51d;  /* jmp 0xf51d */
        l_0x15_f44b:
            ii(0x15_f44b, 5); mov(memw_a16[ss, bp - 0x24], 0xffff);     /* mov word [bp-0x24], 0xffff */
            ii(0x15_f450, 5); mov(memw_a16[ss, bp - 0x22], 0xffff);     /* mov word [bp-0x22], 0xffff */
            ii(0x15_f455, 5); mov(memw_a16[ss, bp - 0x20], 0);          /* mov word [bp-0x20], 0x0 */
            ii(0x15_f45a, 2); mov(al, 0x4);                             /* mov al, 0x4 */
            ii(0x15_f45c, 3); les(bx, ss, bp - 0x18);                   /* les bx, [bp-0x18] */
            ii(0x15_f45f, 4); sub(al, memb_a16[es, bx + 0x17]);         /* sub al, [es:bx+0x17] */
            ii(0x15_f463, 3); shl(al, 0x3);                             /* shl al, 0x3 */
            ii(0x15_f466, 1); pushw(ax);                                /* push ax */
            ii(0x15_f467, 3); lea(ax, bp - 0x24);                       /* lea ax, [bp-0x24] */
            ii(0x15_f46a, 1); pushw(ax);                                /* push ax */
            ii(0x15_f46b, 5); callw_far_abs(0x80, 0x435a);              /* call word 0x80:0x435a */
            ii(0x15_f470, 3); les(bx, ss, bp - 0x18);                   /* les bx, [bp-0x18] */
            ii(0x15_f473, 4); mov(ax, memw_a16[es, bx + 0x8]);          /* mov ax, [es:bx+0x8] */
            ii(0x15_f477, 4); mov(dx, memw_a16[es, bx + 0xa]);          /* mov dx, [es:bx+0xa] */
            ii(0x15_f47b, 3); and(ax, memw_a16[ss, bp - 0x24]);         /* and ax, [bp-0x24] */
            ii(0x15_f47e, 3); and(dx, memw_a16[ss, bp - 0x22]);         /* and dx, [bp-0x22] */
            ii(0x15_f481, 3); mov(cx, memw_a16[ss, bp - 0x6]);          /* mov cx, [bp-0x6] */
            ii(0x15_f484, 3); mov(bx, memw_a16[ss, bp - 0x4]);          /* mov bx, [bp-0x4] */
            ii(0x15_f487, 3); and(cx, memw_a16[ss, bp - 0x24]);         /* and cx, [bp-0x24] */
            ii(0x15_f48a, 3); and(bx, memw_a16[ss, bp - 0x22]);         /* and bx, [bp-0x22] */
            ii(0x15_f48d, 2); cmp(dx, bx);                              /* cmp dx, bx */
            ii(0x15_f48f, 2); if(jbew(0x15_f494, 0x3)) goto l_0x15_f494; /* jbe 0xf494 */
            ii(0x15_f491, 3); jmpw(0x15_f4d8, 0x44); goto l_0x15_f4d8;  /* jmp 0xf4d8 */
        l_0x15_f494:
            ii(0x15_f494, 2); if(jaew(0x15_f499, 0x3)) goto l_0x15_f499; /* jae 0xf499 */
            ii(0x15_f496, 3); jmpw(0x15_f4a0, 0x7); goto l_0x15_f4a0;   /* jmp 0xf4a0 */
        l_0x15_f499:
            ii(0x15_f499, 2); cmp(ax, cx);                              /* cmp ax, cx */
            ii(0x15_f49b, 2); if(jbew(0x15_f4a0, 0x3)) goto l_0x15_f4a0; /* jbe 0xf4a0 */
            ii(0x15_f49d, 3); jmpw(0x15_f4d8, 0x38); goto l_0x15_f4d8;  /* jmp 0xf4d8 */
        l_0x15_f4a0:
            ii(0x15_f4a0, 3); les(bx, ss, bp - 0x18);                   /* les bx, [bp-0x18] */
            ii(0x15_f4a3, 4); mov(ax, memw_a16[es, bx + 0xc]);          /* mov ax, [es:bx+0xc] */
            ii(0x15_f4a7, 4); mov(dx, memw_a16[es, bx + 0xe]);          /* mov dx, [es:bx+0xe] */
            ii(0x15_f4ab, 3); and(ax, memw_a16[ss, bp - 0x24]);         /* and ax, [bp-0x24] */
            ii(0x15_f4ae, 3); and(dx, memw_a16[ss, bp - 0x22]);         /* and dx, [bp-0x22] */
            ii(0x15_f4b1, 3); mov(cx, memw_a16[ss, bp - 0x6]);          /* mov cx, [bp-0x6] */
            ii(0x15_f4b4, 3); mov(bx, memw_a16[ss, bp - 0x4]);          /* mov bx, [bp-0x4] */
            ii(0x15_f4b7, 3); and(cx, memw_a16[ss, bp - 0x24]);         /* and cx, [bp-0x24] */
            ii(0x15_f4ba, 3); and(bx, memw_a16[ss, bp - 0x22]);         /* and bx, [bp-0x22] */
            ii(0x15_f4bd, 2); cmp(dx, bx);                              /* cmp dx, bx */
            ii(0x15_f4bf, 2); if(jaew(0x15_f4c4, 0x3)) goto l_0x15_f4c4; /* jae 0xf4c4 */
            ii(0x15_f4c1, 3); jmpw(0x15_f4d8, 0x14); goto l_0x15_f4d8;  /* jmp 0xf4d8 */
        l_0x15_f4c4:
            ii(0x15_f4c4, 2); if(jbew(0x15_f4c9, 0x3)) goto l_0x15_f4c9; /* jbe 0xf4c9 */
            ii(0x15_f4c6, 3); jmpw(0x15_f4d0, 0x7); goto l_0x15_f4d0;   /* jmp 0xf4d0 */
        l_0x15_f4c9:
            ii(0x15_f4c9, 2); cmp(ax, cx);                              /* cmp ax, cx */
            ii(0x15_f4cb, 2); if(jaew(0x15_f4d0, 0x3)) goto l_0x15_f4d0; /* jae 0xf4d0 */
            ii(0x15_f4cd, 3); jmpw(0x15_f4d8, 0x8); goto l_0x15_f4d8;   /* jmp 0xf4d8 */
        l_0x15_f4d0:
            ii(0x15_f4d0, 5); mov(memw_a16[ss, bp - 0x20], 0x1);        /* mov word [bp-0x20], 0x1 */
            ii(0x15_f4d5, 3); jmpw(0x15_f4dd, 0x5); goto l_0x15_f4dd;   /* jmp 0xf4dd */
        l_0x15_f4d8:
            ii(0x15_f4d8, 5); mov(memw_a16[ss, bp - 0x20], 0);          /* mov word [bp-0x20], 0x0 */
        l_0x15_f4dd:
            ii(0x15_f4dd, 4); cmp(memw_a16[ss, bp - 0x20], 0);          /* cmp word [bp-0x20], 0x0 */
            ii(0x15_f4e1, 2); if(jzw(0x15_f4e6, 0x3)) goto l_0x15_f4e6; /* jz 0xf4e6 */
            ii(0x15_f4e3, 3); jmpw(0x15_f4f3, 0xd); goto l_0x15_f4f3;   /* jmp 0xf4f3 */
        l_0x15_f4e6:
            ii(0x15_f4e6, 3); les(bx, ss, bp - 0x18);                   /* les bx, [bp-0x18] */
            ii(0x15_f4e9, 5); cmp(memb_a16[es, bx + 0x16], 0x6);        /* cmp byte [es:bx+0x16], 0x6 */
            ii(0x15_f4ee, 2); if(jnzw(0x15_f4f3, 0x3)) goto l_0x15_f4f3; /* jnz 0xf4f3 */
            ii(0x15_f4f0, 3); jmpw(0x15_f509, 0x16); goto l_0x15_f509;  /* jmp 0xf509 */
        l_0x15_f4f3:
            ii(0x15_f4f3, 4); cmp(memw_a16[ss, bp - 0x20], 0);          /* cmp word [bp-0x20], 0x0 */
            ii(0x15_f4f7, 2); if(jnzw(0x15_f4fc, 0x3)) goto l_0x15_f4fc; /* jnz 0xf4fc */
            ii(0x15_f4f9, 3); jmpw(0x15_f50f, 0x13); goto l_0x15_f50f;  /* jmp 0xf50f */
        l_0x15_f4fc:
            ii(0x15_f4fc, 3); les(bx, ss, bp - 0x18);                   /* les bx, [bp-0x18] */
            ii(0x15_f4ff, 5); cmp(memb_a16[es, bx + 0x16], 0x5);        /* cmp byte [es:bx+0x16], 0x5 */
            ii(0x15_f504, 2); if(jzw(0x15_f509, 0x3)) goto l_0x15_f509; /* jz 0xf509 */
            ii(0x15_f506, 3); jmpw(0x15_f50f, 0x6); goto l_0x15_f50f;   /* jmp 0xf50f */
        l_0x15_f509:
            ii(0x15_f509, 3); inc(memw_a16[ss, bp - 0xc]);              /* inc word [bp-0xc] */
            ii(0x15_f50c, 3); jmpw(0x15_f51a, 0xb); goto l_0x15_f51a;   /* jmp 0xf51a */
        l_0x15_f50f:
            ii(0x15_f50f, 3); les(bx, ss, bp - 0x18);                   /* les bx, [bp-0x18] */
            ii(0x15_f512, 5); mov(memb_a16[es, bx + 0x18], 0);          /* mov byte [es:bx+0x18], 0x0 */
            ii(0x15_f517, 3); inc(memw_a16[ss, bp - 0x2]);              /* inc word [bp-0x2] */
        l_0x15_f51a:
            ii(0x15_f51a, 3); jmpw(0x15_f528, 0xb); goto l_0x15_f528;   /* jmp 0xf528 */
        l_0x15_f51d:
            ii(0x15_f51d, 3); les(bx, ss, bp - 0x18);                   /* les bx, [bp-0x18] */
            ii(0x15_f520, 5); mov(memb_a16[es, bx + 0x18], 0);          /* mov byte [es:bx+0x18], 0x0 */
            ii(0x15_f525, 3); inc(memw_a16[ss, bp - 0x2]);              /* inc word [bp-0x2] */
        l_0x15_f528:
            ii(0x15_f528, 3); jmpw(0x15_f551, 0x26); goto l_0x15_f551;  /* jmp 0xf551 */
        l_0x15_f52b:
            ii(0x15_f52b, 3); inc(memw_a16[ss, bp - 0xc]);              /* inc word [bp-0xc] */
            ii(0x15_f52e, 3); jmpw(0x15_f551, 0x20); goto l_0x15_f551;  /* jmp 0xf551 */
        //  ii(0x15_f531, 3); Недостижимый код.
l_0x15_f534:
            ii(0x15_f534, 1); dec(ax);                                  /* dec ax */
            ii(0x15_f535, 1); dec(ax);                                  /* dec ax */
            ii(0x15_f536, 2); if(jnzw(0x15_f53b, 0x3)) goto l_0x15_f53b; /* jnz 0xf53b */
            ii(0x15_f538, 3); jmpw(0x15_f381, -0x1ba); goto l_0x15_f381; /* jmp 0xf381 */
        l_0x15_f53b:
            ii(0x15_f53b, 1); dec(ax);                                  /* dec ax */
            ii(0x15_f53c, 1); dec(ax);                                  /* dec ax */
            ii(0x15_f53d, 2); if(jnzw(0x15_f542, 0x3)) goto l_0x15_f542; /* jnz 0xf542 */
            ii(0x15_f53f, 3); jmpw(0x15_f3b0, -0x192); goto l_0x15_f3b0; /* jmp 0xf3b0 */
        l_0x15_f542:
            ii(0x15_f542, 1); dec(ax);                                  /* dec ax */
            ii(0x15_f543, 2); if(jgew(0x15_f548, 0x3)) goto l_0x15_f548; /* jge 0xf548 */
            ii(0x15_f545, 3); jmpw(0x15_f52b, -0x1d); goto l_0x15_f52b; /* jmp 0xf52b */
        l_0x15_f548:
            ii(0x15_f548, 1); dec(ax);                                  /* dec ax */
            ii(0x15_f549, 2); if(jgw(0x15_f54e, 0x3)) goto l_0x15_f54e; /* jg 0xf54e */
            ii(0x15_f54b, 3); jmpw(0x15_f434, -0x11a); goto l_0x15_f434; /* jmp 0xf434 */
        l_0x15_f54e:
            ii(0x15_f54e, 3); jmpw(0x15_f52b, -0x26); goto l_0x15_f52b; /* jmp 0xf52b */
        l_0x15_f551:
            ii(0x15_f551, 3); shr(memw_a16[ss, bp - 0xe], 0x1);         /* shr word [bp-0xe], 1 */
            ii(0x15_f554, 3); rcr(memw_a16[ss, bp - 0x10], 0x1);        /* rcr word [bp-0x10], 1 */
            ii(0x15_f557, 3); jmpw(0x15_f31e, -0x23c); goto l_0x15_f31e; /* jmp 0xf31e */
        l_0x15_f55a:
            ii(0x15_f55a, 4); cmp(memw_a16[ss, bp - 0x2], 0);           /* cmp word [bp-0x2], 0x0 */
            ii(0x15_f55e, 2); if(jnzw(0x15_f563, 0x3)) goto l_0x15_f563; /* jnz 0xf563 */
            ii(0x15_f560, 3); jmpw(0x15_f572, 0xf); goto l_0x15_f572;   /* jmp 0xf572 */
        l_0x15_f563:
            ii(0x15_f563, 4); cmp(memw_a16[ss, bp - 0xc], 0);           /* cmp word [bp-0xc], 0x0 */
            ii(0x15_f567, 2); if(jzw(0x15_f56c, 0x3)) goto l_0x15_f56c; /* jz 0xf56c */
            ii(0x15_f569, 3); jmpw(0x15_f572, 0x6); goto l_0x15_f572;   /* jmp 0xf572 */
        l_0x15_f56c:
            ii(0x15_f56c, 3); mov(ax, 0x1);                             /* mov ax, 0x1 */
            ii(0x15_f56f, 3); jmpw(0x15_f575, 0x3); goto l_0x15_f575;   /* jmp 0xf575 */
        l_0x15_f572:
            ii(0x15_f572, 3); mov(ax, 0);                               /* mov ax, 0x0 */
        l_0x15_f575:
            ii(0x15_f575, 3); jmpw(0x15_f578, 0); goto l_0x15_f578;     /* jmp 0xf578 */
        l_0x15_f578:
            ii(0x15_f578, 1); popw(si);                                 /* pop si */
            ii(0x15_f579, 1); popw(di);                                 /* pop di */
            ii(0x15_f57a, 1); leavew();                                 /* leave */
            ii(0x15_f57b, 1); retfw(); return;                          /* retf */
        }
    }
}
