using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x3ff1-d36c2e1d")]
        public void Method_0000_3ff1()
        {
            ii(0x3ff1, 3);    call(0x3fe6, -0xe);                       /* call 0x3fe6 */
            ii(0x3ff4, 4);    mov(sp, memw[ds, 0x996]);                 /* mov sp, [0x996] */
            ii(0x3ff8, 2);    mov(bp, sp);                              /* mov bp, sp */
            ii(0x3ffa, 3);    mov(di, memw[ss, bp + 14]);               /* mov di, [bp+0xe] */
            ii(0x3ffd, 5);    mov(memw[cs, 0xc], di);                   /* mov [cs:0xc], di */
            ii(0x4002, 3);    mov(ax, memw[ss, bp + 2]);                /* mov ax, [bp+0x2] */
            ii(0x4005, 4);    mov(memw[cs, 0xe], ax);                   /* mov [cs:0xe], ax */
            ii(0x4009, 3);    call(0x4030, 0x24);                       /* call 0x4030 */
            ii(0x400c, 3);    lea(si, memw[ss, bp + 30]);               /* lea si, [bp+0x1e] */
            ii(0x400f, 1);    cld();                                    /* cld */
            ii(0x4010, 5);    les(di, memw[cs, 0xc]);                   /* les di, [cs:0xc] */
            ii(0x4015, 2);    movsd();                                  /* movsd */
            ii(0x4017, 2);    movsd();                                  /* movsd */
            ii(0x4019, 2);    movsd();                                  /* movsd */
            ii(0x401b, 4);    pop(memw[ds, 0x996]);                     /* pop word [0x996] */
            ii(0x401f, 1);    inc(sp);                                  /* inc sp */
            ii(0x4020, 1);    inc(sp);                                  /* inc sp */
            ii(0x4021, 1);    pop(ds);                                  /* pop ds */
            ii(0x4022, 1);    pop(es);                                  /* pop es */
            ii(0x4023, 1);    popa();                                   /* popa */
            ii(0x4024, 5);    mov(ss, memw[cs, 0xe]);                   /* mov ss, [cs:0xe] */
            ii(0x4029, 5);    mov(sp, memw[cs, 0xc]);                   /* mov sp, [cs:0xc] */
            ii(0x402e, 2);    iretd();                                  /* iretd */
        }
    }
}
