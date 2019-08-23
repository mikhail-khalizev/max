using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x17_d8bb-b65b09db")]
        public void Method_0017_d8bb()
        {
            ii(0x17_d8bb, 2); if(jaew(0x17_d8c4, 0x7)) goto l_0x17_d8c4; /* jae 0xd8c4 */
            ii(0x17_d8bd, 3); callw(0x17_d8ce, 0xe);                    /* call 0xd8ce */
            ii(0x17_d8c0, 3); mov(ax, 0xffff);                          /* mov ax, 0xffff */
            ii(0x17_d8c3, 1); cwd();                                    /* cwd */
        l_0x17_d8c4:
            ii(0x17_d8c4, 2); mov(sp, bp);                              /* mov sp, bp */
            ii(0x17_d8c6, 1); popw(bp);                                 /* pop bp */
            ii(0x17_d8c7, 1); retfw();                                  /* retf */
        }
    }
}
