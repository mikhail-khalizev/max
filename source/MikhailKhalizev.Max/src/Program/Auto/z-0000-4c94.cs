using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x4c94-369bb")]
        public void Method_0000_4c94()
        {
            ii(0x4c94, 2);    @int(0x15);                               /* int 0x15 */
            ii(0x4c96, 1);    retw(); return;                           /* ret */
        }
    }
}
