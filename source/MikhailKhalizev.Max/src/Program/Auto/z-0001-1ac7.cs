using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1_1ac7-53327d29")]
        public void Method_0001_1ac7()
        {
            ii(0x1_1ac7, 2);  mov(bx, sp);                              /* mov bx, sp */
            ii(0x1_1ac9, 4);  mov(ax, memw_a16[ss, bx + 0x2]);          /* mov ax, [ss:bx+0x2] */
            ii(0x1_1acd, 3);  add(ax, 0x10);                            /* add ax, 0x10 */
            ii(0x1_1ad0, 2);  rcr(ax, 0x1);                             /* rcr ax, 1 */
            ii(0x1_1ad2, 2);  mov(cl, 0x3);                             /* mov cl, 0x3 */
            ii(0x1_1ad4, 2);  shr(ax, cl);                              /* shr ax, cl */
            ii(0x1_1ad6, 1);  retw();                                   /* ret */
        }
    }
}
