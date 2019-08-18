using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("293fabf2-cd6d-4dd2-817d-3d9ecaa9211c")]
        public void Method_0000_bd92()
        {
            ii(0xbd92, 2);    mov(bx, sp);                              /* mov bx, sp */
            ii(0xbd94, 3);    mov(dx, memw_a16[ds, bx + 0x2]);          /* mov dx, [bx+0x2] */
            ii(0xbd97, 3);    mov(cx, memw_a16[ds, bx + 0x4]);          /* mov cx, [bx+0x4] */
            ii(0xbd9a, 4);    mov(bx, memw_a16[ds, 0xe70]);             /* mov bx, [0xe70] */
            ii(0xbd9e, 2);    mov(ah, 0x3f);                            /* mov ah, 0x3f */
            ii(0xbda0, 2);    @int(0x21);                               /* int 0x21 */
            ii(0xbda2, 2);    sbb(bx, bx);                              /* sbb bx, bx */
            ii(0xbda4, 2);    or(ax, bx);                               /* or ax, bx */
            ii(0xbda6, 1);    retw(); return;                           /* ret */
        }
    }
}
