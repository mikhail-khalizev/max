using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x18_efc3-d34eead4")]
        public void Method_0018_efc3()
        {
            ii(0x18_efc3, 3); callw(0x18_efe8, 0x22);                   /* call 0xefe8 */
            ii(0x18_efc6, 4); add(esp, 0x6);                            /* add esp, 0x6 */
            ii(0x18_efca, 2); iretd(); return;                          /* iretd */
        }
    }
}
