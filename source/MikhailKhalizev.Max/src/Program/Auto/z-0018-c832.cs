using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x18_c832-51746285")]
        public void Method_0018_c832()
        {
            ii(0x18_c832, 1); push(bp);                                 /* push bp */
            ii(0x18_c833, 2); mov(bp, sp);                              /* mov bp, sp */
            ii(0x18_c835, 5); cmp(memb[ds, 0x2e], 0);                   /* cmp byte [0x2e], 0x0 */
            ii(0x18_c83a, 2); if(jz(0x18_c855, 0x19)) goto l_0x18_c855; /* jz 0xc855 */
            ii(0x18_c83c, 3); mov(ax, memw[ss, bp + 0x4]);              /* mov ax, [bp+0x4] */
            ii(0x18_c83f, 4); cmp(memw[ds, 0x97c], ax);                 /* cmp [0x97c], ax */
            ii(0x18_c843, 2); if(jbe(0x18_c855, 0x10)) goto l_0x18_c855; /* jbe 0xc855 */
            ii(0x18_c845, 2); and(al, 0xf8);                            /* and al, 0xf8 */
            ii(0x18_c847, 2); mov(bx, ax);                              /* mov bx, ax */
            ii(0x18_c849, 3); mov(cx, 0x8);                             /* mov cx, 0x8 */
            ii(0x18_c84c, 2); mov(es, cx);                              /* mov es, cx */
            ii(0x18_c84e, 5); cmp(memb[es, bx + 0x5], 0);               /* cmp byte [es:bx+0x5], 0x0 */
            ii(0x18_c853, 2); if(jz(0x18_c859, 0x4)) goto l_0x18_c859;  /* jz 0xc859 */
        l_0x18_c855:
            ii(0x18_c855, 2); sub(ax, ax);                              /* sub ax, ax */
            ii(0x18_c857, 1); leave();                                  /* leave */
            ii(0x18_c858, 1); ret(); return;                            /* ret */
        l_0x18_c859:
            ii(0x18_c859, 3); mov(ax, memw[ss, bp + 0x4]);              /* mov ax, [bp+0x4] */
            ii(0x18_c85c, 1); leave();                                  /* leave */
            ii(0x18_c85d, 1); ret();                                    /* ret */
        }
    }
}
