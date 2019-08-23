using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x657e-fc6525ec")]
        public void Method_0000_657e()
        {
            ii(0x657e, 2);    xor(ah, ah);                              /* xor ah, ah */
            ii(0x6580, 3);    call(0x6584, 0x1);                        /* call 0x6584 */
            ii(0x6583, 1);    ret();                                    /* ret */
        }
    }
}
