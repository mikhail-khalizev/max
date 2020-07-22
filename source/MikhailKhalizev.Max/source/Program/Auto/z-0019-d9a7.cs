using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x19_d9a7-43300879")]
        public void Method_0019_d9a7()
        {
            ii(0x19_d9a7, 1);  push(bp);                               /* push bp */
            ii(0x19_d9a8, 2);  mov(bp, sp);                            /* mov bp, sp */
            ii(0x19_d9aa, 3);  mov(ax, 0x506);                         /* mov ax, 0x506 */
        }
    }
}
