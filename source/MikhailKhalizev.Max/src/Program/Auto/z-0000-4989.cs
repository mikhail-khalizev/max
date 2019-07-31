using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("386f30ab-2219-4f65-baee-5a40a6879fd1")]
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
