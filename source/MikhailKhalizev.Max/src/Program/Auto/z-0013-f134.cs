using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("880586ba-10e9-44df-a8fc-ad70c588d4f9")]
        public void Method_0013_f134()
        {
            ii(0x13_f134, 1); pushw(ds);                                /* push ds */
            ii(0x13_f135, 3); mov(ax, 0x3e68);                          /* mov ax, 0x3e68 */
            ii(0x13_f138, 2); mov(ds, ax);                              /* mov ds, ax */
            ii(0x13_f13a, 5); cmp(memw_a16[ds, 0x1412], 0x1);           /* cmp word [0x1412], 0x1 */
            ii(0x13_f13f, 2); sbb(ax, ax);                              /* sbb ax, ax */
            ii(0x13_f141, 2); neg(ax);                                  /* neg ax */
            ii(0x13_f143, 1); popw(ds);                                 /* pop ds */
            ii(0x13_f144, 1); retfw(); return;                          /* retf */
        }
    }
}
