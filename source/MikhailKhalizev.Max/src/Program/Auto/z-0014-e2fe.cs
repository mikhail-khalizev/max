using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("6c52edd5-870a-4ccc-9cb3-ad11d36b2fc4")]
        public void Method_0014_e2fe()
        {
            ii(0x14_e2fe, 3); callw(0x14_e070, -0x291);                 /* call 0xe070 */
            ii(0x14_e301, 2); if(jcxzw_func(0x14_e2b3, -0x50)) return;  /* jcxz 0xe2b3 */
            ii(0x14_e303, 3); mov(esi, ebx);                            /* mov esi, ebx */
        }
    }
}
