using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x18_f33b-4254bff0")]
        public void Method_0018_f33b()
        {
            ii(0x18_f33b, 3); cmp(edi, ecx);                            /* cmp edi, ecx */
            ii(0x18_f33e, 2); if(jbe_func(0x18_f329, -0x17)) return;    /* jbe 0xf329 */
            ii(0x18_f340, 3); call(0x18_f356, 0x13);                    /* call 0xf356 */
        }
    }
}
