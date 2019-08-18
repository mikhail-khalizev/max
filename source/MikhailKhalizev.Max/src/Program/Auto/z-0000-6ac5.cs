using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x6ac5-c7b24c10")]
        public void Method_0000_6ac5()
        {
            ii(0x6ac5, 1);    cli();                                    /* cli */
            ii(0x6ac6, 3);    pushw(0x1026);                            /* push 0x1026 */
            ii(0x6ac9, 3);    callw(0x7030, 0x564);                     /* call 0x7030 */
            ii(0x6acc, 1);    popw(cx);                                 /* pop cx */
            ii(0x6acd, 3);    pushw(0xf8a);                             /* push 0xf8a */
            ii(0x6ad0, 3);    callw(0x7048, 0x575);                     /* call 0x7048 */
            ii(0x6ad3, 1);    popw(cx);                                 /* pop cx */
            ii(0x6ad4, 1);    sti();                                    /* sti */
            ii(0x6ad5, 1);    retw(); return;                           /* ret */
        }
    }
}
