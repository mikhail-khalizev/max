using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("5612e031-5c54-42ac-bf44-783a45dd4b80")]
        public void /* sys */ Method_1018_2630()
        {
            ii(0x1018_2630, 5); mov(eax, /* sys */ 0x1018_2b48);        /* mov eax, 0x10182b48 */
            ii(0x1018_2635, 5); if(jmpd_func(0x1016_c6c8, -0x1_5f72)) return; /* jmp 0x1016c6c8 */
        }
    }
}
