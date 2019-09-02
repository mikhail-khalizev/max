using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0xfd72-57a7336")]
        public void Method_0000_fd72()
        {
            ii(0xfd72, 4);    enter(4, 0);                              /* enter 0x4, 0x0 */
            ii(0xfd76, 5);    cmp(memw[ds, 0xa2], 0);                   /* cmp word [0xa2], 0x0 */
            ii(0xfd7b, 2);    if(jz(0xfda9, 0x2c)) goto l_0xfda9;       /* jz 0xfda9 */
            ii(0xfd7d, 3);    mov(ax, memw[ds, 0xa0]);                  /* mov ax, [0xa0] */
            ii(0xfd80, 3);    mov(memw[ss, bp - 4], ax);                /* mov [bp-0x4], ax */
            ii(0xfd83, 5);    mov(memw[ss, bp - 2], 0x60);              /* mov word [bp-0x2], 0x60 */
            ii(0xfd88, 3);    push(0x92);                               /* push 0x92 */
            ii(0xfd8b, 2);    push(-1 /* 0xff */);                      /* push 0xffff */
            ii(0xfd8d, 2);    push(0);                                  /* push 0x0 */
            ii(0xfd8f, 4);    push(memw[ds, 0xa2]);                     /* push word [0xa2] */
            ii(0xfd93, 2);    push(0x60);                               /* push 0x60 */
            ii(0xfd95, 3);    call(0x1_1a64, 0x1ccc);                   /* call 0x1a64 */
            ii(0xfd98, 3);    mov(ax, memw[ss, bp + 4]);                /* mov ax, [bp+0x4] */
            ii(0xfd9b, 3);    mov(dx, memw[ss, bp + 6]);                /* mov dx, [bp+0x6] */
            ii(0xfd9e, 3);    les(bx, memw[ss, bp - 4]);                /* les bx, [bp-0x4] */
            ii(0xfda1, 4);    add(memw[es, bx + 12], ax);               /* add [es:bx+0xc], ax */
            ii(0xfda5, 4);    adc(memw[es, bx + 14], dx);               /* adc [es:bx+0xe], dx */
        l_0xfda9:
            ii(0xfda9, 1);    leave();                                  /* leave */
            ii(0xfdaa, 1);    ret();                                    /* ret */
        }
    }
}
