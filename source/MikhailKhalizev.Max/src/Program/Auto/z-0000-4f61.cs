using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("04d3a470-7525-408a-a9dc-4cbb2a05193d")]
        public void Method_0000_4f61()
        {
            ii(0x4f61, 1);    pushw(cs);                                /* push cs */
            ii(0x4f62, 3);    callw(0x4b20, -0x445);                    /* call 0x4b20 */
            ii(0x4f65, 1);    sti();                                    /* sti */
            ii(0x4f66, 1);    retw(); return;                           /* ret */
        }
    }
}
