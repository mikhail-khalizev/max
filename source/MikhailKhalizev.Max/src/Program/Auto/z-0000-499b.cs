using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x499b-3f14dd03")]
        public void Method_0000_499b()
        {
            ii(0x499b, 2);    inb(al, 0x92);                            /* in al, 0x92 */
            ii(0x499d, 2);    and(al, 0xfd);                            /* and al, 0xfd */
            ii(0x499f, 2);    jmp(0x49a1, 0); goto l_0x49a1;            /* jmp 0x49a1 */
        l_0x49a1:
            ii(0x49a1, 2);    outb(0x92, al);                           /* out 0x92, al */
            ii(0x49a3, 1);    ret();                                    /* ret */
        }
    }
}
