using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x19_9906-81c9c361")]
        public void Method_0019_9906()
        {
            ii(0x19_9906, 1); pushw(bp);                                /* push bp */
            ii(0x19_9907, 2); mov(bp, sp);                              /* mov bp, sp */
            ii(0x19_9909, 1); pushw(di);                                /* push di */
            ii(0x19_990a, 1); pushw(ds);                                /* push ds */
            ii(0x19_990b, 3); mov(ax, 0xa8);                            /* mov ax, 0xa8 */
            ii(0x19_990e, 2); mov(ds, ax);                              /* mov ds, ax */
            ii(0x19_9910, 2); mov(ax, ss);                              /* mov ax, ss */
            ii(0x19_9912, 2); mov(es, ax);                              /* mov es, ax */
            ii(0x19_9914, 3); mov(memw_a16[ds, 0x19da], ax);            /* mov [0x19da], ax */
            ii(0x19_9917, 4); mov(memw_a16[ds, 0x19dc], sp);            /* mov [0x19dc], sp */
            ii(0x19_991b, 2); mov(di, sp);                              /* mov di, sp */
            ii(0x19_991d, 4); mov(memw_a16[ds, 0x19de], bp);            /* mov [0x19de], bp */
            ii(0x19_9921, 3); mov(ax, memw_a16[ds, 0x19e0]);            /* mov ax, [0x19e0] */
            ii(0x19_9924, 2); mov(ss, ax);                              /* mov ss, ax */
            ii(0x19_9926, 4); mov(sp, memw_a16[ds, 0x19e2]);            /* mov sp, [0x19e2] */
            ii(0x19_992a, 4); mov(bp, memw_a16[ds, 0x19e2]);            /* mov bp, [0x19e2] */
            ii(0x19_992e, 1); nop();                                    /* nop */
            ii(0x19_992f, 1); pushw(cs);                                /* push cs */
            ii(0x19_9930, 3); if(callw_up(0x19_a4a1, 0xb6e)) return;    /* call 0xa4a1 */
            ii(0x19_9933, 1); cwd();                                    /* cwd */
            ii(0x19_9934, 4); mov(di, memw_a16[ds, 0x19da]);            /* mov di, [0x19da] */
            ii(0x19_9938, 2); mov(ss, di);                              /* mov ss, di */
            ii(0x19_993a, 4); mov(sp, memw_a16[ds, 0x19dc]);            /* mov sp, [0x19dc] */
            ii(0x19_993e, 4); mov(bp, memw_a16[ds, 0x19de]);            /* mov bp, [0x19de] */
            ii(0x19_9942, 1); popw(ds);                                 /* pop ds */
            ii(0x19_9943, 1); popw(di);                                 /* pop di */
            ii(0x19_9944, 1); leavew();                                 /* leave */
            ii(0x19_9945, 1); retfw(); return;                          /* retf */
        }
    }
}
