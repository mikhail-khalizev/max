using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1016_c348-7f6f16e9")]
        public void /* sys */ Method_1016_c348()
        {
            ii(0x1016_c348, 5); mov(eax, memd[ds, 0x101c_fbdc]);        /* mov eax, [0x101cfbdc] */
            ii(0x1016_c34d, 1); ret();                                  /* ret */
        }
    }
}
