using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x8bd6-a219881")]
        public void Method_0000_8bd6()
        {
            ii(0x8bd6, 4);  enter(0x3e, 0);                            /* enter 0x3e, 0x0 */
            ii(0x8bda, 2);  push(0x30);                                /* push 0x30 */
            ii(0x8bdc, 3);  lea(ax, memw[ss, bp - 52]);                /* lea ax, [bp-0x34] */
            ii(0x8bdf, 1);  push(ax);                                  /* push ax */
            ii(0x8be0, 3);  push(memw[ss, bp + 6]);                    /* push word [bp+0x6] */
            ii(0x8be3, 3);  push(memw[ss, bp + 4]);                    /* push word [bp+0x4] */
            ii(0x8be6, 3);  call(0xa481, 0x1898);                      /* call 0xa481 */
            ii(0x8be9, 3);  add(sp, 8);                                /* add sp, 0x8 */
            ii(0x8bec, 4);  mov(memb[ss, bp - 29], 0);                 /* mov byte [bp-0x1d], 0x0 */
            ii(0x8bf0, 5);  cmp(memb[ds, 0xcee], 4);                   /* cmp byte [0xcee], 0x4 */
            ii(0x8bf5, 2);  if(jge(0x8c22, 0x2b)) goto l_0x8c22;       /* jge 0x8c22 */
            ii(0x8bf7, 3);  push(0xeee);                               /* push 0xeee */
            ii(0x8bfa, 3);  lea(ax, memw[ss, bp - 34]);                /* lea ax, [bp-0x22] */
            ii(0x8bfd, 1);  push(ax);                                  /* push ax */
            ii(0x8bfe, 3);  call(0x56fd, -0x3504);                     /* call 0x56fd */
            ii(0x8c01, 1);  pop(bx);                                   /* pop bx */
            ii(0x8c02, 1);  pop(bx);                                   /* pop bx */
            ii(0x8c03, 2);  or(ax, ax);                                /* or ax, ax */
            ii(0x8c05, 2);  if(jz(0x8c22, 0x1b)) goto l_0x8c22;        /* jz 0x8c22 */
            ii(0x8c07, 3);  mov(ax, memw[ss, bp - 8]);                 /* mov ax, [bp-0x8] */
            ii(0x8c0a, 3);  mov(dx, memw[ss, bp - 6]);                 /* mov dx, [bp-0x6] */
            ii(0x8c0d, 2);  and(al, 0xf0);                             /* and al, 0xf0 */
            ii(0x8c0f, 2);  sub(dh, dh);                               /* sub dh, dh */
            ii(0x8c11, 2);  mov(cl, 4);                                /* mov cl, 0x4 */
            ii(0x8c13, 3);  call(0x6550, -0x26c6);                     /* call 0x6550 */
            ii(0x8c16, 3);  mov(memw[ds, 0x98], ax);                   /* mov [0x98], ax */
            ii(0x8c19, 4);  mov(memw[ds, 0x9a], dx);                   /* mov [0x9a], dx */
            ii(0x8c1d, 3);  mov(ax, 1);                                /* mov ax, 0x1 */
            ii(0x8c20, 1);  leave();                                   /* leave */
            ii(0x8c21, 1);  ret(); return;                             /* ret */
        l_0x8c22:
            ii(0x8c22, 2);  push(0xa);                                 /* push 0xa */
            ii(0x8c24, 3);  lea(ax, memw[ss, bp - 62]);                /* lea ax, [bp-0x3e] */
            ii(0x8c27, 1);  push(ax);                                  /* push ax */
            ii(0x8c28, 3);  push(0xc8);                                /* push 0xc8 */
            ii(0x8c2b, 3);  push(memw[ss, bp + 4]);                    /* push word [bp+0x4] */
            ii(0x8c2e, 3);  call(0xa481, 0x1850);                      /* call 0xa481 */
            ii(0x8c31, 3);  add(sp, 8);                                /* add sp, 0x8 */
            ii(0x8c34, 5);  cmp(memw[ss, bp - 62], 0xff2e);            /* cmp word [bp-0x3e], 0xff2e */
            ii(0x8c39, 2);  if(jnz(0x8c50, 0x15)) goto l_0x8c50;       /* jnz 0x8c50 */
            ii(0x8c3b, 4);  cmp(memb[ss, bp - 57], 0x24);              /* cmp byte [bp-0x39], 0x24 */
            ii(0x8c3f, 2);  if(jnz(0x8c50, 0xf)) goto l_0x8c50;        /* jnz 0x8c50 */
            ii(0x8c41, 3);  push(memw[ss, bp - 56]);                   /* push word [bp-0x38] */
            ii(0x8c44, 3);  call(0xa4ec, 0x18a5);                      /* call 0xa4ec */
            ii(0x8c47, 1);  pop(bx);                                   /* pop bx */
            ii(0x8c48, 4);  add(memw[ds, 0x98], ax);                   /* add [0x98], ax */
            ii(0x8c4c, 4);  adc(memw[ds, 0x9a], dx);                   /* adc [0x9a], dx */
        l_0x8c50:
            ii(0x8c50, 2);  sub(ax, ax);                               /* sub ax, ax */
            ii(0x8c52, 1);  leave();                                   /* leave */
            ii(0x8c53, 1);  ret();                                     /* ret */
        }
    }
}
