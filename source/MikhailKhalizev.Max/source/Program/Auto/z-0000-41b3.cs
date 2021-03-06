using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x41b3-c4c7752b")]
        public void Method_0000_41b3()
        {
            ii(0x41b3, 2);  inb(al, 0x92);                             /* in al, 0x92 */
            ii(0x41b5, 3);  and(ah, 2);                                /* and ah, 0x2 */
            ii(0x41b8, 2);  and(al, 0xfd);                             /* and al, 0xfd */
            ii(0x41ba, 2);  or(al, ah);                                /* or al, ah */
            ii(0x41bc, 2);  jmp(0x41be, 0); goto l_0x41be;             /* jmp 0x41be */
        l_0x41be:
            ii(0x41be, 2);  outb(0x92, al);                            /* out 0x92, al */
            ii(0x41c0, 1);  ret();                                     /* ret */
        }
    }
}
