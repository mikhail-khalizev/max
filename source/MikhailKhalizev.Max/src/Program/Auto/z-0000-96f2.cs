using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x96f2-4358619d")]
        public void Method_0000_96f2()
        {
            ii(0x96f2, 1);  push(bp);                                  /* push bp */
            ii(0x96f3, 2);  mov(bp, sp);                               /* mov bp, sp */
            ii(0x96f5, 1);  push(si);                                  /* push si */
            ii(0x96f6, 1);  push(di);                                  /* push di */
            ii(0x96f7, 1);  push(ds);                                  /* push ds */
            ii(0x96f8, 3);  mov(ds, memw[ss, bp + 4]);                 /* mov ds, [bp+0x4] */
            ii(0x96fb, 3);  mov(si, memw[ss, bp + 6]);                 /* mov si, [bp+0x6] */
            ii(0x96fe, 3);  mov(es, memw[ss, bp + 8]);                 /* mov es, [bp+0x8] */
            ii(0x9701, 3);  mov(di, memw[ss, bp + 10]);                /* mov di, [bp+0xa] */
            ii(0x9704, 3);  mov(cx, memw[ss, bp + 12]);                /* mov cx, [bp+0xc] */
            ii(0x9707, 2);  rep(() => movsb());                        /* rep movsb */
            ii(0x9709, 1);  pop(ds);                                   /* pop ds */
            ii(0x970a, 1);  pop(di);                                   /* pop di */
            ii(0x970b, 1);  pop(si);                                   /* pop si */
            ii(0x970c, 2);  mov(sp, bp);                               /* mov sp, bp */
            ii(0x970e, 1);  pop(bp);                                   /* pop bp */
            ii(0x970f, 1);  ret();                                     /* ret */
        }
    }
}
