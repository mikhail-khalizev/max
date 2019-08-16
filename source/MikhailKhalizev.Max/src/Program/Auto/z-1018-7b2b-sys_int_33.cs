using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("8408fe60-31a1-485c-af2b-204a3e9cccf4")]
        public void /* sys */ sys_int_33()
        {
            ii(0x1018_7b2b, 2); @int(0x33);                             /* int 0x33 */
            ii(0x1018_7b2d, 1); retd(); return;                         /* ret */
        }
    }
}
