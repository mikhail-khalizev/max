using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x18_b053-293d6fce")]
        public void Method_0018_b053()
        {
            ii(0x18_b053, 1);  pop(cx);                                /* pop cx */
            ii(0x18_b054, 1);  pop(cx);                                /* pop cx */
            ii(0x18_b055, 3);  jmp_func(0x18_a838, -0x820);            /* jmp 0xa838 */
        }
    }
}
