using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("1897131a-7866-4a49-99a6-cfdb8eb90cd9")]
        public void Method_0014_efc3()
        {
            ii(0x14_efc3, 3); callw(0x14_efe8, 0x22);                   /* call 0xefe8 */
            ii(0x14_efc6, 4); add(esp, 0x6);                            /* add esp, 0x6 */
            ii(0x14_efca, 2); iretd(); return;                          /* iretd */
        }
    }
}
