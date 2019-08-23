using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x19_0520-e1d3bd9a")]
        public void Method_0019_0520()
        {
            ii(0x19_0520, 1); pushw(cs);                                /* push cs */
            ii(0x19_0521, 3); callw(0x19_0534, 0x10);                   /* call 0x534 */
            ii(0x19_0524, 2); or(ax, ax);                               /* or ax, ax */
            ii(0x19_0526, 2); if(jzw(0x19_0533, 0xb)) goto l_0x19_0533; /* jz 0x533 */
            ii(0x19_0528, 1); pushw(ds);                                /* push ds */
            ii(0x19_0529, 3); pushw(0x1878);                            /* push 0x1878 */
            ii(0x19_052c, 1); nop();                                    /* nop */
            ii(0x19_052d, 1); pushw(cs);                                /* push cs */
            ii(0x19_052e, 3); callw(0x19_4f5a, 0x4a29);                 /* call 0x4f5a */
            ii(0x19_0531, 1); popw(bx);                                 /* pop bx */
            ii(0x19_0532, 1); popw(bx);                                 /* pop bx */
        l_0x19_0533:
            ii(0x19_0533, 1); retfw();                                  /* retf */
        }
    }
}
