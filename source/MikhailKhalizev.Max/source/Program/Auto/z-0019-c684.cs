using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x19_c684-e9380c18")]
        public void Method_0019_c684()
        {
            ii(0x19_c684, 4);  enter(0x3a, 0);                         /* enter 0x3a, 0x0 */
            ii(0x19_c688, 3);  lea(ax, memw[ss, bp - 32]);             /* lea ax, [bp-0x20] */
            ii(0x19_c68b, 3);  mov(memw[ss, bp - 4], ax);              /* mov [bp-0x4], ax */
            ii(0x19_c68e, 3);  mov(memw[ss, bp - 2], ss);              /* mov [bp-0x2], ss */
            ii(0x19_c691, 3);  les(bx, memw[ss, bp + 4]);              /* les bx, [bp+0x4] */
            ii(0x19_c694, 5);  mov(memw[es, bx], 0xffff);              /* mov word [es:bx], 0xffff */
            ii(0x19_c699, 6);  mov(memw[es, bx + 2], 0xffff);          /* mov word [es:bx+0x2], 0xffff */
            ii(0x19_c69f, 3);  mov(cx, memw[ss, bp + 8]);              /* mov cx, [bp+0x8] */
            ii(0x19_c6a2, 3);  mov(dx, memw[ss, bp + 10]);             /* mov dx, [bp+0xa] */
            ii(0x19_c6a5, 3);  add(cx, 0xf);                           /* add cx, 0xf */
            ii(0x19_c6a8, 3);  adc(dx, 0);                             /* adc dx, 0x0 */
            ii(0x19_c6ab, 3);  and(cl, 0xf0);                          /* and cl, 0xf0 */
            ii(0x19_c6ae, 3);  mov(memw[ss, bp + 8], cx);              /* mov [bp+0x8], cx */
            ii(0x19_c6b1, 3);  mov(memw[ss, bp + 10], dx);             /* mov [bp+0xa], dx */
            ii(0x19_c6b4, 4);  cmp(memw[ss, bp + 16], 0);              /* cmp word [bp+0x10], 0x0 */
            ii(0x19_c6b8, 2);  if(jz(0x19_c6c4, 0xa)) goto l_0x19_c6c4;/* jz 0xc6c4 */
            ii(0x19_c6ba, 4);  mov(cx, memw[ds, 0x3292]);              /* mov cx, [0x3292] */
            ii(0x19_c6be, 4);  or(cx, memw[ds, 0x3290]);               /* or cx, [0x3290] */
            ii(0x19_c6c2, 2);  if(jnz(0x19_c6c7, 3)) goto l_0x19_c6c7; /* jnz 0xc6c7 */
        l_0x19_c6c4:
            ii(0x19_c6c4, 3);  jmp(0x19_c781, 0xba); goto l_0x19_c781; /* jmp 0xc781 */
        l_0x19_c6c7:
            ii(0x19_c6c7, 3);  mov(cx, memw[ss, bp + 8]);              /* mov cx, [bp+0x8] */
            ii(0x19_c6ca, 3);  mov(memw[ss, bp - 32], cx);             /* mov [bp-0x20], cx */
            ii(0x19_c6cd, 3);  mov(memw[ss, bp - 30], dx);             /* mov [bp-0x1e], dx */
            ii(0x19_c6d0, 2);  mov(ax, ss);                            /* mov ax, ss */
            ii(0x19_c6d2, 3);  mov(memw[ss, bp - 50], ax);             /* mov [bp-0x32], ax */
            ii(0x19_c6d5, 3);  mov(memw[ss, bp - 52], ax);             /* mov [bp-0x34], ax */
            ii(0x19_c6d8, 3);  mov(ax, memw[ss, bp + 12]);             /* mov ax, [bp+0xc] */
            ii(0x19_c6db, 3);  mov(memw[ss, bp - 16], ax);             /* mov [bp-0x10], ax */
            ii(0x19_c6de, 5);  mov(memw[ss, bp - 14], 0);              /* mov word [bp-0xe], 0x0 */
            ii(0x19_c6e3, 3);  mov(ax, memw[ss, bp + 14]);             /* mov ax, [bp+0xe] */
            ii(0x19_c6e6, 3);  mov(memw[ss, bp - 12], ax);             /* mov [bp-0xc], ax */
            ii(0x19_c6e9, 3);  mov(ax, memw[ss, bp - 4]);              /* mov ax, [bp-0x4] */
            ii(0x19_c6ec, 3);  mov(memw[ss, bp - 48], ax);             /* mov [bp-0x30], ax */
            ii(0x19_c6ef, 4);  cmp(memw[ss, bp + 16], 4);              /* cmp word [bp+0x10], 0x4 */
            ii(0x19_c6f3, 2);  if(jnz(0x19_c742, 0x4d)) goto l_0x19_c742;/* jnz 0xc742 */
            ii(0x19_c6f5, 3);  mov(ax, memw[ds, 0x3296]);              /* mov ax, [0x3296] */
            ii(0x19_c6f8, 4);  or(ax, memw[ds, 0x3294]);               /* or ax, [0x3294] */
            ii(0x19_c6fc, 2);  if(jz(0x19_c742, 0x44)) goto l_0x19_c742;/* jz 0xc742 */
            ii(0x19_c6fe, 3);  lea(ax, memw[ss, bp - 32]);             /* lea ax, [bp-0x20] */
            ii(0x19_c701, 1);  push(ss);                               /* push ss */
            ii(0x19_c702, 1);  push(ax);                               /* push ax */
            ii(0x19_c703, 4);  call_far_ind(memw[ds, 0x3294]);         /* call far word [0x3294] */
            ii(0x19_c707, 1);  pop(bx);                                /* pop bx */
            ii(0x19_c708, 1);  pop(bx);                                /* pop bx */
            ii(0x19_c709, 3);  mov(memw[ss, bp - 58], ax);             /* mov [bp-0x3a], ax */
            ii(0x19_c70c, 1);  push(ax);                               /* push ax */
            ii(0x19_c70d, 3);  push(memw[ss, bp - 30]);                /* push word [bp-0x1e] */
            ii(0x19_c710, 3);  push(memw[ss, bp - 32]);                /* push word [bp-0x20] */
            ii(0x19_c713, 3);  push(memw[ss, bp - 18]);                /* push word [bp-0x12] */
            ii(0x19_c716, 3);  push(memw[ss, bp - 20]);                /* push word [bp-0x14] */
            ii(0x19_c719, 3);  push(memw[ss, bp + 14]);                /* push word [bp+0xe] */
            ii(0x19_c71c, 3);  push(memw[ss, bp + 12]);                /* push word [bp+0xc] */
            ii(0x19_c71f, 1);  push(ds);                               /* push ds */
            ii(0x19_c720, 3);  push(0x2775);                           /* push 0x2775 */
            ii(0x19_c723, 3);  call(0x1a_1066, 0x4940);                /* call 0x1066 */
            ii(0x19_c726, 3);  add(sp, 0x12);                          /* add sp, 0x12 */
        l_0x19_c729:
            ii(0x19_c729, 3);  mov(ax, memw[ss, bp - 24]);             /* mov ax, [bp-0x18] */
            ii(0x19_c72c, 3);  mov(dx, memw[ss, bp - 22]);             /* mov dx, [bp-0x16] */
            ii(0x19_c72f, 3);  les(bx, memw[ss, bp + 4]);              /* les bx, [bp+0x4] */
            ii(0x19_c732, 3);  mov(memw[es, bx], ax);                  /* mov [es:bx], ax */
            ii(0x19_c735, 4);  mov(memw[es, bx + 2], dx);              /* mov [es:bx+0x2], dx */
        l_0x19_c739:
            ii(0x19_c739, 3);  mov(ax, memw[ss, bp - 20]);             /* mov ax, [bp-0x14] */
            ii(0x19_c73c, 3);  mov(dx, memw[ss, bp - 18]);             /* mov dx, [bp-0x12] */
            ii(0x19_c73f, 3);  jmp(0x19_c7e7, 0xa5); goto l_0x19_c7e7; /* jmp 0xc7e7 */
        l_0x19_c742:
            ii(0x19_c742, 3);  lea(ax, memw[ss, bp - 52]);             /* lea ax, [bp-0x34] */
            ii(0x19_c745, 1);  push(ss);                               /* push ss */
            ii(0x19_c746, 1);  push(ax);                               /* push ax */
            ii(0x19_c747, 2);  push(0);                                /* push 0x0 */
            ii(0x19_c749, 3);  push(0xd00);                            /* push 0xd00 */
            ii(0x19_c74c, 5);  call_far_abs(0x80, 0x4d1c);             /* call word 0x80:0x4d1c */
            ii(0x19_c751, 3);  add(sp, 8);                             /* add sp, 0x8 */
            ii(0x19_c754, 2);  or(ax, ax);                             /* or ax, ax */
            ii(0x19_c756, 2);  if(jz(0x19_c776, 0x1e)) goto l_0x19_c776;/* jz 0xc776 */
            ii(0x19_c758, 3);  push(memw[ss, bp - 30]);                /* push word [bp-0x1e] */
            ii(0x19_c75b, 3);  push(memw[ss, bp - 32]);                /* push word [bp-0x20] */
            ii(0x19_c75e, 3);  push(memw[ss, bp - 18]);                /* push word [bp-0x12] */
            ii(0x19_c761, 3);  push(memw[ss, bp - 20]);                /* push word [bp-0x14] */
            ii(0x19_c764, 3);  push(memw[ss, bp + 14]);                /* push word [bp+0xe] */
            ii(0x19_c767, 3);  push(memw[ss, bp + 12]);                /* push word [bp+0xc] */
            ii(0x19_c76a, 1);  push(ds);                               /* push ds */
            ii(0x19_c76b, 3);  push(0x27b1);                           /* push 0x27b1 */
            ii(0x19_c76e, 3);  call(0x1a_1066, 0x48f5);                /* call 0x1066 */
            ii(0x19_c771, 3);  add(sp, 0x10);                          /* add sp, 0x10 */
            ii(0x19_c774, 2);  jmp(0x19_c729, -0x4d); goto l_0x19_c729;/* jmp 0xc729 */
        l_0x19_c776:
            ii(0x19_c776, 4);  cmp(memw[ss, bp + 16], 1);              /* cmp word [bp+0x10], 0x1 */
            ii(0x19_c77a, 2);  if(jnz(0x19_c781, 5)) goto l_0x19_c781; /* jnz 0xc781 */
        l_0x19_c77c:
            ii(0x19_c77c, 2);  sub(ax, ax);                            /* sub ax, ax */
            ii(0x19_c77e, 1);  cwd();                                  /* cwd */
            ii(0x19_c77f, 2);  jmp(0x19_c7e7, 0x66); goto l_0x19_c7e7; /* jmp 0xc7e7 */
        l_0x19_c781:
            ii(0x19_c781, 3);  mov(ax, memw[ss, bp + 10]);             /* mov ax, [bp+0xa] */
            ii(0x19_c784, 3);  mov(memw[ss, bp - 40], ax);             /* mov [bp-0x28], ax */
            ii(0x19_c787, 3);  mov(cx, memw[ss, bp + 8]);              /* mov cx, [bp+0x8] */
            ii(0x19_c78a, 3);  mov(memw[ss, bp - 36], cx);             /* mov [bp-0x24], cx */
            ii(0x19_c78d, 2);  sub(cx, cx);                            /* sub cx, cx */
            ii(0x19_c78f, 3);  mov(memw[ss, bp - 50], cx);             /* mov [bp-0x32], cx */
            ii(0x19_c792, 3);  mov(memw[ss, bp - 52], cx);             /* mov [bp-0x34], cx */
            ii(0x19_c795, 3);  lea(cx, memw[ss, bp - 52]);             /* lea cx, [bp-0x34] */
            ii(0x19_c798, 1);  push(ss);                               /* push ss */
            ii(0x19_c799, 1);  push(cx);                               /* push cx */
            ii(0x19_c79a, 1);  push(ax);                               /* push ax */
            ii(0x19_c79b, 3);  mov(ax, 0x501);                         /* mov ax, 0x501 */
            ii(0x19_c79e, 3);  mov(memw[ss, bp - 34], ax);             /* mov [bp-0x22], ax */
            ii(0x19_c7a1, 1);  push(ax);                               /* push ax */
            ii(0x19_c7a2, 5);  call_far_abs(0x80, 0x4d1c);             /* call word 0x80:0x4d1c */
            ii(0x19_c7a7, 3);  add(sp, 8);                             /* add sp, 0x8 */
            ii(0x19_c7aa, 2);  or(ax, ax);                             /* or ax, ax */
            ii(0x19_c7ac, 2);  if(jz(0x19_c77c, -0x32)) goto l_0x19_c77c;/* jz 0xc77c */
            ii(0x19_c7ae, 3);  mov(ax, memw[ss, bp - 40]);             /* mov ax, [bp-0x28] */
            ii(0x19_c7b1, 3);  mov(cx, memw[ss, bp - 36]);             /* mov cx, [bp-0x24] */
            ii(0x19_c7b4, 3);  mov(memw[ss, bp - 20], cx);             /* mov [bp-0x14], cx */
            ii(0x19_c7b7, 3);  mov(memw[ss, bp - 18], ax);             /* mov [bp-0x12], ax */
            ii(0x19_c7ba, 3);  mov(ax, memw[ss, bp - 46]);             /* mov ax, [bp-0x2e] */
            ii(0x19_c7bd, 3);  mov(cx, memw[ss, bp - 48]);             /* mov cx, [bp-0x30] */
            ii(0x19_c7c0, 3);  les(bx, memw[ss, bp + 4]);              /* les bx, [bp+0x4] */
            ii(0x19_c7c3, 3);  mov(memw[es, bx], cx);                  /* mov [es:bx], cx */
            ii(0x19_c7c6, 4);  mov(memw[es, bx + 2], ax);              /* mov [es:bx+0x2], ax */
            ii(0x19_c7ca, 1);  push(ax);                               /* push ax */
            ii(0x19_c7cb, 3);  push(memw[es, bx]);                     /* push word [es:bx] */
            ii(0x19_c7ce, 3);  push(memw[ss, bp + 10]);                /* push word [bp+0xa] */
            ii(0x19_c7d1, 3);  push(memw[ss, bp + 8]);                 /* push word [bp+0x8] */
            ii(0x19_c7d4, 3);  push(memw[ss, bp - 18]);                /* push word [bp-0x12] */
            ii(0x19_c7d7, 3);  push(memw[ss, bp - 20]);                /* push word [bp-0x14] */
            ii(0x19_c7da, 1);  push(ds);                               /* push ds */
            ii(0x19_c7db, 3);  push(0x27dd);                           /* push 0x27dd */
            ii(0x19_c7de, 3);  call(0x1a_1066, 0x4885);                /* call 0x1066 */
            ii(0x19_c7e1, 3);  add(sp, 0x10);                          /* add sp, 0x10 */
            ii(0x19_c7e4, 3);  jmp(0x19_c739, -0xae); goto l_0x19_c739;/* jmp 0xc739 */
        l_0x19_c7e7:
            ii(0x19_c7e7, 1);  leave();                                /* leave */
            ii(0x19_c7e8, 3);  ret(0xe);                               /* ret 0xe */
        }
    }
}
