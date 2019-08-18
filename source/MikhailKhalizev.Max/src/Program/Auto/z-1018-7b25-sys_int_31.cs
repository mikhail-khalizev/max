using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("55defc30-b1c2-4061-b368-69c6c9c4e149")]
        public void /* sys */ sys_int_31()
        {
            ii(0x1018_7b25, 2); @int(0x31);                             /* int 0x31 */
            ii(0x1018_7b27, 1); retd(); return;                         /* ret */
        }
    }
}
