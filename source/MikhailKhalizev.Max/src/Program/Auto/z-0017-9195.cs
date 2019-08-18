using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x17_9195-173a431")]
        public void Method_0017_9195()
        {
            ii(0x17_9195, 2); mov(ah, 0x40);                            /* mov ah, 0x40 */
            ii(0x17_9197, 2); if(jmpw_func(0x17_9177, -0x22)) return;   /* jmp 0x9177 */
        }
    }
}
