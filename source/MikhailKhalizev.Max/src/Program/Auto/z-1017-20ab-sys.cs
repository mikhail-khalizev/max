using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("83bf5aa4-5db9-4206-9aa7-de39f01137e7")]
        public void /* sys */ Method_1017_20ab()
        {
            ii(0x1017_20ab, 3); add(eax, 0x30);                         /* add eax, 0x30 */
            ii(0x1017_20ae, 3); cmp(eax, 0x39);                         /* cmp eax, 0x39 */
            ii(0x1017_20b1, 2); if(jled(0x1017_20b6, 0x3)) goto l_0x1017_20b6; /* jle 0x101720b6 */
            ii(0x1017_20b3, 3); add(eax, 0x27);                         /* add eax, 0x27 */
        l_0x1017_20b6:
            ii(0x1017_20b6, 1); retd(); return;                         /* ret */
        }
    }
}
