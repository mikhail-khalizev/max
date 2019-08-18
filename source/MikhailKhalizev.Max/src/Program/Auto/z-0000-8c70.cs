using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("1828a0a7-73e3-4f8b-b89a-b1b2454d7470")]
        public void Method_0000_8c70()
        {
            ii(0x8c70, 3);    callw(0x863e, -0x635);                    /* call 0x863e */
            ii(0x8c73, 3);    if(jmpw_func(0x89d0, -0x2a6)) return;     /* jmp 0x89d0 */
        }
    }
}
