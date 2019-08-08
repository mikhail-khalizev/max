using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("9bf434d7-6c38-456d-b852-8ce6ab43b1c7")]
        public void Method_1012_2a18()
        {
            ii(0x1012_2a18, 5); calld(0x1011_6ba6, -0xbe77);            /* call 0x10116ba6 */
            ii(0x1012_2a1d, 5); if(jmpd_func(0x1012_31ce, 0x7ac)) return; /* jmp 0x101231ce */
        }
    }
}
