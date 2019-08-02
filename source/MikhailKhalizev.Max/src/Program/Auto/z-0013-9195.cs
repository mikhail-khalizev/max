using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("822152aa-c4a0-4733-91c3-2360204a19eb")]
        public void Method_0013_9195()
        {
            ii(0x13_9195, 2); mov(ah, 0x40);                            /* mov ah, 0x40 */
            ii(0x13_9197, 2); jmpw_func(0x13_9177, -0x22); return;      /* jmp 0x9177 */
        }
    }
}
