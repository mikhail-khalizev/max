using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("f644a21f-8242-4cd7-8e42-5fa8acc57045")]
        public void Method_0015_9be0()
        {
            ii(0x15_9be0, 1); pushw(bp);                                /* push bp */
            ii(0x15_9be1, 2); mov(bp, sp);                              /* mov bp, sp */
            ii(0x15_9be3, 5); callw_far_abs(0x80, 0x5740);              /* call word 0x80:0x5740 */
            ii(0x15_9be8, 3); mov(memw_a16[ds, 0x19e4], ax);            /* mov [0x19e4], ax */
            ii(0x15_9beb, 2); or(ax, ax);                               /* or ax, ax */
            ii(0x15_9bed, 2); if(jzw(0x15_9c2c, 0x3d)) goto l_0x15_9c2c; /* jz 0x9c2c */
            ii(0x15_9bef, 5); callw_far_abs(0x80, 0x5740);              /* call word 0x80:0x5740 */
            ii(0x15_9bf4, 3); mov(memw_a16[ds, 0x19e6], ax);            /* mov [0x19e6], ax */
            ii(0x15_9bf7, 3); mov(memw_a16[ds, 0x19e8], ax);            /* mov [0x19e8], ax */
            ii(0x15_9bfa, 2); or(ax, ax);                               /* or ax, ax */
            ii(0x15_9bfc, 2); if(jzw(0x15_9c2c, 0x2e)) goto l_0x15_9c2c; /* jz 0x9c2c */
            ii(0x15_9bfe, 1); pushw(ax);                                /* push ax */
            ii(0x15_9bff, 3); pushw(memw_a16[ss, bp + 0x8]);            /* push word [bp+0x8] */
            ii(0x15_9c02, 3); pushw(memw_a16[ss, bp + 0x6]);            /* push word [bp+0x6] */
            ii(0x15_9c05, 3); pushw(memw_a16[ss, bp + 0xc]);            /* push word [bp+0xc] */
            ii(0x15_9c08, 3); pushw(memw_a16[ss, bp + 0xa]);            /* push word [bp+0xa] */
            ii(0x15_9c0b, 3); pushw(0x92);                              /* push 0x92 */
            ii(0x15_9c0e, 3); callw(0x15_cc1a, 0x3009);                 /* call 0xcc1a */
            ii(0x15_9c11, 4); pushw(memw_a16[ds, 0x19e4]);              /* push word [0x19e4] */
            ii(0x15_9c15, 3); pushw(memw_a16[ss, bp + 0x8]);            /* push word [bp+0x8] */
            ii(0x15_9c18, 3); pushw(memw_a16[ss, bp + 0x6]);            /* push word [bp+0x6] */
            ii(0x15_9c1b, 3); pushw(memw_a16[ss, bp + 0xc]);            /* push word [bp+0xc] */
            ii(0x15_9c1e, 3); pushw(memw_a16[ss, bp + 0xa]);            /* push word [bp+0xa] */
            ii(0x15_9c21, 3); pushw(0x9a);                              /* push 0x9a */
            ii(0x15_9c24, 3); callw(0x15_cc1a, 0x2ff3);                 /* call 0xcc1a */
            ii(0x15_9c27, 3); mov(ax, memw_a16[ds, 0x19e6]);            /* mov ax, [0x19e6] */
            ii(0x15_9c2a, 1); leavew();                                 /* leave */
            ii(0x15_9c2b, 1); retfw(); return;                          /* retf */
        l_0x15_9c2c:
            ii(0x15_9c2c, 2); sub(ax, ax);                              /* sub ax, ax */
            ii(0x15_9c2e, 1); leavew();                                 /* leave */
            ii(0x15_9c2f, 1); retfw(); return;                          /* retf */
        }
    }
}
