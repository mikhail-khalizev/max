using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x79ef-5629890a")]
        public void Method_0000_79ef()
        {
            ii(0x79ef, 1);  push(bp);                                  /* push bp */
            ii(0x79f0, 2);  mov(bp, sp);                               /* mov bp, sp */
            ii(0x79f2, 3);  mov(ax, memw[ds, 0x97c]);                  /* mov ax, [0x97c] */
            ii(0x79f5, 3);  cmp(memw[ss, bp + 4], ax);                 /* cmp [bp+0x4], ax */
            ii(0x79f8, 2);  if(jbe(0x7a0f, 0x15)) goto l_0x7a0f;       /* jbe 0x7a0f */
            ii(0x79fa, 2);  sub(al, al);                               /* sub al, al */
            ii(0x79fc, 3);  mov(memb[ds, 0x11e9], al);                 /* mov [0x11e9], al */
            ii(0x79ff, 3);  mov(memb[ds, 0x11e8], al);                 /* mov [0x11e8], al */
            ii(0x7a02, 2);  sub(ax, ax);                               /* sub ax, ax */
            ii(0x7a04, 3);  mov(memw[ds, 0x11ea], ax);                 /* mov [0x11ea], ax */
            ii(0x7a07, 3);  mov(memw[ds, 0x11e6], ax);                 /* mov [0x11e6], ax */
            ii(0x7a0a, 3);  mov(memw[ds, 0x11e4], ax);                 /* mov [0x11e4], ax */
            ii(0x7a0d, 1);  leave();                                   /* leave */
            ii(0x7a0e, 1);  ret(); return;                             /* ret */
        l_0x7a0f:
            ii(0x7a0f, 2);  push(8);                                   /* push 0x8 */
            ii(0x7a11, 3);  push(0x11e4);                              /* push 0x11e4 */
            ii(0x7a14, 3);  mov(ax, memw[ss, bp + 4]);                 /* mov ax, [bp+0x4] */
            ii(0x7a17, 2);  and(al, 0xf8);                             /* and al, 0xf8 */
            ii(0x7a19, 2);  sub(dx, dx);                               /* sub dx, dx */
            ii(0x7a1b, 4);  add(ax, memw[ds, 0x98e]);                  /* add ax, [0x98e] */
            ii(0x7a1f, 4);  adc(dx, memw[ds, 0x990]);                  /* adc dx, [0x990] */
            ii(0x7a23, 1);  push(dx);                                  /* push dx */
            ii(0x7a24, 1);  push(ax);                                  /* push ax */
            ii(0x7a25, 3);  call(0x6f9d, -0xa8b);                      /* call 0x6f9d */
            ii(0x7a28, 3);  mov(ax, 1);                                /* mov ax, 0x1 */
            ii(0x7a2b, 1);  leave();                                   /* leave */
            ii(0x7a2c, 1);  ret();                                     /* ret */
        }
    }
}
