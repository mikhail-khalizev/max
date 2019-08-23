using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x19_b95c-a7dd3fa5")]
        public void Method_0019_b95c()
        {
            ii(0x19_b95c, 4); enter(0x90, 0);                           /* enter 0x90, 0x0 */
            ii(0x19_b960, 1); push(si);                                 /* push si */
            ii(0x19_b961, 3); les(bx, memw[ss, bp + 0x4]);              /* les bx, [bp+0x4] */
            ii(0x19_b964, 4); les(si, memw[es, bx + 0x1c]);             /* les si, [es:bx+0x1c] */
            ii(0x19_b968, 4); mov(ax, memw[es, si + 0x74]);             /* mov ax, [es:si+0x74] */
            ii(0x19_b96c, 4); mov(memw[ss, bp - 0x8e], ax);             /* mov [bp-0x8e], ax */
            ii(0x19_b970, 3); mov(es, memw[ss, bp + 0x6]);              /* mov es, [bp+0x6] */
            ii(0x19_b973, 4); mov(ax, memw[es, bx + 0x28]);             /* mov ax, [es:bx+0x28] */
            ii(0x19_b977, 4); mov(dx, memw[es, bx + 0x2a]);             /* mov dx, [es:bx+0x2a] */
            ii(0x19_b97b, 4); mov(memw[ss, bp - 0x8c], ax);             /* mov [bp-0x8c], ax */
            ii(0x19_b97f, 4); mov(memw[ss, bp - 0x8a], dx);             /* mov [bp-0x8a], dx */
            ii(0x19_b983, 2); or(dx, ax);                               /* or dx, ax */
            ii(0x19_b985, 2); if(jz(0x19_b996, 0xf)) goto l_0x19_b996;  /* jz 0xb996 */
            ii(0x19_b987, 3); jmp(0x19_ba32, 0xa8); goto l_0x19_ba32;   /* jmp 0xba32 */
        l_0x19_b98a:
            ii(0x19_b98a, 4); mov(ax, memw[ss, bp - 0x8e]);             /* mov ax, [bp-0x8e] */
            ii(0x19_b98e, 4); dec(memw[ss, bp - 0x8e]);                 /* dec word [bp-0x8e] */
            ii(0x19_b992, 2); or(ax, ax);                               /* or ax, ax */
            ii(0x19_b994, 2); if(jnz(0x19_b999, 0x3)) goto l_0x19_b999; /* jnz 0xb999 */
        l_0x19_b996:
            ii(0x19_b996, 3); jmp(0x19_ba3f, 0xa6); goto l_0x19_ba3f;   /* jmp 0xba3f */
        l_0x19_b999:
            ii(0x19_b999, 1); push(es);                                 /* push es */
            ii(0x19_b99a, 1); push(bx);                                 /* push bx */
            ii(0x19_b99b, 4); lea(ax, memw[ss, bp - 0x82]);             /* lea ax, [bp-0x82] */
            ii(0x19_b99f, 1); push(ss);                                 /* push ss */
            ii(0x19_b9a0, 1); push(ax);                                 /* push ax */
            ii(0x19_b9a1, 3); call(0x19_b92e, -0x76);                   /* call 0xb92e */
            ii(0x19_b9a4, 3); mov(ax, memw[ss, bp + 0x4]);              /* mov ax, [bp+0x4] */
            ii(0x19_b9a7, 3); mov(dx, memw[ss, bp + 0x6]);              /* mov dx, [bp+0x6] */
            ii(0x19_b9aa, 3); add(ax, 0xea);                            /* add ax, 0xea */
            ii(0x19_b9ad, 1); push(dx);                                 /* push dx */
            ii(0x19_b9ae, 1); push(ax);                                 /* push ax */
            ii(0x19_b9af, 4); lea(ax, memw[ss, bp - 0x82]);             /* lea ax, [bp-0x82] */
            ii(0x19_b9b3, 1); push(ss);                                 /* push ss */
            ii(0x19_b9b4, 1); push(ax);                                 /* push ax */
            ii(0x19_b9b5, 1); push(ds);                                 /* push ds */
            ii(0x19_b9b6, 3); push(0x2117);                             /* push 0x2117 */
            ii(0x19_b9b9, 3); call(0x1a_1066, 0x56aa);                  /* call 0x1066 */
            ii(0x19_b9bc, 3); add(sp, 0xc);                             /* add sp, 0xc */
            ii(0x19_b9bf, 4); lea(ax, memw[ss, bp - 0x82]);             /* lea ax, [bp-0x82] */
            ii(0x19_b9c3, 1); push(ss);                                 /* push ss */
            ii(0x19_b9c4, 1); push(ax);                                 /* push ax */
            ii(0x19_b9c5, 3); call(0x19_d6d6, 0x1d0e);                  /* call 0xd6d6 */
            ii(0x19_b9c8, 4); mov(memw[ss, bp - 0x88], ax);             /* mov [bp-0x88], ax */
            ii(0x19_b9cc, 3); cmp(ax, 0xffff);                          /* cmp ax, 0xffff */
            ii(0x19_b9cf, 2); if(jnz(0x19_b9ed, 0x1c)) goto l_0x19_b9ed; /* jnz 0xb9ed */
            ii(0x19_b9d1, 4); lea(ax, memw[ss, bp - 0x82]);             /* lea ax, [bp-0x82] */
            ii(0x19_b9d5, 1); push(ss);                                 /* push ss */
            ii(0x19_b9d6, 1); push(ax);                                 /* push ax */
            ii(0x19_b9d7, 2); push(0);                                  /* push 0x0 */
            ii(0x19_b9d9, 2); push(0);                                  /* push 0x0 */
            ii(0x19_b9db, 2); push(0);                                  /* push 0x0 */
            ii(0x19_b9dd, 2); push(0);                                  /* push 0x0 */
            ii(0x19_b9df, 2); push(0);                                  /* push 0x0 */
            ii(0x19_b9e1, 3); call(0x19_d1ad, 0x17c9);                  /* call 0xd1ad */
            ii(0x19_b9e4, 2); or(ax, ax);                               /* or ax, ax */
            ii(0x19_b9e6, 2); if(jnz(0x19_b9ed, 0x5)) goto l_0x19_b9ed; /* jnz 0xb9ed */
            ii(0x19_b9e8, 3); mov(ax, 0x514);                           /* mov ax, 0x514 */
            ii(0x19_b9eb, 2); jmp(0x19_ba41, 0x54); goto l_0x19_ba41;   /* jmp 0xba41 */
        l_0x19_b9ed:
            ii(0x19_b9ed, 3); push(memw[ss, bp + 0x6]);                 /* push word [bp+0x6] */
            ii(0x19_b9f0, 3); push(memw[ss, bp + 0x4]);                 /* push word [bp+0x4] */
            ii(0x19_b9f3, 4); lea(ax, memw[ss, bp - 0x82]);             /* lea ax, [bp-0x82] */
            ii(0x19_b9f7, 1); push(ss);                                 /* push ss */
            ii(0x19_b9f8, 1); push(ax);                                 /* push ax */
            ii(0x19_b9f9, 3); call(0x19_d270, 0x1874);                  /* call 0xd270 */
            ii(0x19_b9fc, 4); push(memw[ss, bp - 0x88]);                /* push word [bp-0x88] */
            ii(0x19_ba00, 3); call(0x19_a14c, -0x18b7);                 /* call 0xa14c */
            ii(0x19_ba03, 4); mov(memw[ss, bp - 0x86], ax);             /* mov [bp-0x86], ax */
            ii(0x19_ba07, 4); mov(memw[ss, bp - 0x84], dx);             /* mov [bp-0x84], dx */
            ii(0x19_ba0b, 2); or(dx, ax);                               /* or dx, ax */
            ii(0x19_ba0d, 2); if(jz(0x19_ba24, 0x15)) goto l_0x19_ba24; /* jz 0xba24 */
            ii(0x19_ba0f, 4); les(bx, memw[ss, bp - 0x86]);             /* les bx, [bp-0x86] */
            ii(0x19_ba13, 6); test(memb[es, bx + 0x132], 0x2);          /* test byte [es:bx+0x132], 0x2 */
            ii(0x19_ba19, 2); if(jz(0x19_ba24, 0x9)) goto l_0x19_ba24;  /* jz 0xba24 */
            ii(0x19_ba1b, 3); les(bx, memw[ss, bp + 0x4]);              /* les bx, [bp+0x4] */
            ii(0x19_ba1e, 6); or(memb[es, bx + 0x132], 0x2);            /* or byte [es:bx+0x132], 0x2 */
        l_0x19_ba24:
            ii(0x19_ba24, 4); les(bx, memw[ss, bp - 0x8c]);             /* les bx, [bp-0x8c] */
            ii(0x19_ba28, 3); mov(al, memb[es, bx]);                    /* mov al, [es:bx] */
            ii(0x19_ba2b, 2); sub(ah, ah);                              /* sub ah, ah */
            ii(0x19_ba2d, 1); inc(ax);                                  /* inc ax */
            ii(0x19_ba2e, 4); add(memw[ss, bp - 0x8c], ax);             /* add [bp-0x8c], ax */
        l_0x19_ba32:
            ii(0x19_ba32, 4); les(bx, memw[ss, bp - 0x8c]);             /* les bx, [bp-0x8c] */
            ii(0x19_ba36, 4); cmp(memb[es, bx], 0);                     /* cmp byte [es:bx], 0x0 */
            ii(0x19_ba3a, 2); if(jz(0x19_ba3f, 0x3)) goto l_0x19_ba3f;  /* jz 0xba3f */
            ii(0x19_ba3c, 3); jmp(0x19_b98a, -0xb5); goto l_0x19_b98a;  /* jmp 0xb98a */
        l_0x19_ba3f:
            ii(0x19_ba3f, 2); sub(ax, ax);                              /* sub ax, ax */
        l_0x19_ba41:
            ii(0x19_ba41, 1); pop(si);                                  /* pop si */
            ii(0x19_ba42, 1); leave();                                  /* leave */
            ii(0x19_ba43, 3); ret(0x4);                                 /* ret 0x4 */
        }
    }
}
