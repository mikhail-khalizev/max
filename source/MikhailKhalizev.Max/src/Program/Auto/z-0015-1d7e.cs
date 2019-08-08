using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("1f798497-e3b9-4d58-ad27-239c137d725d")]
        public void Method_0015_1d7e()
        {
            ii(0x15_1d7e, 4); les(bx, ds, 0x3ad8);                      /* les bx, [0x3ad8] */
            ii(0x15_1d82, 4); inc(memw_a16[ds, 0x3ad8]);                /* inc word [0x3ad8] */
            ii(0x15_1d86, 4); mov(memb_a16[es, bx], 0x20);              /* mov byte [es:bx], 0x20 */
        }
    }
}
