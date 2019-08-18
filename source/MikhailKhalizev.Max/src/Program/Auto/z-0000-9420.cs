using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x9420-decb9ce4")]
        public void Method_0000_9420()
        {
            ii(0x9420, 3);    callw(0x8dee, -0x635);                    /* call 0x8dee */
            ii(0x9423, 3);    if(jmpw_func(0x9180, -0x2a6)) return;     /* jmp 0x9180 */
        }
    }
}
