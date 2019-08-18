using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("917d4450-eefd-4f02-8107-7ccc055735e3")]
        public void Method_0018_a40b()
        {
            ii(0x18_a40b, 3); callw(0x18_bd02, 0x18f4);                 /* call 0xbd02 */
            ii(0x18_a40e, 3); mov(memw_a16[ss, bp + 0x12], dx);         /* mov [bp+0x12], dx */
            ii(0x18_a411, 1); retw(); return;                           /* ret */
        }
    }
}
