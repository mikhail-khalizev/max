using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("35399eef-15e2-415f-ba28-21c7b2022d76")]
        public void Method_0014_c832()
        {
            ii(0x14_c832, 1); pushw(bp);                                /* push bp */
            ii(0x14_c833, 2); mov(bp, sp);                              /* mov bp, sp */
            ii(0x14_c835, 5); cmp(memb_a16[ds, 0x2e], 0);               /* cmp byte [0x2e], 0x0 */
            ii(0x14_c83a, 2); if(jzw(0x14_c855, 0x19)) goto l_0x14_c855; /* jz 0xc855 */
            ii(0x14_c83c, 3); mov(ax, memw_a16[ss, bp + 0x4]);          /* mov ax, [bp+0x4] */
            ii(0x14_c83f, 4); cmp(memw_a16[ds, 0x97c], ax);             /* cmp [0x97c], ax */
            ii(0x14_c843, 2); if(jbew(0x14_c855, 0x10)) goto l_0x14_c855; /* jbe 0xc855 */
            ii(0x14_c845, 2); and(al, 0xf8);                            /* and al, 0xf8 */
            ii(0x14_c847, 2); mov(bx, ax);                              /* mov bx, ax */
            ii(0x14_c849, 3); mov(cx, 0x8);                             /* mov cx, 0x8 */
            ii(0x14_c84c, 2); mov(es, cx);                              /* mov es, cx */
            ii(0x14_c84e, 5); cmp(memb_a16[es, bx + 0x5], 0);           /* cmp byte [es:bx+0x5], 0x0 */
            ii(0x14_c853, 2); if(jzw(0x14_c859, 0x4)) goto l_0x14_c859; /* jz 0xc859 */
        l_0x14_c855:
            ii(0x14_c855, 2); sub(ax, ax);                              /* sub ax, ax */
            ii(0x14_c857, 1); leavew();                                 /* leave */
            ii(0x14_c858, 1); retw(); return;                           /* ret */
        l_0x14_c859:
            ii(0x14_c859, 3); mov(ax, memw_a16[ss, bp + 0x4]);          /* mov ax, [bp+0x4] */
            ii(0x14_c85c, 1); leavew();                                 /* leave */
            ii(0x14_c85d, 1); retw(); return;                           /* ret */
        }
    }
}
