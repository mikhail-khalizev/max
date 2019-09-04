using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x18_c29c-6c32e52c")]
        public void Method_0018_c29c()
        {
            ii(0x18_c29c, 4);  enter(0x12, 0);                         /* enter 0x12, 0x0 */
            ii(0x18_c2a0, 3);  mov(ax, memw[ss, bp + 8]);              /* mov ax, [bp+0x8] */
            ii(0x18_c2a3, 3);  mov(dx, memw[ss, bp + 10]);             /* mov dx, [bp+0xa] */
            ii(0x18_c2a6, 3);  add(ax, memw[ss, bp + 4]);              /* add ax, [bp+0x4] */
            ii(0x18_c2a9, 3);  adc(dx, memw[ss, bp + 6]);              /* adc dx, [bp+0x6] */
            ii(0x18_c2ac, 3);  mov(memw[ss, bp - 12], ax);             /* mov [bp-0xc], ax */
            ii(0x18_c2af, 3);  mov(memw[ss, bp - 10], dx);             /* mov [bp-0xa], dx */
            ii(0x18_c2b2, 3);  mov(ax, memw[ss, bp + 8]);              /* mov ax, [bp+0x8] */
            ii(0x18_c2b5, 3);  mov(dx, memw[ss, bp + 10]);             /* mov dx, [bp+0xa] */
            ii(0x18_c2b8, 3);  sub(memw[ss, bp + 12], ax);             /* sub [bp+0xc], ax */
            ii(0x18_c2bb, 3);  sbb(memw[ss, bp + 14], dx);             /* sbb [bp+0xe], dx */
        l_0x18_c2be:
            ii(0x18_c2be, 1);  cli();                                  /* cli */
            ii(0x18_c2bf, 3);  mov(ax, memw[ds, 0x98]);                /* mov ax, [0x98] */
            ii(0x18_c2c2, 4);  mov(dx, memw[ds, 0x9a]);                /* mov dx, [0x9a] */
        l_0x18_c2c6:
            ii(0x18_c2c6, 3);  mov(memw[ss, bp - 4], ax);              /* mov [bp-0x4], ax */
            ii(0x18_c2c9, 3);  mov(memw[ss, bp - 2], dx);              /* mov [bp-0x2], dx */
            ii(0x18_c2cc, 2);  push(0);                                /* push 0x0 */
            ii(0x18_c2ce, 1);  push(dx);                               /* push dx */
            ii(0x18_c2cf, 1);  push(ax);                               /* push ax */
            ii(0x18_c2d0, 3);  call(0x18_db51, 0x187e);                /* call 0xdb51 */
            ii(0x18_c2d3, 3);  add(sp, 6);                             /* add sp, 0x6 */
            ii(0x18_c2d6, 3);  mov(memw[ss, bp - 8], ax);              /* mov [bp-0x8], ax */
            ii(0x18_c2d9, 3);  mov(memw[ss, bp - 6], dx);              /* mov [bp-0x6], dx */
            ii(0x18_c2dc, 2);  or(dx, ax);                             /* or dx, ax */
            ii(0x18_c2de, 2);  if(jnz(0x18_c2e3, 3)) goto l_0x18_c2e3; /* jnz 0xc2e3 */
            ii(0x18_c2e0, 3);  jmp(0x18_c3bb, 0xd8); goto l_0x18_c3bb; /* jmp 0xc3bb */
        l_0x18_c2e3:
            ii(0x18_c2e3, 3);  mov(ax, memw[ss, bp - 12]);             /* mov ax, [bp-0xc] */
            ii(0x18_c2e6, 3);  mov(dx, memw[ss, bp - 10]);             /* mov dx, [bp-0xa] */
            ii(0x18_c2e9, 3);  cmp(memw[ss, bp - 8], ax);              /* cmp [bp-0x8], ax */
            ii(0x18_c2ec, 2);  if(jz(0x18_c2f1, 3)) goto l_0x18_c2f1;  /* jz 0xc2f1 */
            ii(0x18_c2ee, 3);  jmp(0x18_c3b2, 0xc1); goto l_0x18_c3b2; /* jmp 0xc3b2 */
        l_0x18_c2f1:
            ii(0x18_c2f1, 3);  cmp(memw[ss, bp - 6], dx);              /* cmp [bp-0x6], dx */
            ii(0x18_c2f4, 2);  if(jz(0x18_c2f9, 3)) goto l_0x18_c2f9;  /* jz 0xc2f9 */
            ii(0x18_c2f6, 3);  jmp(0x18_c3b2, 0xb9); goto l_0x18_c3b2; /* jmp 0xc3b2 */
        l_0x18_c2f9:
            ii(0x18_c2f9, 2);  push(4);                                /* push 0x4 */
            ii(0x18_c2fb, 3);  push(memw[ss, bp - 6]);                 /* push word [bp-0x6] */
            ii(0x18_c2fe, 3);  push(memw[ss, bp - 8]);                 /* push word [bp-0x8] */
            ii(0x18_c301, 3);  call(0x18_db51, 0x184d);                /* call 0xdb51 */
            ii(0x18_c304, 3);  add(sp, 6);                             /* add sp, 0x6 */
            ii(0x18_c307, 3);  mov(memw[ss, bp - 18], ax);             /* mov [bp-0x12], ax */
            ii(0x18_c30a, 3);  mov(memw[ss, bp - 16], dx);             /* mov [bp-0x10], dx */
            ii(0x18_c30d, 3);  cmp(dx, memw[ss, bp + 14]);             /* cmp dx, [bp+0xe] */
            ii(0x18_c310, 2);  if(ja(0x18_c31c, 0xa)) goto l_0x18_c31c;/* ja 0xc31c */
            ii(0x18_c312, 2);  if(jb(0x18_c319, 5)) goto l_0x18_c319;  /* jb 0xc319 */
            ii(0x18_c314, 3);  cmp(ax, memw[ss, bp + 12]);             /* cmp ax, [bp+0xc] */
            ii(0x18_c317, 2);  if(jae(0x18_c31c, 3)) goto l_0x18_c31c; /* jae 0xc31c */
        l_0x18_c319:
            ii(0x18_c319, 3);  jmp(0x18_c3bb, 0x9f); goto l_0x18_c3bb; /* jmp 0xc3bb */
        l_0x18_c31c:
            ii(0x18_c31c, 5);  cmp(memb[ds, 0x2e], 0xb);               /* cmp byte [0x2e], 0xb */
            ii(0x18_c321, 2);  if(jnz(0x18_c34c, 0x29)) goto l_0x18_c34c;/* jnz 0xc34c */
            ii(0x18_c323, 3);  mov(ax, memw[ss, bp - 8]);              /* mov ax, [bp-0x8] */
            ii(0x18_c326, 3);  mov(dx, memw[ss, bp - 6]);              /* mov dx, [bp-0x6] */
            ii(0x18_c329, 3);  add(ax, memw[ss, bp + 12]);             /* add ax, [bp+0xc] */
            ii(0x18_c32c, 3);  adc(dx, memw[ss, bp + 14]);             /* adc dx, [bp+0xe] */
            ii(0x18_c32f, 1);  push(dx);                               /* push dx */
            ii(0x18_c330, 1);  push(ax);                               /* push ax */
            ii(0x18_c331, 3);  push(memw[ss, bp - 6]);                 /* push word [bp-0x6] */
            ii(0x18_c334, 3);  push(memw[ss, bp - 8]);                 /* push word [bp-0x8] */
            ii(0x18_c337, 3);  call(0x18_f2d8, 0x2f9e);                /* call 0xf2d8 */
            ii(0x18_c33a, 3);  add(sp, 8);                             /* add sp, 0x8 */
            ii(0x18_c33d, 3);  mov(memw[ss, bp - 14], ax);             /* mov [bp-0xe], ax */
            ii(0x18_c340, 2);  or(ax, ax);                             /* or ax, ax */
            ii(0x18_c342, 2);  if(jl(0x18_c3bb, 0x77)) goto l_0x18_c3bb;/* jl 0xc3bb */
            ii(0x18_c344, 2);  or(ax, ax);                             /* or ax, ax */
            ii(0x18_c346, 2);  if(jle(0x18_c34c, 4)) goto l_0x18_c34c; /* jle 0xc34c */
            ii(0x18_c348, 1);  sti();                                  /* sti */
            ii(0x18_c349, 3);  jmp(0x18_c2be, -0x8e); goto l_0x18_c2be;/* jmp 0xc2be */
        l_0x18_c34c:
            ii(0x18_c34c, 2);  push(0);                                /* push 0x0 */
            ii(0x18_c34e, 3);  push(memw[ss, bp - 6]);                 /* push word [bp-0x6] */
            ii(0x18_c351, 3);  push(memw[ss, bp - 8]);                 /* push word [bp-0x8] */
            ii(0x18_c354, 3);  call(0x18_db51, 0x17fa);                /* call 0xdb51 */
            ii(0x18_c357, 3);  add(sp, 6);                             /* add sp, 0x6 */
            ii(0x18_c35a, 1);  push(dx);                               /* push dx */
            ii(0x18_c35b, 1);  push(ax);                               /* push ax */
            ii(0x18_c35c, 2);  push(0);                                /* push 0x0 */
            ii(0x18_c35e, 3);  push(memw[ss, bp - 2]);                 /* push word [bp-0x2] */
            ii(0x18_c361, 3);  push(memw[ss, bp - 4]);                 /* push word [bp-0x4] */
            ii(0x18_c364, 3);  call(0x18_db67, 0x1800);                /* call 0xdb67 */
            ii(0x18_c367, 3);  add(sp, 0xa);                           /* add sp, 0xa */
            ii(0x18_c36a, 3);  mov(ax, memw[ss, bp - 18]);             /* mov ax, [bp-0x12] */
            ii(0x18_c36d, 3);  mov(dx, memw[ss, bp - 16]);             /* mov dx, [bp-0x10] */
            ii(0x18_c370, 2);  neg(ax);                                /* neg ax */
            ii(0x18_c372, 3);  adc(dx, 0);                             /* adc dx, 0x0 */
            ii(0x18_c375, 2);  neg(dx);                                /* neg dx */
            ii(0x18_c377, 1);  push(dx);                               /* push dx */
            ii(0x18_c378, 1);  push(ax);                               /* push ax */
            ii(0x18_c379, 3);  call(0x18_bda2, -0x5da);                /* call 0xbda2 */
            ii(0x18_c37c, 1);  pop(bx);                                /* pop bx */
            ii(0x18_c37d, 1);  pop(bx);                                /* pop bx */
            ii(0x18_c37e, 3);  mov(ax, memw[ss, bp - 18]);             /* mov ax, [bp-0x12] */
            ii(0x18_c381, 3);  mov(dx, memw[ss, bp - 16]);             /* mov dx, [bp-0x10] */
            ii(0x18_c384, 3);  cmp(memw[ss, bp + 12], ax);             /* cmp [bp+0xc], ax */
            ii(0x18_c387, 2);  if(jnz(0x18_c38e, 5)) goto l_0x18_c38e; /* jnz 0xc38e */
            ii(0x18_c389, 3);  cmp(memw[ss, bp + 14], dx);             /* cmp [bp+0xe], dx */
            ii(0x18_c38c, 2);  if(jz(0x18_c3ac, 0x1e)) goto l_0x18_c3ac;/* jz 0xc3ac */
        l_0x18_c38e:
            ii(0x18_c38e, 3);  sub(ax, memw[ss, bp + 12]);             /* sub ax, [bp+0xc] */
            ii(0x18_c391, 3);  sbb(dx, memw[ss, bp + 14]);             /* sbb dx, [bp+0xe] */
            ii(0x18_c394, 1);  push(dx);                               /* push dx */
            ii(0x18_c395, 1);  push(ax);                               /* push ax */
            ii(0x18_c396, 3);  mov(ax, memw[ss, bp - 12]);             /* mov ax, [bp-0xc] */
            ii(0x18_c399, 3);  mov(dx, memw[ss, bp - 10]);             /* mov dx, [bp-0xa] */
            ii(0x18_c39c, 3);  add(ax, memw[ss, bp + 12]);             /* add ax, [bp+0xc] */
            ii(0x18_c39f, 3);  adc(dx, memw[ss, bp + 14]);             /* adc dx, [bp+0xe] */
            ii(0x18_c3a2, 1);  push(dx);                               /* push dx */
            ii(0x18_c3a3, 1);  push(ax);                               /* push ax */
            ii(0x18_c3a4, 3);  call(0x18_c010, -0x397);                /* call 0xc010 */
            ii(0x18_c3a7, 3);  add(sp, 8);                             /* add sp, 0x8 */
            ii(0x18_c3aa, 2);  jmp(0x18_c3ad, 1); goto l_0x18_c3ad;    /* jmp 0xc3ad */
        l_0x18_c3ac:
            ii(0x18_c3ac, 1);  sti();                                  /* sti */
        l_0x18_c3ad:
            ii(0x18_c3ad, 3);  mov(ax, 1);                             /* mov ax, 0x1 */
            ii(0x18_c3b0, 1);  leave();                                /* leave */
            ii(0x18_c3b1, 1);  ret(); return;                          /* ret */
        l_0x18_c3b2:
            ii(0x18_c3b2, 3);  mov(ax, memw[ss, bp - 8]);              /* mov ax, [bp-0x8] */
            ii(0x18_c3b5, 3);  mov(dx, memw[ss, bp - 6]);              /* mov dx, [bp-0x6] */
            ii(0x18_c3b8, 3);  jmp(0x18_c2c6, -0xf5); goto l_0x18_c2c6;/* jmp 0xc2c6 */
        l_0x18_c3bb:
            ii(0x18_c3bb, 1);  sti();                                  /* sti */
            ii(0x18_c3bc, 2);  sub(ax, ax);                            /* sub ax, ax */
            ii(0x18_c3be, 1);  leave();                                /* leave */
            ii(0x18_c3bf, 1);  ret();                                  /* ret */
        }
    }
}
