using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0xb696-3c33d557")]
        public void Method_0000_b696()
        {
            ii(0xb696, 4);  enter(0x14, 0);                            /* enter 0x14, 0x0 */
            ii(0xb69a, 5);  cmp(memw[ds, 0xa12], 1);                   /* cmp word [0xa12], 0x1 */
            ii(0xb69f, 2);  if(jl(0xb6a4, 3)) goto l_0xb6a4;           /* jl 0xb6a4 */
            ii(0xb6a1, 3);  jmp(0xb740, 0x9c); goto l_0xb740;          /* jmp 0xb740 */
        l_0xb6a4:
            ii(0xb6a4, 2);  sub(ax, ax);                               /* sub ax, ax */
            ii(0xb6a6, 3);  mov(memw[ss, bp - 16], ax);                /* mov [bp-0x10], ax */
            ii(0xb6a9, 3);  mov(memw[ss, bp - 18], ax);                /* mov [bp-0x12], ax */
            ii(0xb6ac, 5);  test(memb[ds, 0x47], 0x80);                /* test byte [0x47], 0x80 */
            ii(0xb6b1, 2);  if(jz(0xb6da, 0x27)) goto l_0xb6da;        /* jz 0xb6da */
            ii(0xb6b3, 3);  mov(ax, memw[ds, 0xdf4]);                  /* mov ax, [0xdf4] */
            ii(0xb6b6, 3);  mov(memw[ds, 0xaa], ax);                   /* mov [0xaa], ax */
            ii(0xb6b9, 5);  mov(memw[ss, bp - 14], 0xbfde);            /* mov word [bp-0xe], 0xbfde */
            ii(0xb6be, 5);  mov(memw[ss, bp - 12], 2);                 /* mov word [bp-0xc], 0x2 */
            ii(0xb6c3, 2);  sub(ax, ax);                               /* sub ax, ax */
            ii(0xb6c5, 3);  mov(memw[ss, bp - 10], ax);                /* mov [bp-0xa], ax */
            ii(0xb6c8, 3);  mov(memw[ss, bp - 8], ax);                 /* mov [bp-0x8], ax */
            ii(0xb6cb, 3);  lea(ax, memw[ss, bp - 14]);                /* lea ax, [bp-0xe] */
            ii(0xb6ce, 1);  push(ax);                                  /* push ax */
            ii(0xb6cf, 1);  push(ax);                                  /* push ax */
            ii(0xb6d0, 2);  push(0x15);                                /* push 0x15 */
            ii(0xb6d2, 3);  call(0xbe34, 0x75f);                       /* call 0xbe34 */
            ii(0xb6d5, 3);  add(sp, 6);                                /* add sp, 0x6 */
            ii(0xb6d8, 1);  leave();                                   /* leave */
            ii(0xb6d9, 1);  ret(); return;                             /* ret */
        l_0xb6da:
            ii(0xb6da, 3);  mov(ax, memw[ss, bp - 16]);                /* mov ax, [bp-0x10] */
            ii(0xb6dd, 3);  or(ax, memw[ss, bp - 18]);                 /* or ax, [bp-0x12] */
            ii(0xb6e0, 2);  if(jnz(0xb728, 0x46)) goto l_0xb728;       /* jnz 0xb728 */
            ii(0xb6e2, 3);  call(0x7cd4, -0x3a11);                     /* call 0x7cd4 */
            ii(0xb6e5, 3);  mov(memw[ss, bp - 20], ax);                /* mov [bp-0x14], ax */
            ii(0xb6e8, 3);  call(0x773a, -0x3fb1);                     /* call 0x773a */
            ii(0xb6eb, 3);  mov(ax, memw[ss, bp - 20]);                /* mov ax, [bp-0x14] */
            ii(0xb6ee, 3);  shr(ax, 4);                                /* shr ax, 0x4 */
            ii(0xb6f1, 2);  push(0);                                   /* push 0x0 */
            ii(0xb6f3, 1);  push(ax);                                  /* push ax */
            ii(0xb6f4, 3);  call(0x7c18, -0x3adf);                     /* call 0x7c18 */
            ii(0xb6f7, 1);  pop(bx);                                   /* pop bx */
            ii(0xb6f8, 1);  pop(bx);                                   /* pop bx */
            ii(0xb6f9, 3);  mov(memw[ss, bp - 18], ax);                /* mov [bp-0x12], ax */
            ii(0xb6fc, 3);  mov(memw[ss, bp - 16], dx);                /* mov [bp-0x10], dx */
            ii(0xb6ff, 2);  or(dx, ax);                                /* or dx, ax */
            ii(0xb701, 2);  if(jz(0xb725, 0x22)) goto l_0xb725;        /* jz 0xb725 */
            ii(0xb703, 3);  push(0x92);                                /* push 0x92 */
            ii(0xb706, 2);  push(-1 /* 0xff */);                       /* push 0xffff */
            ii(0xb708, 3);  push(memw[ss, bp - 16]);                   /* push word [bp-0x10] */
            ii(0xb70b, 1);  push(ax);                                  /* push ax */
            ii(0xb70c, 2);  push(0x60);                                /* push 0x60 */
            ii(0xb70e, 3);  call(0x7c2c, -0x3ae5);                     /* call 0x7c2c */
            ii(0xb711, 3);  add(sp, 0xa);                              /* add sp, 0xa */
            ii(0xb714, 3);  push(memw[ss, bp - 20]);                   /* push word [bp-0x14] */
            ii(0xb717, 2);  push(0);                                   /* push 0x0 */
            ii(0xb719, 2);  push(0x60);                                /* push 0x60 */
            ii(0xb71b, 2);  push(0);                                   /* push 0x0 */
            ii(0xb71d, 2);  push(0x70);                                /* push 0x70 */
            ii(0xb71f, 3);  call(0xbeb2, 0x790);                       /* call 0xbeb2 */
            ii(0xb722, 3);  add(sp, 0xa);                              /* add sp, 0xa */
        l_0xb725:
            ii(0xb725, 3);  call(0x6f71, -0x47b7);                     /* call 0x6f71 */
        l_0xb728:
            ii(0xb728, 3);  mov(ax, memw[ss, bp - 16]);                /* mov ax, [bp-0x10] */
            ii(0xb72b, 3);  or(ax, memw[ss, bp - 18]);                 /* or ax, [bp-0x12] */
            ii(0xb72e, 2);  if(jz(0xb740, 0x10)) goto l_0xb740;        /* jz 0xb740 */
            ii(0xb730, 3);  mov(ax, memw[ss, bp - 18]);                /* mov ax, [bp-0x12] */
            ii(0xb733, 3);  mov(dx, memw[ss, bp - 16]);                /* mov dx, [bp-0x10] */
            ii(0xb736, 3);  mov(memw[ds, 0xa10], ax);                  /* mov [0xa10], ax */
            ii(0xb739, 4);  mov(memw[ds, 0xa12], dx);                  /* mov [0xa12], dx */
            ii(0xb73d, 3);  call(0x7cde, -0x3a62);                     /* call 0x7cde */
        l_0xb740:
            ii(0xb740, 1);  leave();                                   /* leave */
            ii(0xb741, 1);  ret();                                     /* ret */
        }
    }
}
