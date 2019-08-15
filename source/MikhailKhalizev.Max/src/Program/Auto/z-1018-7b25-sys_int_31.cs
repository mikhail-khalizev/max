using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("8e3a4239-4697-4067-b0af-77aa3f090fa6")]
        public void /* sys */ sys_int_31()
        {
            ii(0x1018_7b25, 2); @int(0x31);                             /* int 0x31 */
            ii(0x1018_7b27, 1); retd(); return;                         /* ret */
        }
    }
}
