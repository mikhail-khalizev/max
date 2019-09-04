using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x95ba-b5eb8f7")]
        public void Method_0000_95ba()
        {
            ii(0x95ba, 2);    mov(bx, sp);                              /* mov bx, sp */
            ii(0x95bc, 3);    mov(dx, memw[ds, bx + 2]);                /* mov dx, [bx+0x2] */
            ii(0x95bf, 3);    mov(cx, memw[ds, bx + 4]);                /* mov cx, [bx+0x4] */
            ii(0x95c2, 4);    mov(bx, memw[ds, 0xe70]);                 /* mov bx, [0xe70] */
            ii(0x95c6, 3);    mov(ax, 0x4200);                          /* mov ax, 0x4200 */
            ii(0x95c9, 2);    @int(0x21);                               /* int 0x21 */
            ii(0x95cb, 2);    sbb(bx, bx);                              /* sbb bx, bx */
            ii(0x95cd, 2);    or(ax, bx);                               /* or ax, bx */
            ii(0x95cf, 2);    or(dx, bx);                               /* or dx, bx */
            ii(0x95d1, 1);    ret();                                    /* ret */
        }
    }
}
