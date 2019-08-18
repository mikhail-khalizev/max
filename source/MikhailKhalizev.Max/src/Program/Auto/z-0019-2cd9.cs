using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("741f8ac3-ee15-4e7d-b652-6d9d6386348a")]
        public void Method_0019_2cd9()
        {
            ii(0x19_2cd9, 2); if(jaew(0x19_2ce2, 0x7)) goto l_0x19_2ce2; /* jae 0x2ce2 */
            ii(0x19_2cdb, 3); callw(0x19_2cec, 0xe);                    /* call 0x2cec */
            ii(0x19_2cde, 3); mov(ax, 0xffff);                          /* mov ax, 0xffff */
            ii(0x19_2ce1, 1); cwd();                                    /* cwd */
        l_0x19_2ce2:
            ii(0x19_2ce2, 2); mov(sp, bp);                              /* mov sp, bp */
            ii(0x19_2ce4, 1); popw(bp);                                 /* pop bp */
            ii(0x19_2ce5, 1); retfw(); return;                          /* retf */
        }
    }
}
