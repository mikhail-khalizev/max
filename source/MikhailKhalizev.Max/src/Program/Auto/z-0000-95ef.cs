using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x95ef-f710f8c8")]
        public void Method_0000_95ef()
        {
            ii(0x95ef, 2);    mov(sp, bp);                              /* mov sp, bp */
            ii(0x95f1, 1);    popw(bp);                                 /* pop bp */
            ii(0x95f2, 1);    popw(di);                                 /* pop di */
            ii(0x95f3, 1);    popw(si);                                 /* pop si */
            ii(0x95f4, 1);    popw(cx);                                 /* pop cx */
            ii(0x95f5, 1);    popw(bx);                                 /* pop bx */
            ii(0x95f6, 1);    retw(); return;                           /* ret */
        }
    }
}
