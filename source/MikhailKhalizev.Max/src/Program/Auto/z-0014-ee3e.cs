using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("5226c1d0-82ed-4576-a53c-0a256dfa7220")]
        public void Method_0014_ee3e()
        {
            ii(0x14_ee3e, 4); mov(dx, memw_a16[ds, 0x4c]);              /* mov dx, [0x4c] */
            ii(0x14_ee42, 2); jmpw_func(0x14_ee6c, 0x28); return;       /* jmp 0xee6c */
        }
    }
}
