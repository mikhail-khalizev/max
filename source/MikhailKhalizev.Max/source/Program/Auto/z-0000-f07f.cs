using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0xf07f-e64d0b8b")]
        public void Method_0000_f07f()
        {
            ii(0xf07f, 1);  push(bp);                                  /* push bp */
            ii(0xf080, 2);  mov(bp, sp);                               /* mov bp, sp */
            ii(0xf082, 3);  mov(bp, memw[ss, bp + 4]);                 /* mov bp, [bp+0x4] */
            ii(0xf085, 4);  mov(bx, memw[ds, 0x996]);                  /* mov bx, [0x996] */
            ii(0xf089, 4);  mov(memb[ds, bx + 23], 0x49);              /* mov byte [bx+0x17], 0x49 */
            ii(0xf08d, 3);  call(0xe863, -0x82d);                      /* call 0xe863 */
            ii(0xf090, 3);  mov(al, memb[ds, bx + 38]);                /* mov al, [bx+0x26] */
            ii(0xf093, 3);  and(ax, 1);                                /* and ax, 0x1 */
            ii(0xf096, 1);  pop(bp);                                   /* pop bp */
            ii(0xf097, 1);  ret();                                     /* ret */
        }
    }
}
