using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x18_ab2c-fcaaa38b")]
        public void Method_0018_ab2c()
        {
            ii(0x18_ab2c, 1); pushw(bx);                                /* push bx */
            ii(0x18_ab2d, 2); xor(bh, bh);                              /* xor bh, bh */
            ii(0x18_ab2f, 3); mov(bl, memb_a16[ss, bp + 0x16]);         /* mov bl, [bp+0x16] */
            ii(0x18_ab32, 3); mov(dl, memb_a16[ss, bp + 0x12]);         /* mov dl, [bp+0x12] */
            ii(0x18_ab35, 2); mov(di, bx);                              /* mov di, bx */
            ii(0x18_ab37, 3); shl(bx, 0x3);                             /* shl bx, 0x3 */
            ii(0x18_ab3a, 3); lea(ax, bx - 0x40);                       /* lea ax, [bx-0x40] */
            ii(0x18_ab3d, 2); sar(ax, 0x1);                             /* sar ax, 1 */
            ii(0x18_ab3f, 3); cmp(ax, 0x9c);                            /* cmp ax, 0x9c */
            ii(0x18_ab42, 1); nop();                                    /* nop */
            ii(0x18_ab43, 2); if(jaew(0x18_ab6f, 0x2a)) goto l_0x18_ab6f; /* jae 0xab6f */
            ii(0x18_ab45, 4); cmp(bx, 0x108);                           /* cmp bx, 0x108 */
            ii(0x18_ab49, 2); if(jzw(0x18_ab6f, 0x24)) goto l_0x18_ab6f; /* jz 0xab6f */
            ii(0x18_ab4b, 4); mov(memb_a16[ds, di + 0x10be], dl);       /* mov [di+0x10be], dl */
            ii(0x18_ab4f, 3); add(ax, 0x111c);                          /* add ax, 0x111c */
            ii(0x18_ab52, 4); mov(si, memw_a16[ds, 0x9b6]);             /* mov si, [0x9b6] */
            ii(0x18_ab56, 2); shr(bx, 0x1);                             /* shr bx, 1 */
            ii(0x18_ab58, 2); or(dl, dl);                               /* or dl, dl */
            ii(0x18_ab5a, 2); if(jnzw(0x18_ab64, 0x8)) goto l_0x18_ab64; /* jnz 0xab64 */
            ii(0x18_ab5c, 4); mov(ax, memw_a16[ds, bx + 0xf6a]);        /* mov ax, [bx+0xf6a] */
            ii(0x18_ab60, 4); mov(si, memw_a16[ds, bx + 0xf6c]);        /* mov si, [bx+0xf6c] */
        l_0x18_ab64:
            ii(0x18_ab64, 4); mov(es, memw_a16[ds, 0xc2e]);             /* mov es, [0xc2e] */
            ii(0x18_ab68, 3); mov(memw_a16[es, bx], ax);                /* mov [es:bx], ax */
            ii(0x18_ab6b, 4); mov(memw_a16[es, bx + 0x2], si);          /* mov [es:bx+0x2], si */
        l_0x18_ab6f:
            ii(0x18_ab6f, 1); popw(bx);                                 /* pop bx */
            ii(0x18_ab70, 1); retw();                                   /* ret */
        }
    }
}
