using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1018_0fdc-a0f8")]
        public void /* sys */ sys_sti()
        {
            ii(0x1018_0fdc, 1); sti();                                  /* sti */
            ii(0x1018_0fdd, 1); ret();                                  /* ret */
        }
    }
}
