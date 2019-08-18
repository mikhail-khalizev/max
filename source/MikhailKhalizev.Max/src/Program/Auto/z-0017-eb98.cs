using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("c041837a-e8e1-4c8d-8f7a-425e1ec33fa2")]
        public void Method_0017_eb98()
        {
            ii(0x17_eb98, 1); pushw(bp);                                /* push bp */
            ii(0x17_eb99, 2); mov(bp, sp);                              /* mov bp, sp */
            ii(0x17_eb9b, 1); pushw(bx);                                /* push bx */
            ii(0x17_eb9c, 1); pushw(ds);                                /* push ds */
            ii(0x17_eb9d, 3); lds(bx, ss, bp + 0xa);                    /* lds bx, [bp+0xa] */
            ii(0x17_eba0, 3); mov(ax, memw_a16[ss, bp + 0xe]);          /* mov ax, [bp+0xe] */
            ii(0x17_eba3, 2); mov(memw_a16[ds, bx], ax);                /* mov [bx], ax */
            ii(0x17_eba5, 3); mov(ax, memw_a16[ss, bp + 0x10]);         /* mov ax, [bp+0x10] */
            ii(0x17_eba8, 3); mov(memw_a16[ds, bx + 0x2], ax);          /* mov [bx+0x2], ax */
            ii(0x17_ebab, 1); pushw(ds);                                /* push ds */
            ii(0x17_ebac, 1); pushw(bx);                                /* push bx */
            ii(0x17_ebad, 3); pushw(memw_a16[ss, bp + 0x8]);            /* push word [bp+0x8] */
            ii(0x17_ebb0, 3); pushw(memw_a16[ss, bp + 0x6]);            /* push word [bp+0x6] */
            ii(0x17_ebb3, 1); nop();                                    /* nop */
            ii(0x17_ebb4, 1); pushw(cs);                                /* push cs */
            ii(0x17_ebb5, 3); callw(0x17_eb64, -0x54);                  /* call 0xeb64 */
            ii(0x17_ebb8, 3); add(sp, 0x8);                             /* add sp, 0x8 */
            ii(0x17_ebbb, 1); popw(ds);                                 /* pop ds */
            ii(0x17_ebbc, 1); popw(bx);                                 /* pop bx */
            ii(0x17_ebbd, 1); popw(bp);                                 /* pop bp */
            ii(0x17_ebbe, 1); retfw(); return;                          /* retf */
        }
    }
}
