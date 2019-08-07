using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("a7cd48d4-8b37-4ac7-b092-00e025e0d20d")]
        public void Method_0013_d48a()
        {
            ii(0x13_d48a, 3); mov(ax, 0x3500);                          /* mov ax, 0x3500 */
            ii(0x13_d48d, 2); @int(0x21);                               /* int 0x21 */
            ii(0x13_d48f, 4); mov(memw_a16[ds, 0x1c40], bx);            /* mov [0x1c40], bx */
            ii(0x13_d493, 4); mov(memw_a16[ds, 0x1c42], es);            /* mov [0x1c42], es */
            ii(0x13_d497, 1); pushw(cs);                                /* push cs */
            ii(0x13_d498, 1); popw(ds);                                 /* pop ds */
            ii(0x13_d499, 3); mov(ax, 0x2500);                          /* mov ax, 0x2500 */
            ii(0x13_d49c, 3); mov(dx, 0x893b);                          /* mov dx, 0x893b */
            ii(0x13_d49f, 2); @int(0x21);                               /* int 0x21 */
            ii(0x13_d4a1, 1); pushw(ss);                                /* push ss */
            ii(0x13_d4a2, 1); popw(ds);                                 /* pop ds */
            ii(0x13_d4a3, 4); mov(cx, memw_a16[ds, 0x1dbe]);            /* mov cx, [0x1dbe] */
            ii(0x13_d4a7, 2); if(jcxzw(0x13_d4d7, 0x2e)) goto l_0x13_d4d7; /* jcxz 0xd4d7 */
            ii(0x13_d4a9, 4); mov(es, memw_a16[ds, 0x1c54]);            /* mov es, [0x1c54] */
            ii(0x13_d4ad, 5); mov(si, memw_a16[es, 0x2c]);              /* mov si, [es:0x2c] */
            ii(0x13_d4b2, 4); lds(ax, ds, 0x1dc0);                      /* lds ax, [0x1dc0] */
            ii(0x13_d4b6, 2); mov(dx, ds);                              /* mov dx, ds */
            ii(0x13_d4b8, 2); xor(bx, bx);                              /* xor bx, bx */
            ii(0x13_d4ba, 5); callw_a16_far_ind(ss, 0x1dbc);            /* call far word [ss:0x1dbc] */
            ii(0x13_d4bf, 2); if(jaew(0x13_d4c6, 0x5)) goto l_0x13_d4c6; /* jae 0xd4c6 */
            ii(0x13_d4c1, 1); pushw(ss);                                /* push ss */
            ii(0x13_d4c2, 1); popw(ds);                                 /* pop ds */
            ii(0x13_d4c3, 3); jmpw_func(0x13_e212, 0xd4c); return;      /* jmp 0xe212 */
        l_0x13_d4c6:
            ii(0x13_d4c6, 5); lds(ax, ss, 0x1dc4);                      /* lds ax, [ss:0x1dc4] */
            ii(0x13_d4cb, 2); mov(dx, ds);                              /* mov dx, ds */
            ii(0x13_d4cd, 3); mov(bx, 0x3);                             /* mov bx, 0x3 */
            ii(0x13_d4d0, 5); callw_a16_far_ind(ss, 0x1dbc);            /* call far word [ss:0x1dbc] */
            ii(0x13_d4d5, 1); pushw(ss);                                /* push ss */
            ii(0x13_d4d6, 1); popw(ds);                                 /* pop ds */
        l_0x13_d4d7:
            ii(0x13_d4d7, 4); mov(es, memw_a16[ds, 0x1c54]);            /* mov es, [0x1c54] */
            ii(0x13_d4db, 5); mov(cx, memw_a16[es, 0x2c]);              /* mov cx, [es:0x2c] */
            ii(0x13_d4e0, 2); if(jcxzw(0x13_d520, 0x3e)) goto l_0x13_d520; /* jcxz 0xd520 */
            ii(0x13_d4e2, 2); mov(es, cx);                              /* mov es, cx */
            ii(0x13_d4e4, 2); xor(di, di);                              /* xor di, di */
        l_0x13_d4e6:
            ii(0x13_d4e6, 4); cmp(memb_a16[es, di], 0);                 /* cmp byte [es:di], 0x0 */
            ii(0x13_d4ea, 2); if(jzw(0x13_d520, 0x34)) goto l_0x13_d520; /* jz 0xd520 */
            ii(0x13_d4ec, 3); mov(cx, 0xd);                             /* mov cx, 0xd */
            ii(0x13_d4ef, 3); mov(si, 0x1c32);                          /* mov si, 0x1c32 */
            ii(0x13_d4f2, 2); repe_a16(() => cmpsb_a16());              /* repe cmpsb */
            ii(0x13_d4f4, 2); if(jzw(0x13_d501, 0xb)) goto l_0x13_d501; /* jz 0xd501 */
            ii(0x13_d4f6, 3); mov(cx, 0x7fff);                          /* mov cx, 0x7fff */
            ii(0x13_d4f9, 2); xor(ax, ax);                              /* xor ax, ax */
            ii(0x13_d4fb, 2); repne_a16(() => scasb_a16());             /* repne scasb */
            ii(0x13_d4fd, 2); if(jnzw(0x13_d520, 0x21)) goto l_0x13_d520; /* jnz 0xd520 */
            ii(0x13_d4ff, 2); jmpw(0x13_d4e6, -0x1b); goto l_0x13_d4e6; /* jmp 0xd4e6 */
        l_0x13_d501:
            ii(0x13_d501, 1); pushw(es);                                /* push es */
            ii(0x13_d502, 1); pushw(ds);                                /* push ds */
            ii(0x13_d503, 1); popw(es);                                 /* pop es */
            ii(0x13_d504, 1); popw(ds);                                 /* pop ds */
            ii(0x13_d505, 2); mov(si, di);                              /* mov si, di */
            ii(0x13_d507, 3); mov(di, 0x1c5d);                          /* mov di, 0x1c5d */
            ii(0x13_d50a, 2); mov(cl, 0x4);                             /* mov cl, 0x4 */
        l_0x13_d50c:
            ii(0x13_d50c, 1); lodsb_a16();                              /* lodsb */
            ii(0x13_d50d, 2); sub(al, 0x41);                            /* sub al, 0x41 */
            ii(0x13_d50f, 2); if(jbw(0x13_d51e, 0xd)) goto l_0x13_d51e; /* jb 0xd51e */
            ii(0x13_d511, 2); shl(al, cl);                              /* shl al, cl */
            ii(0x13_d513, 1); xchg(dx, ax);                             /* xchg dx, ax */
            ii(0x13_d514, 1); lodsb_a16();                              /* lodsb */
            ii(0x13_d515, 2); sub(al, 0x41);                            /* sub al, 0x41 */
            ii(0x13_d517, 2); if(jbw(0x13_d51e, 0x5)) goto l_0x13_d51e; /* jb 0xd51e */
            ii(0x13_d519, 2); or(al, dl);                               /* or al, dl */
            ii(0x13_d51b, 1); stosb_a16();                              /* stosb */
            ii(0x13_d51c, 2); jmpw(0x13_d50c, -0x12); goto l_0x13_d50c; /* jmp 0xd50c */
        l_0x13_d51e:
            ii(0x13_d51e, 1); pushw(ss);                                /* push ss */
            ii(0x13_d51f, 1); popw(ds);                                 /* pop ds */
        l_0x13_d520:
            ii(0x13_d520, 3); mov(bx, 0x4);                             /* mov bx, 0x4 */
        l_0x13_d523:
            ii(0x13_d523, 5); and(memb_a16[ds, bx + 0x1c5d], -0x41 /* 0xbf */); /* and byte [bx+0x1c5d], 0xbf */
            ii(0x13_d528, 3); mov(ax, 0x4400);                          /* mov ax, 0x4400 */
            ii(0x13_d52b, 2); @int(0x21);                               /* int 0x21 */
            ii(0x13_d52d, 2); if(jbw(0x13_d539, 0xa)) goto l_0x13_d539; /* jb 0xd539 */
            ii(0x13_d52f, 3); test(dl, 0x80);                           /* test dl, 0x80 */
            ii(0x13_d532, 2); if(jzw(0x13_d539, 0x5)) goto l_0x13_d539; /* jz 0xd539 */
            ii(0x13_d534, 5); or(memb_a16[ds, bx + 0x1c5d], 0x40);      /* or byte [bx+0x1c5d], 0x40 */
        l_0x13_d539:
            ii(0x13_d539, 1); dec(bx);                                  /* dec bx */
            ii(0x13_d53a, 2); if(jnsw(0x13_d523, -0x19)) goto l_0x13_d523; /* jns 0xd523 */
            ii(0x13_d53c, 3); mov(si, 0x1dc8);                          /* mov si, 0x1dc8 */
            ii(0x13_d53f, 3); mov(di, 0x1dc8);                          /* mov di, 0x1dc8 */
            ii(0x13_d542, 3); callw(0x13_d5ff, 0xba);                   /* call 0xd5ff */
            ii(0x13_d545, 3); mov(si, 0x1dc8);                          /* mov si, 0x1dc8 */
            ii(0x13_d548, 3); mov(di, 0x1dc8);                          /* mov di, 0x1dc8 */
            ii(0x13_d54b, 3); callw(0x13_d5ff, 0xb1);                   /* call 0xd5ff */
            ii(0x13_d54e, 1); retfw(); return;                          /* retf */
        }
    }
}
