using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x19_9be0-491325dd")]
        public void Method_0019_9be0()
        {
            ii(0x19_9be0, 1); push(bp);                                 /* push bp */
            ii(0x19_9be1, 2); mov(bp, sp);                              /* mov bp, sp */
            ii(0x19_9be3, 5); call_far_abs(0x80, 0x5740);               /* call word 0x80:0x5740 */
            ii(0x19_9be8, 3); mov(memw[ds, 0x19e4], ax);                /* mov [0x19e4], ax */
            ii(0x19_9beb, 2); or(ax, ax);                               /* or ax, ax */
            ii(0x19_9bed, 2); if(jz(0x19_9c2c, 0x3d)) goto l_0x19_9c2c; /* jz 0x9c2c */
            ii(0x19_9bef, 5); call_far_abs(0x80, 0x5740);               /* call word 0x80:0x5740 */
            ii(0x19_9bf4, 3); mov(memw[ds, 0x19e6], ax);                /* mov [0x19e6], ax */
            ii(0x19_9bf7, 3); mov(memw[ds, 0x19e8], ax);                /* mov [0x19e8], ax */
            ii(0x19_9bfa, 2); or(ax, ax);                               /* or ax, ax */
            ii(0x19_9bfc, 2); if(jz(0x19_9c2c, 0x2e)) goto l_0x19_9c2c; /* jz 0x9c2c */
            ii(0x19_9bfe, 1); push(ax);                                 /* push ax */
            ii(0x19_9bff, 3); push(memw[ss, bp + 8]);                   /* push word [bp+0x8] */
            ii(0x19_9c02, 3); push(memw[ss, bp + 6]);                   /* push word [bp+0x6] */
            ii(0x19_9c05, 3); push(memw[ss, bp + 0xc]);                 /* push word [bp+0xc] */
            ii(0x19_9c08, 3); push(memw[ss, bp + 0xa]);                 /* push word [bp+0xa] */
            ii(0x19_9c0b, 3); push(0x92);                               /* push 0x92 */
            ii(0x19_9c0e, 3); call(0x19_cc1a, 0x3009);                  /* call 0xcc1a */
            ii(0x19_9c11, 4); push(memw[ds, 0x19e4]);                   /* push word [0x19e4] */
            ii(0x19_9c15, 3); push(memw[ss, bp + 8]);                   /* push word [bp+0x8] */
            ii(0x19_9c18, 3); push(memw[ss, bp + 6]);                   /* push word [bp+0x6] */
            ii(0x19_9c1b, 3); push(memw[ss, bp + 0xc]);                 /* push word [bp+0xc] */
            ii(0x19_9c1e, 3); push(memw[ss, bp + 0xa]);                 /* push word [bp+0xa] */
            ii(0x19_9c21, 3); push(0x9a);                               /* push 0x9a */
            ii(0x19_9c24, 3); call(0x19_cc1a, 0x2ff3);                  /* call 0xcc1a */
            ii(0x19_9c27, 3); mov(ax, memw[ds, 0x19e6]);                /* mov ax, [0x19e6] */
            ii(0x19_9c2a, 1); leave();                                  /* leave */
            ii(0x19_9c2b, 1); retf(); return;                           /* retf */
        l_0x19_9c2c:
            ii(0x19_9c2c, 2); sub(ax, ax);                              /* sub ax, ax */
            ii(0x19_9c2e, 1); leave();                                  /* leave */
            ii(0x19_9c2f, 1); retf();                                   /* retf */
        }
    }
}
