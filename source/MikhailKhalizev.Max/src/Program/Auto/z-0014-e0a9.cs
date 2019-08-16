using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("f24bd2e0-754f-43a0-93c2-e6b3df50b573")]
        public void Method_0014_e0a9()
        {
            ii(0x14_e0a9, 4); mov(si, memw_a32[ss, ebp + 0x1c]);        /* mov si, [ebp+0x1c] */
            ii(0x14_e0ad, 2); or(si, si);                               /* or si, si */
            ii(0x14_e0af, 2); if(jlew_func(0x14_e062, -0x4f)) return;   /* jle 0xe062 */
            ii(0x14_e0b1, 3); pushw(0x4547);                            /* push 0x4547 */
        }
    }
}
