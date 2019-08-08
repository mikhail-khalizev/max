using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("999e37d4-aa55-465c-8dff-76f6a927031f")]
        public void Method_0000_5ffd()
        {
            ii(0x5ffd, 3);    callw(0x6abc, 0xabc);                     /* call 0x6abc */
            ii(0x6000, 1);    retw(); return;                           /* ret */
        }
    }
}
