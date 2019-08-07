using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("39d4542f-795c-4cff-ba6f-9864f8ba5e80")]
        public void Method_0013_8106()
        {
            ii(0x13_8106, 1); pushw(bp);                                /* push bp */
            ii(0x13_8107, 2); mov(bp, sp);                              /* mov bp, sp */
            ii(0x13_8109, 1); pushw(ds);                                /* push ds */
            ii(0x13_810a, 3); mov(ax, 0x3e68);                          /* mov ax, 0x3e68 */
            ii(0x13_810d, 2); mov(ds, ax);                              /* mov ds, ax */
            ii(0x13_810f, 5); cmp(memb_a16[ds, 0xa2a], 0);              /* cmp byte [0xa2a], 0x0 */
            ii(0x13_8114, 2); if(jzw(0x13_8124, 0xe)) goto l_0x13_8124; /* jz 0x8124 */
            ii(0x13_8116, 3); mov(ax, memw_a16[ss, bp + 0x6]);          /* mov ax, [bp+0x6] */
            ii(0x13_8119, 4); les(bx, ds, 0xa26);                       /* les bx, [0xa26] */
            ii(0x13_811d, 4); mov(memw_a16[es, bx + 0x10], ax);         /* mov [es:bx+0x10], ax */
            ii(0x13_8121, 1); popw(ds);                                 /* pop ds */
            ii(0x13_8122, 1); leavew();                                 /* leave */
            ii(0x13_8123, 1); retfw(); return;                          /* retf */
        l_0x13_8124:
            ii(0x13_8124, 2); mov(ah, 0x50);                            /* mov ah, 0x50 */
            ii(0x13_8126, 3); mov(bx, memw_a16[ss, bp + 0x6]);          /* mov bx, [bp+0x6] */
            ii(0x13_8129, 2); @int(0x21);                               /* int 0x21 */
            ii(0x13_812b, 1); popw(ds);                                 /* pop ds */
            ii(0x13_812c, 1); leavew();                                 /* leave */
            ii(0x13_812d, 1); retfw(); return;                          /* retf */
        }
    }
}
