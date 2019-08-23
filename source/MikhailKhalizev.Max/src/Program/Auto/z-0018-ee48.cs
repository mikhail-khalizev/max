using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x18_ee48-f39805a1")]
        public void Method_0018_ee48()
        {
            ii(0x18_ee48, 3); test(cl, 0xc0);                           /* test cl, 0xc0 */
            ii(0x18_ee4b, 2); if(jz_func(0x18_ee84, 0x37)) return;      /* jz 0xee84 */
            ii(0x18_ee4d, 1); push(ax);                                 /* push ax */
            ii(0x18_ee4e, 2); mov(al, cl);                              /* mov al, cl */
            ii(0x18_ee50, 1); push(dx);                                 /* push dx */
            ii(0x18_ee51, 2); and(al, 0x1f);                            /* and al, 0x1f */
            ii(0x18_ee53, 3); mov(dx, 0x18);                            /* mov dx, 0x18 */
            ii(0x18_ee56, 1); push(ds);                                 /* push ds */
            ii(0x18_ee57, 2); mov(ds, dx);                              /* mov ds, dx */
            ii(0x18_ee59, 4); cmp(al, memb[ds, 0x8]);                   /* cmp al, [0x8] */
            ii(0x18_ee5d, 2); if(jz_func(0x18_ee44, -0x1b)) return;     /* jz 0xee44 */
            ii(0x18_ee5f, 3); mov(ax, 0x20);                            /* mov ax, 0x20 */
            ii(0x18_ee62, 2); mov(ds, ax);                              /* mov ds, ax */
            ii(0x18_ee64, 2); test(cl, cl);                             /* test cl, cl */
            ii(0x18_ee66, 2); if(js_func(0x18_ee3e, -0x2a)) return;     /* js 0xee3e */
            ii(0x18_ee68, 4); mov(dx, memw[ds, 0x4a]);                  /* mov dx, [0x4a] */
        }
    }
}
