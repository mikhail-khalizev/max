using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x49c8-5d145081")]
        public void Method_0000_49c8()
        {
            ii(0x49c8, 1);  push(cx);                                  /* push cx */
            ii(0x49c9, 2);  xor(cx, cx);                               /* xor cx, cx */
        l_0x49cb:
            ii(0x49cb, 2);  inb(al, 0x64);                             /* in al, 0x64 */
            ii(0x49cd, 2);  test(al, 2);                               /* test al, 0x2 */
            ii(0x49cf, 2);  if(jnz(0x49d3, 2)) goto l_0x49d3;          /* jnz 0x49d3 */
        l_0x49d1:
            ii(0x49d1, 1);  pop(cx);                                   /* pop cx */
            ii(0x49d2, 1);  ret(); return;                             /* ret */
        l_0x49d3:
            ii(0x49d3, 2);  if(loopne(0x49cb, -0xa)) goto l_0x49cb;    /* loopne 0x49cb */
            ii(0x49d5, 2);  if(jz(0x49d1, -6)) goto l_0x49d1;          /* jz 0x49d1 */
            ii(0x49d7, 2);  push(0x1a);                                /* push 0x1a */
            ii(0x49d9, 3);  call(0x604d, 0x1671);                      /* call 0x604d */
            ii(0x49dc, 3);  call(0x4a3b, 0x5c);                        /* call 0x4a3b */
            ii(0x49df, 2);  add(al, ch);                               /* add al, ch */
            ii(0x49e1, 1);  pop(ax);                                   /* pop ax */
            ii(0x49e2, 2);  add(memb[ds, bx + di], al);                /* add [bx+di], al */
            ii(0x49e4, 3);  call(0x4a3b, 0x54);                        /* call 0x4a3b */
            ii(0x49e7, 2);  add(ch, al);                               /* add ch, al */
            ii(0x49e9, 1);  push(ax);                                  /* push ax */
            ii(0x49ea, 2);  add(memb[ss, bp + di], al);                /* add [bp+di], al */
            ii(0x49ec, 3);  call(0x4a3b, 0x4c);                        /* call 0x4a3b */
            ii(0x49ef, 2);  add(al, -0x18 /* 0xe8 */);                 /* add al, 0xe8 */
            ii(0x49f1, 1);  dec(ax);                                   /* dec ax */
            ii(0x49f2, 2);  add(memb[ds, di], al);                     /* add [di], al */
            ii(0x49f4, 3);  call(0x4a3b, 0x44);                        /* call 0x4a3b */
            ii(0x49f7, 1);  push(es);                                  /* push es */
            ii(0x49f8, 3);  call(0x4a3b, 0x40);                        /* call 0x4a3b */
            ii(0x49fb, 1);  pop(es);                                   /* pop es */
            ii(0x49fc, 3);  call(0x4a3f, 0x40);                        /* call 0x4a3f */
            ii(0x49ff, 2);  or(al, ch);                                /* or al, ch */
            ii(0x4a01, 2);  cmp(memb[ds, bx + si], al);                /* cmp [bx+si], al */
            ii(0x4a03, 2);  or(ax, bp);                                /* or ax, bp */
            ii(0x4a05, 2);  cmp(memb[ds, bx + si], al);                /* cmp [bx+si], al */
            ii(0x4a07, 2);  or(ch, al);                                /* or ch, al */
            ii(0x4a09, 2);  xor(al, 0);                                /* xor al, 0x0 */
            ii(0x4a0b, 2);  or(bp, ax);                                /* or bp, ax */
            ii(0x4a0d, 2);  xor(memb[ds, bx + si], al);                /* xor [bx+si], al */
            ii(0x4a0f, 2);  or(al, 0xe8);                              /* or al, 0xe8 */
            ii(0x4a11, 2);  sub(al, 0);                                /* sub al, 0x0 */
            ii(0x4a13, 3);  or(ax, 0x28e8);                            /* or ax, 0x28e8 */
            ii(0x4a16, 4);  add(memb[ds, 0x20e8], cl);                 /* add [0x20e8], cl */
            ii(0x4a1a, 2);  add(memb[ds, bx], cl);                     /* add [bx], cl */
            ii(0x4a1c, 3);  call(0x4a3b, 0x1c);                        /* call 0x4a3b */
            ii(0x4a1f, 1);  push(ds);                                  /* push ds */
            ii(0x4a20, 3);  call(0x4a3b, 0x18);                        /* call 0x4a3b */
        }
    }
}
