using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x19_7b4f-3a6b64d7")]
        public void Method_0019_7b4f()
        {
            ii(0x19_7b4f, 4); enterw(0x16, 0);                          /* enter 0x16, 0x0 */
            ii(0x19_7b53, 1); pushw(di);                                /* push di */
            ii(0x19_7b54, 1); pushw(si);                                /* push si */
            ii(0x19_7b55, 4); mov(es, memw_a16[ds, 0x3fa0]);            /* mov es, [0x3fa0] */
            ii(0x19_7b59, 4); mov(ax, memw_a16[es, 0x3b78]);            /* mov ax, [es:0x3b78] */
            ii(0x19_7b5d, 5); mov(memw_a16[ss, bp - 0x8], 0);           /* mov word [bp-0x8], 0x0 */
            ii(0x19_7b62, 3); mov(memw_a16[ss, bp - 0x6], ax);          /* mov [bp-0x6], ax */
            ii(0x19_7b65, 3); pushw(0x800);                             /* push 0x800 */
            ii(0x19_7b68, 5); callw_far_abs(0x80, 0x51e8);              /* call word 0x80:0x51e8 */
            ii(0x19_7b6d, 3); add(sp, 0x2);                             /* add sp, 0x2 */
            ii(0x19_7b70, 4); mov(es, memw_a16[ds, 0x3fa2]);            /* mov es, [0x3fa2] */
            ii(0x19_7b74, 4); mov(memw_a16[es, 0x122], ax);             /* mov [es:0x122], ax */
            ii(0x19_7b78, 5); mov(memw_a16[es, 0x124], dx);             /* mov [es:0x124], dx */
            ii(0x19_7b7d, 4); mov(ax, memw_a16[es, 0x124]);             /* mov ax, [es:0x124] */
            ii(0x19_7b81, 5); or(ax, memw_a16[es, 0x122]);              /* or ax, [es:0x122] */
            ii(0x19_7b86, 2); if(jzw(0x19_7b8b, 0x3)) goto l_0x19_7b8b; /* jz 0x7b8b */
            ii(0x19_7b88, 3); jmpw(0x19_7b91, 0x6); goto l_0x19_7b91;   /* jmp 0x7b91 */
        l_0x19_7b8b:
            ii(0x19_7b8b, 3); mov(ax, 0);                               /* mov ax, 0x0 */
            ii(0x19_7b8e, 3); jmpw(0x19_7d5b, 0x1ca); goto l_0x19_7d5b; /* jmp 0x7d5b */
        l_0x19_7b91:
            ii(0x19_7b91, 4); mov(es, memw_a16[ds, 0x3fa2]);            /* mov es, [0x3fa2] */
            ii(0x19_7b95, 5); pushw(memw_a16[es, 0x124]);               /* push word [es:0x124] */
            ii(0x19_7b9a, 5); pushw(memw_a16[es, 0x122]);               /* push word [es:0x122] */
            ii(0x19_7b9f, 3); callw(0x19_fb20, 0x7f7e);                 /* call 0xfb20 */
            ii(0x19_7ba2, 3); cmp(ax, 0);                               /* cmp ax, 0x0 */
            ii(0x19_7ba5, 2); if(jzw(0x19_7baa, 0x3)) goto l_0x19_7baa; /* jz 0x7baa */
            ii(0x19_7ba7, 3); jmpw(0x19_7bb0, 0x6); goto l_0x19_7bb0;   /* jmp 0x7bb0 */
        l_0x19_7baa:
            ii(0x19_7baa, 3); mov(ax, 0);                               /* mov ax, 0x0 */
            ii(0x19_7bad, 3); jmpw(0x19_7d5b, 0x1ab); goto l_0x19_7d5b; /* jmp 0x7d5b */
        l_0x19_7bb0:
            ii(0x19_7bb0, 2); pushw(0);                                 /* push 0x0 */
            ii(0x19_7bb2, 3); pushw(0x800);                             /* push 0x800 */
            ii(0x19_7bb5, 4); mov(es, memw_a16[ds, 0x3fa2]);            /* mov es, [0x3fa2] */
            ii(0x19_7bb9, 5); pushw(memw_a16[es, 0x124]);               /* push word [es:0x124] */
            ii(0x19_7bbe, 5); pushw(memw_a16[es, 0x122]);               /* push word [es:0x122] */
            ii(0x19_7bc3, 1); nop();                                    /* nop */
            ii(0x19_7bc4, 1); pushw(cs);                                /* push cs */
            ii(0x19_7bc5, 3); callw(0x19_0faf, -0x6c19);                /* call 0xfaf */
            ii(0x19_7bc8, 3); add(sp, 0x8);                             /* add sp, 0x8 */
            ii(0x19_7bcb, 3); mov(si, 0);                               /* mov si, 0x0 */
            ii(0x19_7bce, 3); jmpw(0x19_7bd2, 0x1); goto l_0x19_7bd2;   /* jmp 0x7bd2 */
        l_0x19_7bd1:
            ii(0x19_7bd1, 1); inc(si);                                  /* inc si */
        l_0x19_7bd2:
            ii(0x19_7bd2, 3); cmp(si, 0x4);                             /* cmp si, 0x4 */
            ii(0x19_7bd5, 2); if(jlw(0x19_7bda, 0x3)) goto l_0x19_7bda; /* jl 0x7bda */
            ii(0x19_7bd7, 3); jmpw(0x19_7c45, 0x6b); goto l_0x19_7c45;  /* jmp 0x7c45 */
        l_0x19_7bda:
            ii(0x19_7bda, 2); mov(bx, si);                              /* mov bx, si */
            ii(0x19_7bdc, 3); shl(bx, 0x2);                             /* shl bx, 0x2 */
            ii(0x19_7bdf, 4); mov(ax, memw_a16[ds, bx + 0x1590]);       /* mov ax, [bx+0x1590] */
            ii(0x19_7be3, 4); mov(dx, memw_a16[ds, bx + 0x1592]);       /* mov dx, [bx+0x1592] */
            ii(0x19_7be7, 3); mov(memw_a16[ss, bp - 0x4], ax);          /* mov [bp-0x4], ax */
            ii(0x19_7bea, 3); mov(memw_a16[ss, bp - 0x2], dx);          /* mov [bp-0x2], dx */
            ii(0x19_7bed, 2); mov(bx, si);                              /* mov bx, si */
            ii(0x19_7bef, 3); shl(bx, 0x3);                             /* shl bx, 0x3 */
            ii(0x19_7bf2, 4); mov(es, memw_a16[ds, 0x3fa2]);            /* mov es, [0x3fa2] */
            ii(0x19_7bf6, 5); les(di, es, 0x122);                       /* les di, [es:0x122] */
            ii(0x19_7bfb, 5); mov(memb_a16[es, bx + di + 0x1], 0x1);    /* mov byte [es:bx+di+0x1], 0x1 */
            ii(0x19_7c00, 2); mov(di, si);                              /* mov di, si */
            ii(0x19_7c02, 3); shl(di, 0x3);                             /* shl di, 0x3 */
            ii(0x19_7c05, 4); mov(es, memw_a16[ds, 0x3fa2]);            /* mov es, [0x3fa2] */
            ii(0x19_7c09, 5); les(bx, es, 0x122);                       /* les bx, [es:0x122] */
            ii(0x19_7c0e, 4); mov(memb_a16[es, bx + di], 0x1);          /* mov byte [es:bx+di], 0x1 */
            ii(0x19_7c12, 3); mov(ax, memw_a16[ss, bp - 0x4]);          /* mov ax, [bp-0x4] */
            ii(0x19_7c15, 2); mov(bx, si);                              /* mov bx, si */
            ii(0x19_7c17, 3); shl(bx, 0x3);                             /* shl bx, 0x3 */
            ii(0x19_7c1a, 4); mov(es, memw_a16[ds, 0x3fa2]);            /* mov es, [0x3fa2] */
            ii(0x19_7c1e, 5); les(di, es, 0x122);                       /* les di, [es:0x122] */
            ii(0x19_7c23, 4); mov(memw_a16[es, bx + di + 0x2], ax);     /* mov [es:bx+di+0x2], ax */
            ii(0x19_7c27, 6); mov(memw_a16[es, bx + di + 0x4], 0);      /* mov word [es:bx+di+0x4], 0x0 */
            ii(0x19_7c2d, 3); mov(ax, memw_a16[ss, bp - 0x2]);          /* mov ax, [bp-0x2] */
            ii(0x19_7c30, 2); mov(bx, si);                              /* mov bx, si */
            ii(0x19_7c32, 3); shl(bx, 0x3);                             /* shl bx, 0x3 */
            ii(0x19_7c35, 4); mov(es, memw_a16[ds, 0x3fa2]);            /* mov es, [0x3fa2] */
            ii(0x19_7c39, 5); les(di, es, 0x122);                       /* les di, [es:0x122] */
            ii(0x19_7c3e, 4); mov(memw_a16[es, bx + di + 0x6], ax);     /* mov [es:bx+di+0x6], ax */
            ii(0x19_7c42, 3); jmpw(0x19_7bd1, -0x74); goto l_0x19_7bd1; /* jmp 0x7bd1 */
        l_0x19_7c45:
            ii(0x19_7c45, 3); lea(ax, bp - 0x4);                        /* lea ax, [bp-0x4] */
            ii(0x19_7c48, 3); mov(memw_a16[ss, bp - 0x4], ax);          /* mov [bp-0x4], ax */
            ii(0x19_7c4b, 3); mov(memw_a16[ss, bp - 0x2], ss);          /* mov [bp-0x2], ss */
            ii(0x19_7c4e, 2); mov(bx, ax);                              /* mov bx, ax */
            ii(0x19_7c50, 4); mov(memw_a16[ds, bx], 0);                 /* mov word [bx], 0x0 */
            ii(0x19_7c54, 2); pushw(-0x1 /* 0xff */);                   /* push 0xffff */
            ii(0x19_7c56, 3); pushw(memw_a16[ss, bp - 0x2]);            /* push word [bp-0x2] */
            ii(0x19_7c59, 3); pushw(memw_a16[ss, bp - 0x4]);            /* push word [bp-0x4] */
            ii(0x19_7c5c, 5); callw_far_abs(0x80, 0x53e4);              /* call word 0x80:0x53e4 */
            ii(0x19_7c61, 3); add(sp, 0x6);                             /* add sp, 0x6 */
            ii(0x19_7c64, 3); mov(memw_a16[ss, bp - 0x4], ax);          /* mov [bp-0x4], ax */
            ii(0x19_7c67, 3); mov(memw_a16[ss, bp - 0x2], dx);          /* mov [bp-0x2], dx */
            ii(0x19_7c6a, 3); mov(ax, memw_a16[ss, bp - 0x2]);          /* mov ax, [bp-0x2] */
            ii(0x19_7c6d, 3); or(ax, memw_a16[ss, bp - 0x4]);           /* or ax, [bp-0x4] */
            ii(0x19_7c70, 2); if(jzw(0x19_7c75, 0x3)) goto l_0x19_7c75; /* jz 0x7c75 */
            ii(0x19_7c72, 3); jmpw(0x19_7c7b, 0x6); goto l_0x19_7c7b;   /* jmp 0x7c7b */
        l_0x19_7c75:
            ii(0x19_7c75, 3); mov(ax, 0);                               /* mov ax, 0x0 */
            ii(0x19_7c78, 3); jmpw(0x19_7d5b, 0xe0); goto l_0x19_7d5b;  /* jmp 0x7d5b */
        l_0x19_7c7b:
            ii(0x19_7c7b, 3); mov(ax, memw_a16[ss, bp - 0x2]);          /* mov ax, [bp-0x2] */
            ii(0x19_7c7e, 4); mov(es, memw_a16[ds, 0x3fa4]);            /* mov es, [0x3fa4] */
            ii(0x19_7c82, 4); mov(memw_a16[es, 0], ax);                 /* mov [es:0x0], ax */
            ii(0x19_7c86, 3); lea(ax, bp - 0x10);                       /* lea ax, [bp-0x10] */
            ii(0x19_7c89, 1); pushw(ss);                                /* push ss */
            ii(0x19_7c8a, 1); pushw(ax);                                /* push ax */
            ii(0x19_7c8b, 5); pushw(memw_a16[es, 0]);                   /* push word [es:0x0] */
            ii(0x19_7c90, 5); callw_far_abs(0x80, 0x4f82);              /* call word 0x80:0x4f82 */
            ii(0x19_7c95, 3); add(sp, 0x6);                             /* add sp, 0x6 */
            ii(0x19_7c98, 3); cmp(ax, 0);                               /* cmp ax, 0x0 */
            ii(0x19_7c9b, 2); if(jzw(0x19_7ca0, 0x3)) goto l_0x19_7ca0; /* jz 0x7ca0 */
            ii(0x19_7c9d, 3); jmpw(0x19_7ca6, 0x6); goto l_0x19_7ca6;   /* jmp 0x7ca6 */
        l_0x19_7ca0:
            ii(0x19_7ca0, 3); mov(ax, 0);                               /* mov ax, 0x0 */
            ii(0x19_7ca3, 3); jmpw(0x19_7d5b, 0xb5); goto l_0x19_7d5b;  /* jmp 0x7d5b */
        l_0x19_7ca6:
            ii(0x19_7ca6, 4); or(memb_a16[ss, bp - 0xa], 0x40);         /* or byte [bp-0xa], 0x40 */
            ii(0x19_7caa, 3); lea(ax, bp - 0x10);                       /* lea ax, [bp-0x10] */
            ii(0x19_7cad, 1); pushw(ss);                                /* push ss */
            ii(0x19_7cae, 1); pushw(ax);                                /* push ax */
            ii(0x19_7caf, 4); mov(es, memw_a16[ds, 0x3fa4]);            /* mov es, [0x3fa4] */
            ii(0x19_7cb3, 5); pushw(memw_a16[es, 0]);                   /* push word [es:0x0] */
            ii(0x19_7cb8, 5); callw_far_abs(0x80, 0x4ff4);              /* call word 0x80:0x4ff4 */
            ii(0x19_7cbd, 3); add(sp, 0x6);                             /* add sp, 0x6 */
            ii(0x19_7cc0, 3); cmp(ax, 0);                               /* cmp ax, 0x0 */
            ii(0x19_7cc3, 2); if(jzw(0x19_7cc8, 0x3)) goto l_0x19_7cc8; /* jz 0x7cc8 */
            ii(0x19_7cc5, 3); jmpw(0x19_7cce, 0x6); goto l_0x19_7cce;   /* jmp 0x7cce */
        l_0x19_7cc8:
            ii(0x19_7cc8, 3); mov(ax, 0);                               /* mov ax, 0x0 */
            ii(0x19_7ccb, 3); jmpw(0x19_7d5b, 0x8d); goto l_0x19_7d5b;  /* jmp 0x7d5b */
        l_0x19_7cce:
            ii(0x19_7cce, 4); mov(es, memw_a16[ds, 0x3fa6]);            /* mov es, [0x3fa6] */
            ii(0x19_7cd2, 7); mov(memw_a16[es, 0x126], 0x100);          /* mov word [es:0x126], 0x100 */
            ii(0x19_7cd9, 5); callw_far_abs(0x80, 0x51a8);              /* call word 0x80:0x51a8 */
            ii(0x19_7cde, 3); cmp(ax, 0);                               /* cmp ax, 0x0 */
            ii(0x19_7ce1, 2); if(jnzw(0x19_7ce6, 0x3)) goto l_0x19_7ce6; /* jnz 0x7ce6 */
            ii(0x19_7ce3, 3); jmpw(0x19_7d50, 0x6a); goto l_0x19_7d50;  /* jmp 0x7d50 */
        l_0x19_7ce6:
            ii(0x19_7ce6, 5); mov(memw_a16[ss, bp - 0x4], 0x2718);      /* mov word [bp-0x4], 0x2718 */
            ii(0x19_7ceb, 5); mov(memw_a16[ss, bp - 0x2], 0x88);        /* mov word [bp-0x2], 0x88 */
            ii(0x19_7cf0, 3); mov(ax, memw_a16[ss, bp - 0x2]);          /* mov ax, [bp-0x2] */
            ii(0x19_7cf3, 3); mov(memw_a16[ss, bp - 0x12], ax);         /* mov [bp-0x12], ax */
            ii(0x19_7cf6, 3); mov(ax, memw_a16[ss, bp - 0x4]);          /* mov ax, [bp-0x4] */
            ii(0x19_7cf9, 3); mov(memw_a16[ss, bp - 0x16], ax);         /* mov [bp-0x16], ax */
            ii(0x19_7cfc, 5); mov(memw_a16[ss, bp - 0x14], 0);          /* mov word [bp-0x14], 0x0 */
            ii(0x19_7d01, 3); lea(ax, bp - 0x16);                       /* lea ax, [bp-0x16] */
            ii(0x19_7d04, 1); pushw(ss);                                /* push ss */
            ii(0x19_7d05, 1); pushw(ax);                                /* push ax */
            ii(0x19_7d06, 2); pushw(0);                                 /* push 0x0 */
            ii(0x19_7d08, 5); callw_far_abs(0x80, 0xb38);               /* call word 0x80:0xb38 */
            ii(0x19_7d0d, 3); add(sp, 0x6);                             /* add sp, 0x6 */
            ii(0x19_7d10, 3); mov(si, 0x11);                            /* mov si, 0x11 */
            ii(0x19_7d13, 3); jmpw(0x19_7d17, 0x1); goto l_0x19_7d17;   /* jmp 0x7d17 */
        l_0x19_7d16:
            ii(0x19_7d16, 1); inc(si);                                  /* inc si */
        l_0x19_7d17:
            ii(0x19_7d17, 3); cmp(si, 0x1a);                            /* cmp si, 0x1a */
            ii(0x19_7d1a, 2); if(jlew(0x19_7d1f, 0x3)) goto l_0x19_7d1f; /* jle 0x7d1f */
            ii(0x19_7d1c, 3); jmpw(0x19_7d30, 0x11); goto l_0x19_7d30;  /* jmp 0x7d30 */
        l_0x19_7d1f:
            ii(0x19_7d1f, 3); lea(ax, bp - 0x16);                       /* lea ax, [bp-0x16] */
            ii(0x19_7d22, 1); pushw(ss);                                /* push ss */
            ii(0x19_7d23, 1); pushw(ax);                                /* push ax */
            ii(0x19_7d24, 1); pushw(si);                                /* push si */
            ii(0x19_7d25, 5); callw_far_abs(0x80, 0xb38);               /* call word 0x80:0xb38 */
            ii(0x19_7d2a, 3); add(sp, 0x6);                             /* add sp, 0x6 */
            ii(0x19_7d2d, 3); jmpw(0x19_7d16, -0x1a); goto l_0x19_7d16; /* jmp 0x7d16 */
        l_0x19_7d30:
            ii(0x19_7d30, 3); mov(si, 0x25);                            /* mov si, 0x25 */
            ii(0x19_7d33, 3); jmpw(0x19_7d37, 0x1); goto l_0x19_7d37;   /* jmp 0x7d37 */
        l_0x19_7d36:
            ii(0x19_7d36, 1); inc(si);                                  /* inc si */
        l_0x19_7d37:
            ii(0x19_7d37, 3); cmp(si, 0x2e);                            /* cmp si, 0x2e */
            ii(0x19_7d3a, 2); if(jlew(0x19_7d3f, 0x3)) goto l_0x19_7d3f; /* jle 0x7d3f */
            ii(0x19_7d3c, 3); jmpw(0x19_7d50, 0x11); goto l_0x19_7d50;  /* jmp 0x7d50 */
        l_0x19_7d3f:
            ii(0x19_7d3f, 3); lea(ax, bp - 0x16);                       /* lea ax, [bp-0x16] */
            ii(0x19_7d42, 1); pushw(ss);                                /* push ss */
            ii(0x19_7d43, 1); pushw(ax);                                /* push ax */
            ii(0x19_7d44, 1); pushw(si);                                /* push si */
            ii(0x19_7d45, 5); callw_far_abs(0x80, 0xb38);               /* call word 0x80:0xb38 */
            ii(0x19_7d4a, 3); add(sp, 0x6);                             /* add sp, 0x6 */
            ii(0x19_7d4d, 3); jmpw(0x19_7d36, -0x1a); goto l_0x19_7d36; /* jmp 0x7d36 */
        l_0x19_7d50:
            ii(0x19_7d50, 4); mov(es, memw_a16[ds, 0x3fa6]);            /* mov es, [0x3fa6] */
            ii(0x19_7d54, 4); mov(ax, memw_a16[es, 0x126]);             /* mov ax, [es:0x126] */
            ii(0x19_7d58, 3); jmpw(0x19_7d5b, 0); goto l_0x19_7d5b;     /* jmp 0x7d5b */
        l_0x19_7d5b:
            ii(0x19_7d5b, 1); popw(si);                                 /* pop si */
            ii(0x19_7d5c, 1); popw(di);                                 /* pop di */
            ii(0x19_7d5d, 1); leavew();                                 /* leave */
            ii(0x19_7d5e, 1); retfw(); return;                          /* retf */
        }
    }
}
