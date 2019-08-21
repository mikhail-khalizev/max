using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x19_5f69-86e98fd3")]
        public void Method_0019_5f69()
        {
            ii(0x19_5f69, 1); pushw(ds);                                /* push ds */
            ii(0x19_5f6a, 3); pushw(0x11ce);                            /* push 0x11ce */
            ii(0x19_5f6d, 3); callw(0x19_1066, -0x4f0a);                /* call 0x1066 */
            ii(0x19_5f70, 3); add(sp, 0x4);                             /* add sp, 0x4 */
            ii(0x19_5f73, 3); callw(0x19_55db, -0x99b);                 /* call 0x55db */
            ii(0x19_5f76, 1); popw(ds);                                 /* pop ds */
            ii(0x19_5f77, 1); popw(si);                                 /* pop si */
            ii(0x19_5f78, 1); popw(di);                                 /* pop di */
            ii(0x19_5f79, 1); leavew();                                 /* leave */
            ii(0x19_5f7a, 1); retfw(); return;                          /* retf */
        }
    }
}
