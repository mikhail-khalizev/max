using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x6999-53da8bf4")]
        public void Method_0000_6999()
        {
            ii(0x6999, 2);    inb(al, 0x92);                            /* in al, 0x92 */
            ii(0x699b, 2);    or(al, 0x2);                              /* or al, 0x2 */
            ii(0x699d, 2);    jmpw(0x699f, 0); goto l_0x699f;           /* jmp 0x699f */
        l_0x699f:
            ii(0x699f, 2);    outb(0x92, al);                           /* out 0x92, al */
            ii(0x69a1, 1);    retw(); return;                           /* ret */
        }
    }
}
