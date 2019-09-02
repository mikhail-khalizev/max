using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x17_d8fc-6a3b9722")]
        public void Method_0017_d8fc()
        {
            ii(0x17_d8fc, 1); push(bp);                                 /* push bp */
            ii(0x17_d8fd, 2); mov(bp, sp);                              /* mov bp, sp */
            ii(0x17_d8ff, 3); mov(bx, memw[ss, bp + 6]);                /* mov bx, [bp+0x6] */
            ii(0x17_d902, 4); cmp(bx, memw[ds, 0x1c5b]);                /* cmp bx, [0x1c5b] */
            ii(0x17_d906, 2); if(jb(0x17_d90e, 6)) goto l_0x17_d90e;    /* jb 0xd90e */
            ii(0x17_d908, 3); mov(ax, 0x900);                           /* mov ax, 0x900 */
            ii(0x17_d90b, 1); stc();                                    /* stc */
            ii(0x17_d90c, 2); jmp(0x17_d919, 0xb); goto l_0x17_d919;    /* jmp 0xd919 */
        l_0x17_d90e:
            ii(0x17_d90e, 2); mov(ah, 0x3e);                            /* mov ah, 0x3e */
            ii(0x17_d910, 2); @int(0x21);                               /* int 0x21 */
            ii(0x17_d912, 2); if(jb(0x17_d919, 5)) goto l_0x17_d919;    /* jb 0xd919 */
            ii(0x17_d914, 5); mov(memb[ds, bx + 0x1c5d], 0);            /* mov byte [bx+0x1c5d], 0x0 */
        l_0x17_d919:
            ii(0x17_d919, 3); if(jmp_func(0x17_d8a6, -0x76)) return;    /* jmp 0xd8a6 */
        }
    }
}
