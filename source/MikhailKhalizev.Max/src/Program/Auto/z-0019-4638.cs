using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x19_4638-7db2159d")]
        public void Method_0019_4638()
        {
            ii(0x19_4638, 1); push(ds);                                 /* push ds */
            ii(0x19_4639, 3); mov(ax, 0xa8);                            /* mov ax, 0xa8 */
            ii(0x19_463c, 2); mov(ds, ax);                              /* mov ds, ax */
            ii(0x19_463e, 5); cmp(memw[ds, 0x3b72], 0x1);               /* cmp word [0x3b72], 0x1 */
            ii(0x19_4643, 2); sbb(ax, ax);                              /* sbb ax, ax */
            ii(0x19_4645, 2); neg(ax);                                  /* neg ax */
            ii(0x19_4647, 1); pop(ds);                                  /* pop ds */
            ii(0x19_4648, 1); retf();                                   /* retf */
        }
    }
}
