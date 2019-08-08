using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("49b2a0c9-4509-4bfe-b033-a4c076203f96")]
        public void Method_0014_a40b()
        {
            ii(0x14_a40b, 3); callw(0x14_bd02, 0x18f4);                 /* call 0xbd02 */
            ii(0x14_a40e, 3); mov(memw_a16[ss, bp + 0x12], dx);         /* mov [bp+0x12], dx */
            ii(0x14_a411, 1); retw(); return;                           /* ret */
        }
    }
}
