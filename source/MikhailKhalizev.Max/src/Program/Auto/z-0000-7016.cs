using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x7016-2627cff8")]
        public void Method_0000_7016()
        {
            ii(0x7016, 2);    mov(bx, sp);                              /* mov bx, sp */
            ii(0x7018, 1);    pushfw();                                 /* pushfw */
            ii(0x7019, 1);    pop(ax);                                  /* pop ax */
            ii(0x701a, 5);    cmp(memw[ss, bx + 2], 0);                 /* cmp word [ss:bx+0x2], 0x0 */
            ii(0x701f, 1);    cli();                                    /* cli */
            ii(0x7020, 2);    if(jz(0x7023, 1)) goto l_0x7023;          /* jz 0x7023 */
            ii(0x7022, 1);    sti();                                    /* sti */
        l_0x7023:
            ii(0x7023, 3);    shr(ax, 9);                               /* shr ax, 0x9 */
            ii(0x7026, 3);    and(ax, 1);                               /* and ax, 0x1 */
            ii(0x7029, 1);    ret();                                    /* ret */
        }
    }
}
