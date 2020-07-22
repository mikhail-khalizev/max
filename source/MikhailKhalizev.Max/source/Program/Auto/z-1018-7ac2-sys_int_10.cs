using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1018_7ac2-14f6fe")]
        public void /* sys */ sys_int_10()
        {
            ii(0x1018_7ac2, 2);  @int(0x10);                           /* int 0x10 */
            ii(0x1018_7ac4, 1);  ret();                                /* ret */
        }
    }
}
