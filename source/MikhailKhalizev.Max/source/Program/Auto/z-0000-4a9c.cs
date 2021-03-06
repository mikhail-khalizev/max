using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x4a9c-ca213ab3")]
        public void Method_0000_4a9c()
        {
            ii(0x4a9c, 2);  mov(bx, sp);                               /* mov bx, sp */
            ii(0x4a9e, 4);  push(memw[ds, 0xac2]);                     /* push word [0xac2] */
            ii(0x4aa2, 6);  mov(memw[ds, 0xac2], 0x14c4);              /* mov word [0xac2], 0x14c4 */
            ii(0x4aa8, 4);  push(memw[ss, bx + 2]);                    /* push word [ss:bx+0x2] */
            ii(0x4aac, 3);  call(0x589d, 0xdee);                       /* call 0x589d */
            ii(0x4aaf, 1);  pop(cx);                                   /* pop cx */
            ii(0x4ab0, 4);  pop(memw[ds, 0xac2]);                      /* pop word [0xac2] */
            ii(0x4ab4, 1);  ret();                                     /* ret */
        }
    }
}
