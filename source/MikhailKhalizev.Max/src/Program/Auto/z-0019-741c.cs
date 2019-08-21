using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x19_741c-7ecc9d3f")]
        public void Method_0019_741c()
        {
            ii(0x19_741c, 3); mov(ax, 0);                               /* mov ax, 0x0 */
            ii(0x19_741f, 3); mov(memw_a16[ss, bp - 0x56], ax);         /* mov [bp-0x56], ax */
            ii(0x19_7422, 3); mov(memw_a16[ss, bp - 0x58], ax);         /* mov [bp-0x58], ax */
            ii(0x19_7425, 3); if(jmpw_func(0x19_633b, -0x10ed)) return; /* jmp 0x633b */
        }
    }
}
