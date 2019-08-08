using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("d764c4d6-4f6b-4b79-86f4-20ec1f45ae46")]
        public void Method_0015_4188()
        {
            ii(0x15_4188, 1); pushw(bp);                                /* push bp */
            ii(0x15_4189, 2); mov(bp, sp);                              /* mov bp, sp */
            ii(0x15_418b, 1); pushw(bx);                                /* push bx */
            ii(0x15_418c, 1); pushw(ds);                                /* push ds */
            ii(0x15_418d, 3); lds(bx, ss, bp + 0x8);                    /* lds bx, [bp+0x8] */
            ii(0x15_4190, 3); mov(ax, memw_a16[ss, bp + 0xc]);          /* mov ax, [bp+0xc] */
            ii(0x15_4193, 2); mov(memw_a16[ds, bx], ax);                /* mov [bx], ax */
            ii(0x15_4195, 3); mov(ax, memw_a16[ss, bp + 0xe]);          /* mov ax, [bp+0xe] */
            ii(0x15_4198, 3); mov(memw_a16[ds, bx + 0x2], ax);          /* mov [bx+0x2], ax */
            ii(0x15_419b, 1); pushw(ds);                                /* push ds */
            ii(0x15_419c, 1); pushw(bx);                                /* push bx */
            ii(0x15_419d, 3); pushw(memw_a16[ss, bp + 0x6]);            /* push word [bp+0x6] */
            ii(0x15_41a0, 1); nop();                                    /* nop */
            ii(0x15_41a1, 1); pushw(cs);                                /* push cs */
            ii(0x15_41a2, 3); callw(0x15_412f, -0x76);                  /* call 0x412f */
            ii(0x15_41a5, 3); add(sp, 0x6);                             /* add sp, 0x6 */
            ii(0x15_41a8, 1); popw(ds);                                 /* pop ds */
            ii(0x15_41a9, 1); popw(bx);                                 /* pop bx */
            ii(0x15_41aa, 1); popw(bp);                                 /* pop bp */
            ii(0x15_41ab, 1); retfw(); return;                          /* retf */
        }
    }
}
