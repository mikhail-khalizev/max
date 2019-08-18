using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("1db6d1f4-545a-493a-a09d-5262fa9fb3e6")]
        public void Method_0000_4989()
        {
            ii(0x4989, 2);    inb(al, 0x92);                            /* in al, 0x92 */
            ii(0x498b, 2);    or(al, 0x2);                              /* or al, 0x2 */
            ii(0x498d, 2);    jmpw(0x498f, 0); goto l_0x498f;           /* jmp 0x498f */
        l_0x498f:
            ii(0x498f, 2);    outb(0x92, al);                           /* out 0x92, al */
            ii(0x4991, 1);    retw(); return;                           /* ret */
        }
    }
}
