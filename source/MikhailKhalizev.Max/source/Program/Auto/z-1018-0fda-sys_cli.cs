using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1018_0fda-a0d9")]
        public void /* sys */ sys_cli()
        {
            ii(0x1018_0fda, 1);  cli();                                /* cli */
            ii(0x1018_0fdb, 1);  ret();                                /* ret */
        }
    }
}
