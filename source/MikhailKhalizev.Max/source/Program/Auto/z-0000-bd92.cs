using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0xbd92-a51eea5e")]
        public void Method_0000_bd92()
        {
            ii(0xbd92, 2);  mov(bx, sp);                               /* mov bx, sp */
            ii(0xbd94, 3);  mov(dx, memw[ds, bx + 2]);                 /* mov dx, [bx+0x2] */
            ii(0xbd97, 3);  mov(cx, memw[ds, bx + 4]);                 /* mov cx, [bx+0x4] */
            ii(0xbd9a, 4);  mov(bx, memw[ds, 0xe70]);                  /* mov bx, [0xe70] */
            ii(0xbd9e, 2);  mov(ah, 0x3f);                             /* mov ah, 0x3f */
            ii(0xbda0, 2);  @int(0x21);                                /* int 0x21 */
            ii(0xbda2, 2);  sbb(bx, bx);                               /* sbb bx, bx */
            ii(0xbda4, 2);  or(ax, bx);                                /* or ax, bx */
            ii(0xbda6, 1);  ret();                                     /* ret */
        }
    }
}
