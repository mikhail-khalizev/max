using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x19_98c5-f37e1609")]
        public void Method_0019_98c5()
        {
            ii(0x19_98c5, 4); enter(0x4, 0);                            /* enter 0x4, 0x0 */
            ii(0x19_98c9, 1); push(di);                                 /* push di */
            ii(0x19_98ca, 1); push(ds);                                 /* push ds */
            ii(0x19_98cb, 3); mov(ax, 0xa8);                            /* mov ax, 0xa8 */
            ii(0x19_98ce, 2); mov(ds, ax);                              /* mov ds, ax */
            ii(0x19_98d0, 2); mov(ax, ss);                              /* mov ax, ss */
            ii(0x19_98d2, 2); mov(es, ax);                              /* mov es, ax */
            ii(0x19_98d4, 3); mov(memw[ds, 0x19da], ax);                /* mov [0x19da], ax */
            ii(0x19_98d7, 4); mov(memw[ds, 0x19dc], sp);                /* mov [0x19dc], sp */
            ii(0x19_98db, 2); mov(di, sp);                              /* mov di, sp */
            ii(0x19_98dd, 4); mov(memw[ds, 0x19de], bp);                /* mov [0x19de], bp */
            ii(0x19_98e1, 3); mov(ax, memw[ds, 0x19e0]);                /* mov ax, [0x19e0] */
            ii(0x19_98e4, 2); mov(ss, ax);                              /* mov ss, ax */
            ii(0x19_98e6, 4); mov(sp, memw[ds, 0x19e2]);                /* mov sp, [0x19e2] */
            ii(0x19_98ea, 4); mov(bp, memw[ds, 0x19e2]);                /* mov bp, [0x19e2] */
            ii(0x19_98ee, 1); nop();                                    /* nop */
            ii(0x19_98ef, 1); push(cs);                                 /* push cs */
            ii(0x19_98f0, 3); call(0x19_9661, -0x292);                  /* call 0x9661 */
            ii(0x19_98f3, 1); cwd();                                    /* cwd */
            ii(0x19_98f4, 4); mov(di, memw[ds, 0x19da]);                /* mov di, [0x19da] */
            ii(0x19_98f8, 2); mov(ss, di);                              /* mov ss, di */
            ii(0x19_98fa, 4); mov(sp, memw[ds, 0x19dc]);                /* mov sp, [0x19dc] */
            ii(0x19_98fe, 4); mov(bp, memw[ds, 0x19de]);                /* mov bp, [0x19de] */
            ii(0x19_9902, 1); pop(ds);                                  /* pop ds */
            ii(0x19_9903, 1); pop(di);                                  /* pop di */
            ii(0x19_9904, 1); leave();                                  /* leave */
            ii(0x19_9905, 1); retf();                                   /* retf */
        }
    }
}
