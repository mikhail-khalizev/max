using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("fd3a08b5-bfd4-4666-a88c-f46e90754689")]
        public void Method_0000_5006()
        {
            ii(0x5006, 2);    mov(bx, sp);                              /* mov bx, sp */
            ii(0x5008, 1);    pushfw();                                 /* pushfw */
            ii(0x5009, 1);    popw(ax);                                 /* pop ax */
            ii(0x500a, 5);    cmp(memw_a16[ss, bx + 0x2], 0);           /* cmp word [ss:bx+0x2], 0x0 */
            ii(0x500f, 1);    cli();                                    /* cli */
            ii(0x5010, 2);    if(jzw(0x5013, 0x1)) goto l_0x5013;       /* jz 0x5013 */
            ii(0x5012, 1);    sti();                                    /* sti */
        l_0x5013:
            ii(0x5013, 3);    shr(ax, 0x9);                             /* shr ax, 0x9 */
            ii(0x5016, 3);    and(ax, 0x1);                             /* and ax, 0x1 */
            ii(0x5019, 1);    retw(); return;                           /* ret */
        }
    }
}
