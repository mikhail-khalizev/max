using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("8dd63998-fe63-4a77-a839-611f80aa1e84")]
        public void Method_0015_c1f4()
        {
            ii(0x15_c1f4, 4); enterw(0x42, 0);                          /* enter 0x42, 0x0 */
            ii(0x15_c1f8, 1); pushw(si);                                /* push si */
            ii(0x15_c1f9, 1); pushw(ds);                                /* push ds */
            ii(0x15_c1fa, 3); mov(ax, 0xa8);                            /* mov ax, 0xa8 */
            ii(0x15_c1fd, 2); mov(ds, ax);                              /* mov ds, ax */
            ii(0x15_c1ff, 3); les(bx, ss, bp + 0x6);                    /* les bx, [bp+0x6] */
            ii(0x15_c202, 4); mov(ax, memw_a16[es, bx + 0x3c]);         /* mov ax, [es:bx+0x3c] */
            ii(0x15_c206, 4); mov(dx, memw_a16[es, bx + 0x3e]);         /* mov dx, [es:bx+0x3e] */
            ii(0x15_c20a, 3); mov(memw_a16[ss, bp - 0x14], ax);         /* mov [bp-0x14], ax */
            ii(0x15_c20d, 3); mov(memw_a16[ss, bp - 0x12], dx);         /* mov [bp-0x12], dx */
            ii(0x15_c210, 4); mov(ax, memw_a16[es, bx + 0x40]);         /* mov ax, [es:bx+0x40] */
            ii(0x15_c214, 4); mov(dx, memw_a16[es, bx + 0x42]);         /* mov dx, [es:bx+0x42] */
            ii(0x15_c218, 3); mov(memw_a16[ss, bp - 0x3e], ax);         /* mov [bp-0x3e], ax */
            ii(0x15_c21b, 3); mov(memw_a16[ss, bp - 0x3c], dx);         /* mov [bp-0x3c], dx */
            ii(0x15_c21e, 2); sub(ax, ax);                              /* sub ax, ax */
            ii(0x15_c220, 3); mov(memw_a16[ss, bp - 0x1a], ax);         /* mov [bp-0x1a], ax */
            ii(0x15_c223, 3); mov(memw_a16[ss, bp - 0x1c], ax);         /* mov [bp-0x1c], ax */
            ii(0x15_c226, 4); mov(ax, memw_a16[es, bx + 0x1c]);         /* mov ax, [es:bx+0x1c] */
            ii(0x15_c22a, 4); mov(dx, memw_a16[es, bx + 0x1e]);         /* mov dx, [es:bx+0x1e] */
            ii(0x15_c22e, 3); mov(memw_a16[ss, bp - 0x20], ax);         /* mov [bp-0x20], ax */
            ii(0x15_c231, 3); mov(memw_a16[ss, bp - 0x1e], dx);         /* mov [bp-0x1e], dx */
            ii(0x15_c234, 2); mov(es, dx);                              /* mov es, dx */
            ii(0x15_c236, 2); mov(bx, ax);                              /* mov bx, ax */
            ii(0x15_c238, 4); mov(ax, memw_a16[es, bx + 0x28]);         /* mov ax, [es:bx+0x28] */
            ii(0x15_c23c, 4); mov(dx, memw_a16[es, bx + 0x2a]);         /* mov dx, [es:bx+0x2a] */
            ii(0x15_c240, 3); mov(memw_a16[ss, bp - 0x18], ax);         /* mov [bp-0x18], ax */
            ii(0x15_c243, 3); mov(memw_a16[ss, bp - 0x16], dx);         /* mov [bp-0x16], dx */
            ii(0x15_c246, 5); mov(memw_a16[ss, bp - 0x22], 0);          /* mov word [bp-0x22], 0x0 */
            ii(0x15_c24b, 3); les(bx, ss, bp + 0x6);                    /* les bx, [bp+0x6] */
            ii(0x15_c24e, 4); mov(ax, memw_a16[es, bx + 0x54]);         /* mov ax, [es:bx+0x54] */
            ii(0x15_c252, 4); mov(dx, memw_a16[es, bx + 0x56]);         /* mov dx, [es:bx+0x56] */
            ii(0x15_c256, 3); mov(memw_a16[ss, bp - 0xc], ax);          /* mov [bp-0xc], ax */
            ii(0x15_c259, 3); mov(memw_a16[ss, bp - 0xa], dx);          /* mov [bp-0xa], dx */
            ii(0x15_c25c, 4); mov(ax, memw_a16[es, bx + 0x48]);         /* mov ax, [es:bx+0x48] */
            ii(0x15_c260, 4); mov(dx, memw_a16[es, bx + 0x4a]);         /* mov dx, [es:bx+0x4a] */
            ii(0x15_c264, 3); mov(memw_a16[ss, bp - 0x10], ax);         /* mov [bp-0x10], ax */
            ii(0x15_c267, 3); mov(memw_a16[ss, bp - 0xe], dx);          /* mov [bp-0xe], dx */
            ii(0x15_c26a, 5); cmp(memw_a16[es, bx + 0x5c], 0);          /* cmp word [es:bx+0x5c], 0x0 */
            ii(0x15_c26f, 2); if(jzw(0x15_c27f, 0xe)) goto l_0x15_c27f; /* jz 0xc27f */
            ii(0x15_c271, 4); mov(ax, memw_a16[es, bx + 0x4c]);         /* mov ax, [es:bx+0x4c] */
            ii(0x15_c275, 4); mov(dx, memw_a16[es, bx + 0x4e]);         /* mov dx, [es:bx+0x4e] */
            ii(0x15_c279, 3); mov(memw_a16[ss, bp - 0x1c], ax);         /* mov [bp-0x1c], ax */
            ii(0x15_c27c, 3); mov(memw_a16[ss, bp - 0x1a], dx);         /* mov [bp-0x1a], dx */
        l_0x15_c27f:
            ii(0x15_c27f, 5); mov(memw_a16[ss, bp - 0x24], 0);          /* mov word [bp-0x24], 0x0 */
            ii(0x15_c284, 3); jmpw(0x15_c3e7, 0x160); goto l_0x15_c3e7; /* jmp 0xc3e7 */
        l_0x15_c287:
            ii(0x15_c287, 4); imul(ax, memw_a16[ss, bp - 0x24], 0x18);  /* imul ax, [bp-0x24], 0x18 */
            ii(0x15_c28b, 3); add(ax, memw_a16[ss, bp - 0x14]);         /* add ax, [bp-0x14] */
            ii(0x15_c28e, 2); mov(dx, es);                              /* mov dx, es */
            ii(0x15_c290, 1); pushw(dx);                                /* push dx */
            ii(0x15_c291, 1); pushw(ax);                                /* push ax */
            ii(0x15_c292, 3); callw(0x15_cd74, 0xadf);                  /* call 0xcd74 */
        l_0x15_c295:
            ii(0x15_c295, 3); mov(memw_a16[ss, bp - 0x28], ax);         /* mov [bp-0x28], ax */
            ii(0x15_c298, 3); mov(memw_a16[ss, bp - 0x26], dx);         /* mov [bp-0x26], dx */
            ii(0x15_c29b, 3); pushw(memw_a16[ss, bp - 0x16]);           /* push word [bp-0x16] */
            ii(0x15_c29e, 3); pushw(memw_a16[ss, bp - 0x18]);           /* push word [bp-0x18] */
            ii(0x15_c2a1, 3); pushw(memw_a16[ss, bp - 0x2a]);           /* push word [bp-0x2a] */
            ii(0x15_c2a4, 3); pushw(memw_a16[ss, bp - 0x2c]);           /* push word [bp-0x2c] */
            ii(0x15_c2a7, 5); callw_far_abs(0x80, 0x4252);              /* call word 0x80:0x4252 */
            ii(0x15_c2ac, 3); add(memw_a16[ss, bp - 0x28], ax);         /* add [bp-0x28], ax */
            ii(0x15_c2af, 3); adc(memw_a16[ss, bp - 0x26], dx);         /* adc [bp-0x26], dx */
            ii(0x15_c2b2, 4); imul(si, memw_a16[ss, bp - 0x24], 0x18);  /* imul si, [bp-0x24], 0x18 */
            ii(0x15_c2b6, 3); les(bx, ss, bp - 0x14);                   /* les bx, [bp-0x14] */
            ii(0x15_c2b9, 5); test(memb_a16[es, bx + si + 0x9], 0x10);  /* test byte [es:bx+si+0x9], 0x10 */
            ii(0x15_c2be, 2); if(jzw(0x15_c2cc, 0xc)) goto l_0x15_c2cc; /* jz 0xc2cc */
            ii(0x15_c2c0, 2); pushw(0);                                 /* push 0x0 */
            ii(0x15_c2c2, 2); pushw(0);                                 /* push 0x0 */
            ii(0x15_c2c4, 3); pushw(memw_a16[ss, bp - 0x26]);           /* push word [bp-0x26] */
            ii(0x15_c2c7, 3); pushw(memw_a16[ss, bp - 0x28]);           /* push word [bp-0x28] */
            ii(0x15_c2ca, 2); jmpw(0x15_c2e0, 0x14); goto l_0x15_c2e0;  /* jmp 0xc2e0 */
        l_0x15_c2cc:
            ii(0x15_c2cc, 2); pushw(0);                                 /* push 0x0 */
            ii(0x15_c2ce, 2); pushw(0);                                 /* push 0x0 */
            ii(0x15_c2d0, 3); mov(ax, memw_a16[ss, bp - 0x28]);         /* mov ax, [bp-0x28] */
            ii(0x15_c2d3, 3); mov(dx, memw_a16[ss, bp - 0x26]);         /* mov dx, [bp-0x26] */
            ii(0x15_c2d6, 4); add(ax, memw_a16[ds, 0x19ea]);            /* add ax, [0x19ea] */
            ii(0x15_c2da, 4); adc(dx, memw_a16[ds, 0x19ec]);            /* adc dx, [0x19ec] */
            ii(0x15_c2de, 1); pushw(dx);                                /* push dx */
            ii(0x15_c2df, 1); pushw(ax);                                /* push ax */
        l_0x15_c2e0:
            ii(0x15_c2e0, 3); pushw(memw_a16[ss, bp - 0x16]);           /* push word [bp-0x16] */
            ii(0x15_c2e3, 3); pushw(memw_a16[ss, bp - 0x18]);           /* push word [bp-0x18] */
            ii(0x15_c2e6, 3); callw(0x15_de46, 0x1b5d);                 /* call 0xde46 */
            ii(0x15_c2e9, 3); mov(memw_a16[ss, bp - 0x8], ax);          /* mov [bp-0x8], ax */
            ii(0x15_c2ec, 3); mov(memw_a16[ss, bp - 0x6], dx);          /* mov [bp-0x6], dx */
            ii(0x15_c2ef, 3); pushw(memw_a16[ss, bp + 0x8]);            /* push word [bp+0x8] */
            ii(0x15_c2f2, 3); pushw(memw_a16[ss, bp + 0x6]);            /* push word [bp+0x6] */
            ii(0x15_c2f5, 2); pushw(0);                                 /* push 0x0 */
            ii(0x15_c2f7, 2); pushw(0);                                 /* push 0x0 */
            ii(0x15_c2f9, 3); mov(bx, memw_a16[ss, bp - 0x42]);         /* mov bx, [bp-0x42] */
            ii(0x15_c2fc, 3); shl(bx, 0x3);                             /* shl bx, 0x3 */
            ii(0x15_c2ff, 3); les(si, ss, bp - 0xc);                    /* les si, [bp-0xc] */
            ii(0x15_c302, 3); mov(ax, memw_a16[es, bx + si]);           /* mov ax, [es:bx+si] */
            ii(0x15_c305, 4); mov(dx, memw_a16[es, bx + si + 0x2]);     /* mov dx, [es:bx+si+0x2] */
            ii(0x15_c309, 3); add(ax, memw_a16[ss, bp - 0x10]);         /* add ax, [bp-0x10] */
            ii(0x15_c30c, 3); adc(dx, memw_a16[ss, bp - 0xe]);          /* adc dx, [bp-0xe] */
            ii(0x15_c30f, 1); pushw(dx);                                /* push dx */
            ii(0x15_c310, 1); pushw(ax);                                /* push ax */
            ii(0x15_c311, 3); pushw(memw_a16[ss, bp - 0x2]);            /* push word [bp-0x2] */
            ii(0x15_c314, 3); pushw(memw_a16[ss, bp - 0x4]);            /* push word [bp-0x4] */
            ii(0x15_c317, 3); callw(0x15_de46, 0x1b2c);                 /* call 0xde46 */
            ii(0x15_c31a, 3); mov(memw_a16[ss, bp - 0x30], ax);         /* mov [bp-0x30], ax */
            ii(0x15_c31d, 3); mov(memw_a16[ss, bp - 0x2e], dx);         /* mov [bp-0x2e], dx */
            ii(0x15_c320, 1); pushw(dx);                                /* push dx */
            ii(0x15_c321, 1); pushw(ax);                                /* push ax */
            ii(0x15_c322, 3); pushw(memw_a16[ss, bp - 0x2]);            /* push word [bp-0x2] */
            ii(0x15_c325, 3); pushw(memw_a16[ss, bp - 0x4]);            /* push word [bp-0x4] */
            ii(0x15_c328, 3); pushw(memw_a16[ss, bp - 0x6]);            /* push word [bp-0x6] */
            ii(0x15_c32b, 3); pushw(memw_a16[ss, bp - 0x8]);            /* push word [bp-0x8] */
            ii(0x15_c32e, 3); pushw(memw_a16[ss, bp - 0x26]);           /* push word [bp-0x26] */
            ii(0x15_c331, 3); pushw(memw_a16[ss, bp - 0x28]);           /* push word [bp-0x28] */
            ii(0x15_c334, 3); callw(0x15_bbb4, -0x783);                 /* call 0xbbb4 */
            ii(0x15_c337, 3); mov(memw_a16[ss, bp - 0x22], ax);         /* mov [bp-0x22], ax */
            ii(0x15_c33a, 3); pushw(memw_a16[ss, bp - 0x6]);            /* push word [bp-0x6] */
            ii(0x15_c33d, 3); pushw(memw_a16[ss, bp - 0x8]);            /* push word [bp-0x8] */
            ii(0x15_c340, 3); callw(0x15_df78, 0x1c35);                 /* call 0xdf78 */
            ii(0x15_c343, 3); pushw(memw_a16[ss, bp - 0x2e]);           /* push word [bp-0x2e] */
            ii(0x15_c346, 3); pushw(memw_a16[ss, bp - 0x30]);           /* push word [bp-0x30] */
            ii(0x15_c349, 3); callw(0x15_df78, 0x1c2c);                 /* call 0xdf78 */
        l_0x15_c34c:
            ii(0x15_c34c, 4); add(memw_a16[ss, bp - 0x2c], 0x1);        /* add word [bp-0x2c], 0x1 */
            ii(0x15_c350, 4); adc(memw_a16[ss, bp - 0x2a], 0);          /* adc word [bp-0x2a], 0x0 */
        l_0x15_c354:
            ii(0x15_c354, 3); mov(ax, memw_a16[ss, bp - 0x2c]);         /* mov ax, [bp-0x2c] */
            ii(0x15_c357, 3); mov(dx, memw_a16[ss, bp - 0x2a]);         /* mov dx, [bp-0x2a] */
            ii(0x15_c35a, 4); imul(si, memw_a16[ss, bp - 0x24], 0x18);  /* imul si, [bp-0x24], 0x18 */
            ii(0x15_c35e, 3); les(bx, ss, bp - 0x14);                   /* les bx, [bp-0x14] */
            ii(0x15_c361, 4); cmp(memw_a16[es, bx + si + 0x12], dx);    /* cmp [es:bx+si+0x12], dx */
            ii(0x15_c365, 2); if(jbw(0x15_c3e4, 0x7d)) goto l_0x15_c3e4; /* jb 0xc3e4 */
            ii(0x15_c367, 2); if(jaw(0x15_c36f, 0x6)) goto l_0x15_c36f; /* ja 0xc36f */
            ii(0x15_c369, 4); cmp(memw_a16[es, bx + si + 0x10], ax);    /* cmp [es:bx+si+0x10], ax */
            ii(0x15_c36d, 2); if(jbew(0x15_c3e4, 0x75)) goto l_0x15_c3e4; /* jbe 0xc3e4 */
        l_0x15_c36f:
            ii(0x15_c36f, 4); cmp(memw_a16[ss, bp - 0x22], 0);          /* cmp word [bp-0x22], 0x0 */
            ii(0x15_c373, 2); if(jnzw(0x15_c3e4, 0x6f)) goto l_0x15_c3e4; /* jnz 0xc3e4 */
            ii(0x15_c375, 3); pushw(memw_a16[ss, bp + 0x8]);            /* push word [bp+0x8] */
            ii(0x15_c378, 3); pushw(memw_a16[ss, bp + 0x6]);            /* push word [bp+0x6] */
            ii(0x15_c37b, 3); pushw(memw_a16[ss, bp - 0x24]);           /* push word [bp-0x24] */
            ii(0x15_c37e, 1); pushw(ax);                                /* push ax */
            ii(0x15_c37f, 3); lea(ax, bp - 0x34);                       /* lea ax, [bp-0x34] */
            ii(0x15_c382, 1); pushw(ss);                                /* push ss */
            ii(0x15_c383, 1); pushw(ax);                                /* push ax */
            ii(0x15_c384, 3); lea(ax, bp - 0x38);                       /* lea ax, [bp-0x38] */
            ii(0x15_c387, 1); pushw(ss);                                /* push ss */
            ii(0x15_c388, 1); pushw(ax);                                /* push ax */
            ii(0x15_c389, 3); lea(ax, bp - 0x42);                       /* lea ax, [bp-0x42] */
            ii(0x15_c38c, 1); pushw(ss);                                /* push ss */
            ii(0x15_c38d, 1); pushw(ax);                                /* push ax */
            ii(0x15_c38e, 3); callw(0x15_dc78, 0x18e7);                 /* call 0xdc78 */
            ii(0x15_c391, 3); mov(memw_a16[ss, bp - 0x3a], ax);         /* mov [bp-0x3a], ax */
            ii(0x15_c394, 1); dec(ax);                                  /* dec ax */
            ii(0x15_c395, 2); if(jzw(0x15_c39d, 0x6)) goto l_0x15_c39d; /* jz 0xc39d */
            ii(0x15_c397, 4); cmp(memw_a16[ss, bp - 0x3a], 0);          /* cmp word [bp-0x3a], 0x0 */
            ii(0x15_c39b, 2); if(jnzw(0x15_c34c, -0x51)) goto l_0x15_c34c; /* jnz 0xc34c */
        l_0x15_c39d:
            ii(0x15_c39d, 3); mov(bx, memw_a16[ss, bp - 0x42]);         /* mov bx, [bp-0x42] */
            ii(0x15_c3a0, 3); shl(bx, 0x3);                             /* shl bx, 0x3 */
            ii(0x15_c3a3, 3); add(bx, memw_a16[ss, bp - 0xc]);          /* add bx, [bp-0xc] */
            ii(0x15_c3a6, 3); mov(es, memw_a16[ss, bp - 0xa]);          /* mov es, [bp-0xa] */
            ii(0x15_c3a9, 4); mov(ax, memw_a16[es, bx + 0x4]);          /* mov ax, [es:bx+0x4] */
            ii(0x15_c3ad, 4); mov(dx, memw_a16[es, bx + 0x6]);          /* mov dx, [es:bx+0x6] */
            ii(0x15_c3b1, 3); sub(ax, memw_a16[es, bx]);                /* sub ax, [es:bx] */
            ii(0x15_c3b4, 4); sbb(dx, memw_a16[es, bx + 0x2]);          /* sbb dx, [es:bx+0x2] */
            ii(0x15_c3b8, 3); mov(memw_a16[ss, bp - 0x4], ax);          /* mov [bp-0x4], ax */
            ii(0x15_c3bb, 3); mov(memw_a16[ss, bp - 0x2], dx);          /* mov [bp-0x2], dx */
            ii(0x15_c3be, 4); imul(bx, memw_a16[ss, bp - 0x24], 0x18);  /* imul bx, [bp-0x24], 0x18 */
            ii(0x15_c3c2, 3); add(bx, memw_a16[ss, bp - 0x14]);         /* add bx, [bp-0x14] */
            ii(0x15_c3c5, 3); mov(es, memw_a16[ss, bp - 0x12]);         /* mov es, [bp-0x12] */
            ii(0x15_c3c8, 5); test(memb_a16[es, bx + 0x9], 0x10);       /* test byte [es:bx+0x9], 0x10 */
            ii(0x15_c3cd, 2); if(jnzw(0x15_c3d2, 0x3)) goto l_0x15_c3d2; /* jnz 0xc3d2 */
            ii(0x15_c3cf, 3); jmpw(0x15_c287, -0x14b); goto l_0x15_c287; /* jmp 0xc287 */
        l_0x15_c3d2:
            ii(0x15_c3d2, 4); mov(ax, memw_a16[es, bx + 0x14]);         /* mov ax, [es:bx+0x14] */
            ii(0x15_c3d6, 2); sub(cx, cx);                              /* sub cx, cx */
            ii(0x15_c3d8, 1); pushw(ax);                                /* push ax */
            ii(0x15_c3d9, 1); pushw(cx);                                /* push cx */
            ii(0x15_c3da, 5); callw_far_abs(0x80, 0x55dc);              /* call word 0x80:0x55dc */
            ii(0x15_c3df, 1); popw(bx);                                 /* pop bx */
            ii(0x15_c3e0, 1); popw(bx);                                 /* pop bx */
            ii(0x15_c3e1, 3); jmpw(0x15_c295, -0x14f); goto l_0x15_c295; /* jmp 0xc295 */
        l_0x15_c3e4:
            ii(0x15_c3e4, 3); inc(memw_a16[ss, bp - 0x24]);             /* inc word [bp-0x24] */
        l_0x15_c3e7:
            ii(0x15_c3e7, 3); mov(ax, memw_a16[ss, bp - 0x24]);         /* mov ax, [bp-0x24] */
            ii(0x15_c3ea, 3); les(bx, ss, bp - 0x20);                   /* les bx, [bp-0x20] */
            ii(0x15_c3ed, 4); cmp(memw_a16[es, bx + 0x44], ax);         /* cmp [es:bx+0x44], ax */
            ii(0x15_c3f1, 2); if(jbew(0x15_c404, 0x11)) goto l_0x15_c404; /* jbe 0xc404 */
            ii(0x15_c3f3, 4); cmp(memw_a16[ss, bp - 0x22], 0);          /* cmp word [bp-0x22], 0x0 */
            ii(0x15_c3f7, 2); if(jnzw(0x15_c404, 0xb)) goto l_0x15_c404; /* jnz 0xc404 */
            ii(0x15_c3f9, 2); sub(ax, ax);                              /* sub ax, ax */
            ii(0x15_c3fb, 3); mov(memw_a16[ss, bp - 0x2a], ax);         /* mov [bp-0x2a], ax */
            ii(0x15_c3fe, 3); mov(memw_a16[ss, bp - 0x2c], ax);         /* mov [bp-0x2c], ax */
            ii(0x15_c401, 3); jmpw(0x15_c354, -0xb0); goto l_0x15_c354; /* jmp 0xc354 */
        l_0x15_c404:
            ii(0x15_c404, 3); mov(ax, memw_a16[ss, bp - 0x22]);         /* mov ax, [bp-0x22] */
            ii(0x15_c407, 1); popw(ds);                                 /* pop ds */
            ii(0x15_c408, 1); popw(si);                                 /* pop si */
            ii(0x15_c409, 1); leavew();                                 /* leave */
            ii(0x15_c40a, 1); retfw(); return;                          /* retf */
        }
    }
}
