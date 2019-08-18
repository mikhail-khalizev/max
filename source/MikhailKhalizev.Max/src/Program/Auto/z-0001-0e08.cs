using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("338086f4-a540-4cd1-9027-8a676f7fab75")]
        public void Method_0001_0e08()
        {
            ii(0x1_0e08, 3);  test(cl, 0xc0);                           /* test cl, 0xc0 */
            ii(0x1_0e0b, 2);  if(jzw_func(0x1_0e44, 0x37)) return;      /* jz 0xe44 */
            ii(0x1_0e0d, 1);  pushw(ax);                                /* push ax */
            ii(0x1_0e0e, 2);  mov(al, cl);                              /* mov al, cl */
            ii(0x1_0e10, 1);  pushw(dx);                                /* push dx */
            ii(0x1_0e11, 2);  and(al, 0x1f);                            /* and al, 0x1f */
            ii(0x1_0e13, 3);  mov(dx, 0x18);                            /* mov dx, 0x18 */
            ii(0x1_0e16, 1);  pushw(ds);                                /* push ds */
            ii(0x1_0e17, 2);  mov(ds, dx);                              /* mov ds, dx */
            ii(0x1_0e19, 4);  cmp(al, memb_a16[ds, 0x8]);               /* cmp al, [0x8] */
            ii(0x1_0e1d, 2);  if(jzw_func(0x1_0e04, -0x1b)) return;     /* jz 0xe04 */
            ii(0x1_0e1f, 3);  mov(ax, 0x20);                            /* mov ax, 0x20 */
            ii(0x1_0e22, 2);  mov(ds, ax);                              /* mov ds, ax */
            ii(0x1_0e24, 2);  test(cl, cl);                             /* test cl, cl */
            ii(0x1_0e26, 2);  if(jsw_func(0x1_0dfe, -0x2a)) return;     /* js 0xdfe */
            ii(0x1_0e28, 4);  mov(dx, memw_a16[ds, 0x4a]);              /* mov dx, [0x4a] */
        }
    }
}
