using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x19_9bb6-49d16676")]
        public void Method_0019_9bb6()
        {
            ii(0x19_9bb6, 1);  push(bp);                               /* push bp */
            ii(0x19_9bb7, 2);  mov(bp, sp);                            /* mov bp, sp */
            ii(0x19_9bb9, 3);  mov(ax, memw[ds, 0x3292]);              /* mov ax, [0x3292] */
            ii(0x19_9bbc, 4);  or(ax, memw[ds, 0x3290]);               /* or ax, [0x3290] */
            ii(0x19_9bc0, 2);  if(jz(0x19_9bd9, 0x17)) goto l_0x19_9bd9;/* jz 0x9bd9 */
            ii(0x19_9bc2, 3);  push(memw[ss, bp + 6]);                 /* push word [bp+0x6] */
            ii(0x19_9bc5, 3);  push(memw[ss, bp + 4]);                 /* push word [bp+0x4] */
            ii(0x19_9bc8, 3);  push(memw[ss, bp + 10]);                /* push word [bp+0xa] */
            ii(0x19_9bcb, 3);  push(memw[ss, bp + 8]);                 /* push word [bp+0x8] */
            ii(0x19_9bce, 3);  push(memw[ss, bp + 12]);                /* push word [bp+0xc] */
            ii(0x19_9bd1, 4);  call_far_ind(memw[ds, 0x3290]);         /* call far word [0x3290] */
            ii(0x19_9bd5, 2);  mov(sp, bp);                            /* mov sp, bp */
            ii(0x19_9bd7, 2);  jmp(0x19_9bdc, 3); goto l_0x19_9bdc;    /* jmp 0x9bdc */
        l_0x19_9bd9:
            ii(0x19_9bd9, 3);  mov(ax, 0xffff);                        /* mov ax, 0xffff */
        l_0x19_9bdc:
            ii(0x19_9bdc, 1);  leave();                                /* leave */
            ii(0x19_9bdd, 3);  ret(0xa);                               /* ret 0xa */
        }
    }
}
