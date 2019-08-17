using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("d77b4281-9186-4f19-bd6a-47215d1a7a69")]
        public void Method_0000_5c1c()
        {
            ii(0x5c1c, 3);    callw(0x5c26, 0x7);                       /* call 0x5c26 */
            ii(0x5c1f, 2);    if(jzw_func(0x5c60, 0x3f)) return;        /* jz 0x5c60 */
        }
    }
}
