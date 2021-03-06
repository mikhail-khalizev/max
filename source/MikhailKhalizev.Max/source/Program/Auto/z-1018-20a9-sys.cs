using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1018_20a9-771ba1f5")]
        public void /* sys */ Method_1018_20a9()
        {
            ii(0x1018_20a9, 6);  lea(ecx, memd[ds, /* sys */ 0x1019_6c4c]);/* lea ecx, [0x10196c4c] */
            ii(0x1018_20af, 3);  mov(dx, cs);                          /* mov dx, cs */
            ii(0x1018_20b2, 3);  shl(edx, 0x10);                       /* shl edx, 0x10 */
            ii(0x1018_20b5, 3);  mov(dx, cx);                          /* mov dx, cx */
            ii(0x1018_20b8, 3);  mov(cx, cs);                          /* mov cx, cs */
            ii(0x1018_20bb, 3);  and(cl, 3);                           /* and cl, 0x3 */
            ii(0x1018_20be, 4);  shl(cx, 0xd);                         /* shl cx, 0xd */
            ii(0x1018_20c2, 3);  or(ch, 0x8e);                         /* or ch, 0x8e */
            ii(0x1018_20c5, 1);  ret();                                /* ret */
        }
    }
}
