using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0xfb97-f6cc0e92")]
        public void Method_0000_fb97()
        {
            ii(0xfb97, 2);    mov(bx, sp);                              /* mov bx, sp */
            ii(0xfb99, 4);    mov(ax, memw_a16[ss, bx + 0x2]);          /* mov ax, [ss:bx+0x2] */
            ii(0xfb9d, 4);    mov(dx, memw_a16[ss, bx + 0x4]);          /* mov dx, [ss:bx+0x4] */
            ii(0xfba1, 2);    shl(ax, 0x1);                             /* shl ax, 1 */
            ii(0xfba3, 2);    rcl(dx, 0x1);                             /* rcl dx, 1 */
            ii(0xfba5, 2);    shl(ax, 0x1);                             /* shl ax, 1 */
            ii(0xfba7, 2);    rcl(dx, 0x1);                             /* rcl dx, 1 */
            ii(0xfba9, 2);    shl(ax, 0x1);                             /* shl ax, 1 */
            ii(0xfbab, 2);    rcl(dx, 0x1);                             /* rcl dx, 1 */
            ii(0xfbad, 2);    shl(ax, 0x1);                             /* shl ax, 1 */
            ii(0xfbaf, 2);    rcl(dx, 0x1);                             /* rcl dx, 1 */
            ii(0xfbb1, 1);    retw(); return;                           /* ret */
        }
    }
}
