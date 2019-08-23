using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0xdd62-57a7336")]
        public void Method_0000_dd62()
        {
            ii(0xdd62, 4);    enter(0x4, 0);                            /* enter 0x4, 0x0 */
            ii(0xdd66, 5);    cmp(memw[ds, 0xa2], 0);                   /* cmp word [0xa2], 0x0 */
            ii(0xdd6b, 2);    if(jz(0xdd99, 0x2c)) goto l_0xdd99;       /* jz 0xdd99 */
            ii(0xdd6d, 3);    mov(ax, memw[ds, 0xa0]);                  /* mov ax, [0xa0] */
            ii(0xdd70, 3);    mov(memw[ss, bp - 0x4], ax);              /* mov [bp-0x4], ax */
            ii(0xdd73, 5);    mov(memw[ss, bp - 0x2], 0x60);            /* mov word [bp-0x2], 0x60 */
            ii(0xdd78, 3);    push(0x92);                               /* push 0x92 */
            ii(0xdd7b, 2);    push(-0x1 /* 0xff */);                    /* push 0xffff */
            ii(0xdd7d, 2);    push(0);                                  /* push 0x0 */
            ii(0xdd7f, 4);    push(memw[ds, 0xa2]);                     /* push word [0xa2] */
            ii(0xdd83, 2);    push(0x60);                               /* push 0x60 */
            ii(0xdd85, 3);    call(0xfa54, 0x1ccc);                     /* call 0xfa54 */
            ii(0xdd88, 3);    mov(ax, memw[ss, bp + 0x4]);              /* mov ax, [bp+0x4] */
            ii(0xdd8b, 3);    mov(dx, memw[ss, bp + 0x6]);              /* mov dx, [bp+0x6] */
            ii(0xdd8e, 3);    les(bx, ss, bp - 0x4);                    /* les bx, [bp-0x4] */
            ii(0xdd91, 4);    add(memw[es, bx + 0xc], ax);              /* add [es:bx+0xc], ax */
            ii(0xdd95, 4);    adc(memw[es, bx + 0xe], dx);              /* adc [es:bx+0xe], dx */
        l_0xdd99:
            ii(0xdd99, 1);    leave();                                  /* leave */
            ii(0xdd9a, 1);    ret();                                    /* ret */
        }
    }
}
