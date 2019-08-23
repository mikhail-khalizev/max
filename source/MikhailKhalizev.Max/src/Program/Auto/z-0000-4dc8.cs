using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x4dc8-95f6284a")]
        public void Method_0000_4dc8()
        {
            ii(0x4dc8, 3);    mov(ax, 0xaac);                           /* mov ax, 0xaac */
            ii(0x4dcb, 1);    pushw(ax);                                /* push ax */
            ii(0x4dcc, 3);    callw(0x4a87, -0x348);                    /* call 0x4a87 */
            ii(0x4dcf, 1);    popw(bx);                                 /* pop bx */
            ii(0x4dd0, 1);    retw();                                   /* ret */
        }
    }
}
