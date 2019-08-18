using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x2f36-369b3")]
        public void Method_0000_2f36()
        {
            ii(0x2f36, 2);    @int(0x15);                               /* int 0x15 */
            ii(0x2f38, 1);    retfw(); return;                          /* retf */
        }
    }
}
