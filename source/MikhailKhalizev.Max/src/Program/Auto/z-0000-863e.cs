using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x863e-11c6c4dd")]
        public void Method_0000_863e()
        {
            ii(0x863e, 4);  enter(0x1c, 0);                            /* enter 0x1c, 0x0 */
            ii(0x8642, 2);  sub(ax, ax);                               /* sub ax, ax */
            ii(0x8644, 3);  mov(memw[ds, 0xa6], ax);                   /* mov [0xa6], ax */
            ii(0x8647, 3);  mov(memw[ds, 0xa4], ax);                   /* mov [0xa4], ax */
            ii(0x864a, 3);  mov(memw[ds, 0x9e], ax);                   /* mov [0x9e], ax */
            ii(0x864d, 3);  mov(memw[ds, 0x9c], ax);                   /* mov [0x9c], ax */
            ii(0x8650, 3);  mov(memw[ds, 0x9a], ax);                   /* mov [0x9a], ax */
            ii(0x8653, 3);  mov(memw[ds, 0x98], ax);                   /* mov [0x98], ax */
            ii(0x8656, 6);  mov(memw[ds, 0xa0], 0x98);                 /* mov word [0xa0], 0x98 */
            ii(0x865c, 4);  mov(memw[ds, 0xa2], ds);                   /* mov [0xa2], ds */
            ii(0x8660, 5);  cmp(memb[ds, 0x2e], 0xb);                  /* cmp byte [0x2e], 0xb */
            ii(0x8665, 2);  if(jnz(0x869c, 0x35)) goto l_0x869c;       /* jnz 0x869c */
            ii(0x8667, 4);  push(memw[ds, 0xeca]);                     /* push word [0xeca] */
            ii(0x866b, 3);  call(0x9d3c, 0x16ce);                      /* call 0x9d3c */
            ii(0x866e, 1);  pop(bx);                                   /* pop bx */
            ii(0x866f, 3);  mov(memw[ds, 0x98], ax);                   /* mov [0x98], ax */
            ii(0x8672, 4);  mov(memw[ds, 0x9a], dx);                   /* mov [0x9a], dx */
            ii(0x8676, 3);  mov(ax, memw[ds, 0xecc]);                  /* mov ax, [0xecc] */
            ii(0x8679, 4);  add(ax, memw[ds, 0xeca]);                  /* add ax, [0xeca] */
            ii(0x867d, 3);  mov(memw[ss, bp - 28], ax);                /* mov [bp-0x1c], ax */
            ii(0x8680, 4);  cmp(ax, memw[ds, 0xeca]);                  /* cmp ax, [0xeca] */
            ii(0x8684, 2);  if(jae(0x868b, 5)) goto l_0x868b;          /* jae 0x868b */
            ii(0x8686, 5);  mov(memw[ss, bp - 28], 0xff00);            /* mov word [bp-0x1c], 0xff00 */
        l_0x868b:
            ii(0x868b, 3);  push(memw[ss, bp - 28]);                   /* push word [bp-0x1c] */
            ii(0x868e, 3);  call(0x9d3c, 0x16ab);                      /* call 0x9d3c */
            ii(0x8691, 1);  pop(bx);                                   /* pop bx */
            ii(0x8692, 3);  mov(memw[ds, 0x9c], ax);                   /* mov [0x9c], ax */
            ii(0x8695, 4);  mov(memw[ds, 0x9e], dx);                   /* mov [0x9e], dx */
            ii(0x8699, 3);  jmp(0x8786, 0xea); goto l_0x8786;          /* jmp 0x8786 */
        l_0x869c:
            ii(0x869c, 5);  test(memb[ds, 0x47], 1);                   /* test byte [0x47], 0x1 */
            ii(0x86a1, 2);  if(jnz(0x86e7, 0x44)) goto l_0x86e7;       /* jnz 0x86e7 */
            ii(0x86a3, 4);  push(memw[ds, 0xeca]);                     /* push word [0xeca] */
            ii(0x86a7, 3);  call(0x9d3c, 0x1692);                      /* call 0x9d3c */
            ii(0x86aa, 1);  pop(bx);                                   /* pop bx */
            ii(0x86ab, 3);  mov(memw[ds, 0x98], ax);                   /* mov [0x98], ax */
            ii(0x86ae, 4);  mov(memw[ds, 0x9a], dx);                   /* mov [0x9a], dx */
            ii(0x86b2, 4);  push(memw[ds, 0xece]);                     /* push word [0xece] */
            ii(0x86b6, 3);  call(0x9d3c, 0x1683);                      /* call 0x9d3c */
            ii(0x86b9, 1);  pop(bx);                                   /* pop bx */
            ii(0x86ba, 3);  mov(memw[ds, 0x9c], ax);                   /* mov [0x9c], ax */
            ii(0x86bd, 4);  mov(memw[ds, 0x9e], dx);                   /* mov [0x9e], dx */
            ii(0x86c1, 3);  call(0xa274, 0x1bb0);                      /* call 0xa274 */
            ii(0x86c4, 2);  or(ax, ax);                                /* or ax, ax */
            ii(0x86c6, 2);  if(jnz(0x86cb, 3)) goto l_0x86cb;          /* jnz 0x86cb */
            ii(0x86c8, 3);  jmp(0x8786, 0xbb); goto l_0x8786;          /* jmp 0x8786 */
        l_0x86cb:
            ii(0x86cb, 3);  mov(ax, memw[ds, 0xecc]);                  /* mov ax, [0xecc] */
            ii(0x86ce, 3);  mov(memw[ds, 0xa8], ax);                   /* mov [0xa8], ax */
            ii(0x86d1, 1);  push(ax);                                  /* push ax */
            ii(0x86d2, 3);  call(0x9d3c, 0x1667);                      /* call 0x9d3c */
            ii(0x86d5, 1);  pop(bx);                                   /* pop bx */
            ii(0x86d6, 4);  add(ax, memw[ds, 0x98]);                   /* add ax, [0x98] */
            ii(0x86da, 4);  adc(dx, memw[ds, 0x9a]);                   /* adc dx, [0x9a] */
        l_0x86de:
            ii(0x86de, 3);  mov(memw[ds, 0x9c], ax);                   /* mov [0x9c], ax */
            ii(0x86e1, 4);  mov(memw[ds, 0x9e], dx);                   /* mov [0x9e], dx */
            ii(0x86e5, 1);  leave();                                   /* leave */
            ii(0x86e6, 1);  ret(); return;                             /* ret */
        l_0x86e7:
            ii(0x86e7, 4);  mov(memb[ss, bp - 13], 0x88);              /* mov byte [bp-0xd], 0x88 */
            ii(0x86eb, 3);  lea(ax, memw[ss, bp - 14]);                /* lea ax, [bp-0xe] */
            ii(0x86ee, 1);  push(ax);                                  /* push ax */
            ii(0x86ef, 1);  push(ax);                                  /* push ax */
            ii(0x86f0, 2);  push(0x15);                                /* push 0x15 */
            ii(0x86f2, 3);  call(0x9674, 0xf7f);                       /* call 0x9674 */
            ii(0x86f5, 3);  add(sp, 6);                                /* add sp, 0x6 */
            ii(0x86f8, 3);  mov(ax, memw[ss, bp - 14]);                /* mov ax, [bp-0xe] */
            ii(0x86fb, 3);  mov(memw[ds, 0xa8], ax);                   /* mov [0xa8], ax */
            ii(0x86fe, 3);  call(0xa274, 0x1b73);                      /* call 0xa274 */
            ii(0x8701, 2);  or(ax, ax);                                /* or ax, ax */
            ii(0x8703, 2);  if(jnz(0x86cb, -0x3a)) goto l_0x86cb;      /* jnz 0x86cb */
            ii(0x8705, 6);  cmp(memw[ds, 0xa8], 0xfc00);               /* cmp word [0xa8], 0xfc00 */
            ii(0x870b, 2);  if(jb(0x8711, 4)) goto l_0x8711;           /* jb 0x8711 */
            ii(0x870d, 4);  dec(memw[ds, 0xa8]);                       /* dec word [0xa8] */
        l_0x8711:
            ii(0x8711, 4);  push(memw[ds, 0xa8]);                      /* push word [0xa8] */
            ii(0x8715, 3);  call(0x9d3c, 0x1624);                      /* call 0x9d3c */
            ii(0x8718, 1);  pop(bx);                                   /* pop bx */
            ii(0x8719, 3);  add(ax, 0);                                /* add ax, 0x0 */
            ii(0x871c, 3);  adc(dx, 1);                                /* adc dx, 0x1 */
            ii(0x871f, 3);  mov(memw[ss, bp - 18], ax);                /* mov [bp-0x12], ax */
            ii(0x8722, 3);  mov(memw[ss, bp - 16], dx);                /* mov [bp-0x10], dx */
            ii(0x8725, 3);  call(0x85e2, -0x146);                      /* call 0x85e2 */
            ii(0x8728, 4);  cmp(memw[ss, bp - 14], 0);                 /* cmp word [bp-0xe], 0x0 */
            ii(0x872c, 2);  if(jz(0x8786, 0x58)) goto l_0x8786;        /* jz 0x8786 */
            ii(0x872e, 6);  mov(memw[ds, 0xaa4], 0x1b41);              /* mov word [0xaa4], 0x1b41 */
            ii(0x8734, 6);  mov(memw[ds, 0xaa6], 0x1bb5);              /* mov word [0xaa6], 0x1bb5 */
            ii(0x873a, 6);  mov(memw[ds, 0x98], 0);                    /* mov word [0x98], 0x0 */
            ii(0x8740, 6);  mov(memw[ds, 0x9a], 1);                    /* mov word [0x9a], 0x1 */
            ii(0x8746, 3);  mov(ax, memw[ss, bp - 18]);                /* mov ax, [bp-0x12] */
            ii(0x8749, 3);  mov(dx, memw[ss, bp - 16]);                /* mov dx, [bp-0x10] */
            ii(0x874c, 3);  mov(memw[ds, 0x9c], ax);                   /* mov [0x9c], ax */
            ii(0x874f, 4);  mov(memw[ds, 0x9e], dx);                   /* mov [0x9e], dx */
            ii(0x8753, 3);  call(0x851a, -0x23c);                      /* call 0x851a */
            ii(0x8756, 2);  or(ax, ax);                                /* or ax, ax */
            ii(0x8758, 2);  if(jnz(0x8786, 0x2c)) goto l_0x8786;       /* jnz 0x8786 */
            ii(0x875a, 5);  mov(memw[ss, bp - 14], 0x3519);            /* mov word [bp-0xe], 0x3519 */
            ii(0x875f, 3);  lea(ax, memw[ss, bp - 26]);                /* lea ax, [bp-0x1a] */
            ii(0x8762, 1);  push(ax);                                  /* push ax */
            ii(0x8763, 3);  lea(cx, memw[ss, bp - 14]);                /* lea cx, [bp-0xe] */
            ii(0x8766, 1);  push(cx);                                  /* push cx */
            ii(0x8767, 1);  push(cx);                                  /* push cx */
            ii(0x8768, 3);  call(0x5d08, -0x2a63);                     /* call 0x5d08 */
            ii(0x876b, 3);  add(sp, 6);                                /* add sp, 0x6 */
            ii(0x876e, 2);  push(0);                                   /* push 0x0 */
            ii(0x8770, 3);  push(memw[ss, bp - 26]);                   /* push word [bp-0x1a] */
            ii(0x8773, 3);  call(0x8426, -0x350);                      /* call 0x8426 */
            ii(0x8776, 1);  pop(bx);                                   /* pop bx */
            ii(0x8777, 1);  pop(bx);                                   /* pop bx */
            ii(0x8778, 2);  or(ax, ax);                                /* or ax, ax */
            ii(0x877a, 2);  if(jnz(0x8783, 7)) goto l_0x8783;          /* jnz 0x8783 */
            ii(0x877c, 3);  push(0x4e36);                              /* push 0x4e36 */
            ii(0x877f, 3);  call(0x8573, -0x20f);                      /* call 0x8573 */
            ii(0x8782, 1);  pop(bx);                                   /* pop bx */
        l_0x8783:
            ii(0x8783, 3);  call(0x84a4, -0x2e2);                      /* call 0x84a4 */
        l_0x8786:
            ii(0x8786, 5);  cmp(memw[ds, 0xecc], 0);                   /* cmp word [0xecc], 0x0 */
            ii(0x878b, 2);  if(jnz(0x8797, 0xa)) goto l_0x8797;        /* jnz 0x8797 */
            ii(0x878d, 2);  sub(ax, ax);                               /* sub ax, ax */
            ii(0x878f, 3);  mov(memw[ds, 0x9e], ax);                   /* mov [0x9e], ax */
            ii(0x8792, 3);  mov(memw[ds, 0x9c], ax);                   /* mov [0x9c], ax */
            ii(0x8795, 1);  leave();                                   /* leave */
            ii(0x8796, 1);  ret(); return;                             /* ret */
        l_0x8797:
            ii(0x8797, 3);  mov(ax, memw[ds, 0x9c]);                   /* mov ax, [0x9c] */
            ii(0x879a, 4);  mov(dx, memw[ds, 0x9e]);                   /* mov dx, [0x9e] */
            ii(0x879e, 2);  mov(cl, 6);                                /* mov cl, 0x6 */
            ii(0x87a0, 3);  call(0x97d2, 0x102f);                      /* call 0x97d2 */
            ii(0x87a3, 4);  cmp(ax, memw[ds, 0xece]);                  /* cmp ax, [0xece] */
            ii(0x87a7, 2);  if(jbe(0x87b8, 0xf)) goto l_0x87b8;        /* jbe 0x87b8 */
            ii(0x87a9, 4);  push(memw[ds, 0xece]);                     /* push word [0xece] */
            ii(0x87ad, 3);  call(0x9d3c, 0x158c);                      /* call 0x9d3c */
            ii(0x87b0, 1);  pop(bx);                                   /* pop bx */
            ii(0x87b1, 3);  mov(memw[ds, 0x9c], ax);                   /* mov [0x9c], ax */
            ii(0x87b4, 4);  mov(memw[ds, 0x9e], dx);                   /* mov [0x9e], dx */
        l_0x87b8:
            ii(0x87b8, 4);  push(memw[ds, 0xecc]);                     /* push word [0xecc] */
            ii(0x87bc, 3);  call(0x9d3c, 0x157d);                      /* call 0x9d3c */
            ii(0x87bf, 1);  pop(bx);                                   /* pop bx */
            ii(0x87c0, 4);  add(ax, memw[ds, 0x98]);                   /* add ax, [0x98] */
            ii(0x87c4, 4);  adc(dx, memw[ds, 0x9a]);                   /* adc dx, [0x9a] */
            ii(0x87c8, 3);  mov(memw[ss, bp - 18], ax);                /* mov [bp-0x12], ax */
            ii(0x87cb, 3);  mov(memw[ss, bp - 16], dx);                /* mov [bp-0x10], dx */
            ii(0x87ce, 3);  mov(ax, memw[ds, 0x98]);                   /* mov ax, [0x98] */
            ii(0x87d1, 4);  mov(dx, memw[ds, 0x9a]);                   /* mov dx, [0x9a] */
            ii(0x87d5, 2);  mov(cl, 6);                                /* mov cl, 0x6 */
            ii(0x87d7, 3);  call(0x97d2, 0xff8);                       /* call 0x97d2 */
            ii(0x87da, 4);  cmp(ax, memw[ds, 0xeca]);                  /* cmp ax, [0xeca] */
            ii(0x87de, 2);  if(jae(0x8821, 0x41)) goto l_0x8821;       /* jae 0x8821 */
            ii(0x87e0, 4);  push(memw[ds, 0xeca]);                     /* push word [0xeca] */
            ii(0x87e4, 3);  call(0x9d3c, 0x1555);                      /* call 0x9d3c */
            ii(0x87e7, 1);  pop(bx);                                   /* pop bx */
            ii(0x87e8, 3);  mov(memw[ds, 0x98], ax);                   /* mov [0x98], ax */
            ii(0x87eb, 4);  mov(memw[ds, 0x9a], dx);                   /* mov [0x9a], dx */
            ii(0x87ef, 4);  push(memw[ds, 0xecc]);                     /* push word [0xecc] */
            ii(0x87f3, 3);  call(0x9d3c, 0x1546);                      /* call 0x9d3c */
            ii(0x87f6, 1);  pop(bx);                                   /* pop bx */
            ii(0x87f7, 4);  add(ax, memw[ds, 0x98]);                   /* add ax, [0x98] */
            ii(0x87fb, 4);  adc(dx, memw[ds, 0x9a]);                   /* adc dx, [0x9a] */
            ii(0x87ff, 3);  mov(memw[ss, bp - 18], ax);                /* mov [bp-0x12], ax */
            ii(0x8802, 3);  mov(memw[ss, bp - 16], dx);                /* mov [bp-0x10], dx */
            ii(0x8805, 3);  mov(ax, memw[ds, 0x9c]);                   /* mov ax, [0x9c] */
            ii(0x8808, 4);  mov(dx, memw[ds, 0x9e]);                   /* mov dx, [0x9e] */
            ii(0x880c, 3);  cmp(memw[ss, bp - 16], dx);                /* cmp [bp-0x10], dx */
            ii(0x880f, 2);  if(ja(0x8850, 0x3f)) goto l_0x8850;        /* ja 0x8850 */
            ii(0x8811, 2);  if(jb(0x8818, 5)) goto l_0x8818;           /* jb 0x8818 */
            ii(0x8813, 3);  cmp(memw[ss, bp - 18], ax);                /* cmp [bp-0x12], ax */
            ii(0x8816, 2);  if(jae(0x8850, 0x38)) goto l_0x8850;       /* jae 0x8850 */
        l_0x8818:
            ii(0x8818, 3);  mov(ax, memw[ss, bp - 18]);                /* mov ax, [bp-0x12] */
            ii(0x881b, 3);  mov(dx, memw[ss, bp - 16]);                /* mov dx, [bp-0x10] */
            ii(0x881e, 3);  jmp(0x86de, -0x143); goto l_0x86de;        /* jmp 0x86de */
        l_0x8821:
            ii(0x8821, 3);  mov(ax, memw[ds, 0x9c]);                   /* mov ax, [0x9c] */
            ii(0x8824, 4);  mov(dx, memw[ds, 0x9e]);                   /* mov dx, [0x9e] */
            ii(0x8828, 3);  cmp(memw[ss, bp - 16], dx);                /* cmp [bp-0x10], dx */
            ii(0x882b, 2);  if(ja(0x8850, 0x23)) goto l_0x8850;        /* ja 0x8850 */
            ii(0x882d, 2);  if(jb(0x8834, 5)) goto l_0x8834;           /* jb 0x8834 */
            ii(0x882f, 3);  cmp(memw[ss, bp - 18], ax);                /* cmp [bp-0x12], ax */
            ii(0x8832, 2);  if(jae(0x8850, 0x1c)) goto l_0x8850;       /* jae 0x8850 */
        l_0x8834:
            ii(0x8834, 4);  push(memw[ds, 0xecc]);                     /* push word [0xecc] */
            ii(0x8838, 3);  call(0x9d3c, 0x1501);                      /* call 0x9d3c */
            ii(0x883b, 1);  pop(bx);                                   /* pop bx */
            ii(0x883c, 4);  mov(cx, memw[ds, 0x9c]);                   /* mov cx, [0x9c] */
            ii(0x8840, 4);  mov(bx, memw[ds, 0x9e]);                   /* mov bx, [0x9e] */
            ii(0x8844, 2);  sub(cx, ax);                               /* sub cx, ax */
            ii(0x8846, 2);  sbb(bx, dx);                               /* sbb bx, dx */
            ii(0x8848, 4);  mov(memw[ds, 0x98], cx);                   /* mov [0x98], cx */
            ii(0x884c, 4);  mov(memw[ds, 0x9a], bx);                   /* mov [0x9a], bx */
        l_0x8850:
            ii(0x8850, 1);  leave();                                   /* leave */
            ii(0x8851, 1);  ret();                                     /* ret */
        }
    }
}
