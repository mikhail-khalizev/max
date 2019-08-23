using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1016_ca48-70ba0b9")]
        public void /* sys */ Method_1016_ca48()
        {
            ii(0x1016_ca48, 5); mov(memd_a32[ds, 0x1020_8580], eax);    /* mov [0x10208580], eax */
            ii(0x1016_ca4d, 6); mov(memd_a32[ds, 0x1020_857c], edx);    /* mov [0x1020857c], edx */
            ii(0x1016_ca53, 6); mov(memd_a32[ds, 0x1020_8578], ebx);    /* mov [0x10208578], ebx */
            ii(0x1016_ca59, 1); retd();                                 /* ret */
        }
    }
}
