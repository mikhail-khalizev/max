using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("6bb0d868-f5bc-4b54-9335-a73391012d48")]
        public void /* sys */ sys_delete()
        {
            ii(0x1016_5f64, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1016_5f66, 6); if(jnzd_func(Definitions.sys_free, 0x5155)) return; /* jnz 0x1016b0c1 */
            ii(0x1016_5f6c, 1); retd(); return;                         /* ret */
        }
    }
}
