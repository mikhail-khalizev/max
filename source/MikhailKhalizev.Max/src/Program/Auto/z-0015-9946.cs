using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("92b6af11-a4a9-4a4e-83c5-7dfddf7e226f")]
        public void Method_0015_9946()
        {
            ii(0x15_9946, 1); pushw(bp);                                /* push bp */
            ii(0x15_9947, 2); mov(bp, sp);                              /* mov bp, sp */
            ii(0x15_9949, 1); pushw(di);                                /* push di */
            ii(0x15_994a, 1); pushw(ds);                                /* push ds */
            ii(0x15_994b, 3); mov(ax, 0xa8);                            /* mov ax, 0xa8 */
            ii(0x15_994e, 2); mov(ds, ax);                              /* mov ds, ax */
            ii(0x15_9950, 2); mov(ax, ss);                              /* mov ax, ss */
            ii(0x15_9952, 2); mov(es, ax);                              /* mov es, ax */
            ii(0x15_9954, 3); mov(memw_a16[ds, 0x19da], ax);            /* mov [0x19da], ax */
            ii(0x15_9957, 4); mov(memw_a16[ds, 0x19dc], sp);            /* mov [0x19dc], sp */
            ii(0x15_995b, 2); mov(di, sp);                              /* mov di, sp */
            ii(0x15_995d, 4); mov(memw_a16[ds, 0x19de], bp);            /* mov [0x19de], bp */
            ii(0x15_9961, 3); mov(ax, memw_a16[ds, 0x19e0]);            /* mov ax, [0x19e0] */
            ii(0x15_9964, 2); mov(ss, ax);                              /* mov ss, ax */
            ii(0x15_9966, 4); mov(sp, memw_a16[ds, 0x19e2]);            /* mov sp, [0x19e2] */
            ii(0x15_996a, 4); mov(bp, memw_a16[ds, 0x19e2]);            /* mov bp, [0x19e2] */
            ii(0x15_996e, 2); pushw(0);                                 /* push 0x0 */
            ii(0x15_9970, 4); pushw(memw_a16[es, di + 0x1c]);           /* push word [es:di+0x1c] */
            ii(0x15_9974, 4); pushw(memw_a16[es, di + 0x1a]);           /* push word [es:di+0x1a] */
            ii(0x15_9978, 4); pushw(memw_a16[es, di + 0x18]);           /* push word [es:di+0x18] */
            ii(0x15_997c, 4); pushw(memw_a16[es, di + 0x16]);           /* push word [es:di+0x16] */
            ii(0x15_9980, 4); pushw(memw_a16[es, di + 0x14]);           /* push word [es:di+0x14] */
            ii(0x15_9984, 4); pushw(memw_a16[es, di + 0x12]);           /* push word [es:di+0x12] */
            ii(0x15_9988, 4); pushw(memw_a16[es, di + 0x10]);           /* push word [es:di+0x10] */
            ii(0x15_998c, 4); pushw(memw_a16[es, di + 0xe]);            /* push word [es:di+0xe] */
            ii(0x15_9990, 4); pushw(memw_a16[es, di + 0xc]);            /* push word [es:di+0xc] */
            ii(0x15_9994, 4); pushw(memw_a16[es, di + 0xa]);            /* push word [es:di+0xa] */
            ii(0x15_9998, 1); nop();                                    /* nop */
            ii(0x15_9999, 1); pushw(cs);                                /* push cs */
            ii(0x15_999a, 3); callw(0x15_8c69, -0xd34);                 /* call 0x8c69 */
            ii(0x15_999d, 1); cwd();                                    /* cwd */
            ii(0x15_999e, 4); mov(di, memw_a16[ds, 0x19da]);            /* mov di, [0x19da] */
            ii(0x15_99a2, 2); mov(ss, di);                              /* mov ss, di */
            ii(0x15_99a4, 4); mov(sp, memw_a16[ds, 0x19dc]);            /* mov sp, [0x19dc] */
            ii(0x15_99a8, 4); mov(bp, memw_a16[ds, 0x19de]);            /* mov bp, [0x19de] */
            ii(0x15_99ac, 1); popw(ds);                                 /* pop ds */
            ii(0x15_99ad, 1); popw(di);                                 /* pop di */
            ii(0x15_99ae, 1); leavew();                                 /* leave */
            ii(0x15_99af, 1); retfw(); return;                          /* retf */
        }
    }
}