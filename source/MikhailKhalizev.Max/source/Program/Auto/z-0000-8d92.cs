using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x8d92-9928b721")]
        public void Method_0000_8d92()
        {
            ii(0x8d92, 3);  call(0xaa14, 0x1c7f);                      /* call 0xaa14 */
            ii(0x8d95, 3);  push(0x4df8);                              /* push 0x4df8 */
            ii(0x8d98, 3);  call(0x8d23, -0x78);                       /* call 0x8d23 */
            ii(0x8d9b, 1);  pop(bx);                                   /* pop bx */
            ii(0x8d9c, 1);  ret();                                     /* ret */
        }
    }
}
