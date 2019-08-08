using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("ed89667d-34c9-4af6-a8e6-ca4d377ff73d")]
        public void Method_0000_6004()
        {
            ii(0x6004, 4);    mov(sp, memw_a16[ds, 0x996]);             /* mov sp, [0x996] */
            ii(0x6008, 2);    mov(bp, sp);                              /* mov bp, sp */
            ii(0x600a, 3);    mov(di, memw_a16[ss, bp + 0xe]);          /* mov di, [bp+0xe] */
            ii(0x600d, 5);    mov(memw_a16[cs, 0xc], di);               /* mov [cs:0xc], di */
            ii(0x6012, 3);    mov(ax, memw_a16[ss, bp + 0x2]);          /* mov ax, [bp+0x2] */
            ii(0x6015, 4);    mov(memw_a16[cs, 0xe], ax);               /* mov [cs:0xe], ax */
            ii(0x6019, 3);    callw(0x6040, 0x24);                      /* call 0x6040 */
            ii(0x601c, 3);    lea(si, bp + 0x1e);                       /* lea si, [bp+0x1e] */
            ii(0x601f, 1);    cld();                                    /* cld */
            ii(0x6020, 5);    les(di, cs, 0xc);                         /* les di, [cs:0xc] */
            ii(0x6025, 2);    movsd_a16();                              /* movsd */
            ii(0x6027, 2);    movsd_a16();                              /* movsd */
            ii(0x6029, 2);    movsd_a16();                              /* movsd */
            ii(0x602b, 4);    popw(memw_a16[ds, 0x996]);                /* pop word [0x996] */
            ii(0x602f, 1);    inc(sp);                                  /* inc sp */
            ii(0x6030, 1);    inc(sp);                                  /* inc sp */
            ii(0x6031, 1);    popw(ds);                                 /* pop ds */
            ii(0x6032, 1);    popw(es);                                 /* pop es */
            ii(0x6033, 1);    popa();                                   /* popa */
            ii(0x6034, 5);    mov(ss, memw_a16[cs, 0xe]);               /* mov ss, [cs:0xe] */
            ii(0x6039, 5);    mov(sp, memw_a16[cs, 0xc]);               /* mov sp, [cs:0xc] */
            ii(0x603e, 2);    iretd(); return;                          /* iretd */
        }
    }
}
