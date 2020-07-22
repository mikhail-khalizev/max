using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x4218-5d145081")]
        public void Method_0000_4218()
        {
            ii(0x4218, 1);  push(cx);                                  /* push cx */
            ii(0x4219, 2);  xor(cx, cx);                               /* xor cx, cx */
        l_0x421b:
            ii(0x421b, 2);  inb(al, 0x64);                             /* in al, 0x64 */
            ii(0x421d, 2);  test(al, 2);                               /* test al, 0x2 */
            ii(0x421f, 2);  if(jnz(0x4223, 2)) goto l_0x4223;          /* jnz 0x4223 */
        l_0x4221:
            ii(0x4221, 1);  pop(cx);                                   /* pop cx */
            ii(0x4222, 1);  ret(); return;                             /* ret */
        l_0x4223:
            ii(0x4223, 2);  if(loopne(0x421b, -0xa)) goto l_0x421b;    /* loopne 0x421b */
            ii(0x4225, 2);  if(jz(0x4221, -6)) goto l_0x4221;          /* jz 0x4221 */
            ii(0x4227, 2);  push(0x1a);                                /* push 0x1a */
            ii(0x4229, 3);  call(0x589d, 0x1671);                      /* call 0x589d */
            ii(0x422c, 3);  call(0x428b, 0x5c);                        /* call 0x428b */
            ii(0x422f, 2);  add(al, ch);                               /* add al, ch */
            ii(0x4231, 1);  pop(ax);                                   /* pop ax */
            ii(0x4232, 2);  add(memb[ds, bx + di], al);                /* add [bx+di], al */
            ii(0x4234, 3);  call(0x428b, 0x54);                        /* call 0x428b */
            ii(0x4237, 2);  add(ch, al);                               /* add ch, al */
            ii(0x4239, 1);  push(ax);                                  /* push ax */
            ii(0x423a, 2);  add(memb[ss, bp + di], al);                /* add [bp+di], al */
            ii(0x423c, 3);  call(0x428b, 0x4c);                        /* call 0x428b */
            ii(0x423f, 2);  add(al, -0x18 /* 0xe8 */);                 /* add al, 0xe8 */
            ii(0x4241, 1);  dec(ax);                                   /* dec ax */
            ii(0x4242, 2);  add(memb[ds, di], al);                     /* add [di], al */
            ii(0x4244, 3);  call(0x428b, 0x44);                        /* call 0x428b */
            ii(0x4247, 1);  push(es);                                  /* push es */
            ii(0x4248, 3);  call(0x428b, 0x40);                        /* call 0x428b */
            ii(0x424b, 1);  pop(es);                                   /* pop es */
            ii(0x424c, 3);  call(0x428f, 0x40);                        /* call 0x428f */
            ii(0x424f, 2);  or(al, ch);                                /* or al, ch */
            ii(0x4251, 2);  cmp(memb[ds, bx + si], al);                /* cmp [bx+si], al */
            ii(0x4253, 2);  or(ax, bp);                                /* or ax, bp */
            ii(0x4255, 2);  cmp(memb[ds, bx + si], al);                /* cmp [bx+si], al */
            ii(0x4257, 2);  or(ch, al);                                /* or ch, al */
            ii(0x4259, 2);  xor(al, 0);                                /* xor al, 0x0 */
            ii(0x425b, 2);  or(bp, ax);                                /* or bp, ax */
            ii(0x425d, 2);  xor(memb[ds, bx + si], al);                /* xor [bx+si], al */
            ii(0x425f, 2);  or(al, 0xe8);                              /* or al, 0xe8 */
            ii(0x4261, 2);  sub(al, 0);                                /* sub al, 0x0 */
            ii(0x4263, 3);  or(ax, 0x28e8);                            /* or ax, 0x28e8 */
            ii(0x4266, 4);  add(memb[ds, 0x20e8], cl);                 /* add [0x20e8], cl */
            ii(0x426a, 2);  add(memb[ds, bx], cl);                     /* add [bx], cl */
            ii(0x426c, 3);  call(0x428b, 0x1c);                        /* call 0x428b */
            ii(0x426f, 1);  push(ds);                                  /* push ds */
            ii(0x4270, 3);  call(0x428b, 0x18);                        /* call 0x428b */
        }
    }
}
