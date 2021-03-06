using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x85ed-82f953e0")]
        public void Method_0000_85ed()
        {
            ii(0x85ed, 4);  enter(4, 0);                               /* enter 0x4, 0x0 */
            ii(0x85f1, 2);  push(4);                                   /* push 0x4 */
            ii(0x85f3, 3);  lea(ax, memw[ss, bp + 4]);                 /* lea ax, [bp+0x4] */
            ii(0x85f6, 1);  push(ax);                                  /* push ax */
            ii(0x85f7, 3);  call(0x979a, 0x11a0);                      /* call 0x979a */
            ii(0x85fa, 3);  cmp(dx, 0x10);                             /* cmp dx, 0x10 */
            ii(0x85fd, 2);  if(jg(0x8601, 2)) goto l_0x8601;           /* jg 0x8601 */
            ii(0x85ff, 2);  if(jl(0x863a, 0x39)) goto l_0x863a;        /* jl 0x863a */
        l_0x8601:
            ii(0x8601, 2);  push(4);                                   /* push 0x4 */
            ii(0x8603, 3);  push(0xf08);                               /* push 0xf08 */
            ii(0x8606, 3);  push(memw[ss, bp + 6]);                    /* push word [bp+0x6] */
            ii(0x8609, 3);  push(memw[ss, bp + 4]);                    /* push word [bp+0x4] */
            ii(0x860c, 3);  call(0x4812, -0x3dfd);                     /* call 0x4812 */
            ii(0x860f, 3);  add(sp, 8);                                /* add sp, 0x8 */
            ii(0x8612, 2);  push(4);                                   /* push 0x4 */
            ii(0x8614, 3);  lea(ax, memw[ss, bp - 4]);                 /* lea ax, [bp-0x4] */
            ii(0x8617, 1);  push(ax);                                  /* push ax */
            ii(0x8618, 3);  push(memw[ss, bp + 6]);                    /* push word [bp+0x6] */
            ii(0x861b, 3);  push(memw[ss, bp + 4]);                    /* push word [bp+0x4] */
            ii(0x861e, 3);  call(0x47dd, -0x3e44);                     /* call 0x47dd */
            ii(0x8621, 3);  add(sp, 8);                                /* add sp, 0x8 */
            ii(0x8624, 3);  mov(ax, memw[ds, 0xf08]);                  /* mov ax, [0xf08] */
            ii(0x8627, 4);  mov(dx, memw[ds, 0xf0a]);                  /* mov dx, [0xf0a] */
            ii(0x862b, 3);  cmp(memw[ss, bp - 4], ax);                 /* cmp [bp-0x4], ax */
            ii(0x862e, 2);  if(jnz(0x863a, 0xa)) goto l_0x863a;        /* jnz 0x863a */
            ii(0x8630, 3);  cmp(memw[ss, bp - 2], dx);                 /* cmp [bp-0x2], dx */
            ii(0x8633, 2);  if(jnz(0x863a, 5)) goto l_0x863a;          /* jnz 0x863a */
            ii(0x8635, 3);  mov(ax, 1);                                /* mov ax, 0x1 */
            ii(0x8638, 1);  leave();                                   /* leave */
            ii(0x8639, 1);  ret(); return;                             /* ret */
        l_0x863a:
            ii(0x863a, 2);  sub(ax, ax);                               /* sub ax, ax */
            ii(0x863c, 1);  leave();                                   /* leave */
            ii(0x863d, 1);  ret();                                     /* ret */
        }
    }
}
