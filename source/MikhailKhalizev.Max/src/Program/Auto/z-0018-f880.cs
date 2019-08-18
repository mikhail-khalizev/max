using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("683b8573-12b7-48fb-bd85-86ebd2f44a2c")]
        public void Method_0018_f880()
        {
            ii(0x18_f880, 3); callw(0x18_fa00, 0x17d);                  /* call 0xfa00 */
            ii(0x18_f883, 1); cld();                                    /* cld */
            ii(0x18_f884, 3); callw(0x18_fa00, 0x179);                  /* call 0xfa00 */
            ii(0x18_f887, 1); std();                                    /* std */
            ii(0x18_f888, 3); callw(0x18_fa00, 0x175);                  /* call 0xfa00 */
        }
    }
}
