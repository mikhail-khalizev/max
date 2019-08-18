using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("b7e88a70-ea89-4ef6-b2d2-bb3f5edf7850")]
        public void Method_0017_8106()
        {
            ii(0x17_8106, 1); pushw(bp);                                /* push bp */
            ii(0x17_8107, 2); mov(bp, sp);                              /* mov bp, sp */
            ii(0x17_8109, 1); pushw(ds);                                /* push ds */
            ii(0x17_810a, 3); mov(ax, 0x3e68);                          /* mov ax, 0x3e68 */
            ii(0x17_810d, 2); mov(ds, ax);                              /* mov ds, ax */
            ii(0x17_810f, 5); cmp(memb_a16[ds, 0xa2a], 0);              /* cmp byte [0xa2a], 0x0 */
            ii(0x17_8114, 2); if(jzw(0x17_8124, 0xe)) goto l_0x17_8124; /* jz 0x8124 */
            ii(0x17_8116, 3); mov(ax, memw_a16[ss, bp + 0x6]);          /* mov ax, [bp+0x6] */
            ii(0x17_8119, 4); les(bx, ds, 0xa26);                       /* les bx, [0xa26] */
            ii(0x17_811d, 4); mov(memw_a16[es, bx + 0x10], ax);         /* mov [es:bx+0x10], ax */
            ii(0x17_8121, 1); popw(ds);                                 /* pop ds */
            ii(0x17_8122, 1); leavew();                                 /* leave */
            ii(0x17_8123, 1); retfw(); return;                          /* retf */
        l_0x17_8124:
            ii(0x17_8124, 2); mov(ah, 0x50);                            /* mov ah, 0x50 */
            ii(0x17_8126, 3); mov(bx, memw_a16[ss, bp + 0x6]);          /* mov bx, [bp+0x6] */
            ii(0x17_8129, 2); @int(0x21);                               /* int 0x21 */
            ii(0x17_812b, 1); popw(ds);                                 /* pop ds */
            ii(0x17_812c, 1); leavew();                                 /* leave */
            ii(0x17_812d, 1); retfw(); return;                          /* retf */
        }
    }
}
