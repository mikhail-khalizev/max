using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x6f8d-53327d29")]
        public void Method_0000_6f8d()
        {
            ii(0x6f8d, 2);    mov(bx, sp);                              /* mov bx, sp */
            ii(0x6f8f, 4);    mov(ax, memw_a16[ss, bx + 0x2]);          /* mov ax, [ss:bx+0x2] */
            ii(0x6f93, 3);    add(ax, 0x10);                            /* add ax, 0x10 */
            ii(0x6f96, 2);    rcr(ax, 0x1);                             /* rcr ax, 1 */
            ii(0x6f98, 2);    mov(cl, 0x3);                             /* mov cl, 0x3 */
            ii(0x6f9a, 2);    shr(ax, cl);                              /* shr ax, cl */
            ii(0x6f9c, 1);    retw();                                   /* ret */
        }
    }
}
