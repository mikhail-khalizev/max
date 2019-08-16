using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("d2f5efdd-5f97-43e4-abf6-ffaa3d9137cb")]
        public void Method_0013_d8bb_v2()
        {
            ii(0x13_d8bb, 2); if(jaew(0x13_d8c4, 0x7)) goto l_0x13_d8c4; /* jae 0x2ce2 */
            ii(0x13_d8bd, 3); callw(0x13_d8ce, 0xe);                    /* call 0x2cec */
            ii(0x13_d8c0, 3); mov(ax, 0xffff);                          /* mov ax, 0xffff */
            ii(0x13_d8c3, 1); cwd();                                    /* cwd */
        l_0x13_d8c4:
            ii(0x13_d8c4, 2); mov(sp, bp);                              /* mov sp, bp */
            ii(0x13_d8c6, 1); popw(bp);                                 /* pop bp */
            ii(0x13_d8c7, 1); retfw(); return;                          /* retf */
        }
    }
}
