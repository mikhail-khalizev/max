using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("a93422f5-1306-4e2e-ad05-75ec54dcba69")]
        public void /* sys */ sys_int_33()
        {
            ii(0x1018_7b2b, 2); @int(0x33);                             /* int 0x33 */
            ii(0x1018_7b2d, 1); retd(); return;                         /* ret */
        }
    }
}
