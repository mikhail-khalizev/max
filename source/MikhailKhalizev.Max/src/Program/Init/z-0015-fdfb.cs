using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("6e8b924d-0c80-40af-aa4d-3d6a9d6345d3")]
        public void Method_0015_fdfb()
        {
            ii(0x15_fdfb, 3); callw(0x15_fcea, -0x114);                 /* call 0xfcea */
            ii(0x15_fdfe, 2); or(ax, ax);                               /* or ax, ax */
            ii(0x15_fe00, 2); if(jzw(0x15_fe05, 0x3)) goto l_0x15_fe05; /* jz 0xfe05 */
            ii(0x15_fe02, 2); sub(ax, ax);                              /* sub ax, ax */
            ii(0x15_fe04, 1); retfw(); return;                          /* retf */
        l_0x15_fe05:
            ii(0x15_fe05, 2); pushw(0x4);                               /* push 0x4 */
            ii(0x15_fe07, 1); pushw(cs);                                /* push cs */
            ii(0x15_fe08, 3); callw(0x15_fd12, -0xf9);                  /* call 0xfd12 */
            ii(0x15_fe0b, 1); retfw(); return;                          /* retf */
        }
    }
}
