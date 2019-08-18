using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x17_7b24-fe64b7d1")]
        public void Method_0017_7b24()
        {
            ii(0x17_7b24, 4); enterw(0xa, 0);                           /* enter 0xa, 0x0 */
            ii(0x17_7b28, 1); pushw(di);                                /* push di */
            ii(0x17_7b29, 1); pushw(si);                                /* push si */
            ii(0x17_7b2a, 1); pushw(ds);                                /* push ds */
            ii(0x17_7b2b, 3); mov(ax, 0x3e68);                          /* mov ax, 0x3e68 */
            ii(0x17_7b2e, 2); mov(ds, ax);                              /* mov ds, ax */
            ii(0x17_7b30, 5); mov(memw_a16[ss, bp - 0x6], 0);           /* mov word [bp-0x6], 0x0 */
        l_0x17_7b35:
            ii(0x17_7b35, 3); mov(ax, memw_a16[ss, bp - 0x6]);          /* mov ax, [bp-0x6] */
            ii(0x17_7b38, 4); cmp(memw_a16[ds, 0x50bc], ax);            /* cmp [0x50bc], ax */
            ii(0x17_7b3c, 2); if(jaw(0x17_7b41, 0x3)) goto l_0x17_7b41; /* ja 0x7b41 */
            ii(0x17_7b3e, 3); jmpw(0x17_7be4, 0xa3); goto l_0x17_7be4;  /* jmp 0x7be4 */
        l_0x17_7b41:
            ii(0x17_7b41, 2); mov(bx, ax);                              /* mov bx, ax */
            ii(0x17_7b43, 3); shl(bx, 0x2);                             /* shl bx, 0x2 */
            ii(0x17_7b46, 4); les(si, ds, 0x4fa4);                      /* les si, [0x4fa4] */
            ii(0x17_7b4a, 3); mov(cx, memw_a16[es, bx + si]);           /* mov cx, [es:bx+si] */
            ii(0x17_7b4d, 4); mov(dx, memw_a16[es, bx + si + 0x2]);     /* mov dx, [es:bx+si+0x2] */
            ii(0x17_7b51, 3); mov(memw_a16[ss, bp - 0x4], cx);          /* mov [bp-0x4], cx */
            ii(0x17_7b54, 3); mov(memw_a16[ss, bp - 0x2], dx);          /* mov [bp-0x2], dx */
            ii(0x17_7b57, 2); mov(si, cx);                              /* mov si, cx */
            ii(0x17_7b59, 2); mov(di, dx);                              /* mov di, dx */
            ii(0x17_7b5b, 2); or(dx, cx);                               /* or dx, cx */
            ii(0x17_7b5d, 2); if(jzw(0x17_7bde, 0x7f)) goto l_0x17_7bde; /* jz 0x7bde */
            ii(0x17_7b5f, 4); les(bx, ds, 0x4f9c);                      /* les bx, [0x4f9c] */
            ii(0x17_7b63, 2); mov(si, ax);                              /* mov si, ax */
            ii(0x17_7b65, 3); mov(dl, memb_a16[es, bx + si]);           /* mov dl, [es:bx+si] */
            ii(0x17_7b68, 3); and(dl, 0x80);                            /* and dl, 0x80 */
            ii(0x17_7b6b, 3); cmp(dl, -0x80 /* 0x80 */);                /* cmp dl, 0x80 */
            ii(0x17_7b6e, 2); if(jzw(0x17_7bde, 0x6e)) goto l_0x17_7bde; /* jz 0x7bde */
            ii(0x17_7b70, 3); sub(cx, 0);                               /* sub cx, 0x0 */
            ii(0x17_7b73, 3); sbb(di, 0x1);                             /* sbb di, 0x1 */
            ii(0x17_7b76, 1); pushw(di);                                /* push di */
            ii(0x17_7b77, 1); pushw(cx);                                /* push cx */
            ii(0x17_7b78, 4); pushw(memw_a16[ds, 0x4f8e]);              /* push word [0x4f8e] */
            ii(0x17_7b7c, 4); pushw(memw_a16[ds, 0x4f8c]);              /* push word [0x4f8c] */
            ii(0x17_7b80, 3); callw(0x17_9208, 0x1685);                 /* call 0x9208 */
            ii(0x17_7b83, 3); add(sp, 0x8);                             /* add sp, 0x8 */
            ii(0x17_7b86, 3); mov(memw_a16[ss, bp - 0xa], ax);          /* mov [bp-0xa], ax */
            ii(0x17_7b89, 3); mov(memw_a16[ss, bp - 0x8], dx);          /* mov [bp-0x8], dx */
            ii(0x17_7b8c, 4); test(memb_a16[ss, bp - 0xa], 0x20);       /* test byte [bp-0xa], 0x20 */
            ii(0x17_7b90, 2); if(jzw(0x17_7bc2, 0x30)) goto l_0x17_7bc2; /* jz 0x7bc2 */
            ii(0x17_7b92, 4); and(memb_a16[ss, bp - 0xa], -0x21 /* 0xdf */); /* and byte [bp-0xa], 0xdf */
            ii(0x17_7b96, 1); pushw(dx);                                /* push dx */
            ii(0x17_7b97, 3); pushw(memw_a16[ss, bp - 0xa]);            /* push word [bp-0xa] */
            ii(0x17_7b9a, 3); mov(ax, memw_a16[ss, bp - 0x4]);          /* mov ax, [bp-0x4] */
            ii(0x17_7b9d, 3); mov(dx, memw_a16[ss, bp - 0x2]);          /* mov dx, [bp-0x2] */
            ii(0x17_7ba0, 3); sub(ax, 0);                               /* sub ax, 0x0 */
            ii(0x17_7ba3, 3); sbb(dx, 0x1);                             /* sbb dx, 0x1 */
            ii(0x17_7ba6, 1); pushw(dx);                                /* push dx */
            ii(0x17_7ba7, 1); pushw(ax);                                /* push ax */
            ii(0x17_7ba8, 4); pushw(memw_a16[ds, 0x4f8e]);              /* push word [0x4f8e] */
            ii(0x17_7bac, 4); pushw(memw_a16[ds, 0x4f8c]);              /* push word [0x4f8c] */
            ii(0x17_7bb0, 3); callw(0x17_9235, 0x1682);                 /* call 0x9235 */
            ii(0x17_7bb3, 3); add(sp, 0xc);                             /* add sp, 0xc */
            ii(0x17_7bb6, 4); les(bx, ds, 0x4f9c);                      /* les bx, [0x4f9c] */
            ii(0x17_7bba, 4); or(memb_a16[es, bx + si], 0x7f);          /* or byte [es:bx+si], 0x7f */
            ii(0x17_7bbe, 2); jmpw(0x17_7bde, 0x1e); goto l_0x17_7bde;  /* jmp 0x7bde */
        //    ii(0x17_7bc0, 1); nop();                                    /* nop */
        //    ii(0x17_7bc1, 1); nop();                                    /* nop */
        l_0x17_7bc2:
            ii(0x17_7bc2, 4); les(bx, ds, 0x4f9c);                      /* les bx, [0x4f9c] */
            ii(0x17_7bc6, 3); mov(si, memw_a16[ss, bp - 0x6]);          /* mov si, [bp-0x6] */
            ii(0x17_7bc9, 4); test(memb_a16[es, bx + si], 0x7f);        /* test byte [es:bx+si], 0x7f */
            ii(0x17_7bcd, 2); if(jzw(0x17_7bde, 0xf)) goto l_0x17_7bde; /* jz 0x7bde */
            ii(0x17_7bcf, 3); mov(al, memb_a16[es, bx + si]);           /* mov al, [es:bx+si] */
            ii(0x17_7bd2, 2); mov(cx, ax);                              /* mov cx, ax */
            ii(0x17_7bd4, 2); dec(al);                                  /* dec al */
            ii(0x17_7bd6, 2); xor(cl, al);                              /* xor cl, al */
            ii(0x17_7bd8, 3); and(cl, 0x7f);                            /* and cl, 0x7f */
            ii(0x17_7bdb, 3); xor(memb_a16[es, bx + si], cl);           /* xor [es:bx+si], cl */
        l_0x17_7bde:
            ii(0x17_7bde, 3); inc(memw_a16[ss, bp - 0x6]);              /* inc word [bp-0x6] */
            ii(0x17_7be1, 3); jmpw(0x17_7b35, -0xaf); goto l_0x17_7b35; /* jmp 0x7b35 */
        l_0x17_7be4:
            ii(0x17_7be4, 1); popw(ds);                                 /* pop ds */
            ii(0x17_7be5, 1); popw(si);                                 /* pop si */
            ii(0x17_7be6, 1); popw(di);                                 /* pop di */
            ii(0x17_7be7, 1); leavew();                                 /* leave */
            ii(0x17_7be8, 1); retfw(); return;                          /* retf */
        //  ii(0x17_7be9, 1); Недостижимый (и не декодированный) код.
        //    ii(0x17_7bea, 4); enterw(0xa, 0);                           /* enter 0xa, 0x0 */
        //    ii(0x17_7bee, 1); pushw(di);                                /* push di */
        //    ii(0x17_7bef, 1); pushw(si);                                /* push si */
        //    ii(0x17_7bf0, 1); pushw(ds);                                /* push ds */
        //    ii(0x17_7bf1, 3); mov(ax, 0x3e68);                          /* mov ax, 0x3e68 */
        //    ii(0x17_7bf4, 2); mov(ds, ax);                              /* mov ds, ax */
        //    ii(0x17_7bf6, 3); mov(bx, memw_a16[ss, bp + 0x6]);          /* mov bx, [bp+0x6] */
        //    ii(0x17_7bf9, 3); shl(bx, 0x2);                             /* shl bx, 0x2 */
        //    ii(0x17_7bfc, 4); les(si, ds, 0x4fa0);                      /* les si, [0x4fa0] */
        //    ii(0x17_7c00, 3); mov(ax, memw_a16[es, bx + si]);           /* mov ax, [es:bx+si] */
        //    ii(0x17_7c03, 4); mov(dx, memw_a16[es, bx + si + 0x2]);     /* mov dx, [es:bx+si+0x2] */
        //    ii(0x17_7c07, 3); mov(memw_a16[ss, bp - 0x4], ax);          /* mov [bp-0x4], ax */
        //    ii(0x17_7c0a, 3); mov(memw_a16[ss, bp - 0x2], dx);          /* mov [bp-0x2], dx */
        //    ii(0x17_7c0d, 4); les(si, ds, 0x4fa4);                      /* les si, [0x4fa4] */
        //    ii(0x17_7c11, 3); mov(ax, memw_a16[es, bx + si]);           /* mov ax, [es:bx+si] */
        //    ii(0x17_7c14, 4); mov(dx, memw_a16[es, bx + si + 0x2]);     /* mov dx, [es:bx+si+0x2] */
        //    ii(0x17_7c18, 3); mov(memw_a16[ss, bp - 0x8], ax);          /* mov [bp-0x8], ax */
        //    ii(0x17_7c1b, 3); mov(memw_a16[ss, bp - 0x6], dx);          /* mov [bp-0x6], dx */
        //    ii(0x17_7c1e, 5); cmp(memw_a16[ds, 0x984], 0);              /* cmp word [0x984], 0x0 */
        //    ii(0x17_7c23, 2); if(jzw(0x17_7c75, 0x50)) goto l_0x17_7c75; /* jz 0x7c75 */
        //    ii(0x17_7c25, 4); les(bx, ds, 0x4fc4);                      /* les bx, [0x4fc4] */
        //    ii(0x17_7c29, 4); mov(memb_a16[es, bx], 0x21);              /* mov byte [es:bx], 0x21 */
        //    ii(0x17_7c2d, 3); mov(al, memb_a16[ds, 0x5130]);            /* mov al, [0x5130] */
        //    ii(0x17_7c30, 4); les(bx, ds, 0x4fc4);                      /* les bx, [0x4fc4] */
        //    ii(0x17_7c34, 4); mov(memb_a16[es, bx + 0x1], al);          /* mov [es:bx+0x1], al */
        //    ii(0x17_7c38, 3); mov(ax, memw_a16[ss, bp - 0x8]);          /* mov ax, [bp-0x8] */
        //    ii(0x17_7c3b, 3); mov(dx, memw_a16[ss, bp - 0x6]);          /* mov dx, [bp-0x6] */
        //    ii(0x17_7c3e, 2); mov(dh, dl);                              /* mov dh, dl */
        //    ii(0x17_7c40, 2); mov(dl, ah);                              /* mov dl, ah */
        //    ii(0x17_7c42, 2); mov(ah, al);                              /* mov ah, al */
        //    ii(0x17_7c44, 2); sub(al, al);                              /* sub al, al */
        //    ii(0x17_7c46, 2); shl(ax, 0x1);                             /* shl ax, 1 */
        //    ii(0x17_7c48, 2); rcl(dx, 0x1);                             /* rcl dx, 1 */
        //    ii(0x17_7c4a, 2); shl(ax, 0x1);                             /* shl ax, 1 */
        //    ii(0x17_7c4c, 2); rcl(dx, 0x1);                             /* rcl dx, 1 */
        //    ii(0x17_7c4e, 2); shl(ax, 0x1);                             /* shl ax, 1 */
        //    ii(0x17_7c50, 2); rcl(dx, 0x1);                             /* rcl dx, 1 */
        //    ii(0x17_7c52, 2); shl(ax, 0x1);                             /* shl ax, 1 */
        //    ii(0x17_7c54, 2); rcl(dx, 0x1);                             /* rcl dx, 1 */
        //    ii(0x17_7c56, 4); les(bx, ds, 0x4fc4);                      /* les bx, [0x4fc4] */
        //    ii(0x17_7c5a, 4); mov(memw_a16[es, bx + 0x2], ax);          /* mov [es:bx+0x2], ax */
        //    ii(0x17_7c5e, 4); mov(memw_a16[es, bx + 0x4], dx);          /* mov [es:bx+0x4], dx */
        //    ii(0x17_7c62, 4); pushw(memw_a16[ds, 0x5167]);              /* push word [0x5167] */
        //    ii(0x17_7c66, 4); pushw(memw_a16[ds, 0x4fc6]);              /* push word [0x4fc6] */
        //    ii(0x17_7c6a, 4); pushw(memw_a16[ds, 0x4fc4]);              /* push word [0x4fc4] */
        //    ii(0x17_7c6e, 2); pushw(0x6);                               /* push 0x6 */
        //    ii(0x17_7c70, 1); nop();                                    /* nop */
        //    ii(0x17_7c71, 1); pushw(cs);                                /* push cs */
        //    ii(0x17_7c72, 3); callw(0x17_0864, -0x7411);                /* call 0x864 */
        l_0x17_7c75:
            ii(0x17_7c75, 3); mov(ax, memw_a16[ss, bp - 0x8]);          /* mov ax, [bp-0x8] */
            ii(0x17_7c78, 3); mov(dx, memw_a16[ss, bp - 0x6]);          /* mov dx, [bp-0x6] */
            ii(0x17_7c7b, 3); sub(ax, 0);                               /* sub ax, 0x0 */
            ii(0x17_7c7e, 3); sbb(dx, 0x1);                             /* sbb dx, 0x1 */
            ii(0x17_7c81, 1); pushw(dx);                                /* push dx */
            ii(0x17_7c82, 1); pushw(ax);                                /* push ax */
            ii(0x17_7c83, 4); pushw(memw_a16[ds, 0x1fa6]);              /* push word [0x1fa6] */
            ii(0x17_7c87, 4); pushw(memw_a16[ds, 0x1fa4]);              /* push word [0x1fa4] */
            ii(0x17_7c8b, 2); mov(si, ax);                              /* mov si, ax */
            ii(0x17_7c8d, 2); mov(di, dx);                              /* mov di, dx */
            ii(0x17_7c8f, 3); callw(0x17_90c4, 0x1432);                 /* call 0x90c4 */
            ii(0x17_7c92, 3); add(sp, 0x8);                             /* add sp, 0x8 */
            ii(0x17_7c95, 3); mov(memw_a16[ss, bp - 0xa], ax);          /* mov [bp-0xa], ax */
            ii(0x17_7c98, 1); pushw(di);                                /* push di */
            ii(0x17_7c99, 1); pushw(si);                                /* push si */
            ii(0x17_7c9a, 4); pushw(memw_a16[ds, 0x4f8e]);              /* push word [0x4f8e] */
            ii(0x17_7c9e, 4); pushw(memw_a16[ds, 0x4f8c]);              /* push word [0x4f8c] */
            ii(0x17_7ca2, 3); callw(0x17_9208, 0x1563);                 /* call 0x9208 */
            ii(0x17_7ca5, 3); add(sp, 0x8);                             /* add sp, 0x8 */
            ii(0x17_7ca8, 1); pushw(dx);                                /* push dx */
            ii(0x17_7ca9, 1); pushw(ax);                                /* push ax */
            ii(0x17_7caa, 2); pushw(0x1);                               /* push 0x1 */
            ii(0x17_7cac, 3); mov(bx, memw_a16[ss, bp - 0xa]);          /* mov bx, [bp-0xa] */
            ii(0x17_7caf, 3); shl(bx, 0x3);                             /* shl bx, 0x3 */
            ii(0x17_7cb2, 4); pushw(memw_a16[ds, bx + 0x2026]);         /* push word [bx+0x2026] */
            ii(0x17_7cb6, 4); pushw(memw_a16[ds, bx + 0x2024]);         /* push word [bx+0x2024] */
            ii(0x17_7cba, 3); pushw(memw_a16[ss, bp - 0x2]);            /* push word [bp-0x2] */
            ii(0x17_7cbd, 3); pushw(memw_a16[ss, bp - 0x4]);            /* push word [bp-0x4] */
            ii(0x17_7cc0, 2); pushw(0);                                 /* push 0x0 */
            ii(0x17_7cc2, 3); pushw(memw_a16[ss, bp - 0x6]);            /* push word [bp-0x6] */
            ii(0x17_7cc5, 3); pushw(memw_a16[ss, bp - 0x8]);            /* push word [bp-0x8] */
            ii(0x17_7cc8, 4); callw_a16_far_ind(ds, bx + 0x2020);       /* call far word [bx+0x2020] */
            ii(0x17_7ccc, 3); add(sp, 0x14);                            /* add sp, 0x14 */
            ii(0x17_7ccf, 2); or(ax, ax);                               /* or ax, ax */
            ii(0x17_7cd1, 2); if(jzw(0x17_7cea, 0x17)) goto l_0x17_7cea; /* jz 0x7cea */
            ii(0x17_7cd3, 4); pushw(memw_a16[ds, 0x51a7]);              /* push word [0x51a7] */
            ii(0x17_7cd7, 1); pushw(di);                                /* push di */
            ii(0x17_7cd8, 1); pushw(si);                                /* push si */
            ii(0x17_7cd9, 4); pushw(memw_a16[ds, 0x1fa6]);              /* push word [0x1fa6] */
            ii(0x17_7cdd, 4); pushw(memw_a16[ds, 0x1fa4]);              /* push word [0x1fa4] */
            ii(0x17_7ce1, 3); callw(0x17_91e3, 0x14ff);                 /* call 0x91e3 */
            ii(0x17_7ce4, 3); add(sp, 0xa);                             /* add sp, 0xa */
            ii(0x17_7ce7, 2); jmpw(0x17_7c75, -0x74); goto l_0x17_7c75; /* jmp 0x7c75 */
        //    ii(0x17_7ce9, 1); nop();                                    /* nop */
        l_0x17_7cea:
            ii(0x17_7cea, 3); pushw(memw_a16[ss, bp - 0x6]);            /* push word [bp-0x6] */
            ii(0x17_7ced, 3); pushw(memw_a16[ss, bp - 0x8]);            /* push word [bp-0x8] */
            ii(0x17_7cf0, 1); pushw(cs);                                /* push cs */
            ii(0x17_7cf1, 3); callw(0x17_7f8a, 0x296);                  /* call 0x7f8a */
            ii(0x17_7cf4, 3); add(sp, 0x4);                             /* add sp, 0x4 */
            ii(0x17_7cf7, 1); popw(ds);                                 /* pop ds */
            ii(0x17_7cf8, 1); popw(si);                                 /* pop si */
            ii(0x17_7cf9, 1); popw(di);                                 /* pop di */
            ii(0x17_7cfa, 1); leavew();                                 /* leave */
            ii(0x17_7cfb, 1); retfw(); return;                          /* retf */
        }
    }
}
