using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x19_3ab8-325ab0c1")]
        public void Method_0019_3ab8()
        {
            ii(0x19_3ab8, 3); mov(ax, 2);                               /* mov ax, 0x2 */
            ii(0x19_3abb, 3); if(jmp_func(0x19_2203, -0x18bb)) return;  /* jmp 0x2203 */
        }
    }
}
