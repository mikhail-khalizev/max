using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("8e09e101-119c-4b46-857c-46569620b479")]
        public void Method_0000_6abc()
        {
            ii(0x6abc, 1);    cli();                                    /* cli */
            ii(0x6abd, 3);    pushw(0x1026);                            /* push 0x1026 */
            ii(0x6ac0, 3);    callw(0x7048, 0x585);                     /* call 0x7048 */
            ii(0x6ac3, 1);    popw(cx);                                 /* pop cx */
            ii(0x6ac4, 1);    retw(); return;                           /* ret */
        }
    }
}
