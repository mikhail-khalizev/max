using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("215badbb-e71a-48ee-8f7d-42b0e67cd668")]
        public void Method_0014_b5a3()
        {
            ii(0x14_b5a3, 3); cmp(ah, 0x13);                            /* cmp ah, 0x13 */
            ii(0x14_b5a6, 2); if(jzw_func(0x14_b5b6, 0xe)) return;      /* jz 0xb5b6 */
            ii(0x14_b5a8, 3); cmp(ah, 0x10);                            /* cmp ah, 0x10 */
            ii(0x14_b5ab, 2); if(jzw_func(0x14_b5dc, 0x2f)) return;     /* jz 0xb5dc */
            ii(0x14_b5ad, 3); cmp(ah, 0x1c);                            /* cmp ah, 0x1c */
            ii(0x14_b5b0, 2); if(jzw_func(0x14_b5fc, 0x4a)) return;     /* jz 0xb5fc */
        }
    }
}