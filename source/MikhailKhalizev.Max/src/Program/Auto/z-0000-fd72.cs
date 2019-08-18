using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0xfd72-57a7336")]
        public void Method_0000_fd72()
        {
            ii(0xfd72, 4);    enterw(0x4, 0);                           /* enter 0x4, 0x0 */
            ii(0xfd76, 5);    cmp(memw_a16[ds, 0xa2], 0);               /* cmp word [0xa2], 0x0 */
            ii(0xfd7b, 2);    if(jzw(0xfda9, 0x2c)) goto l_0xfda9;      /* jz 0xfda9 */
            ii(0xfd7d, 3);    mov(ax, memw_a16[ds, 0xa0]);              /* mov ax, [0xa0] */
            ii(0xfd80, 3);    mov(memw_a16[ss, bp - 0x4], ax);          /* mov [bp-0x4], ax */
            ii(0xfd83, 5);    mov(memw_a16[ss, bp - 0x2], 0x60);        /* mov word [bp-0x2], 0x60 */
            ii(0xfd88, 3);    pushw(0x92);                              /* push 0x92 */
            ii(0xfd8b, 2);    pushw(-0x1 /* 0xff */);                   /* push 0xffff */
            ii(0xfd8d, 2);    pushw(0);                                 /* push 0x0 */
            ii(0xfd8f, 4);    pushw(memw_a16[ds, 0xa2]);                /* push word [0xa2] */
            ii(0xfd93, 2);    pushw(0x60);                              /* push 0x60 */
            ii(0xfd95, 3);    callw(0x1_1a64, 0x1ccc);                  /* call 0x1a64 */
            ii(0xfd98, 3);    mov(ax, memw_a16[ss, bp + 0x4]);          /* mov ax, [bp+0x4] */
            ii(0xfd9b, 3);    mov(dx, memw_a16[ss, bp + 0x6]);          /* mov dx, [bp+0x6] */
            ii(0xfd9e, 3);    les(bx, ss, bp - 0x4);                    /* les bx, [bp-0x4] */
            ii(0xfda1, 4);    add(memw_a16[es, bx + 0xc], ax);          /* add [es:bx+0xc], ax */
            ii(0xfda5, 4);    adc(memw_a16[es, bx + 0xe], dx);          /* adc [es:bx+0xe], dx */
        l_0xfda9:
            ii(0xfda9, 1);    leavew();                                 /* leave */
            ii(0xfdaa, 1);    retw(); return;                           /* ret */
        }
    }
}
