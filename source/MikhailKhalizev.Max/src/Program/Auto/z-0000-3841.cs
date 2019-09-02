using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x3841-d36c2e1d")]
        public void Method_0000_3841()
        {
            ii(0x3841, 3);    call(0x3836, -0xe);                       /* call 0x3836 */
            ii(0x3844, 4);    mov(sp, memw[ds, 0x996]);                 /* mov sp, [0x996] */
            ii(0x3848, 2);    mov(bp, sp);                              /* mov bp, sp */
            ii(0x384a, 3);    mov(di, memw[ss, bp + 14]);               /* mov di, [bp+0xe] */
            ii(0x384d, 5);    mov(memw[cs, 0xc], di);                   /* mov [cs:0xc], di */
            ii(0x3852, 3);    mov(ax, memw[ss, bp + 2]);                /* mov ax, [bp+0x2] */
            ii(0x3855, 4);    mov(memw[cs, 0xe], ax);                   /* mov [cs:0xe], ax */
            ii(0x3859, 3);    call(0x3880, 0x24);                       /* call 0x3880 */
            ii(0x385c, 3);    lea(si, memw[ss, bp + 30]);               /* lea si, [bp+0x1e] */
            ii(0x385f, 1);    cld();                                    /* cld */
            ii(0x3860, 5);    les(di, memw[cs, 0xc]);                   /* les di, [cs:0xc] */
            ii(0x3865, 2);    movsd();                                  /* movsd */
            ii(0x3867, 2);    movsd();                                  /* movsd */
            ii(0x3869, 2);    movsd();                                  /* movsd */
            ii(0x386b, 4);    pop(memw[ds, 0x996]);                     /* pop word [0x996] */
            ii(0x386f, 1);    inc(sp);                                  /* inc sp */
            ii(0x3870, 1);    inc(sp);                                  /* inc sp */
            ii(0x3871, 1);    pop(ds);                                  /* pop ds */
            ii(0x3872, 1);    pop(es);                                  /* pop es */
            ii(0x3873, 1);    popa();                                   /* popa */
            ii(0x3874, 5);    mov(ss, memw[cs, 0xe]);                   /* mov ss, [cs:0xe] */
            ii(0x3879, 5);    mov(sp, memw[cs, 0xc]);                   /* mov sp, [cs:0xc] */
            ii(0x387e, 2);    iretd();                                  /* iretd */
        }
    }
}
