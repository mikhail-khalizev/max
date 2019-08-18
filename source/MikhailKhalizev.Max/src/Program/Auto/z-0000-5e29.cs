using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("19e01479-5d18-41b8-b6bd-0d71a50a853c")]
        public void Method_0000_5e29()
        {
            ii(0x5e29, 3);    callw(0x46cc, -0x1760);                   /* call 0x46cc */
            ii(0x5e2c, 1);    retw(); return;                           /* ret */
        }
    }
}
