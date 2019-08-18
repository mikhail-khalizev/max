using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("09f9456f-3601-461a-8aa9-7bf73396fd50")]
        public void Method_0000_85e2()
        {
            ii(0x85e2, 3);    callw(0xa264, 0x1c7f);                    /* call 0xa264 */
            ii(0x85e5, 3);    pushw(0x4df8);                            /* push 0x4df8 */
            ii(0x85e8, 3);    callw(0x8573, -0x78);                     /* call 0x8573 */
            ii(0x85eb, 1);    popw(bx);                                 /* pop bx */
            ii(0x85ec, 1);    retw(); return;                           /* ret */
        }
    }
}
