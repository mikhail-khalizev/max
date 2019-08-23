using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1018_f204-13dbcb")]
        public void /* sys_mve */ Method_1018_f204()
        {
            ii(0x1018_f204, 3); mov(eax, memd[ss, esp]);                /* mov eax, [esp] */
        }
    }
}
