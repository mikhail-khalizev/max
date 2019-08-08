using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("c5e33e3f-d749-4599-9c9f-c586ee43dc3b")]
        public void Method_0014_a42e()
        {
            ii(0x14_a42e, 1); popw(cx);                                 /* pop cx */
            ii(0x14_a42f, 2); or(ax, ax);                               /* or ax, ax */
            ii(0x14_a431, 2); if(jzw_func(0x14_a3f7, -0x3c)) return;    /* jz 0xa3f7 */
            ii(0x14_a433, 1); retw(); return;                           /* ret */
        }
    }
}
