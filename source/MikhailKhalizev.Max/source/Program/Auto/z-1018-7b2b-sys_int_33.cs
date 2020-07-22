using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1018_7b2b-14fabd")]
        public void /* sys */ sys_int_33()
        {
            ii(0x1018_7b2b, 2);  @int(0x33);                           /* int 0x33 */
            ii(0x1018_7b2d, 1);  ret();                                /* ret */
        }
    }
}
