using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("d762701f-5e60-4c24-b1fa-634928cc06ee")]
        public void /* sys */ sys_int_16()
        {
            ii(0x1018_7ad4, 2); @int(0x16);                             /* int 0x16 */
            ii(0x1018_7ad6, 1); retd(); return;                         /* ret */
        }
    }
}
