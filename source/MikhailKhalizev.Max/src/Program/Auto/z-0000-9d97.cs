using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x9d97-a72a1c9")]
        public void Method_0000_9d97()
        {
            ii(0x9d97, 3);  mov(bx, 0xffff);                           /* mov bx, 0xffff */
            ii(0x9d9a, 4);  xchg(memw[ds, 0xe70], bx);                 /* xchg [0xe70], bx */
            ii(0x9d9e, 2);  mov(ah, 0x3e);                             /* mov ah, 0x3e */
            ii(0x9da0, 2);  @int(0x21);                                /* int 0x21 */
            ii(0x9da2, 1);  ret();                                     /* ret */
        }
    }
}
