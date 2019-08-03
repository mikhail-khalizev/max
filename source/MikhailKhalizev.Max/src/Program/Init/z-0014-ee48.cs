using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("ef9a3eb0-c366-4862-8a45-3b01ca6578f7")]
        public void Method_0014_ee48()
        {
            ii(0x14_ee48, 3); test(cl, 0xc0);                           /* test cl, 0xc0 */
            ii(0x14_ee4b, 2); jzw_func(0x14_ee84, 0x37);                /* jz 0xee84 */
            ii(0x14_ee4d, 1); pushw(ax);                                /* push ax */
            ii(0x14_ee4e, 2); mov(al, cl);                              /* mov al, cl */
            ii(0x14_ee50, 1); pushw(dx);                                /* push dx */
            ii(0x14_ee51, 2); and(al, 0x1f);                            /* and al, 0x1f */
            ii(0x14_ee53, 3); mov(dx, 0x18);                            /* mov dx, 0x18 */
            ii(0x14_ee56, 1); pushw(ds);                                /* push ds */
            ii(0x14_ee57, 2); mov(ds, dx);                              /* mov ds, dx */
            ii(0x14_ee59, 4); cmp(al, memb_a16[ds, 0x8]);               /* cmp al, [0x8] */
            ii(0x14_ee5d, 2); jzw_func(0x14_ee44, -0x1b);               /* jz 0xee44 */
            ii(0x14_ee5f, 3); mov(ax, 0x20);                            /* mov ax, 0x20 */
            ii(0x14_ee62, 2); mov(ds, ax);                              /* mov ds, ax */
            ii(0x14_ee64, 2); test(cl, cl);                             /* test cl, cl */
            ii(0x14_ee66, 2); jsw_func(0x14_ee3e, -0x2a);               /* js 0xee3e */
            ii(0x14_ee68, 4); mov(dx, memw_a16[ds, 0x4a]);              /* mov dx, [0x4a] */
        }
    }
}
