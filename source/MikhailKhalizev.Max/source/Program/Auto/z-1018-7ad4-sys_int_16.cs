using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1018_7ad4-14f538")]
        public void /* sys */ sys_int_16()
        {
            ii(0x1018_7ad4, 2);  @int(0x16);                           /* int 0x16 */
            ii(0x1018_7ad6, 1);  ret();                                /* ret */
        }
    }
}
