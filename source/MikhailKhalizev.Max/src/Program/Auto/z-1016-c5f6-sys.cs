using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1016_c5f6-575018d1")]
        public void /* sys */ Method_1016_c5f6()
        {
            ii(0x1016_c5f6, 4); fld(memq[ss, esp + 0xc]);               /* fld qword [esp+0xc] */
            ii(0x1016_c5fa, 4); fld(memq[ss, esp + 0x4]);               /* fld qword [esp+0x4] */
            ii(0x1016_c5fe, 5); call(/* sys */ 0x1016_c4a0, -0x163);    /* call 0x1016c4a0 */
            ii(0x1016_c603, 3); ret(0x10);                              /* ret 0x10 */
        }
    }
}
