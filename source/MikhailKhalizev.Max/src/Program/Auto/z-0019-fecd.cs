using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x19_fecd-24cf0066")]
        public void Method_0019_fecd()
        {
            ii(0x19_fecd, 1); popw(ds);                                 /* pop ds */
            ii(0x19_fece, 1); leavew();                                 /* leave */
            ii(0x19_fecf, 3); retw(0x2); return;                        /* ret 0x2 */
        }
    }
}
