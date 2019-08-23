using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x9d82-a51eea5e")]
        public void Method_0000_9d82()
        {
            ii(0x9d82, 2);    mov(bx, sp);                              /* mov bx, sp */
            ii(0x9d84, 3);    mov(dx, memw[ds, bx + 0x2]);              /* mov dx, [bx+0x2] */
            ii(0x9d87, 3);    mov(cx, memw[ds, bx + 0x4]);              /* mov cx, [bx+0x4] */
            ii(0x9d8a, 4);    mov(bx, memw[ds, 0xe70]);                 /* mov bx, [0xe70] */
            ii(0x9d8e, 2);    mov(ah, 0x3f);                            /* mov ah, 0x3f */
            ii(0x9d90, 2);    @int(0x21);                               /* int 0x21 */
            ii(0x9d92, 2);    sbb(bx, bx);                              /* sbb bx, bx */
            ii(0x9d94, 2);    or(ax, bx);                               /* or ax, bx */
            ii(0x9d96, 1);    ret();                                    /* ret */
        }
    }
}
