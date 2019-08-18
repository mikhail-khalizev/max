using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("5334d11f-8925-475a-a877-a14277a94931")]
        public void Method_0018_e2fe()
        {
            ii(0x18_e2fe, 3); callw(0x18_e070, -0x291);                 /* call 0xe070 */
            ii(0x18_e301, 2); if(jcxzw_func(0x18_e2b3, -0x50)) return;  /* jcxz 0xe2b3 */
            ii(0x18_e303, 3); mov(esi, ebx);                            /* mov esi, ebx */
            ii(0x18_e306, 3); movsd_a32();                              /* a32 movsd */
            ii(0x18_e309, 3); movsd_a32();                              /* a32 movsd */
            ii(0x18_e30c, 3); if(jmpw_func(0x18_e067, -0x2a8)) return;  /* jmp 0xe067 */
        }
    }
}
