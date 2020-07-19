using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x499d-137911bc")]
        public void Method_0000_499d()
        {
            ii(0x499d, 3);  call(0x4c5b, 0x2bb);                       /* call 0x4c5b */
            ii(0x49a0, 2);  if(jnz(0x4a17, 0x75)) goto l_0x4a17;       /* jnz 0x4a17 */
            ii(0x49a2, 2);  xor(bx, bx);                               /* xor bx, bx */
            ii(0x49a4, 2);  mov(es, bx);                               /* mov es, bx */
            ii(0x49a6, 4);  mov(bl, memb[ds, 0x34]);                   /* mov bl, [0x34] */
            ii(0x49aa, 3);  shl(bx, 2);                                /* shl bx, 0x2 */
            ii(0x49ad, 2);  mov(dx, cs);                               /* mov dx, cs */
            ii(0x49af, 4);  cmp(dx, memw[es, bx + 2]);                 /* cmp dx, [es:bx+0x2] */
            ii(0x49b3, 2);  if(jnz(0x49d4, 0x1f)) goto l_0x49d4;       /* jnz 0x49d4 */
            ii(0x49b5, 2);  mov(ah, 0x25);                             /* mov ah, 0x25 */
            ii(0x49b7, 5);  cmp(memb[ds, 0x34], 0x15);                 /* cmp byte [0x34], 0x15 */
            ii(0x49bc, 5);  lds(dx, memw[cs, 0x12c4]);                 /* lds dx, [cs:0x12c4] */
            ii(0x49c1, 2);  if(jz(0x49c8, 5)) goto l_0x49c8;           /* jz 0x49c8 */
            ii(0x49c3, 5);  lds(dx, memw[ss, 0xf84]);                  /* lds dx, [ss:0xf84] */
        l_0x49c8:
            ii(0x49c8, 1);  cli();                                     /* cli */
            ii(0x49c9, 3);  mov(memw[es, bx], dx);                     /* mov [es:bx], dx */
            ii(0x49cc, 4);  mov(memw[es, bx + 2], ds);                 /* mov [es:bx+0x2], ds */
            ii(0x49d0, 1);  sti();                                     /* sti */
            ii(0x49d1, 1);  push(ss);                                  /* push ss */
            ii(0x49d2, 1);  pop(ds);                                   /* pop ds */
            ii(0x49d3, 1);  ret(); return;                             /* ret */
        l_0x49d4:
            ii(0x49d4, 1);  xchg(cx, ax);                              /* xchg cx, ax */
        l_0x49d5:
            ii(0x49d5, 2);  mov(ds, ax);                               /* mov ds, ax */
            ii(0x49d7, 3);  cmp(ax, memw[ds, bx - 2]);                 /* cmp ax, [bx-0x2] */
            ii(0x49da, 2);  if(jnz(0x4a17, 0x3b)) goto l_0x4a17;       /* jnz 0x4a17 */
            ii(0x49dc, 3);  cmp(bx, memw[ds, bx - 4]);                 /* cmp bx, [bx-0x4] */
            ii(0x49df, 2);  if(jnz(0x4a17, 0x36)) goto l_0x4a17;       /* jnz 0x4a17 */
            ii(0x49e1, 3);  mov(ax, memw[ds, bx - 6]);                 /* mov ax, [bx-0x6] */
            ii(0x49e4, 2);  cmp(dx, ax);                               /* cmp dx, ax */
            ii(0x49e6, 2);  if(jz(0x49ed, 5)) goto l_0x49ed;           /* jz 0x49ed */
            ii(0x49e8, 3);  mov(bx, memw[ds, bx - 8]);                 /* mov bx, [bx-0x8] */
            ii(0x49eb, 2);  jmp(0x49d5, -0x18); goto l_0x49d5;         /* jmp 0x49d5 */
        l_0x49ed:
            ii(0x49ed, 4);  mov(ax, memw[cs, 0x12c4]);                 /* mov ax, [cs:0x12c4] */
            ii(0x49f1, 1);  cli();                                     /* cli */
            ii(0x49f2, 3);  mov(memw[ds, bx - 8], ax);                 /* mov [bx-0x8], ax */
            ii(0x49f5, 4);  mov(ax, memw[cs, 0x12c6]);                 /* mov ax, [cs:0x12c6] */
            ii(0x49f9, 3);  mov(memw[ds, bx - 6], ax);                 /* mov [bx-0x6], ax */
            ii(0x49fc, 1);  sti();                                     /* sti */
            ii(0x49fd, 3);  mov(ax, memw[ds, 0]);                      /* mov ax, [0x0] */
            ii(0x4a00, 2);  or(ax, ax);                                /* or ax, ax */
            ii(0x4a02, 2);  if(jnz(0x4a07, 3)) goto l_0x4a07;          /* jnz 0x4a07 */
            ii(0x4a04, 3);  mov(ax, memw[ds, 0x10]);                   /* mov ax, [0x10] */
        l_0x4a07:
            ii(0x4a07, 2);  or(ax, ax);                                /* or ax, ax */
            ii(0x4a09, 2);  if(jz(0x4a17, 0xc)) goto l_0x4a17;         /* jz 0x4a17 */
            ii(0x4a0b, 3);  sub(ax, 0x11);                             /* sub ax, 0x11 */
            ii(0x4a0e, 2);  mov(ds, ax);                               /* mov ds, ax */
            ii(0x4a10, 1);  inc(ax);                                   /* inc ax */
            ii(0x4a11, 4);  cmp(memw[ds, 1], ax);                      /* cmp [0x1], ax */
            ii(0x4a15, 2);  if(jz(0x4a1a, 3)) goto l_0x4a1a;           /* jz 0x4a1a */
        l_0x4a17:
            ii(0x4a17, 3);  mov(ax, 0xffff);                           /* mov ax, 0xffff */
        l_0x4a1a:
            ii(0x4a1a, 5);  mov(bx, memw[ss, 0xcec]);                  /* mov bx, [ss:0xcec] */
            ii(0x4a1f, 1);  dec(bx);                                   /* dec bx */
            ii(0x4a20, 2);  mov(ds, bx);                               /* mov ds, bx */
            ii(0x4a22, 3);  mov(memw[ds, 1], ax);                      /* mov [0x1], ax */
            ii(0x4a25, 1);  push(ss);                                  /* push ss */
            ii(0x4a26, 1);  pop(ds);                                   /* pop ds */
            ii(0x4a27, 1);  ret();                                     /* ret */
        }
    }
}
