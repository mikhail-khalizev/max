using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x5006-2627cff8")]
        public void Method_0000_5006()
        {
            ii(0x5006, 2);    mov(bx, sp);                              /* mov bx, sp */
            ii(0x5008, 1);    pushfw();                                 /* pushfw */
            ii(0x5009, 1);    pop(ax);                                  /* pop ax */
            ii(0x500a, 5);    cmp(memw[ss, bx + 2], 0);                 /* cmp word [ss:bx+0x2], 0x0 */
            ii(0x500f, 1);    cli();                                    /* cli */
            ii(0x5010, 2);    if(jz(0x5013, 1)) goto l_0x5013;          /* jz 0x5013 */
            ii(0x5012, 1);    sti();                                    /* sti */
        l_0x5013:
            ii(0x5013, 3);    shr(ax, 9);                               /* shr ax, 0x9 */
            ii(0x5016, 3);    and(ax, 1);                               /* and ax, 0x1 */
            ii(0x5019, 1);    ret();                                    /* ret */
        }
    }
}
