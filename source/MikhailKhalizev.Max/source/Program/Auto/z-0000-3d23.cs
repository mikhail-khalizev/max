using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x3d23-e829cd71")]
        public void Method_0000_3d23()
        {
            ii(0x3d23, 2);  outb(0x22, al);                            /* out 0x22, al */
            ii(0x3d25, 2);  mov(ah, al);                               /* mov ah, al */
            ii(0x3d27, 2);  jmp(0x3d29, 0); goto l_0x3d29;             /* jmp 0x3d29 */
        l_0x3d29:
            ii(0x3d29, 2);  inb(al, 0x23);                             /* in al, 0x23 */
            ii(0x3d2b, 1);  ret();                                     /* ret */
        }
    }
}
