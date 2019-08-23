using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x19_9ed2-f7e739e2")]
        public void Method_0019_9ed2()
        {
            ii(0x19_9ed2, 4); enter(0xea, 0);                           /* enter 0xea, 0x0 */
            ii(0x19_9ed6, 1); push(si);                                 /* push si */
            ii(0x19_9ed7, 6); mov(memw[ss, bp - 0x82], 0xffff);         /* mov word [bp-0x82], 0xffff */
            ii(0x19_9edd, 3); mov(ax, memw[ds, 0x3292]);                /* mov ax, [0x3292] */
            ii(0x19_9ee0, 4); or(ax, memw[ds, 0x3290]);                 /* or ax, [0x3290] */
            ii(0x19_9ee4, 2); if(jnz(0x19_9eec, 0x6)) goto l_0x19_9eec; /* jnz 0x9eec */
            ii(0x19_9ee6, 3); mov(ax, 0x1);                             /* mov ax, 0x1 */
            ii(0x19_9ee9, 3); jmp(0x19_a067, 0x17b); goto l_0x19_a067;  /* jmp 0xa067 */
        l_0x19_9eec:
            ii(0x19_9eec, 3); push(memw[ss, bp + 0x6]);                 /* push word [bp+0x6] */
            ii(0x19_9eef, 3); call(0x19_a14c, 0x25a);                   /* call 0xa14c */
            ii(0x19_9ef2, 4); mov(memw[ss, bp - 0x86], ax);             /* mov [bp-0x86], ax */
            ii(0x19_9ef6, 4); mov(memw[ss, bp - 0x84], dx);             /* mov [bp-0x84], dx */
            ii(0x19_9efa, 5); cmp(memb[ds, 0x19f4], 0x1);               /* cmp byte [0x19f4], 0x1 */
            ii(0x19_9eff, 2); if(jnz(0x19_9f3e, 0x3d)) goto l_0x19_9f3e; /* jnz 0x9f3e */
            ii(0x19_9f01, 4); les(bx, ss, bp - 0x86);                   /* les bx, [bp-0x86] */
            ii(0x19_9f05, 5); cmp(memw[es, bx + 0x5c], 0);              /* cmp word [es:bx+0x5c], 0x0 */
            ii(0x19_9f0a, 2); if(jz(0x19_9f17, 0xb)) goto l_0x19_9f17;  /* jz 0x9f17 */
            ii(0x19_9f0c, 1); push(ds);                                 /* push ds */
            ii(0x19_9f0d, 3); push(0x1f9c);                             /* push 0x1f9c */
            ii(0x19_9f10, 3); call(0x1a_1066, 0x7153);                  /* call 0x1066 */
            ii(0x19_9f13, 1); pop(bx);                                  /* pop bx */
            ii(0x19_9f14, 1); pop(bx);                                  /* pop bx */
            ii(0x19_9f15, 2); jmp(0x19_9f3e, 0x27); goto l_0x19_9f3e;   /* jmp 0x9f3e */
        l_0x19_9f17:
            ii(0x19_9f17, 1); push(dx);                                 /* push dx */
            ii(0x19_9f18, 1); push(ax);                                 /* push ax */
            ii(0x19_9f19, 2); push(-0x6 /* 0xfa */);                    /* push 0xfffa */
            ii(0x19_9f1b, 3); lea(ax, bp - 0x80);                       /* lea ax, [bp-0x80] */
            ii(0x19_9f1e, 1); push(ss);                                 /* push ss */
            ii(0x19_9f1f, 1); push(ax);                                 /* push ax */
            ii(0x19_9f20, 3); call(0x19_c5ce, 0x26ab);                  /* call 0xc5ce */
            ii(0x19_9f23, 2); push(0x1);                                /* push 0x1 */
            ii(0x19_9f25, 4); mov(ax, memw[ss, bp - 0x86]);             /* mov ax, [bp-0x86] */
            ii(0x19_9f29, 4); mov(dx, memw[ss, bp - 0x84]);             /* mov dx, [bp-0x84] */
            ii(0x19_9f2d, 3); add(ax, 0x12a);                           /* add ax, 0x12a */
            ii(0x19_9f30, 1); push(dx);                                 /* push dx */
            ii(0x19_9f31, 1); push(ax);                                 /* push ax */
            ii(0x19_9f32, 3); lea(ax, bp - 0x80);                       /* lea ax, [bp-0x80] */
            ii(0x19_9f35, 1); push(ss);                                 /* push ss */
            ii(0x19_9f36, 1); push(ax);                                 /* push ax */
            ii(0x19_9f37, 3); call(0x19_9bb6, -0x384);                  /* call 0x9bb6 */
            ii(0x19_9f3a, 4); mov(memw[ss, bp - 0x82], ax);             /* mov [bp-0x82], ax */
        l_0x19_9f3e:
            ii(0x19_9f3e, 5); cmp(memw[ss, bp - 0x82], 0);              /* cmp word [bp-0x82], 0x0 */
            ii(0x19_9f43, 2); if(jg(0x19_9f48, 0x3)) goto l_0x19_9f48;  /* jg 0x9f48 */
            ii(0x19_9f45, 3); jmp(0x19_9fc8, 0x80); goto l_0x19_9fc8;   /* jmp 0x9fc8 */
        l_0x19_9f48:
            ii(0x19_9f48, 5); cmp(memw[ss, bp - 0x82], 0x2);            /* cmp word [bp-0x82], 0x2 */
            ii(0x19_9f4d, 2); if(jnz(0x19_9f52, 0x3)) goto l_0x19_9f52; /* jnz 0x9f52 */
            ii(0x19_9f4f, 3); jmp(0x19_a04f, 0xfd); goto l_0x19_a04f;   /* jmp 0xa04f */
        l_0x19_9f52:
            ii(0x19_9f52, 2); push(0x2);                                /* push 0x2 */
            ii(0x19_9f54, 4); mov(ax, memw[ss, bp - 0x86]);             /* mov ax, [bp-0x86] */
            ii(0x19_9f58, 4); mov(dx, memw[ss, bp - 0x84]);             /* mov dx, [bp-0x84] */
            ii(0x19_9f5c, 3); add(ax, 0x12a);                           /* add ax, 0x12a */
            ii(0x19_9f5f, 1); push(dx);                                 /* push dx */
            ii(0x19_9f60, 1); push(ax);                                 /* push ax */
            ii(0x19_9f61, 2); push(0);                                  /* push 0x0 */
            ii(0x19_9f63, 2); push(0);                                  /* push 0x0 */
            ii(0x19_9f65, 3); call(0x19_9bb6, -0x3b2);                  /* call 0x9bb6 */
            ii(0x19_9f68, 4); mov(memw[ss, bp - 0x82], ax);             /* mov [bp-0x82], ax */
            ii(0x19_9f6c, 4); les(bx, ds, 0x1f1a);                      /* les bx, [0x1f1a] */
            ii(0x19_9f70, 4); lea(bx, bx + 0x1352);                     /* lea bx, [bx+0x1352] */
            ii(0x19_9f74, 3); mov(si, memw[ss, bp + 0x6]);              /* mov si, [bp+0x6] */
            ii(0x19_9f77, 3); mov(al, memb[es, bx + si]);               /* mov al, [es:bx+si] */
            ii(0x19_9f7a, 2); inc(al);                                  /* inc al */
            ii(0x19_9f7c, 4); mov(bx, memw[ds, 0x1f1a]);                /* mov bx, [0x1f1a] */
            ii(0x19_9f80, 5); mov(memb[es, bx + si + 0x1352], al);      /* mov [es:bx+si+0x1352], al */
            ii(0x19_9f85, 4); push(memw[ss, bp - 0x84]);                /* push word [bp-0x84] */
            ii(0x19_9f89, 4); push(memw[ss, bp - 0x86]);                /* push word [bp-0x86] */
            ii(0x19_9f8d, 3); call(0x19_b228, 0x1298);                  /* call 0xb228 */
            ii(0x19_9f90, 2); or(ax, ax);                               /* or ax, ax */
            ii(0x19_9f92, 2); if(jz(0x19_9fcd, 0x39)) goto l_0x19_9fcd; /* jz 0x9fcd */
        l_0x19_9f94:
            ii(0x19_9f94, 2); push(0x4);                                /* push 0x4 */
            ii(0x19_9f96, 4); mov(ax, memw[ss, bp - 0x86]);             /* mov ax, [bp-0x86] */
            ii(0x19_9f9a, 4); mov(dx, memw[ss, bp - 0x84]);             /* mov dx, [bp-0x84] */
            ii(0x19_9f9e, 3); add(ax, 0x12a);                           /* add ax, 0x12a */
            ii(0x19_9fa1, 1); push(dx);                                 /* push dx */
            ii(0x19_9fa2, 1); push(ax);                                 /* push ax */
            ii(0x19_9fa3, 2); push(0);                                  /* push 0x0 */
            ii(0x19_9fa5, 2); push(0);                                  /* push 0x0 */
            ii(0x19_9fa7, 3); call(0x19_9bb6, -0x3f4);                  /* call 0x9bb6 */
            ii(0x19_9faa, 4); les(bx, ds, 0x1f1a);                      /* les bx, [0x1f1a] */
            ii(0x19_9fae, 4); lea(bx, bx + 0x1352);                     /* lea bx, [bx+0x1352] */
            ii(0x19_9fb2, 3); mov(si, memw[ss, bp + 0x6]);              /* mov si, [bp+0x6] */
            ii(0x19_9fb5, 3); mov(al, memb[es, bx + si]);               /* mov al, [es:bx+si] */
            ii(0x19_9fb8, 2); dec(al);                                  /* dec al */
            ii(0x19_9fba, 4); mov(bx, memw[ds, 0x1f1a]);                /* mov bx, [0x1f1a] */
            ii(0x19_9fbe, 5); mov(memb[es, bx + si + 0x1352], al);      /* mov [es:bx+si+0x1352], al */
            ii(0x19_9fc3, 1); nop();                                    /* nop */
            ii(0x19_9fc4, 1); push(cs);                                 /* push cs */
            ii(0x19_9fc5, 3); call(0x19_fdfb, 0x5e33);                  /* call 0xfdfb */
        l_0x19_9fc8:
            ii(0x19_9fc8, 2); sub(ax, ax);                              /* sub ax, ax */
            ii(0x19_9fca, 3); jmp(0x19_a067, 0x9a); goto l_0x19_a067;   /* jmp 0xa067 */
        l_0x19_9fcd:
            ii(0x19_9fcd, 4); mov(ax, memw[ss, bp - 0x86]);             /* mov ax, [bp-0x86] */
            ii(0x19_9fd1, 4); mov(dx, memw[ss, bp - 0x84]);             /* mov dx, [bp-0x84] */
            ii(0x19_9fd5, 3); add(ax, 0x72);                            /* add ax, 0x72 */
            ii(0x19_9fd8, 1); push(dx);                                 /* push dx */
            ii(0x19_9fd9, 1); push(ax);                                 /* push ax */
            ii(0x19_9fda, 3); call(0x19_c4ae, 0x24d1);                  /* call 0xc4ae */
            ii(0x19_9fdd, 3); mov(memw[ss, bp + 0x4], ax);              /* mov [bp+0x4], ax */
            ii(0x19_9fe0, 2); or(ax, ax);                               /* or ax, ax */
            ii(0x19_9fe2, 2); if(jl(0x19_9f94, -0x50)) goto l_0x19_9f94; /* jl 0x9f94 */
            ii(0x19_9fe4, 4); les(bx, ss, bp - 0x86);                   /* les bx, [bp-0x86] */
            ii(0x19_9fe8, 4); les(bx, es, bx + 0x38);                   /* les bx, [es:bx+0x38] */
            ii(0x19_9fec, 4); mov(memw[es, bx + 0x4], ax);              /* mov [es:bx+0x4], ax */
            ii(0x19_9ff0, 3); mov(ax, memw[ds, 0x19fe]);                /* mov ax, [0x19fe] */
            ii(0x19_9ff3, 4); mov(dx, memw[ds, 0x1a00]);                /* mov dx, [0x1a00] */
            ii(0x19_9ff7, 3); mov(memw[es, bx], ax);                    /* mov [es:bx], ax */
            ii(0x19_9ffa, 4); mov(memw[es, bx + 0x2], dx);              /* mov [es:bx+0x2], dx */
            ii(0x19_9ffe, 3); cmp(ax, 0xffff);                          /* cmp ax, 0xffff */
            ii(0x19_a001, 2); if(jnz(0x19_a007, 0x4)) goto l_0x19_a007; /* jnz 0xa007 */
            ii(0x19_a003, 2); cmp(dx, ax);                              /* cmp dx, ax */
            ii(0x19_a005, 2); if(jz(0x19_a03f, 0x38)) goto l_0x19_a03f; /* jz 0xa03f */
        l_0x19_a007:
            ii(0x19_a007, 4); les(bx, ss, bp - 0x86);                   /* les bx, [bp-0x86] */
            ii(0x19_a00b, 4); mov(ax, memw[es, bx + 0x38]);             /* mov ax, [es:bx+0x38] */
            ii(0x19_a00f, 4); mov(dx, memw[es, bx + 0x3a]);             /* mov dx, [es:bx+0x3a] */
            ii(0x19_a013, 3); add(ax, 0x6);                             /* add ax, 0x6 */
            ii(0x19_a016, 1); push(dx);                                 /* push dx */
            ii(0x19_a017, 1); push(ax);                                 /* push ax */
            ii(0x19_a018, 3); call(0x19_e2de, 0x42c3);                  /* call 0xe2de */
            ii(0x19_a01b, 3); push(memw[ss, bp + 0x4]);                 /* push word [bp+0x4] */
            ii(0x19_a01e, 3); call(0x19_9e8b, -0x196);                  /* call 0x9e8b */
            ii(0x19_a021, 4); push(memw[ss, bp - 0x84]);                /* push word [bp-0x84] */
            ii(0x19_a025, 4); push(memw[ss, bp - 0x86]);                /* push word [bp-0x86] */
            ii(0x19_a029, 3); call(0x19_b5d1, 0x15a5);                  /* call 0xb5d1 */
            ii(0x19_a02c, 2); or(ax, ax);                               /* or ax, ax */
            ii(0x19_a02e, 2); if(jnz(0x19_a03f, 0xf)) goto l_0x19_a03f; /* jnz 0xa03f */
            ii(0x19_a030, 4); push(memw[ss, bp - 0x84]);                /* push word [bp-0x84] */
            ii(0x19_a034, 4); push(memw[ss, bp - 0x86]);                /* push word [bp-0x86] */
            ii(0x19_a038, 3); call(0x19_a993, 0x958);                   /* call 0xa993 */
            ii(0x19_a03b, 2); or(ax, ax);                               /* or ax, ax */
            ii(0x19_a03d, 2); if(jz(0x19_a042, 0x3)) goto l_0x19_a042;  /* jz 0xa042 */
        l_0x19_a03f:
            ii(0x19_a03f, 3); jmp(0x19_9f94, -0xae); goto l_0x19_9f94;  /* jmp 0x9f94 */
        l_0x19_a042:
            ii(0x19_a042, 3); mov(bx, memw[ss, bp + 0x6]);              /* mov bx, [bp+0x6] */
            ii(0x19_a045, 2); shl(bx, 0x1);                             /* shl bx, 1 */
            ii(0x19_a047, 6); mov(memw[ds, bx + 0x1f24], 0x1);          /* mov word [bx+0x1f24], 0x1 */
            ii(0x19_a04d, 2); jmp(0x19_a058, 0x9); goto l_0x19_a058;    /* jmp 0xa058 */
        l_0x19_a04f:
            ii(0x19_a04f, 3); push(memw[ss, bp + 0x4]);                 /* push word [bp+0x4] */
            ii(0x19_a052, 5); call_far_abs(0x80, 0x3ae6);               /* call word 0x80:0x3ae6 */
            ii(0x19_a057, 1); pop(bx);                                  /* pop bx */
        l_0x19_a058:
            ii(0x19_a058, 4); push(memw[ss, bp - 0x84]);                /* push word [bp-0x84] */
            ii(0x19_a05c, 4); push(memw[ss, bp - 0x86]);                /* push word [bp-0x86] */
            ii(0x19_a060, 3); call(0x19_9e88, -0x1db);                  /* call 0x9e88 */
            ii(0x19_a063, 4); mov(ax, memw[ss, bp - 0x82]);             /* mov ax, [bp-0x82] */
        l_0x19_a067:
            ii(0x19_a067, 1); pop(si);                                  /* pop si */
            ii(0x19_a068, 1); leave();                                  /* leave */
            ii(0x19_a069, 3); ret(0x4);                                 /* ret 0x4 */
        }
    }
}
