using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x8c70-decb9ce4")]
        public void Method_0000_8c70()
        {
            ii(0x8c70, 3);  call(0x863e, -0x635);                      /* call 0x863e */
            ii(0x8c73, 3);  jmp_func(0x89d0, -0x2a6);                  /* jmp 0x89d0 */
        }
    }
}
