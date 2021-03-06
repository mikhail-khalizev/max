using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x19_36e2-667d8fae")]
        public void Method_0019_36e2()
        {
            ii(0x19_36e2, 1);  push(bp);                               /* push bp */
            ii(0x19_36e3, 2);  mov(bp, sp);                            /* mov bp, sp */
            ii(0x19_36e5, 3);  mov(ax, memw[ss, bp + 8]);              /* mov ax, [bp+0x8] */
            ii(0x19_36e8, 3);  mov(cx, memw[ss, bp + 12]);             /* mov cx, [bp+0xc] */
            ii(0x19_36eb, 2);  or(cx, ax);                             /* or cx, ax */
            ii(0x19_36ed, 3);  mov(cx, memw[ss, bp + 10]);             /* mov cx, [bp+0xa] */
            ii(0x19_36f0, 2);  if(jnz(0x19_36fb, 9)) goto l_0x19_36fb; /* jnz 0x36fb */
            ii(0x19_36f2, 3);  mov(ax, memw[ss, bp + 6]);              /* mov ax, [bp+0x6] */
            ii(0x19_36f5, 2);  mul(cx);                                /* mul cx */
            ii(0x19_36f7, 1);  pop(bp);                                /* pop bp */
            ii(0x19_36f8, 3);  retf(8); return;                        /* retf 0x8 */
        l_0x19_36fb:
            ii(0x19_36fb, 1);  push(bx);                               /* push bx */
            ii(0x19_36fc, 2);  mul(cx);                                /* mul cx */
            ii(0x19_36fe, 2);  mov(bx, ax);                            /* mov bx, ax */
            ii(0x19_3700, 3);  mov(ax, memw[ss, bp + 6]);              /* mov ax, [bp+0x6] */
            ii(0x19_3703, 3);  mul(memw[ss, bp + 12]);                 /* mul word [bp+0xc] */
            ii(0x19_3706, 2);  add(bx, ax);                            /* add bx, ax */
            ii(0x19_3708, 3);  mov(ax, memw[ss, bp + 6]);              /* mov ax, [bp+0x6] */
            ii(0x19_370b, 2);  mul(cx);                                /* mul cx */
            ii(0x19_370d, 2);  add(dx, bx);                            /* add dx, bx */
            ii(0x19_370f, 1);  pop(bx);                                /* pop bx */
            ii(0x19_3710, 1);  pop(bp);                                /* pop bp */
            ii(0x19_3711, 3);  retf(8);                                /* retf 0x8 */
        }
    }
}
