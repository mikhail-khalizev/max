using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x6973-c4c7752b")]
        public void Method_0000_6973()
        {
            ii(0x6973, 2);    inb(al, 0x92);                            /* in al, 0x92 */
            ii(0x6975, 3);    and(ah, 0x2);                             /* and ah, 0x2 */
            ii(0x6978, 2);    and(al, 0xfd);                            /* and al, 0xfd */
            ii(0x697a, 2);    or(al, ah);                               /* or al, ah */
            ii(0x697c, 2);    jmpw(0x697e, 0); goto l_0x697e;           /* jmp 0x697e */
        l_0x697e:
            ii(0x697e, 2);    outb(0x92, al);                           /* out 0x92, al */
            ii(0x6980, 1);    retw();                                   /* ret */
        }
    }
}
