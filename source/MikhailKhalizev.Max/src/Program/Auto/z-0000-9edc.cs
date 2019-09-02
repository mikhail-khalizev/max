using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x9edc-aada4fc4")]
        public void Method_0000_9edc()
        {
            ii(0x9edc, 3);    mov(ax, 1);                               /* mov ax, 0x1 */
            ii(0x9edf, 5);    cmp(memb[ds, 0xcee], 2);                  /* cmp byte [0xcee], 0x2 */
            ii(0x9ee4, 2);    if(jbe(0x9ef4, 0xe)) goto l_0x9ef4;       /* jbe 0x9ef4 */
            ii(0x9ee6, 3);    sub(sp, 0x22);                            /* sub sp, 0x22 */
            ii(0x9ee9, 2);    mov(dx, sp);                              /* mov dx, sp */
            ii(0x9eeb, 3);    mov(ax, 0x3800);                          /* mov ax, 0x3800 */
            ii(0x9eee, 2);    @int(0x21);                               /* int 0x21 */
            ii(0x9ef0, 3);    add(sp, 0x22);                            /* add sp, 0x22 */
            ii(0x9ef3, 1);    xchg(bx, ax);                             /* xchg bx, ax */
        l_0x9ef4:
            ii(0x9ef4, 1);    ret();                                    /* ret */
        }
    }
}
