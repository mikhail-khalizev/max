using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("bba89dbf-7d8a-4359-aa9c-792358e4ac13")]
        public void Method_0013_d8a6()
        {
            ii(0x13_d8a6, 2); if(jbw(0x13_d8bd, 0x15)) goto l_0x13_d8bd; /* jb 0xd8bd */
            ii(0x13_d8a8, 2); xor(ax, ax);                              /* xor ax, ax */
            ii(0x13_d8aa, 2); mov(sp, bp);                              /* mov sp, bp */
            ii(0x13_d8ac, 1); popw(bp);                                 /* pop bp */
            ii(0x13_d8ad, 1); retfw(); return;                          /* retf */
        //  ii(0x13_d8ae, 15); Недостижимый (и не декодированный) код.
        l_0x13_d8bd:
            ii(0x13_d8bd, 3); callw(0x13_d8ce, 0xe);                    /* call 0xd8ce */
            ii(0x13_d8c0, 3); mov(ax, 0xffff);                          /* mov ax, 0xffff */
            ii(0x13_d8c3, 1); cwd();                                    /* cwd */
            ii(0x13_d8c4, 2); mov(sp, bp);                              /* mov sp, bp */
            ii(0x13_d8c6, 1); popw(bp);                                 /* pop bp */
            ii(0x13_d8c7, 1); retfw(); return;                          /* retf */
        }
    }
}
