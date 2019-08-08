using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("837f5657-62cd-47ff-b415-defa29a05063")]
        public void Method_0014_acf3()
        {
            ii(0x14_acf3, 1); pushw(ds);                                /* push ds */
            ii(0x14_acf4, 2); pushw(0x48);                              /* push 0x48 */
            ii(0x14_acf6, 1); popw(ds);                                 /* pop ds */
            ii(0x14_acf7, 4); mov(memw_a16[ds, 0x1060], dx);            /* mov [0x1060], dx */
            ii(0x14_acfb, 4); mov(memw_a16[ds, 0x1062], cx);            /* mov [0x1062], cx */
            ii(0x14_acff, 1); popw(ds);                                 /* pop ds */
            ii(0x14_ad00, 1); retw(); return;                           /* ret */
        }
    }
}
