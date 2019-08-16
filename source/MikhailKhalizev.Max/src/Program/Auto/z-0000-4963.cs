using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("6fd9b5e0-9eff-4f24-a90c-c6b686293ed6")]
        public void Method_0000_4963()
        {
            ii(0x4963, 2);    inb(al, 0x92);                            /* in al, 0x92 */
            ii(0x4965, 3);    and(ah, 0x2);                             /* and ah, 0x2 */
            ii(0x4968, 2);    and(al, 0xfd);                            /* and al, 0xfd */
            ii(0x496a, 2);    or(al, ah);                               /* or al, ah */
            ii(0x496c, 2);    jmpw(0x496e, 0); goto l_0x496e;           /* jmp 0x496e */
        l_0x496e:
            ii(0x496e, 2);    outb(0x92, al);                           /* out 0x92, al */
            ii(0x4970, 1);    retw(); return;                           /* ret */
        }
    }
}
