using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x44e4-369bb")]
        public void Method_0000_44e4()
        {
            ii(0x44e4, 2);    @int(0x15);                               /* int 0x15 */
            ii(0x44e6, 1);    retw(); return;                           /* ret */
        }
    }
}
