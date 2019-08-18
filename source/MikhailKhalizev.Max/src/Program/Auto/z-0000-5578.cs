using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("701febe7-134b-4bbd-8a1c-ef51b70880fe")]
        public void Method_0000_5578()
        {
            ii(0x5578, 3);    mov(ax, 0xaac);                           /* mov ax, 0xaac */
            ii(0x557b, 1);    pushw(ax);                                /* push ax */
            ii(0x557c, 3);    callw(0x5237, -0x348);                    /* call 0x5237 */
            ii(0x557f, 1);    popw(bx);                                 /* pop bx */
            ii(0x5580, 1);    retw(); return;                           /* ret */
        }
    }
}
