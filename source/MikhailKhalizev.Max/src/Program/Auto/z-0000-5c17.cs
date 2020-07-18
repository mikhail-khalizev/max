using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x5c17-35b67718")]
        public void Method_0000_5c17()
        {
            ii(0x5c17, 3);  call(0x5c26, 0xc);                         /* call 0x5c26 */
            ii(0x5c1a, 2);  mov(bl, 0x3f);                             /* mov bl, 0x3f */
        }
    }
}
