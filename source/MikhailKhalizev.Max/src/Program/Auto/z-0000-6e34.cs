using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x6e34-ee01711a")]
        public void Method_0000_6e34()
        {
            ii(0x6e34, 4);  enter(2, 0);                               /* enter 0x2, 0x0 */
            ii(0x6e38, 3);  mov(ax, memw[ds, 0xd0e]);                  /* mov ax, [0xd0e] */
            ii(0x6e3b, 3);  mov(cx, 0x180);                            /* mov cx, 0x180 */
            ii(0x6e3e, 2);  imul(cx);                                  /* imul cx */
            ii(0x6e40, 3);  add(ax, 0x2a);                             /* add ax, 0x2a */
            ii(0x6e43, 3);  mov(memw[ss, bp - 2], ax);                 /* mov [bp-0x2], ax */
            ii(0x6e46, 5);  cmp(memw[ds, 0xf4e], 0);                   /* cmp word [0xf4e], 0x0 */
            ii(0x6e4b, 2);  if(jnz(0x6e6e, 0x21)) goto l_0x6e6e;       /* jnz 0x6e6e */
            ii(0x6e4d, 6);  mov(memw[ds, 0x11d4], 8);                  /* mov word [0x11d4], 0x8 */
            ii(0x6e53, 1);  push(ax);                                  /* push ax */
            ii(0x6e54, 5);  call_far_abs(0x1a2, 0xb12);                /* call word 0x1a2:0xb12 */
            ii(0x6e59, 1);  pop(bx);                                   /* pop bx */
            ii(0x6e5a, 3);  push(memw[ss, bp - 2]);                    /* push word [bp-0x2] */
            ii(0x6e5d, 3);  call(0x5a2e, -0x1432);                     /* call 0x5a2e */
            ii(0x6e60, 1);  pop(bx);                                   /* pop bx */
            ii(0x6e61, 3);  mov(memw[ds, 0xf4e], ax);                  /* mov [0xf4e], ax */
            ii(0x6e64, 2);  or(ax, ax);                                /* or ax, ax */
            ii(0x6e66, 2);  if(jnz(0x6e6e, 6)) goto l_0x6e6e;          /* jnz 0x6e6e */
            ii(0x6e68, 2);  push(9);                                   /* push 0x9 */
            ii(0x6e6a, 3);  call(0x589d, -0x15d0);                     /* call 0x589d */
            ii(0x6e6d, 1);  pop(bx);                                   /* pop bx */
        l_0x6e6e:
            ii(0x6e6e, 3);  push(memw[ss, bp - 2]);                    /* push word [bp-0x2] */
            ii(0x6e71, 2);  push(0);                                   /* push 0x0 */
            ii(0x6e73, 4);  push(memw[ds, 0xf4e]);                     /* push word [0xf4e] */
            ii(0x6e77, 3);  call(0x5d66, -0x1114);                     /* call 0x5d66 */
            ii(0x6e7a, 3);  mov(ax, memw[ss, bp - 2]);                 /* mov ax, [bp-0x2] */
            ii(0x6e7d, 4);  add(ax, memw[ds, 0xf4e]);                  /* add ax, [0xf4e] */
            ii(0x6e81, 3);  mov(memw[ds, 0xf4c], ax);                  /* mov [0xf4c], ax */
            ii(0x6e84, 3);  sub(ax, 0x2a);                             /* sub ax, 0x2a */
            ii(0x6e87, 3);  mov(memw[ds, 0x996], ax);                  /* mov [0x996], ax */
            ii(0x6e8a, 2);  mov(bx, ax);                               /* mov bx, ax */
            ii(0x6e8c, 4);  mov(cx, memw[ds, 0xf4c]);                  /* mov cx, [0xf4c] */
            ii(0x6e90, 2);  mov(memw[ds, bx], cx);                     /* mov [bx], cx */
            ii(0x6e92, 5);  mov(memw[ds, bx + 24], 0xffff);            /* mov word [bx+0x18], 0xffff */
            ii(0x6e97, 6);  mov(memw[ds, 0x99e], 0);                   /* mov word [0x99e], 0x0 */
            ii(0x6e9d, 1);  leave();                                   /* leave */
            ii(0x6e9e, 1);  ret();                                     /* ret */
        }
    }
}
