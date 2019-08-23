using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x18_c004-f99da11a")]
        public void Method_0018_c004()
        {
            ii(0x18_c004, 1); pushw(bp);                                /* push bp */
            ii(0x18_c005, 2); mov(bp, sp);                              /* mov bp, sp */
            ii(0x18_c007, 3); mov(ax, memw_a16[ss, bp + 0x4]);          /* mov ax, [bp+0x4] */
            ii(0x18_c00a, 2); @int(0x15);                               /* int 0x15 */
            ii(0x18_c00c, 1); leavew();                                 /* leave */
            ii(0x18_c00d, 3); retw(0x2);                                /* ret 0x2 */
        }
    }
}
