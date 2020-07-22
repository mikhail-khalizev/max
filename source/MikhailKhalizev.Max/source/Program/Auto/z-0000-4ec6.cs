using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x4ec6-dec33951")]
        public void Method_0000_4ec6()
        {
            ii(0x4ec6, 1);  push(bp);                                  /* push bp */
            ii(0x4ec7, 2);  mov(bp, sp);                               /* mov bp, sp */
            ii(0x4ec9, 3);  mov(ax, memw[ss, bp + 4]);                 /* mov ax, [bp+0x4] */
            ii(0x4ecc, 3);  sub(ax, 0x61);                             /* sub ax, 0x61 */
            ii(0x4ecf, 3);  cmp(ax, 0x19);                             /* cmp ax, 0x19 */
            ii(0x4ed2, 2);  if(ja(0x4edc, 8)) goto l_0x4edc;           /* ja 0x4edc */
            ii(0x4ed4, 3);  mov(ax, memw[ss, bp + 4]);                 /* mov ax, [bp+0x4] */
            ii(0x4ed7, 3);  sub(ax, 0x20);                             /* sub ax, 0x20 */
            ii(0x4eda, 1);  pop(bp);                                   /* pop bp */
            ii(0x4edb, 1);  ret(); return;                             /* ret */
        l_0x4edc:
            ii(0x4edc, 3);  mov(ax, memw[ss, bp + 4]);                 /* mov ax, [bp+0x4] */
            ii(0x4edf, 1);  pop(bp);                                   /* pop bp */
            ii(0x4ee0, 1);  ret();                                     /* ret */
        }
    }
}
