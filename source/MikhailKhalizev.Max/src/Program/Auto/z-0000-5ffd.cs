using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x5ffd-19dc34d")]
        public void Method_0000_5ffd()
        {
            ii(0x5ffd, 3);    callw(0x6abc, 0xabc);                     /* call 0x6abc */
            ii(0x6000, 1);    retw();                                   /* ret */
        }
    }
}
