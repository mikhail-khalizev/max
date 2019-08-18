using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x9d53-a96a40c1")]
        public void Method_0000_9d53()
        {
            ii(0x9d53, 1);    popw(cx);                                 /* pop cx */
            ii(0x9d54, 1);    popw(ax);                                 /* pop ax */
            ii(0x9d55, 1);    popw(ax);                                 /* pop ax */
            ii(0x9d56, 2);    if(jmpw_abs(cx)) return;                  /* jmp cx */
            ii(0x9d58, 2);    mov(bx, sp);                              /* mov bx, sp */
            ii(0x9d5a, 3);    mov(dx, memw_a16[ds, bx + 0x2]);          /* mov dx, [bx+0x2] */
            ii(0x9d5d, 3);    mov(ax, 0x3d00);                          /* mov ax, 0x3d00 */
            ii(0x9d60, 2);    @int(0x21);                               /* int 0x21 */
            ii(0x9d62, 2);    sbb(bx, bx);                              /* sbb bx, bx */
            ii(0x9d64, 2);    or(ax, bx);                               /* or ax, bx */
            ii(0x9d66, 3);    mov(memw_a16[ds, 0xe70], ax);             /* mov [0xe70], ax */
            ii(0x9d69, 1);    retw(); return;                           /* ret */
        }
    }
}
