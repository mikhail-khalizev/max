using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("e534dac2-4e2c-44a8-8bd6-7a98c3b95d02")]
        public void Method_0014_f880()
        {
            ii(0x14_f880, 3); callw(0x14_fa00, 0x17d);                  /* call 0xfa00 */
            ii(0x14_f883, 1); cld();                                    /* cld */
            ii(0x14_f884, 3); callw(0x14_fa00, 0x179);                  /* call 0xfa00 */
            ii(0x14_f887, 1); std();                                    /* std */
            ii(0x14_f888, 3); callw(0x14_fa00, 0x175);                  /* call 0xfa00 */
        }
    }
}
