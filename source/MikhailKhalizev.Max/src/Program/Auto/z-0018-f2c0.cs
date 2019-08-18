using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x18_f2c0-6d77f75")]
        public void Method_0018_f2c0()
        {
            ii(0x18_f2c0, 5); test(memb_a16[ds, 0x1582], 0x1);          /* test byte [0x1582], 0x1 */
            ii(0x18_f2c5, 4); if(jnzw_func(0x18_f351, 0x88)) return;    /* jnz 0xf351 */
            ii(0x18_f2c9, 1); pushw(cs);                                /* push cs */
            ii(0x18_f2ca, 3); callw(0x18_f270, -0x5d);                  /* call 0xf270 */
            ii(0x18_f2cd, 2); or(ax, ax);                               /* or ax, ax */
            ii(0x18_f2cf, 4); if(jzw_func(0x18_f34e, 0x7b)) return;     /* jz 0xf34e */
            ii(0x18_f2d3, 1); popw(ax);                                 /* pop ax */
            ii(0x18_f2d4, 1); inc(ax);                                  /* inc ax */
            ii(0x18_f2d5, 1); pushw(ax);                                /* push ax */
            ii(0x18_f2d6, 2); if(jmpw_func(0x18_f33b, 0x63)) return;    /* jmp 0xf33b */
        }
    }
}
