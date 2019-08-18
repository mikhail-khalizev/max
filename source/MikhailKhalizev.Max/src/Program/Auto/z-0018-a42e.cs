using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x18_a42e-53f8e851")]
        public void Method_0018_a42e()
        {
            ii(0x18_a42e, 1); popw(cx);                                 /* pop cx */
            ii(0x18_a42f, 2); or(ax, ax);                               /* or ax, ax */
            ii(0x18_a431, 2); if(jzw_func(0x18_a3f7, -0x3c)) return;    /* jz 0xa3f7 */
            ii(0x18_a433, 1); retw(); return;                           /* ret */
        }
    }
}
