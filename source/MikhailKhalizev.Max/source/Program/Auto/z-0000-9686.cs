using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x9686-3c33d557")]
        public void Method_0000_9686()
        {
            ii(0x9686, 4);  enter(0x14, 0);                            /* enter 0x14, 0x0 */
            ii(0x968a, 5);  cmp(memw[ds, 0xa12], 1);                   /* cmp word [0xa12], 0x1 */
            ii(0x968f, 2);  if(jl(0x9694, 3)) goto l_0x9694;           /* jl 0x9694 */
            ii(0x9691, 3);  jmp(0x9730, 0x9c); goto l_0x9730;          /* jmp 0x9730 */
        l_0x9694:
            ii(0x9694, 2);  sub(ax, ax);                               /* sub ax, ax */
            ii(0x9696, 3);  mov(memw[ss, bp - 16], ax);                /* mov [bp-0x10], ax */
            ii(0x9699, 3);  mov(memw[ss, bp - 18], ax);                /* mov [bp-0x12], ax */
            ii(0x969c, 5);  test(memb[ds, 0x47], 0x80);                /* test byte [0x47], 0x80 */
            ii(0x96a1, 2);  if(jz(0x96ca, 0x27)) goto l_0x96ca;        /* jz 0x96ca */
            ii(0x96a3, 3);  mov(ax, memw[ds, 0xdf4]);                  /* mov ax, [0xdf4] */
            ii(0x96a6, 3);  mov(memw[ds, 0xaa], ax);                   /* mov [0xaa], ax */
            ii(0x96a9, 5);  mov(memw[ss, bp - 14], 0xbfde);            /* mov word [bp-0xe], 0xbfde */
            ii(0x96ae, 5);  mov(memw[ss, bp - 12], 2);                 /* mov word [bp-0xc], 0x2 */
            ii(0x96b3, 2);  sub(ax, ax);                               /* sub ax, ax */
            ii(0x96b5, 3);  mov(memw[ss, bp - 10], ax);                /* mov [bp-0xa], ax */
            ii(0x96b8, 3);  mov(memw[ss, bp - 8], ax);                 /* mov [bp-0x8], ax */
            ii(0x96bb, 3);  lea(ax, memw[ss, bp - 14]);                /* lea ax, [bp-0xe] */
            ii(0x96be, 1);  push(ax);                                  /* push ax */
            ii(0x96bf, 1);  push(ax);                                  /* push ax */
            ii(0x96c0, 2);  push(0x15);                                /* push 0x15 */
            ii(0x96c2, 3);  call(0x9e24, 0x75f);                       /* call 0x9e24 */
            ii(0x96c5, 3);  add(sp, 6);                                /* add sp, 0x6 */
            ii(0x96c8, 1);  leave();                                   /* leave */
            ii(0x96c9, 1);  ret(); return;                             /* ret */
        l_0x96ca:
            ii(0x96ca, 3);  mov(ax, memw[ss, bp - 16]);                /* mov ax, [bp-0x10] */
            ii(0x96cd, 3);  or(ax, memw[ss, bp - 18]);                 /* or ax, [bp-0x12] */
            ii(0x96d0, 2);  if(jnz(0x9718, 0x46)) goto l_0x9718;       /* jnz 0x9718 */
            ii(0x96d2, 3);  call(0x5cc4, -0x3a11);                     /* call 0x5cc4 */
            ii(0x96d5, 3);  mov(memw[ss, bp - 20], ax);                /* mov [bp-0x14], ax */
            ii(0x96d8, 3);  call(0x572a, -0x3fb1);                     /* call 0x572a */
            ii(0x96db, 3);  mov(ax, memw[ss, bp - 20]);                /* mov ax, [bp-0x14] */
            ii(0x96de, 3);  shr(ax, 4);                                /* shr ax, 0x4 */
            ii(0x96e1, 2);  push(0);                                   /* push 0x0 */
            ii(0x96e3, 1);  push(ax);                                  /* push ax */
            ii(0x96e4, 3);  call(0x5c08, -0x3adf);                     /* call 0x5c08 */
            ii(0x96e7, 1);  pop(bx);                                   /* pop bx */
            ii(0x96e8, 1);  pop(bx);                                   /* pop bx */
            ii(0x96e9, 3);  mov(memw[ss, bp - 18], ax);                /* mov [bp-0x12], ax */
            ii(0x96ec, 3);  mov(memw[ss, bp - 16], dx);                /* mov [bp-0x10], dx */
            ii(0x96ef, 2);  or(dx, ax);                                /* or dx, ax */
            ii(0x96f1, 2);  if(jz(0x9715, 0x22)) goto l_0x9715;        /* jz 0x9715 */
            ii(0x96f3, 3);  push(0x92);                                /* push 0x92 */
            ii(0x96f6, 2);  push(-1 /* 0xff */);                       /* push 0xffff */
            ii(0x96f8, 3);  push(memw[ss, bp - 16]);                   /* push word [bp-0x10] */
            ii(0x96fb, 1);  push(ax);                                  /* push ax */
            ii(0x96fc, 2);  push(0x60);                                /* push 0x60 */
            ii(0x96fe, 3);  call(0x5c1c, -0x3ae5);                     /* call 0x5c1c */
            ii(0x9701, 3);  add(sp, 0xa);                              /* add sp, 0xa */
            ii(0x9704, 3);  push(memw[ss, bp - 20]);                   /* push word [bp-0x14] */
            ii(0x9707, 2);  push(0);                                   /* push 0x0 */
            ii(0x9709, 2);  push(0x60);                                /* push 0x60 */
            ii(0x970b, 2);  push(0);                                   /* push 0x0 */
            ii(0x970d, 2);  push(0x70);                                /* push 0x70 */
            ii(0x970f, 3);  call(0x9ea2, 0x790);                       /* call 0x9ea2 */
            ii(0x9712, 3);  add(sp, 0xa);                              /* add sp, 0xa */
        l_0x9715:
            ii(0x9715, 3);  call(0x4f61, -0x47b7);                     /* call 0x4f61 */
        l_0x9718:
            ii(0x9718, 3);  mov(ax, memw[ss, bp - 16]);                /* mov ax, [bp-0x10] */
            ii(0x971b, 3);  or(ax, memw[ss, bp - 18]);                 /* or ax, [bp-0x12] */
            ii(0x971e, 2);  if(jz(0x9730, 0x10)) goto l_0x9730;        /* jz 0x9730 */
            ii(0x9720, 3);  mov(ax, memw[ss, bp - 18]);                /* mov ax, [bp-0x12] */
            ii(0x9723, 3);  mov(dx, memw[ss, bp - 16]);                /* mov dx, [bp-0x10] */
            ii(0x9726, 3);  mov(memw[ds, 0xa10], ax);                  /* mov [0xa10], ax */
            ii(0x9729, 4);  mov(memw[ds, 0xa12], dx);                  /* mov [0xa12], dx */
            ii(0x972d, 3);  call(0x5cce, -0x3a62);                     /* call 0x5cce */
        l_0x9730:
            ii(0x9730, 1);  leave();                                   /* leave */
            ii(0x9731, 1);  ret();                                     /* ret */
        }
    }
}
