using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x18_e416-9e1b0cfe")]
        public void Method_0018_e416()
        {
            ii(0x18_e416, 1);  push(di);                               /* push di */
            ii(0x18_e417, 2);  push(0x16);                             /* push 0x16 */
            ii(0x18_e419, 3);  call(0x18_e868, 0x44c);                 /* call 0xe868 */
            ii(0x18_e41c, 2);  jmp_func(0x18_e3ac, -0x72);             /* jmp 0xe3ac */
        }
    }
}
