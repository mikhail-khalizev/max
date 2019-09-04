using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x19_1af0-4828907e")]
        public void Method_0019_1af0()
        {
            ii(0x19_1af0, 4);  enter(2, 0);                            /* enter 0x2, 0x0 */
            ii(0x19_1af4, 1);  push(ds);                               /* push ds */
            ii(0x19_1af5, 3);  mov(ax, 0xa8);                          /* mov ax, 0xa8 */
            ii(0x19_1af8, 2);  mov(ds, ax);                            /* mov ds, ax */
            ii(0x19_1afa, 3);  mov(bx, memw[ss, bp + 8]);              /* mov bx, [bp+0x8] */
            ii(0x19_1afd, 2);  shl(bx, 1);                             /* shl bx, 1 */
            ii(0x19_1aff, 4);  mov(ax, memw[ds, bx + 0x3a3a]);         /* mov ax, [bx+0x3a3a] */
            ii(0x19_1b03, 3);  mov(memw[ss, bp - 2], ax);              /* mov [bp-0x2], ax */
            ii(0x19_1b06, 3);  mov(ax, memw[ss, bp + 6]);              /* mov ax, [bp+0x6] */
            ii(0x19_1b09, 4);  mov(memw[ds, bx + 0x3a3a], ax);         /* mov [bx+0x3a3a], ax */
            ii(0x19_1b0d, 3);  mov(ax, memw[ss, bp - 2]);              /* mov ax, [bp-0x2] */
            ii(0x19_1b10, 1);  pop(ds);                                /* pop ds */
            ii(0x19_1b11, 1);  leave();                                /* leave */
            ii(0x19_1b12, 3);  retf(4);                                /* retf 0x4 */
        }
    }
}
