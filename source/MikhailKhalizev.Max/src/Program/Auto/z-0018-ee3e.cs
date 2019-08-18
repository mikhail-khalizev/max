using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("efc9dded-0ff5-4040-8b57-84226f2b7519")]
        public void Method_0018_ee3e()
        {
            ii(0x18_ee3e, 4); mov(dx, memw_a16[ds, 0x4c]);              /* mov dx, [0x4c] */
            ii(0x18_ee42, 2); if(jmpw_func(0x18_ee6c, 0x28)) return;    /* jmp 0xee6c */
        }
    }
}
