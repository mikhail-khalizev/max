using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x4856-2627cff8")]
        public void Method_0000_4856()
        {
            ii(0x4856, 2);    mov(bx, sp);                              /* mov bx, sp */
            ii(0x4858, 1);    pushfw();                                 /* pushfw */
            ii(0x4859, 1);    popw(ax);                                 /* pop ax */
            ii(0x485a, 5);    cmp(memw_a16[ss, bx + 0x2], 0);           /* cmp word [ss:bx+0x2], 0x0 */
            ii(0x485f, 1);    cli();                                    /* cli */
            ii(0x4860, 2);    if(jzw(0x4863, 0x1)) goto l_0x4863;       /* jz 0x4863 */
            ii(0x4862, 1);    sti();                                    /* sti */
        l_0x4863:
            ii(0x4863, 3);    shr(ax, 0x9);                             /* shr ax, 0x9 */
            ii(0x4866, 3);    and(ax, 0x1);                             /* and ax, 0x1 */
            ii(0x4869, 1);    retw();                                   /* ret */
        }
    }
}
