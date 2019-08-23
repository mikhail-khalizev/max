using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x17_eb40-6ec372b4")]
        public void Method_0017_eb40()
        {
            ii(0x17_eb40, 1); pushw(bp);                                /* push bp */
            ii(0x17_eb41, 2); mov(bp, sp);                              /* mov bp, sp */
            ii(0x17_eb43, 1); pushw(bx);                                /* push bx */
            ii(0x17_eb44, 1); pushw(ds);                                /* push ds */
            ii(0x17_eb45, 3); lds(bx, ss, bp + 0x8);                    /* lds bx, [bp+0x8] */
            ii(0x17_eb48, 3); mov(ax, memw_a16[ss, bp + 0xc]);          /* mov ax, [bp+0xc] */
            ii(0x17_eb4b, 2); mov(memw_a16[ds, bx], ax);                /* mov [bx], ax */
            ii(0x17_eb4d, 3); mov(ax, memw_a16[ss, bp + 0xe]);          /* mov ax, [bp+0xe] */
            ii(0x17_eb50, 3); mov(memw_a16[ds, bx + 0x2], ax);          /* mov [bx+0x2], ax */
            ii(0x17_eb53, 1); pushw(ds);                                /* push ds */
            ii(0x17_eb54, 1); pushw(bx);                                /* push bx */
            ii(0x17_eb55, 3); pushw(memw_a16[ss, bp + 0x6]);            /* push word [bp+0x6] */
            ii(0x17_eb58, 1); nop();                                    /* nop */
            ii(0x17_eb59, 1); pushw(cs);                                /* push cs */
            ii(0x17_eb5a, 3); callw(0x17_eaed, -0x70);                  /* call 0xeaed */
            ii(0x17_eb5d, 3); add(sp, 0x6);                             /* add sp, 0x6 */
            ii(0x17_eb60, 1); popw(ds);                                 /* pop ds */
            ii(0x17_eb61, 1); popw(bx);                                 /* pop bx */
            ii(0x17_eb62, 1); popw(bp);                                 /* pop bp */
            ii(0x17_eb63, 1); retfw();                                  /* retf */
        }
    }
}
