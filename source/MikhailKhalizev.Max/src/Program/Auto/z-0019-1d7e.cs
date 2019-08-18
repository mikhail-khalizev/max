using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("8b560b5c-4234-4792-b606-3a972bc8591b")]
        public void Method_0019_1d7e()
        {
            ii(0x19_1d7e, 4); les(bx, ds, 0x3ad8);                      /* les bx, [0x3ad8] */
            ii(0x19_1d82, 4); inc(memw_a16[ds, 0x3ad8]);                /* inc word [0x3ad8] */
            ii(0x19_1d86, 4); mov(memb_a16[es, bx], 0x20);              /* mov byte [es:bx], 0x20 */
        }
    }
}
