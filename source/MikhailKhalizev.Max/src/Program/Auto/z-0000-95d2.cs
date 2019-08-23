using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x95d2-a51eea5e")]
        public void Method_0000_95d2()
        {
            ii(0x95d2, 2);    mov(bx, sp);                              /* mov bx, sp */
            ii(0x95d4, 3);    mov(dx, memw[ds, bx + 0x2]);              /* mov dx, [bx+0x2] */
            ii(0x95d7, 3);    mov(cx, memw[ds, bx + 0x4]);              /* mov cx, [bx+0x4] */
            ii(0x95da, 4);    mov(bx, memw[ds, 0xe70]);                 /* mov bx, [0xe70] */
            ii(0x95de, 2);    mov(ah, 0x3f);                            /* mov ah, 0x3f */
            ii(0x95e0, 2);    @int(0x21);                               /* int 0x21 */
            ii(0x95e2, 2);    sbb(bx, bx);                              /* sbb bx, bx */
            ii(0x95e4, 2);    or(ax, bx);                               /* or ax, bx */
            ii(0x95e6, 1);    ret();                                    /* ret */
        }
    }
}
