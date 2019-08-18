using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("c851f44b-964b-4cb4-8461-47cee806a447")]
        public void Method_0000_6333()
        {
            ii(0x6333, 6);    mov(memw_a16[ds, 0x11d4], 0x7);           /* mov word [0x11d4], 0x7 */
            ii(0x6339, 3);    mov(ax, 0x15);                            /* mov ax, 0x15 */
            ii(0x633c, 1);    pushw(ax);                                /* push ax */
            ii(0x633d, 3);    callw(0x589d, -0xaa3);                    /* call 0x589d */
            ii(0x6340, 1);    popw(bx);                                 /* pop bx */
            ii(0x6341, 1);    retw(); return;                           /* ret */
        }
    }
}
