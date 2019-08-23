using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x19_0534-174e522")]
        public void Method_0019_0534()
        {
            ii(0x19_0534, 3); mov(ax, 0x1);                             /* mov ax, 0x1 */
            ii(0x19_0537, 1); retfw();                                  /* retf */
        }
    }
}
