using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x858e-fc6525ec")]
        public void Method_0000_858e()
        {
            ii(0x858e, 2);    xor(ah, ah);                              /* xor ah, ah */
            ii(0x8590, 3);    call(0x8594, 0x1);                        /* call 0x8594 */
            ii(0x8593, 1);    ret();                                    /* ret */
        }
    }
}
