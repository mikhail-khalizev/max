using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("3825b8ea-b276-4df1-9bd3-8c3e95e8ae71")]
        public void Method_0015_a1f7()
        {
            ii(0x15_a1f7, 4); enterw(0x34, 0);                          /* enter 0x34, 0x0 */
            ii(0x15_a1fb, 1); pushw(si);                                /* push si */
            ii(0x15_a1fc, 3); pushw(memw_a16[ss, bp + 0x4]);            /* push word [bp+0x4] */
            ii(0x15_a1ff, 3); callw(0x15_a14c, -0xb6);                  /* call 0xa14c */
            ii(0x15_a202, 3); mov(memw_a16[ss, bp - 0x30], ax);         /* mov [bp-0x30], ax */
            ii(0x15_a205, 3); mov(memw_a16[ss, bp - 0x2e], dx);         /* mov [bp-0x2e], dx */
            ii(0x15_a208, 2); or(dx, ax);                               /* or dx, ax */
            ii(0x15_a20a, 2); if(jnzw(0x15_a20f, 0x3)) goto l_0x15_a20f; /* jnz 0xa20f */
            ii(0x15_a20c, 3); jmpw(0x15_a49c, 0x28d); goto l_0x15_a49c; /* jmp 0xa49c */
        l_0x15_a20f:
            ii(0x15_a20f, 3); mov(memw_a16[ss, bp - 0x32], ax);         /* mov [bp-0x32], ax */
            ii(0x15_a212, 4); mov(cx, memw_a16[ds, 0x3292]);            /* mov cx, [0x3292] */
            ii(0x15_a216, 4); or(cx, memw_a16[ds, 0x3290]);             /* or cx, [0x3290] */
            ii(0x15_a21a, 2); if(jzw(0x15_a22f, 0x13)) goto l_0x15_a22f; /* jz 0xa22f */
            ii(0x15_a21c, 2); mov(bx, ax);                              /* mov bx, ax */
            ii(0x15_a21e, 3); mov(es, memw_a16[ss, bp - 0x2e]);         /* mov es, [bp-0x2e] */
            ii(0x15_a221, 6); cmp(memw_a16[es, bx + 0x12a], -0x1 /* 0xff */); /* cmp word [es:bx+0x12a], 0xffff */
            ii(0x15_a227, 2); if(jzw(0x15_a22f, 0x6)) goto l_0x15_a22f; /* jz 0xa22f */
            ii(0x15_a229, 4); mov(memb_a16[ss, bp - 0x34], 0x1);        /* mov byte [bp-0x34], 0x1 */
            ii(0x15_a22d, 2); jmpw(0x15_a233, 0x4); goto l_0x15_a233;   /* jmp 0xa233 */
        l_0x15_a22f:
            ii(0x15_a22f, 4); mov(memb_a16[ss, bp - 0x34], 0);          /* mov byte [bp-0x34], 0x0 */
        l_0x15_a233:
            ii(0x15_a233, 3); mov(ax, memw_a16[ss, bp - 0x32]);         /* mov ax, [bp-0x32] */
            ii(0x15_a236, 3); add(ax, 0xea);                            /* add ax, 0xea */
            ii(0x15_a239, 3); pushw(memw_a16[ss, bp - 0x2e]);           /* push word [bp-0x2e] */
            ii(0x15_a23c, 1); pushw(ax);                                /* push ax */
            ii(0x15_a23d, 3); pushw(memw_a16[ss, bp + 0x4]);            /* push word [bp+0x4] */
            ii(0x15_a240, 1); pushw(ds);                                /* push ds */
            ii(0x15_a241, 3); pushw(0x1fd4);                            /* push 0x1fd4 */
            ii(0x15_a244, 3); callw(0x16_1066, 0x6e1f);                 /* call 0x1066 */
            ii(0x15_a247, 3); add(sp, 0xa);                             /* add sp, 0xa */
            ii(0x15_a24a, 3); mov(es, memw_a16[ss, bp - 0x2e]);         /* mov es, [bp-0x2e] */
            ii(0x15_a24d, 3); mov(bx, memw_a16[ss, bp - 0x32]);         /* mov bx, [bp-0x32] */
            ii(0x15_a250, 4); mov(ax, memw_a16[es, bx + 0x38]);         /* mov ax, [es:bx+0x38] */
            ii(0x15_a254, 4); mov(dx, memw_a16[es, bx + 0x3a]);         /* mov dx, [es:bx+0x3a] */
            ii(0x15_a258, 3); mov(memw_a16[ss, bp - 0x2a], ax);         /* mov [bp-0x2a], ax */
            ii(0x15_a25b, 3); mov(memw_a16[ss, bp - 0x28], dx);         /* mov [bp-0x28], dx */
            ii(0x15_a25e, 2); or(dx, ax);                               /* or dx, ax */
            ii(0x15_a260, 2); if(jzw(0x15_a2a8, 0x46)) goto l_0x15_a2a8; /* jz 0xa2a8 */
            ii(0x15_a262, 3); les(bx, ss, bp - 0x2a);                   /* les bx, [bp-0x2a] */
            ii(0x15_a265, 5); cmp(memw_a16[es, bx + 0x4], 0);           /* cmp word [es:bx+0x4], 0x0 */
            ii(0x15_a26a, 2); if(jzw(0x15_a294, 0x28)) goto l_0x15_a294; /* jz 0xa294 */
            ii(0x15_a26c, 3); lea(ax, bp - 0x26);                       /* lea ax, [bp-0x26] */
            ii(0x15_a26f, 1); pushw(ss);                                /* push ss */
            ii(0x15_a270, 1); pushw(ax);                                /* push ax */
            ii(0x15_a271, 3); callw(0x15_e2de, 0x406a);                 /* call 0xe2de */
            ii(0x15_a274, 3); mov(ax, memw_a16[ss, bp - 0x2a]);         /* mov ax, [bp-0x2a] */
            ii(0x15_a277, 3); mov(dx, memw_a16[ss, bp - 0x28]);         /* mov dx, [bp-0x28] */
            ii(0x15_a27a, 3); add(ax, 0x6);                             /* add ax, 0x6 */
            ii(0x15_a27d, 1); pushw(dx);                                /* push dx */
            ii(0x15_a27e, 1); pushw(ax);                                /* push ax */
            ii(0x15_a27f, 3); callw(0x15_e33a, 0x40b8);                 /* call 0xe33a */
            ii(0x15_a282, 3); les(bx, ss, bp - 0x2a);                   /* les bx, [bp-0x2a] */
            ii(0x15_a285, 4); pushw(memw_a16[es, bx + 0x4]);            /* push word [es:bx+0x4] */
            ii(0x15_a289, 3); callw(0x15_febc, 0x5c30);                 /* call 0xfebc */
            ii(0x15_a28c, 3); lea(ax, bp - 0x26);                       /* lea ax, [bp-0x26] */
            ii(0x15_a28f, 1); pushw(ss);                                /* push ss */
            ii(0x15_a290, 1); pushw(ax);                                /* push ax */
            ii(0x15_a291, 3); callw(0x15_e33a, 0x40a6);                 /* call 0xe33a */
        l_0x15_a294:
            ii(0x15_a294, 3); pushw(memw_a16[ss, bp - 0x28]);           /* push word [bp-0x28] */
            ii(0x15_a297, 3); pushw(memw_a16[ss, bp - 0x2a]);           /* push word [bp-0x2a] */
            ii(0x15_a29a, 5); callw_far_abs(0x80, 0x55dc);              /* call word 0x80:0x55dc */
            ii(0x15_a29f, 1); popw(bx);                                 /* pop bx */
            ii(0x15_a2a0, 1); popw(bx);                                 /* pop bx */
            ii(0x15_a2a1, 1); pushw(dx);                                /* push dx */
            ii(0x15_a2a2, 1); pushw(ax);                                /* push ax */
            ii(0x15_a2a3, 3); callw(0x15_a1c1, -0xe5);                  /* call 0xa1c1 */
            ii(0x15_a2a6, 2); jmpw(0x15_a2b8, 0x10); goto l_0x15_a2b8;  /* jmp 0xa2b8 */
        l_0x15_a2a8:
            ii(0x15_a2a8, 6); cmp(memw_a16[es, bx + 0xb4], -0x1 /* 0xff */); /* cmp word [es:bx+0xb4], 0xffff */
            ii(0x15_a2ae, 2); if(jzw(0x15_a2b8, 0x8)) goto l_0x15_a2b8; /* jz 0xa2b8 */
            ii(0x15_a2b0, 5); pushw(memw_a16[es, bx + 0xb4]);           /* push word [es:bx+0xb4] */
            ii(0x15_a2b5, 3); callw(0x15_febc, 0x5c04);                 /* call 0xfebc */
        l_0x15_a2b8:
            ii(0x15_a2b8, 4); les(bx, ds, 0x1f1a);                      /* les bx, [0x1f1a] */
            ii(0x15_a2bc, 4); lea(bx, bx + 0x1352);                     /* lea bx, [bx+0x1352] */
            ii(0x15_a2c0, 3); mov(si, memw_a16[ss, bp + 0x4]);          /* mov si, [bp+0x4] */
            ii(0x15_a2c3, 3); mov(al, memb_a16[es, bx + si]);           /* mov al, [es:bx+si] */
            ii(0x15_a2c6, 2); dec(al);                                  /* dec al */
            ii(0x15_a2c8, 4); mov(bx, memw_a16[ds, 0x1f1a]);            /* mov bx, [0x1f1a] */
            ii(0x15_a2cc, 5); mov(memb_a16[es, bx + si + 0x1352], al);  /* mov [es:bx+si+0x1352], al */
            ii(0x15_a2d1, 3); mov(es, memw_a16[ss, bp - 0x2e]);         /* mov es, [bp-0x2e] */
            ii(0x15_a2d4, 3); mov(bx, memw_a16[ss, bp - 0x32]);         /* mov bx, [bp-0x32] */
            ii(0x15_a2d7, 5); cmp(memw_a16[es, bx + 0x6c], -0x1 /* 0xff */); /* cmp word [es:bx+0x6c], 0xffff */
            ii(0x15_a2dc, 2); if(jnzw(0x15_a2e1, 0x3)) goto l_0x15_a2e1; /* jnz 0xa2e1 */
            ii(0x15_a2de, 3); jmpw(0x15_a45b, 0x17a); goto l_0x15_a45b; /* jmp 0xa45b */
        l_0x15_a2e1:
            ii(0x15_a2e1, 6); cmp(memb_a16[es, bx + 0xc2], 0);          /* cmp byte [es:bx+0xc2], 0x0 */
            ii(0x15_a2e7, 2); if(jnzw(0x15_a2ec, 0x3)) goto l_0x15_a2ec; /* jnz 0xa2ec */
            ii(0x15_a2e9, 3); jmpw(0x15_a3d8, 0xec); goto l_0x15_a3d8;  /* jmp 0xa3d8 */
        l_0x15_a2ec:
            ii(0x15_a2ec, 4); pushw(memw_a16[es, bx + 0x4e]);           /* push word [es:bx+0x4e] */
            ii(0x15_a2f0, 4); pushw(memw_a16[es, bx + 0x4c]);           /* push word [es:bx+0x4c] */
            ii(0x15_a2f4, 3); callw(0x15_a1c1, -0x136);                 /* call 0xa1c1 */
        l_0x15_a2f7:
            ii(0x15_a2f7, 3); mov(es, memw_a16[ss, bp - 0x2e]);         /* mov es, [bp-0x2e] */
            ii(0x15_a2fa, 3); mov(bx, memw_a16[ss, bp - 0x32]);         /* mov bx, [bp-0x32] */
            ii(0x15_a2fd, 4); pushw(memw_a16[es, bx + 0x46]);           /* push word [es:bx+0x46] */
            ii(0x15_a301, 4); pushw(memw_a16[es, bx + 0x44]);           /* push word [es:bx+0x44] */
            ii(0x15_a305, 2); mov(si, es);                              /* mov si, es */
            ii(0x15_a307, 3); callw(0x15_a1c1, -0x149);                 /* call 0xa1c1 */
            ii(0x15_a30a, 2); mov(es, si);                              /* mov es, si */
            ii(0x15_a30c, 3); mov(bx, memw_a16[ss, bp - 0x32]);         /* mov bx, [bp-0x32] */
            ii(0x15_a30f, 5); pushw(memw_a16[es, bx + 0xbc]);           /* push word [es:bx+0xbc] */
            ii(0x15_a314, 5); pushw(memw_a16[es, bx + 0xba]);           /* push word [es:bx+0xba] */
            ii(0x15_a319, 3); callw(0x15_a1c1, -0x15b);                 /* call 0xa1c1 */
            ii(0x15_a31c, 4); cmp(memb_a16[ss, bp - 0x34], 0);          /* cmp byte [bp-0x34], 0x0 */
            ii(0x15_a320, 2); if(jzw(0x15_a325, 0x3)) goto l_0x15_a325; /* jz 0xa325 */
            ii(0x15_a322, 3); jmpw(0x15_a424, 0xff); goto l_0x15_a424;  /* jmp 0xa424 */
        l_0x15_a325:
            ii(0x15_a325, 2); mov(es, si);                              /* mov es, si */
            ii(0x15_a327, 3); mov(bx, memw_a16[ss, bp - 0x32]);         /* mov bx, [bp-0x32] */
            ii(0x15_a32a, 4); pushw(memw_a16[es, bx + 0x56]);           /* push word [es:bx+0x56] */
            ii(0x15_a32e, 4); pushw(memw_a16[es, bx + 0x54]);           /* push word [es:bx+0x54] */
            ii(0x15_a332, 3); callw(0x15_df78, 0x3c43);                 /* call 0xdf78 */
            ii(0x15_a335, 2); mov(es, si);                              /* mov es, si */
            ii(0x15_a337, 3); mov(bx, memw_a16[ss, bp - 0x32]);         /* mov bx, [bp-0x32] */
            ii(0x15_a33a, 4); pushw(memw_a16[es, bx + 0x1e]);           /* push word [es:bx+0x1e] */
            ii(0x15_a33e, 4); pushw(memw_a16[es, bx + 0x1c]);           /* push word [es:bx+0x1c] */
            ii(0x15_a342, 3); callw(0x15_df78, 0x3c33);                 /* call 0xdf78 */
            ii(0x15_a345, 2); mov(es, si);                              /* mov es, si */
            ii(0x15_a347, 3); mov(bx, memw_a16[ss, bp - 0x32]);         /* mov bx, [bp-0x32] */
            ii(0x15_a34a, 4); pushw(memw_a16[es, bx + 0x22]);           /* push word [es:bx+0x22] */
            ii(0x15_a34e, 4); pushw(memw_a16[es, bx + 0x20]);           /* push word [es:bx+0x20] */
            ii(0x15_a352, 3); callw(0x15_df78, 0x3c23);                 /* call 0xdf78 */
            ii(0x15_a355, 2); mov(es, si);                              /* mov es, si */
            ii(0x15_a357, 3); mov(bx, memw_a16[ss, bp - 0x32]);         /* mov bx, [bp-0x32] */
            ii(0x15_a35a, 4); pushw(memw_a16[es, bx + 0x26]);           /* push word [es:bx+0x26] */
            ii(0x15_a35e, 4); pushw(memw_a16[es, bx + 0x24]);           /* push word [es:bx+0x24] */
            ii(0x15_a362, 3); callw(0x15_df78, 0x3c13);                 /* call 0xdf78 */
            ii(0x15_a365, 2); mov(es, si);                              /* mov es, si */
            ii(0x15_a367, 3); mov(bx, memw_a16[ss, bp - 0x32]);         /* mov bx, [bp-0x32] */
            ii(0x15_a36a, 4); pushw(memw_a16[es, bx + 0x36]);           /* push word [es:bx+0x36] */
            ii(0x15_a36e, 4); pushw(memw_a16[es, bx + 0x34]);           /* push word [es:bx+0x34] */
            ii(0x15_a372, 3); callw(0x15_df78, 0x3c03);                 /* call 0xdf78 */
            ii(0x15_a375, 2); mov(es, si);                              /* mov es, si */
            ii(0x15_a377, 3); mov(bx, memw_a16[ss, bp - 0x32]);         /* mov bx, [bp-0x32] */
            ii(0x15_a37a, 4); pushw(memw_a16[es, bx + 0x2a]);           /* push word [es:bx+0x2a] */
            ii(0x15_a37e, 4); pushw(memw_a16[es, bx + 0x28]);           /* push word [es:bx+0x28] */
            ii(0x15_a382, 3); callw(0x15_df78, 0x3bf3);                 /* call 0xdf78 */
            ii(0x15_a385, 2); mov(es, si);                              /* mov es, si */
            ii(0x15_a387, 3); mov(bx, memw_a16[ss, bp - 0x32]);         /* mov bx, [bp-0x32] */
            ii(0x15_a38a, 4); pushw(memw_a16[es, bx + 0x2e]);           /* push word [es:bx+0x2e] */
            ii(0x15_a38e, 4); pushw(memw_a16[es, bx + 0x2c]);           /* push word [es:bx+0x2c] */
            ii(0x15_a392, 3); callw(0x15_df78, 0x3be3);                 /* call 0xdf78 */
            ii(0x15_a395, 2); mov(es, si);                              /* mov es, si */
            ii(0x15_a397, 3); mov(bx, memw_a16[ss, bp - 0x32]);         /* mov bx, [bp-0x32] */
            ii(0x15_a39a, 4); pushw(memw_a16[es, bx + 0x3e]);           /* push word [es:bx+0x3e] */
            ii(0x15_a39e, 4); pushw(memw_a16[es, bx + 0x3c]);           /* push word [es:bx+0x3c] */
            ii(0x15_a3a2, 3); callw(0x15_df78, 0x3bd3);                 /* call 0xdf78 */
            ii(0x15_a3a5, 2); mov(es, si);                              /* mov es, si */
            ii(0x15_a3a7, 3); mov(bx, memw_a16[ss, bp - 0x32]);         /* mov bx, [bp-0x32] */
            ii(0x15_a3aa, 4); pushw(memw_a16[es, bx + 0x42]);           /* push word [es:bx+0x42] */
            ii(0x15_a3ae, 4); pushw(memw_a16[es, bx + 0x40]);           /* push word [es:bx+0x40] */
            ii(0x15_a3b2, 3); callw(0x15_df78, 0x3bc3);                 /* call 0xdf78 */
            ii(0x15_a3b5, 2); mov(es, si);                              /* mov es, si */
            ii(0x15_a3b7, 3); mov(bx, memw_a16[ss, bp - 0x32]);         /* mov bx, [bp-0x32] */
            ii(0x15_a3ba, 4); pushw(memw_a16[es, bx + 0x5a]);           /* push word [es:bx+0x5a] */
            ii(0x15_a3be, 4); pushw(memw_a16[es, bx + 0x58]);           /* push word [es:bx+0x58] */
            ii(0x15_a3c2, 3); callw(0x15_df78, 0x3bb3);                 /* call 0xdf78 */
            ii(0x15_a3c5, 2); mov(es, si);                              /* mov es, si */
            ii(0x15_a3c7, 3); mov(bx, memw_a16[ss, bp - 0x32]);         /* mov bx, [bp-0x32] */
            ii(0x15_a3ca, 4); pushw(memw_a16[es, bx + 0x3a]);           /* push word [es:bx+0x3a] */
            ii(0x15_a3ce, 4); pushw(memw_a16[es, bx + 0x38]);           /* push word [es:bx+0x38] */
            ii(0x15_a3d2, 3); callw(0x15_df78, 0x3ba3);                 /* call 0xdf78 */
            ii(0x15_a3d5, 3); jmpw(0x15_a45b, 0x83); goto l_0x15_a45b;  /* jmp 0xa45b */
        l_0x15_a3d8:
            ii(0x15_a3d8, 5); mov(memw_a16[ss, bp - 0x2c], 0);          /* mov word [bp-0x2c], 0x0 */
            ii(0x15_a3dd, 2); jmpw(0x15_a3e2, 0x3); goto l_0x15_a3e2;   /* jmp 0xa3e2 */
        l_0x15_a3df:
            ii(0x15_a3df, 3); inc(memw_a16[ss, bp - 0x2c]);             /* inc word [bp-0x2c] */
        l_0x15_a3e2:
            ii(0x15_a3e2, 3); mov(ax, memw_a16[ss, bp - 0x2c]);         /* mov ax, [bp-0x2c] */
            ii(0x15_a3e5, 2); sub(dx, dx);                              /* sub dx, dx */
            ii(0x15_a3e7, 3); mov(es, memw_a16[ss, bp - 0x2e]);         /* mov es, [bp-0x2e] */
            ii(0x15_a3ea, 3); mov(bx, memw_a16[ss, bp - 0x32]);         /* mov bx, [bp-0x32] */
            ii(0x15_a3ed, 2); mov(cx, es);                              /* mov cx, es */
            ii(0x15_a3ef, 4); les(si, es, bx + 0x1c);                   /* les si, [es:bx+0x1c] */
            ii(0x15_a3f3, 4); cmp(memw_a16[es, si + 0x46], dx);         /* cmp [es:si+0x46], dx */
            ii(0x15_a3f7, 2); if(jaew(0x15_a3fc, 0x3)) goto l_0x15_a3fc; /* jae 0xa3fc */
            ii(0x15_a3f9, 3); jmpw(0x15_a2f7, -0x105); goto l_0x15_a2f7; /* jmp 0xa2f7 */
        l_0x15_a3fc:
            ii(0x15_a3fc, 2); if(jaw(0x15_a407, 0x9)) goto l_0x15_a407; /* ja 0xa407 */
            ii(0x15_a3fe, 4); cmp(memw_a16[es, si + 0x44], ax);         /* cmp [es:si+0x44], ax */
            ii(0x15_a402, 2); if(jaw(0x15_a407, 0x3)) goto l_0x15_a407; /* ja 0xa407 */
            ii(0x15_a404, 3); jmpw(0x15_a2f7, -0x110); goto l_0x15_a2f7; /* jmp 0xa2f7 */
        l_0x15_a407:
            ii(0x15_a407, 3); imul(bx, ax, 0x18);                       /* imul bx, ax, 0x18 */
            ii(0x15_a40a, 2); mov(es, cx);                              /* mov es, cx */
            ii(0x15_a40c, 3); mov(si, memw_a16[ss, bp - 0x32]);         /* mov si, [bp-0x32] */
            ii(0x15_a40f, 2); mov(ax, bx);                              /* mov ax, bx */
            ii(0x15_a411, 4); les(bx, es, si + 0x3c);                   /* les bx, [es:si+0x3c] */
            ii(0x15_a415, 2); mov(si, ax);                              /* mov si, ax */
            ii(0x15_a417, 4); pushw(memw_a16[es, bx + si + 0x6]);       /* push word [es:bx+si+0x6] */
            ii(0x15_a41b, 4); pushw(memw_a16[es, bx + si + 0x4]);       /* push word [es:bx+si+0x4] */
            ii(0x15_a41f, 3); callw(0x15_a1c1, -0x261);                 /* call 0xa1c1 */
            ii(0x15_a422, 2); jmpw(0x15_a3df, -0x45); goto l_0x15_a3df; /* jmp 0xa3df */
        l_0x15_a424:
            ii(0x15_a424, 2); pushw(0x4);                               /* push 0x4 */
            ii(0x15_a426, 3); mov(ax, memw_a16[ss, bp - 0x32]);         /* mov ax, [bp-0x32] */
            ii(0x15_a429, 3); add(ax, 0x12a);                           /* add ax, 0x12a */
            ii(0x15_a42c, 3); pushw(memw_a16[ss, bp - 0x2e]);           /* push word [bp-0x2e] */
            ii(0x15_a42f, 1); pushw(ax);                                /* push ax */
            ii(0x15_a430, 2); pushw(0);                                 /* push 0x0 */
            ii(0x15_a432, 2); pushw(0);                                 /* push 0x0 */
            ii(0x15_a434, 3); callw(0x15_9bb6, -0x881);                 /* call 0x9bb6 */
            ii(0x15_a437, 3); mov(memw_a16[ss, bp - 0x2c], ax);         /* mov [bp-0x2c], ax */
            ii(0x15_a43a, 4); les(bx, ds, 0x1f1a);                      /* les bx, [0x1f1a] */
            ii(0x15_a43e, 4); add(bx, 0x1352);                          /* add bx, 0x1352 */
            ii(0x15_a442, 3); mov(si, memw_a16[ss, bp + 0x4]);          /* mov si, [bp+0x4] */
            ii(0x15_a445, 3); mov(al, memb_a16[es, bx + si]);           /* mov al, [es:bx+si] */
            ii(0x15_a448, 2); sub(ah, ah);                              /* sub ah, ah */
            ii(0x15_a44a, 3); sub(ax, memw_a16[ss, bp - 0x2c]);         /* sub ax, [bp-0x2c] */
            ii(0x15_a44d, 3); cmp(ax, 0xffff);                          /* cmp ax, 0xffff */
            ii(0x15_a450, 2); if(jzw(0x15_a45b, 0x9)) goto l_0x15_a45b; /* jz 0xa45b */
            ii(0x15_a452, 1); pushw(ds);                                /* push ds */
            ii(0x15_a453, 3); pushw(0x1fe7);                            /* push 0x1fe7 */
            ii(0x15_a456, 3); callw(0x16_1066, 0x6c0d);                 /* call 0x1066 */
            ii(0x15_a459, 1); popw(bx);                                 /* pop bx */
            ii(0x15_a45a, 1); popw(bx);                                 /* pop bx */
        l_0x15_a45b:
            ii(0x15_a45b, 4); les(bx, ds, 0x1f1a);                      /* les bx, [0x1f1a] */
            ii(0x15_a45f, 4); add(bx, 0x1352);                          /* add bx, 0x1352 */
            ii(0x15_a463, 3); mov(si, memw_a16[ss, bp + 0x4]);          /* mov si, [bp+0x4] */
            ii(0x15_a466, 4); cmp(memb_a16[es, bx + si], 0);            /* cmp byte [es:bx+si], 0x0 */
            ii(0x15_a46a, 2); if(jnzw(0x15_a491, 0x25)) goto l_0x15_a491; /* jnz 0xa491 */
            ii(0x15_a46c, 2); pushw(0);                                 /* push 0x0 */
            ii(0x15_a46e, 3); pushw(0x134);                             /* push 0x134 */
            ii(0x15_a471, 4); imul(ax, si, 0x134);                      /* imul ax, si, 0x134 */
            ii(0x15_a475, 4); add(ax, memw_a16[ds, 0x1f1a]);            /* add ax, [0x1f1a] */
            ii(0x15_a479, 2); mov(dx, es);                              /* mov dx, es */
            ii(0x15_a47b, 3); add(ax, 0x12);                            /* add ax, 0x12 */
            ii(0x15_a47e, 1); pushw(dx);                                /* push dx */
            ii(0x15_a47f, 1); pushw(ax);                                /* push ax */
            ii(0x15_a480, 1); nop();                                    /* nop */
            ii(0x15_a481, 1); pushw(cs);                                /* push cs */
            ii(0x15_a482, 3); callw(0x16_0faf, 0x6b2a);                 /* call 0xfaf */
            ii(0x15_a485, 3); add(sp, 0x8);                             /* add sp, 0x8 */
            ii(0x15_a488, 4); les(bx, ds, 0x1f1a);                      /* les bx, [0x1f1a] */
            ii(0x15_a48c, 5); dec(memw_a16[es, bx + 0x1362]);           /* dec word [es:bx+0x1362] */
        l_0x15_a491:
            ii(0x15_a491, 3); mov(bx, memw_a16[ss, bp + 0x4]);          /* mov bx, [bp+0x4] */
            ii(0x15_a494, 2); shl(bx, 0x1);                             /* shl bx, 1 */
            ii(0x15_a496, 6); mov(memw_a16[ds, bx + 0x1f24], 0);        /* mov word [bx+0x1f24], 0x0 */
        l_0x15_a49c:
            ii(0x15_a49c, 1); popw(si);                                 /* pop si */
            ii(0x15_a49d, 1); leavew();                                 /* leave */
            ii(0x15_a49e, 3); retw(0x2); return;                        /* ret 0x2 */
        }
    }
}