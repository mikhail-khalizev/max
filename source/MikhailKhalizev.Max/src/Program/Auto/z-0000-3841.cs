using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("120c5b4b-6a1e-47f8-b2a3-1dac77402918")]
        public void Method_0000_3841()
        {
            ii(0x3841, 3);    callw(0x3836, -0xe);                      /* call 0x3836 */
            ii(0x3844, 4);    mov(sp, memw_a16[ds, 0x996]);             /* mov sp, [0x996] */
            ii(0x3848, 2);    mov(bp, sp);                              /* mov bp, sp */
            ii(0x384a, 3);    mov(di, memw_a16[ss, bp + 0xe]);          /* mov di, [bp+0xe] */
            ii(0x384d, 5);    mov(memw_a16[cs, 0xc], di);               /* mov [cs:0xc], di */
            ii(0x3852, 3);    mov(ax, memw_a16[ss, bp + 0x2]);          /* mov ax, [bp+0x2] */
            ii(0x3855, 4);    mov(memw_a16[cs, 0xe], ax);               /* mov [cs:0xe], ax */
            ii(0x3859, 3);    callw(0x3880, 0x24);                      /* call 0x3880 */
            ii(0x385c, 3);    lea(si, bp + 0x1e);                       /* lea si, [bp+0x1e] */
            ii(0x385f, 1);    cld();                                    /* cld */
            ii(0x3860, 5);    les(di, cs, 0xc);                         /* les di, [cs:0xc] */
            ii(0x3865, 2);    movsd_a16();                              /* movsd */
            ii(0x3867, 2);    movsd_a16();                              /* movsd */
            ii(0x3869, 2);    movsd_a16();                              /* movsd */
            ii(0x386b, 4);    popw(memw_a16[ds, 0x996]);                /* pop word [0x996] */
            ii(0x386f, 1);    inc(sp);                                  /* inc sp */
            ii(0x3870, 1);    inc(sp);                                  /* inc sp */
            ii(0x3871, 1);    popw(ds);                                 /* pop ds */
            ii(0x3872, 1);    popw(es);                                 /* pop es */
            ii(0x3873, 1);    popa();                                   /* popa */
            ii(0x3874, 5);    mov(ss, memw_a16[cs, 0xe]);               /* mov ss, [cs:0xe] */
            ii(0x3879, 5);    mov(sp, memw_a16[cs, 0xc]);               /* mov sp, [cs:0xc] */
            ii(0x387e, 2);    iretd(); return;                          /* iretd */
        }
    }
}
