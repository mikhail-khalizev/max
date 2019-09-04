using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x4f7d-53327d29")]
        public void Method_0000_4f7d()
        {
            ii(0x4f7d, 2);    mov(bx, sp);                              /* mov bx, sp */
            ii(0x4f7f, 4);    mov(ax, memw[ss, bx + 2]);                /* mov ax, [ss:bx+0x2] */
            ii(0x4f83, 3);    add(ax, 0x10);                            /* add ax, 0x10 */
            ii(0x4f86, 2);    rcr(ax, 1);                               /* rcr ax, 1 */
            ii(0x4f88, 2);    mov(cl, 3);                               /* mov cl, 0x3 */
            ii(0x4f8a, 2);    shr(ax, cl);                              /* shr ax, cl */
            ii(0x4f8c, 1);    ret();                                    /* ret */
        }
    }
}
