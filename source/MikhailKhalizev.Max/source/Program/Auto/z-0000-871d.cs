using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x871d-898eae37")]
        public void Method_0000_871d()
        {
            ii(0x871d, 4);  mov(fs, memw[ds, 0xd60]);                  /* mov fs, [0xd60] */
            ii(0x8721, 4);  mov(gs, memw[ds, 0xd62]);                  /* mov gs, [0xd62] */
            ii(0x8725, 3);  jmp_func(0x6065, -0x26c3);                 /* jmp 0x6065 */
        }
    }
}
