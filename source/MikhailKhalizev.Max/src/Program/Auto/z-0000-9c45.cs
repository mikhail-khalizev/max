using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x9c45-33a4c219")]
        public void Method_0000_9c45()
        {
            ii(0x9c45, 3);    mov(ax, 0x3300);                          /* mov ax, 0x3300 */
            ii(0x9c48, 2);    @int(0x21);                               /* int 0x21 */
            ii(0x9c4a, 2);    mov(cl, dl);                              /* mov cl, dl */
            ii(0x9c4c, 2);    mov(bx, sp);                              /* mov bx, sp */
            ii(0x9c4e, 3);    mov(dl, memb_a16[ds, bx + 0x2]);          /* mov dl, [bx+0x2] */
            ii(0x9c51, 1);    inc(ax);                                  /* inc ax */
            ii(0x9c52, 2);    @int(0x21);                               /* int 0x21 */
            ii(0x9c54, 1);    xchg(cx, ax);                             /* xchg cx, ax */
            ii(0x9c55, 1);    cbw();                                    /* cbw */
            ii(0x9c56, 1);    retw(); return;                           /* ret */
        }
    }
}
