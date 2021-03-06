using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x4971-1e98f8c3")]
        public void Method_0000_4971()
        {
            ii(0x4971, 3);  call(0x49c8, 0x54);                        /* call 0x49c8 */
            ii(0x4974, 2);  mov(al, 0xd1);                             /* mov al, 0xd1 */
            ii(0x4976, 2);  outb(0x64, al);                            /* out 0x64, al */
            ii(0x4978, 3);  call(0x49c8, 0x4d);                        /* call 0x49c8 */
            ii(0x497b, 2);  xchg(ah, al);                              /* xchg ah, al */
            ii(0x497d, 2);  outb(0x60, al);                            /* out 0x60, al */
            ii(0x497f, 3);  call(0x49c8, 0x46);                        /* call 0x49c8 */
            ii(0x4982, 1);  ret();                                     /* ret */
        }
    }
}
