using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x6004-8f393cf8")]
        public void Method_0000_6004()
        {
            ii(0x6004, 4);  mov(sp, memw[ds, 0x996]);                  /* mov sp, [0x996] */
            ii(0x6008, 2);  mov(bp, sp);                               /* mov bp, sp */
            ii(0x600a, 3);  mov(di, memw[ss, bp + 14]);                /* mov di, [bp+0xe] */
            ii(0x600d, 5);  mov(memw[cs, 0xc], di);                    /* mov [cs:0xc], di */
            ii(0x6012, 3);  mov(ax, memw[ss, bp + 2]);                 /* mov ax, [bp+0x2] */
            ii(0x6015, 4);  mov(memw[cs, 0xe], ax);                    /* mov [cs:0xe], ax */
            ii(0x6019, 3);  call(0x6040, 0x24);                        /* call 0x6040 */
            ii(0x601c, 3);  lea(si, memw[ss, bp + 30]);                /* lea si, [bp+0x1e] */
            ii(0x601f, 1);  cld();                                     /* cld */
            ii(0x6020, 5);  les(di, memw[cs, 0xc]);                    /* les di, [cs:0xc] */
            ii(0x6025, 2);  movsd();                                   /* movsd */
            ii(0x6027, 2);  movsd();                                   /* movsd */
            ii(0x6029, 2);  movsd();                                   /* movsd */
            ii(0x602b, 4);  pop(memw[ds, 0x996]);                      /* pop word [0x996] */
            ii(0x602f, 1);  inc(sp);                                   /* inc sp */
            ii(0x6030, 1);  inc(sp);                                   /* inc sp */
            ii(0x6031, 1);  pop(ds);                                   /* pop ds */
            ii(0x6032, 1);  pop(es);                                   /* pop es */
            ii(0x6033, 1);  popa();                                    /* popa */
            ii(0x6034, 5);  mov(ss, memw[cs, 0xe]);                    /* mov ss, [cs:0xe] */
            ii(0x6039, 5);  mov(sp, memw[cs, 0xc]);                    /* mov sp, [cs:0xc] */
            ii(0x603e, 2);  iretd();                                   /* iretd */
        }
    }
}
