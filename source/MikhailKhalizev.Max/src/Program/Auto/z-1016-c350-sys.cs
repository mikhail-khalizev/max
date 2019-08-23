using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1016_c350-79d243a5")]
        public void /* sys */ Method_1016_c350()
        {
            ii(0x1016_c350, 5); mov(eax, memd_a32[ds, 0x101c_fb90]);    /* mov eax, [0x101cfb90] */
            ii(0x1016_c355, 1); retd();                                 /* ret */
        }
    }
}
