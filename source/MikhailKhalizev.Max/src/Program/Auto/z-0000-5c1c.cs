using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x5c1c-35bc9714")]
        public void Method_0000_5c1c()
        {
            ii(0x5c1c, 3);    call(0x5c26, 0x7);                        /* call 0x5c26 */
            ii(0x5c1f, 2);    if(jz_func(0x5c60, 0x3f)) return;         /* jz 0x5c60 */
        }
    }
}
