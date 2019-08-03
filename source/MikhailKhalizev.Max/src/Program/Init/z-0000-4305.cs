using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0c724c95-244d-428e-a3c9-8fb02dc60549")]
        public void Method_0000_4305()
        {
            ii(0x4305, 1);    cli();                                    /* cli */
            ii(0x4306, 3);    pushw(0x1026);                            /* push 0x1026 */
            ii(0x4309, 3);    callw(0x4870, 0x564);                     /* call 0x4870 */
            ii(0x430c, 1);    popw(cx);                                 /* pop cx */
            ii(0x430d, 3);    pushw(0xf8a);                             /* push 0xf8a */
            ii(0x4310, 3);    callw(0x4888, 0x575);                     /* call 0x4888 */
            ii(0x4313, 1);    popw(cx);                                 /* pop cx */
            ii(0x4314, 1);    sti();                                    /* sti */
            ii(0x4315, 1);    retw(); return;                           /* ret */
        }
    }
}
