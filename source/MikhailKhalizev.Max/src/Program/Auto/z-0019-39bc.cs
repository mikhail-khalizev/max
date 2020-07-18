using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x19_39bc-5c47ced")]
        public void Method_0019_39bc()
        {
            ii(0x19_39bc, 1);  push(bp);                               /* push bp */
            ii(0x19_39bd, 2);  mov(bp, sp);                            /* mov bp, sp */
            ii(0x19_39bf, 2);  mov(dx, di);                            /* mov dx, di */
            ii(0x19_39c1, 3);  les(di, memw[ss, bp + 6]);              /* les di, [bp+0x6] */
            ii(0x19_39c4, 2);  xor(ax, ax);                            /* xor ax, ax */
            ii(0x19_39c6, 3);  mov(cx, 0xffff);                        /* mov cx, 0xffff */
            ii(0x19_39c9, 2);  repne(() => scasb());                   /* repne scasb */
            ii(0x19_39cb, 2);  not(cx);                                /* not cx */
            ii(0x19_39cd, 1);  dec(cx);                                /* dec cx */
            ii(0x19_39ce, 1);  xchg(cx, ax);                           /* xchg cx, ax */
            ii(0x19_39cf, 2);  mov(di, dx);                            /* mov di, dx */
            ii(0x19_39d1, 1);  pop(bp);                                /* pop bp */
            ii(0x19_39d2, 1);  retf();                                 /* retf */
        }
    }
}
