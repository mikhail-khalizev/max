using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("d16d092b-5033-41e8-8912-d1b99efbcf8c")]
        public void Method_0000_2f36()
        {
            ii(0x2f36, 2);    @int(0x15);                               /* int 0x15 */
            ii(0x2f38, 1);    retfw(); return;                          /* retf */
        }
    }
}
