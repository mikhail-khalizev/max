using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x95a8-c0836a26")]
        public void Method_0000_95a8()
        {
            ii(0x95a8, 2);  mov(bx, sp);                               /* mov bx, sp */
            ii(0x95aa, 3);  mov(dx, memw[ds, bx + 2]);                 /* mov dx, [bx+0x2] */
            ii(0x95ad, 3);  mov(ax, 0x3d00);                           /* mov ax, 0x3d00 */
            ii(0x95b0, 2);  @int(0x21);                                /* int 0x21 */
            ii(0x95b2, 2);  sbb(bx, bx);                               /* sbb bx, bx */
            ii(0x95b4, 2);  or(ax, bx);                                /* or ax, bx */
            ii(0x95b6, 3);  mov(memw[ds, 0xe70], ax);                  /* mov [0xe70], ax */
            ii(0x95b9, 1);  ret();                                     /* ret */
        }
    }
}
