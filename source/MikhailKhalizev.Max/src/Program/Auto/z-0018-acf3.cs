using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("3b992b92-219b-4bcd-985c-51716bda907b")]
        public void Method_0018_acf3()
        {
            ii(0x18_acf3, 1); pushw(ds);                                /* push ds */
            ii(0x18_acf4, 2); pushw(0x48);                              /* push 0x48 */
            ii(0x18_acf6, 1); popw(ds);                                 /* pop ds */
            ii(0x18_acf7, 4); mov(memw_a16[ds, 0x1060], dx);            /* mov [0x1060], dx */
            ii(0x18_acfb, 4); mov(memw_a16[ds, 0x1062], cx);            /* mov [0x1062], cx */
            ii(0x18_acff, 1); popw(ds);                                 /* pop ds */
            ii(0x18_ad00, 1); retw(); return;                           /* ret */
        }
    }
}
