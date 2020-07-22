using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x18_f2c0-6d77f75")]
        public void Method_0018_f2c0()
        {
            ii(0x18_f2c0, 5);  test(memb[ds, 0x1582], 1);              /* test byte [0x1582], 0x1 */
            ii(0x18_f2c5, 4);  if(jnz_func(0x18_f351, 0x88)) return;   /* jnz 0xf351 */
            ii(0x18_f2c9, 1);  push(cs);                               /* push cs */
            ii(0x18_f2ca, 3);  call(0x18_f270, -0x5d);                 /* call 0xf270 */
            ii(0x18_f2cd, 2);  or(ax, ax);                             /* or ax, ax */
            ii(0x18_f2cf, 4);  if(jz_func(0x18_f34e, 0x7b)) return;    /* jz 0xf34e */
            ii(0x18_f2d3, 1);  pop(ax);                                /* pop ax */
            ii(0x18_f2d4, 1);  inc(ax);                                /* inc ax */
            ii(0x18_f2d5, 1);  push(ax);                               /* push ax */
            ii(0x18_f2d6, 2);  jmp_func(0x18_f33b, 0x63);              /* jmp 0xf33b */
        }
    }
}
