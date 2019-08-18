using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("12e800cb-da62-4c61-8981-1a339fe3a770")]
        public void /* sys */ Method_1016_c348()
        {
            ii(0x1016_c348, 5); mov(eax, memd_a32[ds, 0x101c_fbdc]);    /* mov eax, [0x101cfbdc] */
            ii(0x1016_c34d, 1); retd(); return;                         /* ret */
        }
    }
}
