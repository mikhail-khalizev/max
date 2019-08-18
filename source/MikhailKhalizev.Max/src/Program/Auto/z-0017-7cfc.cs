using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x17_7cfc-7c41b51")]
        public void Method_0017_7cfc()
        {
            ii(0x17_7cfc, 4); enterw(0x2, 0);                           /* enter 0x2, 0x0 */
            ii(0x17_7d00, 1); pushw(ds);                                /* push ds */
            ii(0x17_7d01, 3); mov(ax, 0x3e68);                          /* mov ax, 0x3e68 */
            ii(0x17_7d04, 2); mov(ds, ax);                              /* mov ds, ax */
            ii(0x17_7d06, 5); cmp(memw_a16[ds, 0x984], 0);              /* cmp word [0x984], 0x0 */
            ii(0x17_7d0b, 2); if(jzw(0x17_7d5d, 0x50)) goto l_0x17_7d5d; /* jz 0x7d5d */
            ii(0x17_7d0d, 4); les(bx, ds, 0x4fc4);                      /* les bx, [0x4fc4] */
            ii(0x17_7d11, 4); mov(memb_a16[es, bx], 0x22);              /* mov byte [es:bx], 0x22 */
            ii(0x17_7d15, 3); mov(al, memb_a16[ds, 0x5130]);            /* mov al, [0x5130] */
            ii(0x17_7d18, 4); les(bx, ds, 0x4fc4);                      /* les bx, [0x4fc4] */
            ii(0x17_7d1c, 4); mov(memb_a16[es, bx + 0x1], al);          /* mov [es:bx+0x1], al */
            ii(0x17_7d20, 3); mov(ax, memw_a16[ss, bp + 0x6]);          /* mov ax, [bp+0x6] */
            ii(0x17_7d23, 3); mov(dx, memw_a16[ss, bp + 0x8]);          /* mov dx, [bp+0x8] */
            ii(0x17_7d26, 2); mov(dh, dl);                              /* mov dh, dl */
            ii(0x17_7d28, 2); mov(dl, ah);                              /* mov dl, ah */
            ii(0x17_7d2a, 2); mov(ah, al);                              /* mov ah, al */
            ii(0x17_7d2c, 2); sub(al, al);                              /* sub al, al */
            ii(0x17_7d2e, 2); shl(ax, 0x1);                             /* shl ax, 1 */
            ii(0x17_7d30, 2); rcl(dx, 0x1);                             /* rcl dx, 1 */
            ii(0x17_7d32, 2); shl(ax, 0x1);                             /* shl ax, 1 */
            ii(0x17_7d34, 2); rcl(dx, 0x1);                             /* rcl dx, 1 */
            ii(0x17_7d36, 2); shl(ax, 0x1);                             /* shl ax, 1 */
            ii(0x17_7d38, 2); rcl(dx, 0x1);                             /* rcl dx, 1 */
            ii(0x17_7d3a, 2); shl(ax, 0x1);                             /* shl ax, 1 */
            ii(0x17_7d3c, 2); rcl(dx, 0x1);                             /* rcl dx, 1 */
            ii(0x17_7d3e, 4); les(bx, ds, 0x4fc4);                      /* les bx, [0x4fc4] */
            ii(0x17_7d42, 4); mov(memw_a16[es, bx + 0x2], ax);          /* mov [es:bx+0x2], ax */
            ii(0x17_7d46, 4); mov(memw_a16[es, bx + 0x4], dx);          /* mov [es:bx+0x4], dx */
            ii(0x17_7d4a, 4); pushw(memw_a16[ds, 0x5167]);              /* push word [0x5167] */
            ii(0x17_7d4e, 4); pushw(memw_a16[ds, 0x4fc6]);              /* push word [0x4fc6] */
            ii(0x17_7d52, 4); pushw(memw_a16[ds, 0x4fc4]);              /* push word [0x4fc4] */
            ii(0x17_7d56, 2); pushw(0x6);                               /* push 0x6 */
            ii(0x17_7d58, 1); nop();                                    /* nop */
            ii(0x17_7d59, 1); pushw(cs);                                /* push cs */
            ii(0x17_7d5a, 3); callw(0x17_0864, -0x74f9);                /* call 0x864 */
        l_0x17_7d5d:
            ii(0x17_7d5d, 3); mov(ax, memw_a16[ss, bp + 0x6]);          /* mov ax, [bp+0x6] */
            ii(0x17_7d60, 3); mov(dx, memw_a16[ss, bp + 0x8]);          /* mov dx, [bp+0x8] */
            ii(0x17_7d63, 3); sub(ax, 0);                               /* sub ax, 0x0 */
            ii(0x17_7d66, 3); sbb(dx, 0x1);                             /* sbb dx, 0x1 */
            ii(0x17_7d69, 1); pushw(dx);                                /* push dx */
            ii(0x17_7d6a, 1); pushw(ax);                                /* push ax */
            ii(0x17_7d6b, 4); pushw(memw_a16[ds, 0x1fa6]);              /* push word [0x1fa6] */
            ii(0x17_7d6f, 4); pushw(memw_a16[ds, 0x1fa4]);              /* push word [0x1fa4] */
            ii(0x17_7d73, 3); callw(0x17_90c4, 0x134e);                 /* call 0x90c4 */
            ii(0x17_7d76, 3); add(sp, 0x8);                             /* add sp, 0x8 */
            ii(0x17_7d79, 3); mov(memw_a16[ss, bp - 0x2], ax);          /* mov [bp-0x2], ax */
            ii(0x17_7d7c, 3); pushw(memw_a16[ss, bp + 0xc]);            /* push word [bp+0xc] */
            ii(0x17_7d7f, 3); pushw(memw_a16[ss, bp + 0xa]);            /* push word [bp+0xa] */
            ii(0x17_7d82, 2); pushw(0);                                 /* push 0x0 */
            ii(0x17_7d84, 2); mov(bx, ax);                              /* mov bx, ax */
            ii(0x17_7d86, 3); shl(bx, 0x3);                             /* shl bx, 0x3 */
            ii(0x17_7d89, 4); pushw(memw_a16[ds, bx + 0x2026]);         /* push word [bx+0x2026] */
            ii(0x17_7d8d, 4); pushw(memw_a16[ds, bx + 0x2024]);         /* push word [bx+0x2024] */
            ii(0x17_7d91, 3); pushw(memw_a16[ss, bp + 0x8]);            /* push word [bp+0x8] */
            ii(0x17_7d94, 3); pushw(memw_a16[ss, bp + 0x6]);            /* push word [bp+0x6] */
            ii(0x17_7d97, 2); pushw(0);                                 /* push 0x0 */
            ii(0x17_7d99, 3); pushw(memw_a16[ss, bp + 0x8]);            /* push word [bp+0x8] */
            ii(0x17_7d9c, 3); pushw(memw_a16[ss, bp + 0x6]);            /* push word [bp+0x6] */
            ii(0x17_7d9f, 4); callw_a16_far_ind(ds, bx + 0x2020);       /* call far word [bx+0x2020] */
            ii(0x17_7da3, 3); add(sp, 0x14);                            /* add sp, 0x14 */
            ii(0x17_7da6, 1); popw(ds);                                 /* pop ds */
            ii(0x17_7da7, 1); leavew();                                 /* leave */
            ii(0x17_7da8, 1); retfw(); return;                          /* retf */
        //  ii(0x17_7da9, 3); Недостижимый (и не декодированный) код.
        //    ii(0x17_7dac, 4); enterw(0x10, 0);                          /* enter 0x10, 0x0 */
        //    ii(0x17_7db0, 1); pushw(di);                                /* push di */
        //    ii(0x17_7db1, 1); pushw(si);                                /* push si */
        //    ii(0x17_7db2, 1); pushw(ds);                                /* push ds */
        //    ii(0x17_7db3, 3); mov(ax, 0x3e68);                          /* mov ax, 0x3e68 */
        //    ii(0x17_7db6, 2); mov(ds, ax);                              /* mov ds, ax */
        //    ii(0x17_7db8, 3); mov(ax, memw_a16[ss, bp + 0x6]);          /* mov ax, [bp+0x6] */
        //    ii(0x17_7dbb, 3); mov(dx, memw_a16[ss, bp + 0x8]);          /* mov dx, [bp+0x8] */
        //    ii(0x17_7dbe, 2); mov(dh, dl);                              /* mov dh, dl */
        //    ii(0x17_7dc0, 2); mov(dl, ah);                              /* mov dl, ah */
        //    ii(0x17_7dc2, 2); mov(ah, al);                              /* mov ah, al */
        //    ii(0x17_7dc4, 2); sub(al, al);                              /* sub al, al */
        //    ii(0x17_7dc6, 2); shl(ax, 0x1);                             /* shl ax, 1 */
        //    ii(0x17_7dc8, 2); rcl(dx, 0x1);                             /* rcl dx, 1 */
        //    ii(0x17_7dca, 2); shl(ax, 0x1);                             /* shl ax, 1 */
        //    ii(0x17_7dcc, 2); rcl(dx, 0x1);                             /* rcl dx, 1 */
        //    ii(0x17_7dce, 2); shl(ax, 0x1);                             /* shl ax, 1 */
        //    ii(0x17_7dd0, 2); rcl(dx, 0x1);                             /* rcl dx, 1 */
        //    ii(0x17_7dd2, 2); shl(ax, 0x1);                             /* shl ax, 1 */
        //    ii(0x17_7dd4, 2); rcl(dx, 0x1);                             /* rcl dx, 1 */
        //    ii(0x17_7dd6, 3); mov(memw_a16[ss, bp - 0xc], ax);          /* mov [bp-0xc], ax */
        //    ii(0x17_7dd9, 3); mov(memw_a16[ss, bp - 0xa], dx);          /* mov [bp-0xa], dx */
        //    ii(0x17_7ddc, 3); mov(ax, memw_a16[ss, bp + 0x6]);          /* mov ax, [bp+0x6] */
        //    ii(0x17_7ddf, 3); mov(dx, memw_a16[ss, bp + 0x8]);          /* mov dx, [bp+0x8] */
        //    ii(0x17_7de2, 3); sub(ax, 0);                               /* sub ax, 0x0 */
        //    ii(0x17_7de5, 3); sbb(dx, 0x1);                             /* sbb dx, 0x1 */
        //    ii(0x17_7de8, 3); mov(memw_a16[ss, bp - 0x8], ax);          /* mov [bp-0x8], ax */
        //    ii(0x17_7deb, 3); mov(memw_a16[ss, bp - 0x6], dx);          /* mov [bp-0x6], dx */
        //    ii(0x17_7dee, 1); pushw(dx);                                /* push dx */
        //    ii(0x17_7def, 1); pushw(ax);                                /* push ax */
        //    ii(0x17_7df0, 4); pushw(memw_a16[ds, 0x4f8e]);              /* push word [0x4f8e] */
        //    ii(0x17_7df4, 4); pushw(memw_a16[ds, 0x4f8c]);              /* push word [0x4f8c] */
        //    ii(0x17_7df8, 2); mov(si, ax);                              /* mov si, ax */
        //    ii(0x17_7dfa, 2); mov(di, dx);                              /* mov di, dx */
        //    ii(0x17_7dfc, 3); callw(0x17_9208, 0x1409);                 /* call 0x9208 */
        //    ii(0x17_7dff, 3); add(sp, 0x8);                             /* add sp, 0x8 */
        //    ii(0x17_7e02, 3); mov(memw_a16[ss, bp - 0x4], ax);          /* mov [bp-0x4], ax */
        //    ii(0x17_7e05, 3); mov(memw_a16[ss, bp - 0x2], dx);          /* mov [bp-0x2], dx */
        //    ii(0x17_7e08, 3); mov(bx, memw_a16[ss, bp + 0xa]);          /* mov bx, [bp+0xa] */
        //    ii(0x17_7e0b, 3); shl(bx, 0x2);                             /* shl bx, 0x2 */
        //    ii(0x17_7e0e, 2); mov(ax, si);                              /* mov ax, si */
        //    ii(0x17_7e10, 4); les(si, ds, 0x4fa0);                      /* les si, [0x4fa0] */
        //    ii(0x17_7e14, 3); mov(memw_a16[ss, bp - 0x10], ax);         /* mov [bp-0x10], ax */
        //    ii(0x17_7e17, 3); mov(memw_a16[ss, bp - 0xe], di);          /* mov [bp-0xe], di */
        //    ii(0x17_7e1a, 3); mov(ax, memw_a16[es, bx + si]);           /* mov ax, [es:bx+si] */
        //    ii(0x17_7e1d, 4); mov(dx, memw_a16[es, bx + si + 0x2]);     /* mov dx, [es:bx+si+0x2] */
        //    ii(0x17_7e21, 2); mov(dh, dl);                              /* mov dh, dl */
        //    ii(0x17_7e23, 2); mov(dl, ah);                              /* mov dl, ah */
        //    ii(0x17_7e25, 2); mov(ah, al);                              /* mov ah, al */
        //    ii(0x17_7e27, 2); sub(al, al);                              /* sub al, al */
        //    ii(0x17_7e29, 2); shl(ax, 0x1);                             /* shl ax, 1 */
        //    ii(0x17_7e2b, 2); rcl(dx, 0x1);                             /* rcl dx, 1 */
        //    ii(0x17_7e2d, 2); shl(ax, 0x1);                             /* shl ax, 1 */
        //    ii(0x17_7e2f, 2); rcl(dx, 0x1);                             /* rcl dx, 1 */
        //    ii(0x17_7e31, 2); shl(ax, 0x1);                             /* shl ax, 1 */
        //    ii(0x17_7e33, 2); rcl(dx, 0x1);                             /* rcl dx, 1 */
        //    ii(0x17_7e35, 2); shl(ax, 0x1);                             /* shl ax, 1 */
        //    ii(0x17_7e37, 2); rcl(dx, 0x1);                             /* rcl dx, 1 */
        //    ii(0x17_7e39, 2); mov(cx, ax);                              /* mov cx, ax */
        //    ii(0x17_7e3b, 2); mov(si, dx);                              /* mov si, dx */
        //    ii(0x17_7e3d, 3); xor(ax, memw_a16[ss, bp - 0x4]);          /* xor ax, [bp-0x4] */
        //    ii(0x17_7e40, 3); and(ah, 0xf);                             /* and ah, 0xf */
        //    ii(0x17_7e43, 2); sub(dx, dx);                              /* sub dx, dx */
        //    ii(0x17_7e45, 2); xor(cx, ax);                              /* xor cx, ax */
        //    ii(0x17_7e47, 2); xor(si, dx);                              /* xor si, dx */
        //    ii(0x17_7e49, 3); mov(memw_a16[ss, bp - 0x4], cx);          /* mov [bp-0x4], cx */
        //    ii(0x17_7e4c, 3); mov(memw_a16[ss, bp - 0x2], si);          /* mov [bp-0x2], si */
        //    ii(0x17_7e4f, 4); or(memb_a16[ss, bp - 0x4], 0x1);          /* or byte [bp-0x4], 0x1 */
        //    ii(0x17_7e53, 4); and(memb_a16[ss, bp - 0x4], -0x19 /* 0xe7 */); /* and byte [bp-0x4], 0xe7 */
        //    ii(0x17_7e57, 1); pushw(si);                                /* push si */
        //    ii(0x17_7e58, 3); pushw(memw_a16[ss, bp - 0x4]);            /* push word [bp-0x4] */
        //    ii(0x17_7e5b, 1); pushw(di);                                /* push di */
        //    ii(0x17_7e5c, 3); pushw(memw_a16[ss, bp - 0x10]);           /* push word [bp-0x10] */
        //    ii(0x17_7e5f, 4); pushw(memw_a16[ds, 0x4f8e]);              /* push word [0x4f8e] */
        //    ii(0x17_7e63, 4); pushw(memw_a16[ds, 0x4f8c]);              /* push word [0x4f8c] */
        //    ii(0x17_7e67, 2); mov(si, bx);                              /* mov si, bx */
        //    ii(0x17_7e69, 3); callw(0x17_9235, 0x13c9);                 /* call 0x9235 */
        //    ii(0x17_7e6c, 3); add(sp, 0xc);                             /* add sp, 0xc */
        //    ii(0x17_7e6f, 1); nop();                                    /* nop */
        //    ii(0x17_7e70, 1); pushw(cs);                                /* push cs */
        //    ii(0x17_7e71, 3); callw(0x17_8e97, 0x1023);                 /* call 0x8e97 */
        //    ii(0x17_7e74, 3); mov(ax, memw_a16[ss, bp + 0x6]);          /* mov ax, [bp+0x6] */
        //    ii(0x17_7e77, 3); mov(dx, memw_a16[ss, bp + 0x8]);          /* mov dx, [bp+0x8] */
        //    ii(0x17_7e7a, 2); sub(dh, dh);                              /* sub dh, dh */
        //    ii(0x17_7e7c, 4); les(bx, ds, 0x4fa4);                      /* les bx, [0x4fa4] */
        //    ii(0x17_7e80, 3); mov(memw_a16[es, bx + si], ax);           /* mov [es:bx+si], ax */
        //    ii(0x17_7e83, 4); mov(memw_a16[es, bx + si + 0x2], dx);     /* mov [es:bx+si+0x2], dx */
        //    ii(0x17_7e87, 3); mov(bx, memw_a16[ss, bp + 0xa]);          /* mov bx, [bp+0xa] */
        //    ii(0x17_7e8a, 4); les(si, ds, 0x4f9c);                      /* les si, [0x4f9c] */
        //    ii(0x17_7e8e, 4); or(memb_a16[es, bx + si], 0x7f);          /* or byte [es:bx+si], 0x7f */
        //    ii(0x17_7e92, 1); popw(ds);                                 /* pop ds */
        //    ii(0x17_7e93, 1); popw(si);                                 /* pop si */
        //    ii(0x17_7e94, 1); popw(di);                                 /* pop di */
        //    ii(0x17_7e95, 1); leavew();                                 /* leave */
        //    ii(0x17_7e96, 1); retfw(); return;                          /* retf */
        //  ii(0x17_7e97, 1); Недостижимый (и не декодированный) код.
        //    ii(0x17_7e98, 1); pushw(bp);                                /* push bp */
        //    ii(0x17_7e99, 2); mov(bp, sp);                              /* mov bp, sp */
        //    ii(0x17_7e9b, 1); pushw(si);                                /* push si */
        //    ii(0x17_7e9c, 1); pushw(ds);                                /* push ds */
        //    ii(0x17_7e9d, 3); mov(ax, 0x3e68);                          /* mov ax, 0x3e68 */
        //    ii(0x17_7ea0, 2); mov(ds, ax);                              /* mov ds, ax */
        //    ii(0x17_7ea2, 4); les(bx, ds, 0x4f9c);                      /* les bx, [0x4f9c] */
        //    ii(0x17_7ea6, 3); mov(si, memw_a16[ss, bp + 0x6]);          /* mov si, [bp+0x6] */
        //    ii(0x17_7ea9, 4); test(memb_a16[es, bx + si], 0x80);        /* test byte [es:bx+si], 0x80 */
        //    ii(0x17_7ead, 2); if(jzw(0x17_7ec2, 0x13)) goto l_0x17_7ec2; /* jz 0x7ec2 */
        //    ii(0x17_7eaf, 3); mov(al, memb_a16[es, bx + si]);           /* mov al, [es:bx+si] */
        //    ii(0x17_7eb2, 2); mov(cx, ax);                              /* mov cx, ax */
        //    ii(0x17_7eb4, 2); inc(al);                                  /* inc al */
        //    ii(0x17_7eb6, 2); xor(cl, al);                              /* xor cl, al */
        //    ii(0x17_7eb8, 3); and(cl, 0x7f);                            /* and cl, 0x7f */
        //    ii(0x17_7ebb, 3); xor(memb_a16[es, bx + si], cl);           /* xor [es:bx+si], cl */
        //    ii(0x17_7ebe, 1); popw(ds);                                 /* pop ds */
        //    ii(0x17_7ebf, 1); popw(si);                                 /* pop si */
        //    ii(0x17_7ec0, 1); leavew();                                 /* leave */
        //    ii(0x17_7ec1, 1); retfw(); return;                          /* retf */
        l_0x17_7ec2:
            ii(0x17_7ec2, 5); sub(memw_a16[ds, 0x1fb0], 0x1);           /* sub word [0x1fb0], 0x1 */
            ii(0x17_7ec7, 5); sbb(memw_a16[ds, 0x1fb2], 0);             /* sbb word [0x1fb2], 0x0 */
            ii(0x17_7ecc, 5); sub(memw_a16[ds, 0x1fb8], 0x1);           /* sub word [0x1fb8], 0x1 */
            ii(0x17_7ed1, 5); sbb(memw_a16[ds, 0x1fba], 0);             /* sbb word [0x1fba], 0x0 */
            ii(0x17_7ed6, 4); or(memb_a16[es, bx + si], -0x80 /* 0x80 */); /* or byte [es:bx+si], 0x80 */
            ii(0x17_7eda, 4); les(bx, ds, 0x4f9c);                      /* les bx, [0x4f9c] */
            ii(0x17_7ede, 4); and(memb_a16[es, bx + si], -0x80 /* 0x80 */); /* and byte [es:bx+si], 0x80 */
            ii(0x17_7ee2, 1); popw(ds);                                 /* pop ds */
            ii(0x17_7ee3, 1); popw(si);                                 /* pop si */
            ii(0x17_7ee4, 1); leavew();                                 /* leave */
            ii(0x17_7ee5, 1); retfw(); return;                          /* retf */
        }
    }
}
