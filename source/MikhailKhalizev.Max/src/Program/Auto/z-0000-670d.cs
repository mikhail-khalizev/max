using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("45b00256-5dd2-4cc2-a477-c8765a980dc7")]
        public void Method_0000_670d()
        {
            ii(0x670d, 4);    mov(fs, memw_a16[ds, 0xd60]);             /* mov fs, [0xd60] */
            ii(0x6711, 4);    mov(gs, memw_a16[ds, 0xd62]);             /* mov gs, [0xd62] */
            ii(0x6715, 3);    if(jmpw_func(0x4055, -0x26c3)) return;    /* jmp 0x4055 */
        }
    }
}
