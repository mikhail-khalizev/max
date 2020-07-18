using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x18_a366-bc1e3900")]
        public void Method_0018_a366()
        {
            ii(0x18_a366, 2);  pushfd();                               /* pushfd */
            ii(0x18_a368, 2);  pushd(cs);                              /* o32 push cs */
            ii(0x18_a36a, 2);  push(0);                                /* push 0x0 */
            ii(0x18_a36c, 3);  call(0x18_a7be, 0x44f);                 /* call 0xa7be */
            ii(0x18_a36f, 1);  retf();                                 /* retf */
        }
    }
}
