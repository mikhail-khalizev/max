using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x4aac-f51b9b96")]
        public void Method_0000_4aac()
        {
            ii(0x4aac, 1);    cli();                                    /* cli */
            ii(0x4aad, 3);    pushw(0x1026);                            /* push 0x1026 */
            ii(0x4ab0, 3);    callw(0x5038, 0x585);                     /* call 0x5038 */
            ii(0x4ab3, 1);    popw(cx);                                 /* pop cx */
            ii(0x4ab4, 1);    retw(); return;                           /* ret */
        }
    }
}
