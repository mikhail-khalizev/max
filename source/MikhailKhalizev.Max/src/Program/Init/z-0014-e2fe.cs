using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("939c5aeb-4d75-4940-b026-b22b85b98276")]
        public void Method_0014_e2fe()
        {
            ii(0x14_e2fe, 3); callw(0x14_e070, -0x291);                 /* call 0xe070 */
            ii(0x14_e301, 2); jcxzw_func(0x14_e2b3, -0x50);             /* jcxz 0xe2b3 */
            ii(0x14_e303, 3); mov(esi, ebx);                            /* mov esi, ebx */
            ii(0x14_e306, 3); movsd_a32();                              /* a32 movsd */
            ii(0x14_e309, 3); movsd_a32();                              /* a32 movsd */
            ii(0x14_e30c, 3); jmpw_func(0x14_e067, -0x2a8); return;     /* jmp 0xe067 */
        }
    }
}
