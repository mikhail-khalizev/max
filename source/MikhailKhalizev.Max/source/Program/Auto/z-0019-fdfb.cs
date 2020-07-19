using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x19_fdfb-3c21614d")]
        public void Method_0019_fdfb()
        {
            ii(0x19_fdfb, 3);  call(0x19_fcea, -0x114);                /* call 0xfcea */
            ii(0x19_fdfe, 2);  or(ax, ax);                             /* or ax, ax */
            ii(0x19_fe00, 2);  if(jz(0x19_fe05, 3)) goto l_0x19_fe05;  /* jz 0xfe05 */
            ii(0x19_fe02, 2);  sub(ax, ax);                            /* sub ax, ax */
            ii(0x19_fe04, 1);  retf(); return;                         /* retf */
        l_0x19_fe05:
            ii(0x19_fe05, 2);  push(4);                                /* push 0x4 */
            ii(0x19_fe07, 1);  push(cs);                               /* push cs */
            ii(0x19_fe08, 3);  call(0x19_fd12, -0xf9);                 /* call 0xfd12 */
            ii(0x19_fe0b, 1);  retf();                                 /* retf */
        }
    }
}
