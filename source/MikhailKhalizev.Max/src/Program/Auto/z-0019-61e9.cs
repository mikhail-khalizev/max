using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x19_61e9-7199083e")]
        public void Method_0019_61e9()
        {
            ii(0x19_61e9, 3); add(sp, 0x2);                             /* add sp, 0x2 */
            ii(0x19_61ec, 1); popw(si);                                 /* pop si */
            ii(0x19_61ed, 1); popw(di);                                 /* pop di */
            ii(0x19_61ee, 1); leavew();                                 /* leave */
            ii(0x19_61ef, 1); retw(); return;                           /* ret */
        }
    }
}
