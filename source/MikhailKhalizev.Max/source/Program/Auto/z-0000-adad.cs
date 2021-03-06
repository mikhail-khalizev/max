using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0xadad-82f953e0")]
        public void Method_0000_adad()
        {
            ii(0xadad, 4);  enter(4, 0);                               /* enter 0x4, 0x0 */
            ii(0xadb1, 2);  push(4);                                   /* push 0x4 */
            ii(0xadb3, 3);  lea(ax, memw[ss, bp + 4]);                 /* lea ax, [bp+0x4] */
            ii(0xadb6, 1);  push(ax);                                  /* push ax */
            ii(0xadb7, 3);  call(0xbf5a, 0x11a0);                      /* call 0xbf5a */
            ii(0xadba, 3);  cmp(dx, 0x10);                             /* cmp dx, 0x10 */
            ii(0xadbd, 2);  if(jg(0xadc1, 2)) goto l_0xadc1;           /* jg 0xadc1 */
            ii(0xadbf, 2);  if(jl(0xadfa, 0x39)) goto l_0xadfa;        /* jl 0xadfa */
        l_0xadc1:
            ii(0xadc1, 2);  push(4);                                   /* push 0x4 */
            ii(0xadc3, 3);  push(0xf08);                               /* push 0xf08 */
            ii(0xadc6, 3);  push(memw[ss, bp + 6]);                    /* push word [bp+0x6] */
            ii(0xadc9, 3);  push(memw[ss, bp + 4]);                    /* push word [bp+0x4] */
            ii(0xadcc, 3);  call(0x6fd2, -0x3dfd);                     /* call 0x6fd2 */
            ii(0xadcf, 3);  add(sp, 8);                                /* add sp, 0x8 */
            ii(0xadd2, 2);  push(4);                                   /* push 0x4 */
            ii(0xadd4, 3);  lea(ax, memw[ss, bp - 4]);                 /* lea ax, [bp-0x4] */
            ii(0xadd7, 1);  push(ax);                                  /* push ax */
            ii(0xadd8, 3);  push(memw[ss, bp + 6]);                    /* push word [bp+0x6] */
            ii(0xaddb, 3);  push(memw[ss, bp + 4]);                    /* push word [bp+0x4] */
            ii(0xadde, 3);  call(0x6f9d, -0x3e44);                     /* call 0x6f9d */
            ii(0xade1, 3);  add(sp, 8);                                /* add sp, 0x8 */
            ii(0xade4, 3);  mov(ax, memw[ds, 0xf08]);                  /* mov ax, [0xf08] */
            ii(0xade7, 4);  mov(dx, memw[ds, 0xf0a]);                  /* mov dx, [0xf0a] */
            ii(0xadeb, 3);  cmp(memw[ss, bp - 4], ax);                 /* cmp [bp-0x4], ax */
            ii(0xadee, 2);  if(jnz(0xadfa, 0xa)) goto l_0xadfa;        /* jnz 0xadfa */
            ii(0xadf0, 3);  cmp(memw[ss, bp - 2], dx);                 /* cmp [bp-0x2], dx */
            ii(0xadf3, 2);  if(jnz(0xadfa, 5)) goto l_0xadfa;          /* jnz 0xadfa */
            ii(0xadf5, 3);  mov(ax, 1);                                /* mov ax, 0x1 */
            ii(0xadf8, 1);  leave();                                   /* leave */
            ii(0xadf9, 1);  ret(); return;                             /* ret */
        l_0xadfa:
            ii(0xadfa, 2);  sub(ax, ax);                               /* sub ax, ax */
            ii(0xadfc, 1);  leave();                                   /* leave */
            ii(0xadfd, 1);  ret();                                     /* ret */
        }
    }
}
