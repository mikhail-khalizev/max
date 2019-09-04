using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x5c10-a41b77d2")]
        public void Method_0000_5c10()
        {
            ii(0x5c10, 1);  push(bp);                                  /* push bp */
            ii(0x5c11, 2);  mov(bp, sp);                               /* mov bp, sp */
            ii(0x5c13, 2);  mov(dx, di);                               /* mov dx, di */
            ii(0x5c15, 2);  mov(ax, ds);                               /* mov ax, ds */
            ii(0x5c17, 2);  mov(es, ax);                               /* mov es, ax */
            ii(0x5c19, 3);  mov(di, memw[ss, bp + 4]);                 /* mov di, [bp+0x4] */
            ii(0x5c1c, 2);  xor(ax, ax);                               /* xor ax, ax */
            ii(0x5c1e, 3);  mov(cx, 0xffff);                           /* mov cx, 0xffff */
            ii(0x5c21, 2);  repne(() => scasb());                      /* repne scasb */
            ii(0x5c23, 2);  not(cx);                                   /* not cx */
            ii(0x5c25, 1);  dec(cx);                                   /* dec cx */
            ii(0x5c26, 1);  xchg(cx, ax);                              /* xchg cx, ax */
            ii(0x5c27, 2);  mov(di, dx);                               /* mov di, dx */
            ii(0x5c29, 1);  pop(bp);                                   /* pop bp */
            ii(0x5c2a, 1);  ret();                                     /* ret */
        }
    }
}
