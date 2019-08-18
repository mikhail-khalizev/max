using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x17_f134-f5bb300c")]
        public void Method_0017_f134()
        {
            ii(0x17_f134, 1); pushw(ds);                                /* push ds */
            ii(0x17_f135, 3); mov(ax, 0x3e68);                          /* mov ax, 0x3e68 */
            ii(0x17_f138, 2); mov(ds, ax);                              /* mov ds, ax */
            ii(0x17_f13a, 5); cmp(memw_a16[ds, 0x1412], 0x1);           /* cmp word [0x1412], 0x1 */
            ii(0x17_f13f, 2); sbb(ax, ax);                              /* sbb ax, ax */
            ii(0x17_f141, 2); neg(ax);                                  /* neg ax */
            ii(0x17_f143, 1); popw(ds);                                 /* pop ds */
            ii(0x17_f144, 1); retfw(); return;                          /* retf */
        }
    }
}
