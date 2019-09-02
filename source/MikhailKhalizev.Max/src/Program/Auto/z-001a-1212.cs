using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1a_1212-79c2ecd9")]
        public void Method_001a_1212()
        {
            ii(0x1a_1212, 4); enter(8, 0);                              /* enter 0x8, 0x0 */
            ii(0x1a_1216, 1); push(ds);                                 /* push ds */
            ii(0x1a_1217, 3); mov(ax, 0xa8);                            /* mov ax, 0xa8 */
            ii(0x1a_121a, 2); mov(ds, ax);                              /* mov ds, ax */
        l_0x1a_121c:
            ii(0x1a_121c, 3); les(bx, memw[ss, bp + 6]);                /* les bx, [bp+0x6] */
            ii(0x1a_121f, 3); inc(memw[ss, bp + 6]);                    /* inc word [bp+0x6] */
            ii(0x1a_1222, 3); mov(al, memb[es, bx]);                    /* mov al, [es:bx] */
            ii(0x1a_1225, 3); les(bx, memw[ss, bp + 0xa]);              /* les bx, [bp+0xa] */
            ii(0x1a_1228, 3); inc(memw[ss, bp + 0xa]);                  /* inc word [bp+0xa] */
            ii(0x1a_122b, 3); mov(memb[es, bx], al);                    /* mov [es:bx], al */
            ii(0x1a_122e, 2); or(al, al);                               /* or al, al */
            ii(0x1a_1230, 2); if(jnz(0x1a_121c, -0x16)) goto l_0x1a_121c; /* jnz 0x121c */
            ii(0x1a_1232, 3); mov(ax, memw[ss, bp - 4]);                /* mov ax, [bp-0x4] */
            ii(0x1a_1235, 3); mov(dx, memw[ss, bp - 2]);                /* mov dx, [bp-0x2] */
            ii(0x1a_1238, 1); pop(ds);                                  /* pop ds */
            ii(0x1a_1239, 1); leave();                                  /* leave */
            ii(0x1a_123a, 3); retf(8);                                  /* retf 0x8 */
        }
    }
}
