using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x17_db16-97944398")]
        public void Method_0017_db16()
        {
            ii(0x17_db16, 1);  push(bp);                               /* push bp */
            ii(0x17_db17, 2);  mov(bp, sp);                            /* mov bp, sp */
            ii(0x17_db19, 2);  mov(dx, di);                            /* mov dx, di */
            ii(0x17_db1b, 2);  mov(ax, ds);                            /* mov ax, ds */
            ii(0x17_db1d, 2);  mov(es, ax);                            /* mov es, ax */
            ii(0x17_db1f, 3);  mov(di, memw[ss, bp + 6]);              /* mov di, [bp+0x6] */
            ii(0x17_db22, 2);  xor(ax, ax);                            /* xor ax, ax */
            ii(0x17_db24, 3);  mov(cx, 0xffff);                        /* mov cx, 0xffff */
            ii(0x17_db27, 2);  repne(() => scasb());                   /* repne scasb */
            ii(0x17_db29, 2);  not(cx);                                /* not cx */
            ii(0x17_db2b, 1);  dec(cx);                                /* dec cx */
            ii(0x17_db2c, 1);  xchg(cx, ax);                           /* xchg cx, ax */
            ii(0x17_db2d, 2);  mov(di, dx);                            /* mov di, dx */
            ii(0x17_db2f, 1);  pop(bp);                                /* pop bp */
            ii(0x17_db30, 1);  retf();                                 /* retf */
        }
    }
}
