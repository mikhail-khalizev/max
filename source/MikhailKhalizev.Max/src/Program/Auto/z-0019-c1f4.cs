using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x19_c1f4-c2d40bd7")]
        public void Method_0019_c1f4()
        {
            ii(0x19_c1f4, 4);  enter(0x42, 0);                         /* enter 0x42, 0x0 */
            ii(0x19_c1f8, 1);  push(si);                               /* push si */
            ii(0x19_c1f9, 1);  push(ds);                               /* push ds */
            ii(0x19_c1fa, 3);  mov(ax, 0xa8);                          /* mov ax, 0xa8 */
            ii(0x19_c1fd, 2);  mov(ds, ax);                            /* mov ds, ax */
            ii(0x19_c1ff, 3);  les(bx, memw[ss, bp + 6]);              /* les bx, [bp+0x6] */
            ii(0x19_c202, 4);  mov(ax, memw[es, bx + 60]);             /* mov ax, [es:bx+0x3c] */
            ii(0x19_c206, 4);  mov(dx, memw[es, bx + 62]);             /* mov dx, [es:bx+0x3e] */
            ii(0x19_c20a, 3);  mov(memw[ss, bp - 20], ax);             /* mov [bp-0x14], ax */
            ii(0x19_c20d, 3);  mov(memw[ss, bp - 18], dx);             /* mov [bp-0x12], dx */
            ii(0x19_c210, 4);  mov(ax, memw[es, bx + 64]);             /* mov ax, [es:bx+0x40] */
            ii(0x19_c214, 4);  mov(dx, memw[es, bx + 66]);             /* mov dx, [es:bx+0x42] */
            ii(0x19_c218, 3);  mov(memw[ss, bp - 62], ax);             /* mov [bp-0x3e], ax */
            ii(0x19_c21b, 3);  mov(memw[ss, bp - 60], dx);             /* mov [bp-0x3c], dx */
            ii(0x19_c21e, 2);  sub(ax, ax);                            /* sub ax, ax */
            ii(0x19_c220, 3);  mov(memw[ss, bp - 26], ax);             /* mov [bp-0x1a], ax */
            ii(0x19_c223, 3);  mov(memw[ss, bp - 28], ax);             /* mov [bp-0x1c], ax */
            ii(0x19_c226, 4);  mov(ax, memw[es, bx + 28]);             /* mov ax, [es:bx+0x1c] */
            ii(0x19_c22a, 4);  mov(dx, memw[es, bx + 30]);             /* mov dx, [es:bx+0x1e] */
            ii(0x19_c22e, 3);  mov(memw[ss, bp - 32], ax);             /* mov [bp-0x20], ax */
            ii(0x19_c231, 3);  mov(memw[ss, bp - 30], dx);             /* mov [bp-0x1e], dx */
            ii(0x19_c234, 2);  mov(es, dx);                            /* mov es, dx */
            ii(0x19_c236, 2);  mov(bx, ax);                            /* mov bx, ax */
            ii(0x19_c238, 4);  mov(ax, memw[es, bx + 40]);             /* mov ax, [es:bx+0x28] */
            ii(0x19_c23c, 4);  mov(dx, memw[es, bx + 42]);             /* mov dx, [es:bx+0x2a] */
            ii(0x19_c240, 3);  mov(memw[ss, bp - 24], ax);             /* mov [bp-0x18], ax */
            ii(0x19_c243, 3);  mov(memw[ss, bp - 22], dx);             /* mov [bp-0x16], dx */
            ii(0x19_c246, 5);  mov(memw[ss, bp - 34], 0);              /* mov word [bp-0x22], 0x0 */
            ii(0x19_c24b, 3);  les(bx, memw[ss, bp + 6]);              /* les bx, [bp+0x6] */
            ii(0x19_c24e, 4);  mov(ax, memw[es, bx + 84]);             /* mov ax, [es:bx+0x54] */
            ii(0x19_c252, 4);  mov(dx, memw[es, bx + 86]);             /* mov dx, [es:bx+0x56] */
            ii(0x19_c256, 3);  mov(memw[ss, bp - 12], ax);             /* mov [bp-0xc], ax */
            ii(0x19_c259, 3);  mov(memw[ss, bp - 10], dx);             /* mov [bp-0xa], dx */
            ii(0x19_c25c, 4);  mov(ax, memw[es, bx + 72]);             /* mov ax, [es:bx+0x48] */
            ii(0x19_c260, 4);  mov(dx, memw[es, bx + 74]);             /* mov dx, [es:bx+0x4a] */
            ii(0x19_c264, 3);  mov(memw[ss, bp - 16], ax);             /* mov [bp-0x10], ax */
            ii(0x19_c267, 3);  mov(memw[ss, bp - 14], dx);             /* mov [bp-0xe], dx */
            ii(0x19_c26a, 5);  cmp(memw[es, bx + 92], 0);              /* cmp word [es:bx+0x5c], 0x0 */
            ii(0x19_c26f, 2);  if(jz(0x19_c27f, 0xe)) goto l_0x19_c27f;/* jz 0xc27f */
            ii(0x19_c271, 4);  mov(ax, memw[es, bx + 76]);             /* mov ax, [es:bx+0x4c] */
            ii(0x19_c275, 4);  mov(dx, memw[es, bx + 78]);             /* mov dx, [es:bx+0x4e] */
            ii(0x19_c279, 3);  mov(memw[ss, bp - 28], ax);             /* mov [bp-0x1c], ax */
            ii(0x19_c27c, 3);  mov(memw[ss, bp - 26], dx);             /* mov [bp-0x1a], dx */
        l_0x19_c27f:
            ii(0x19_c27f, 5);  mov(memw[ss, bp - 36], 0);              /* mov word [bp-0x24], 0x0 */
            ii(0x19_c284, 3);  jmp(0x19_c3e7, 0x160); goto l_0x19_c3e7;/* jmp 0xc3e7 */
        l_0x19_c287:
            ii(0x19_c287, 4);  imul(ax, memw[ss, bp - 36], 0x18);      /* imul ax, [bp-0x24], 0x18 */
            ii(0x19_c28b, 3);  add(ax, memw[ss, bp - 20]);             /* add ax, [bp-0x14] */
            ii(0x19_c28e, 2);  mov(dx, es);                            /* mov dx, es */
            ii(0x19_c290, 1);  push(dx);                               /* push dx */
            ii(0x19_c291, 1);  push(ax);                               /* push ax */
            ii(0x19_c292, 3);  call(0x19_cd74, 0xadf);                 /* call 0xcd74 */
        l_0x19_c295:
            ii(0x19_c295, 3);  mov(memw[ss, bp - 40], ax);             /* mov [bp-0x28], ax */
            ii(0x19_c298, 3);  mov(memw[ss, bp - 38], dx);             /* mov [bp-0x26], dx */
            ii(0x19_c29b, 3);  push(memw[ss, bp - 22]);                /* push word [bp-0x16] */
            ii(0x19_c29e, 3);  push(memw[ss, bp - 24]);                /* push word [bp-0x18] */
            ii(0x19_c2a1, 3);  push(memw[ss, bp - 42]);                /* push word [bp-0x2a] */
            ii(0x19_c2a4, 3);  push(memw[ss, bp - 44]);                /* push word [bp-0x2c] */
            ii(0x19_c2a7, 5);  call_far_abs(0x80, 0x4252);             /* call word 0x80:0x4252 */
            ii(0x19_c2ac, 3);  add(memw[ss, bp - 40], ax);             /* add [bp-0x28], ax */
            ii(0x19_c2af, 3);  adc(memw[ss, bp - 38], dx);             /* adc [bp-0x26], dx */
            ii(0x19_c2b2, 4);  imul(si, memw[ss, bp - 36], 0x18);      /* imul si, [bp-0x24], 0x18 */
            ii(0x19_c2b6, 3);  les(bx, memw[ss, bp - 20]);             /* les bx, [bp-0x14] */
            ii(0x19_c2b9, 5);  test(memb[es, bx + si + 9], 0x10);      /* test byte [es:bx+si+0x9], 0x10 */
            ii(0x19_c2be, 2);  if(jz(0x19_c2cc, 0xc)) goto l_0x19_c2cc;/* jz 0xc2cc */
            ii(0x19_c2c0, 2);  push(0);                                /* push 0x0 */
            ii(0x19_c2c2, 2);  push(0);                                /* push 0x0 */
            ii(0x19_c2c4, 3);  push(memw[ss, bp - 38]);                /* push word [bp-0x26] */
            ii(0x19_c2c7, 3);  push(memw[ss, bp - 40]);                /* push word [bp-0x28] */
            ii(0x19_c2ca, 2);  jmp(0x19_c2e0, 0x14); goto l_0x19_c2e0; /* jmp 0xc2e0 */
        l_0x19_c2cc:
            ii(0x19_c2cc, 2);  push(0);                                /* push 0x0 */
            ii(0x19_c2ce, 2);  push(0);                                /* push 0x0 */
            ii(0x19_c2d0, 3);  mov(ax, memw[ss, bp - 40]);             /* mov ax, [bp-0x28] */
            ii(0x19_c2d3, 3);  mov(dx, memw[ss, bp - 38]);             /* mov dx, [bp-0x26] */
            ii(0x19_c2d6, 4);  add(ax, memw[ds, 0x19ea]);              /* add ax, [0x19ea] */
            ii(0x19_c2da, 4);  adc(dx, memw[ds, 0x19ec]);              /* adc dx, [0x19ec] */
            ii(0x19_c2de, 1);  push(dx);                               /* push dx */
            ii(0x19_c2df, 1);  push(ax);                               /* push ax */
        l_0x19_c2e0:
            ii(0x19_c2e0, 3);  push(memw[ss, bp - 22]);                /* push word [bp-0x16] */
            ii(0x19_c2e3, 3);  push(memw[ss, bp - 24]);                /* push word [bp-0x18] */
            ii(0x19_c2e6, 3);  call(0x19_de46, 0x1b5d);                /* call 0xde46 */
            ii(0x19_c2e9, 3);  mov(memw[ss, bp - 8], ax);              /* mov [bp-0x8], ax */
            ii(0x19_c2ec, 3);  mov(memw[ss, bp - 6], dx);              /* mov [bp-0x6], dx */
            ii(0x19_c2ef, 3);  push(memw[ss, bp + 8]);                 /* push word [bp+0x8] */
            ii(0x19_c2f2, 3);  push(memw[ss, bp + 6]);                 /* push word [bp+0x6] */
            ii(0x19_c2f5, 2);  push(0);                                /* push 0x0 */
            ii(0x19_c2f7, 2);  push(0);                                /* push 0x0 */
            ii(0x19_c2f9, 3);  mov(bx, memw[ss, bp - 66]);             /* mov bx, [bp-0x42] */
            ii(0x19_c2fc, 3);  shl(bx, 3);                             /* shl bx, 0x3 */
            ii(0x19_c2ff, 3);  les(si, memw[ss, bp - 12]);             /* les si, [bp-0xc] */
            ii(0x19_c302, 3);  mov(ax, memw[es, bx + si]);             /* mov ax, [es:bx+si] */
            ii(0x19_c305, 4);  mov(dx, memw[es, bx + si + 2]);         /* mov dx, [es:bx+si+0x2] */
            ii(0x19_c309, 3);  add(ax, memw[ss, bp - 16]);             /* add ax, [bp-0x10] */
            ii(0x19_c30c, 3);  adc(dx, memw[ss, bp - 14]);             /* adc dx, [bp-0xe] */
            ii(0x19_c30f, 1);  push(dx);                               /* push dx */
            ii(0x19_c310, 1);  push(ax);                               /* push ax */
            ii(0x19_c311, 3);  push(memw[ss, bp - 2]);                 /* push word [bp-0x2] */
            ii(0x19_c314, 3);  push(memw[ss, bp - 4]);                 /* push word [bp-0x4] */
            ii(0x19_c317, 3);  call(0x19_de46, 0x1b2c);                /* call 0xde46 */
            ii(0x19_c31a, 3);  mov(memw[ss, bp - 48], ax);             /* mov [bp-0x30], ax */
            ii(0x19_c31d, 3);  mov(memw[ss, bp - 46], dx);             /* mov [bp-0x2e], dx */
            ii(0x19_c320, 1);  push(dx);                               /* push dx */
            ii(0x19_c321, 1);  push(ax);                               /* push ax */
            ii(0x19_c322, 3);  push(memw[ss, bp - 2]);                 /* push word [bp-0x2] */
            ii(0x19_c325, 3);  push(memw[ss, bp - 4]);                 /* push word [bp-0x4] */
            ii(0x19_c328, 3);  push(memw[ss, bp - 6]);                 /* push word [bp-0x6] */
            ii(0x19_c32b, 3);  push(memw[ss, bp - 8]);                 /* push word [bp-0x8] */
            ii(0x19_c32e, 3);  push(memw[ss, bp - 38]);                /* push word [bp-0x26] */
            ii(0x19_c331, 3);  push(memw[ss, bp - 40]);                /* push word [bp-0x28] */
            ii(0x19_c334, 3);  call(0x19_bbb4, -0x783);                /* call 0xbbb4 */
            ii(0x19_c337, 3);  mov(memw[ss, bp - 34], ax);             /* mov [bp-0x22], ax */
            ii(0x19_c33a, 3);  push(memw[ss, bp - 6]);                 /* push word [bp-0x6] */
            ii(0x19_c33d, 3);  push(memw[ss, bp - 8]);                 /* push word [bp-0x8] */
            ii(0x19_c340, 3);  call(0x19_df78, 0x1c35);                /* call 0xdf78 */
            ii(0x19_c343, 3);  push(memw[ss, bp - 46]);                /* push word [bp-0x2e] */
            ii(0x19_c346, 3);  push(memw[ss, bp - 48]);                /* push word [bp-0x30] */
            ii(0x19_c349, 3);  call(0x19_df78, 0x1c2c);                /* call 0xdf78 */
        l_0x19_c34c:
            ii(0x19_c34c, 4);  add(memw[ss, bp - 44], 1);              /* add word [bp-0x2c], 0x1 */
            ii(0x19_c350, 4);  adc(memw[ss, bp - 42], 0);              /* adc word [bp-0x2a], 0x0 */
        l_0x19_c354:
            ii(0x19_c354, 3);  mov(ax, memw[ss, bp - 44]);             /* mov ax, [bp-0x2c] */
            ii(0x19_c357, 3);  mov(dx, memw[ss, bp - 42]);             /* mov dx, [bp-0x2a] */
            ii(0x19_c35a, 4);  imul(si, memw[ss, bp - 36], 0x18);      /* imul si, [bp-0x24], 0x18 */
            ii(0x19_c35e, 3);  les(bx, memw[ss, bp - 20]);             /* les bx, [bp-0x14] */
            ii(0x19_c361, 4);  cmp(memw[es, bx + si + 18], dx);        /* cmp [es:bx+si+0x12], dx */
            ii(0x19_c365, 2);  if(jb(0x19_c3e4, 0x7d)) goto l_0x19_c3e4;/* jb 0xc3e4 */
            ii(0x19_c367, 2);  if(ja(0x19_c36f, 6)) goto l_0x19_c36f;  /* ja 0xc36f */
            ii(0x19_c369, 4);  cmp(memw[es, bx + si + 16], ax);        /* cmp [es:bx+si+0x10], ax */
            ii(0x19_c36d, 2);  if(jbe(0x19_c3e4, 0x75)) goto l_0x19_c3e4;/* jbe 0xc3e4 */
        l_0x19_c36f:
            ii(0x19_c36f, 4);  cmp(memw[ss, bp - 34], 0);              /* cmp word [bp-0x22], 0x0 */
            ii(0x19_c373, 2);  if(jnz(0x19_c3e4, 0x6f)) goto l_0x19_c3e4;/* jnz 0xc3e4 */
            ii(0x19_c375, 3);  push(memw[ss, bp + 8]);                 /* push word [bp+0x8] */
            ii(0x19_c378, 3);  push(memw[ss, bp + 6]);                 /* push word [bp+0x6] */
            ii(0x19_c37b, 3);  push(memw[ss, bp - 36]);                /* push word [bp-0x24] */
            ii(0x19_c37e, 1);  push(ax);                               /* push ax */
            ii(0x19_c37f, 3);  lea(ax, memw[ss, bp - 52]);             /* lea ax, [bp-0x34] */
            ii(0x19_c382, 1);  push(ss);                               /* push ss */
            ii(0x19_c383, 1);  push(ax);                               /* push ax */
            ii(0x19_c384, 3);  lea(ax, memw[ss, bp - 56]);             /* lea ax, [bp-0x38] */
            ii(0x19_c387, 1);  push(ss);                               /* push ss */
            ii(0x19_c388, 1);  push(ax);                               /* push ax */
            ii(0x19_c389, 3);  lea(ax, memw[ss, bp - 66]);             /* lea ax, [bp-0x42] */
            ii(0x19_c38c, 1);  push(ss);                               /* push ss */
            ii(0x19_c38d, 1);  push(ax);                               /* push ax */
            ii(0x19_c38e, 3);  call(0x19_dc78, 0x18e7);                /* call 0xdc78 */
            ii(0x19_c391, 3);  mov(memw[ss, bp - 58], ax);             /* mov [bp-0x3a], ax */
            ii(0x19_c394, 1);  dec(ax);                                /* dec ax */
            ii(0x19_c395, 2);  if(jz(0x19_c39d, 6)) goto l_0x19_c39d;  /* jz 0xc39d */
            ii(0x19_c397, 4);  cmp(memw[ss, bp - 58], 0);              /* cmp word [bp-0x3a], 0x0 */
            ii(0x19_c39b, 2);  if(jnz(0x19_c34c, -0x51)) goto l_0x19_c34c;/* jnz 0xc34c */
        l_0x19_c39d:
            ii(0x19_c39d, 3);  mov(bx, memw[ss, bp - 66]);             /* mov bx, [bp-0x42] */
            ii(0x19_c3a0, 3);  shl(bx, 3);                             /* shl bx, 0x3 */
            ii(0x19_c3a3, 3);  add(bx, memw[ss, bp - 12]);             /* add bx, [bp-0xc] */
            ii(0x19_c3a6, 3);  mov(es, memw[ss, bp - 10]);             /* mov es, [bp-0xa] */
            ii(0x19_c3a9, 4);  mov(ax, memw[es, bx + 4]);              /* mov ax, [es:bx+0x4] */
            ii(0x19_c3ad, 4);  mov(dx, memw[es, bx + 6]);              /* mov dx, [es:bx+0x6] */
            ii(0x19_c3b1, 3);  sub(ax, memw[es, bx]);                  /* sub ax, [es:bx] */
            ii(0x19_c3b4, 4);  sbb(dx, memw[es, bx + 2]);              /* sbb dx, [es:bx+0x2] */
            ii(0x19_c3b8, 3);  mov(memw[ss, bp - 4], ax);              /* mov [bp-0x4], ax */
            ii(0x19_c3bb, 3);  mov(memw[ss, bp - 2], dx);              /* mov [bp-0x2], dx */
            ii(0x19_c3be, 4);  imul(bx, memw[ss, bp - 36], 0x18);      /* imul bx, [bp-0x24], 0x18 */
            ii(0x19_c3c2, 3);  add(bx, memw[ss, bp - 20]);             /* add bx, [bp-0x14] */
            ii(0x19_c3c5, 3);  mov(es, memw[ss, bp - 18]);             /* mov es, [bp-0x12] */
            ii(0x19_c3c8, 5);  test(memb[es, bx + 9], 0x10);           /* test byte [es:bx+0x9], 0x10 */
            ii(0x19_c3cd, 2);  if(jnz(0x19_c3d2, 3)) goto l_0x19_c3d2; /* jnz 0xc3d2 */
            ii(0x19_c3cf, 3);  jmp(0x19_c287, -0x14b); goto l_0x19_c287;/* jmp 0xc287 */
        l_0x19_c3d2:
            ii(0x19_c3d2, 4);  mov(ax, memw[es, bx + 20]);             /* mov ax, [es:bx+0x14] */
            ii(0x19_c3d6, 2);  sub(cx, cx);                            /* sub cx, cx */
            ii(0x19_c3d8, 1);  push(ax);                               /* push ax */
            ii(0x19_c3d9, 1);  push(cx);                               /* push cx */
            ii(0x19_c3da, 5);  call_far_abs(0x80, 0x55dc);             /* call word 0x80:0x55dc */
            ii(0x19_c3df, 1);  pop(bx);                                /* pop bx */
            ii(0x19_c3e0, 1);  pop(bx);                                /* pop bx */
            ii(0x19_c3e1, 3);  jmp(0x19_c295, -0x14f); goto l_0x19_c295;/* jmp 0xc295 */
        l_0x19_c3e4:
            ii(0x19_c3e4, 3);  inc(memw[ss, bp - 36]);                 /* inc word [bp-0x24] */
        l_0x19_c3e7:
            ii(0x19_c3e7, 3);  mov(ax, memw[ss, bp - 36]);             /* mov ax, [bp-0x24] */
            ii(0x19_c3ea, 3);  les(bx, memw[ss, bp - 32]);             /* les bx, [bp-0x20] */
            ii(0x19_c3ed, 4);  cmp(memw[es, bx + 68], ax);             /* cmp [es:bx+0x44], ax */
            ii(0x19_c3f1, 2);  if(jbe(0x19_c404, 0x11)) goto l_0x19_c404;/* jbe 0xc404 */
            ii(0x19_c3f3, 4);  cmp(memw[ss, bp - 34], 0);              /* cmp word [bp-0x22], 0x0 */
            ii(0x19_c3f7, 2);  if(jnz(0x19_c404, 0xb)) goto l_0x19_c404;/* jnz 0xc404 */
            ii(0x19_c3f9, 2);  sub(ax, ax);                            /* sub ax, ax */
            ii(0x19_c3fb, 3);  mov(memw[ss, bp - 42], ax);             /* mov [bp-0x2a], ax */
            ii(0x19_c3fe, 3);  mov(memw[ss, bp - 44], ax);             /* mov [bp-0x2c], ax */
            ii(0x19_c401, 3);  jmp(0x19_c354, -0xb0); goto l_0x19_c354;/* jmp 0xc354 */
        l_0x19_c404:
            ii(0x19_c404, 3);  mov(ax, memw[ss, bp - 34]);             /* mov ax, [bp-0x22] */
            ii(0x19_c407, 1);  pop(ds);                                /* pop ds */
            ii(0x19_c408, 1);  pop(si);                                /* pop si */
            ii(0x19_c409, 1);  leave();                                /* leave */
            ii(0x19_c40a, 1);  retf();                                 /* retf */
        }
    }
}
