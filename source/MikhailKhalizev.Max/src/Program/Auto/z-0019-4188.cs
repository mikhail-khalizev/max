using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x19_4188-a007652e")]
        public void Method_0019_4188()
        {
            ii(0x19_4188, 1); push(bp);                                 /* push bp */
            ii(0x19_4189, 2); mov(bp, sp);                              /* mov bp, sp */
            ii(0x19_418b, 1); push(bx);                                 /* push bx */
            ii(0x19_418c, 1); push(ds);                                 /* push ds */
            ii(0x19_418d, 3); lds(bx, memw[ss, bp + 8]);                /* lds bx, [bp+0x8] */
            ii(0x19_4190, 3); mov(ax, memw[ss, bp + 12]);               /* mov ax, [bp+0xc] */
            ii(0x19_4193, 2); mov(memw[ds, bx], ax);                    /* mov [bx], ax */
            ii(0x19_4195, 3); mov(ax, memw[ss, bp + 14]);               /* mov ax, [bp+0xe] */
            ii(0x19_4198, 3); mov(memw[ds, bx + 2], ax);                /* mov [bx+0x2], ax */
            ii(0x19_419b, 1); push(ds);                                 /* push ds */
            ii(0x19_419c, 1); push(bx);                                 /* push bx */
            ii(0x19_419d, 3); push(memw[ss, bp + 6]);                   /* push word [bp+0x6] */
            ii(0x19_41a0, 1); nop();                                    /* nop */
            ii(0x19_41a1, 1); push(cs);                                 /* push cs */
            ii(0x19_41a2, 3); call(0x19_412f, -0x76);                   /* call 0x412f */
            ii(0x19_41a5, 3); add(sp, 6);                               /* add sp, 0x6 */
            ii(0x19_41a8, 1); pop(ds);                                  /* pop ds */
            ii(0x19_41a9, 1); pop(bx);                                  /* pop bx */
            ii(0x19_41aa, 1); pop(bp);                                  /* pop bp */
            ii(0x19_41ab, 1); retf();                                   /* retf */
        }
    }
}
