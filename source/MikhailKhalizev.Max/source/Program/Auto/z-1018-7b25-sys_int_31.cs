using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1018_7b25-14faff")]
        public void /* sys */ sys_int_31()
        {
            ii(0x1018_7b25, 2);  @int(0x31);                           /* int 0x31 */
            ii(0x1018_7b27, 1);  ret();                                /* ret */
        }
    }
}
