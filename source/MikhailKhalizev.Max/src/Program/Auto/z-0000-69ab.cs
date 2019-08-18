using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x69ab-3f14dd03")]
        public void Method_0000_69ab()
        {
            ii(0x69ab, 2);    inb(al, 0x92);                            /* in al, 0x92 */
            ii(0x69ad, 2);    and(al, 0xfd);                            /* and al, 0xfd */
            ii(0x69af, 2);    jmpw(0x69b1, 0); goto l_0x69b1;           /* jmp 0x69b1 */
        l_0x69b1:
            ii(0x69b1, 2);    outb(0x92, al);                           /* out 0x92, al */
            ii(0x69b3, 1);    retw(); return;                           /* ret */
        }
    }
}
