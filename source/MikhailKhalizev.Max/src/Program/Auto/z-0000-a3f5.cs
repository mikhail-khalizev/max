using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0xa3f5-33a4c219")]
        public void Method_0000_a3f5()
        {
            ii(0xa3f5, 3);    mov(ax, 0x3300);                          /* mov ax, 0x3300 */
            ii(0xa3f8, 2);    @int(0x21);                               /* int 0x21 */
            ii(0xa3fa, 2);    mov(cl, dl);                              /* mov cl, dl */
            ii(0xa3fc, 2);    mov(bx, sp);                              /* mov bx, sp */
            ii(0xa3fe, 3);    mov(dl, memb_a16[ds, bx + 0x2]);          /* mov dl, [bx+0x2] */
            ii(0xa401, 1);    inc(ax);                                  /* inc ax */
            ii(0xa402, 2);    @int(0x21);                               /* int 0x21 */
            ii(0xa404, 1);    xchg(cx, ax);                             /* xchg cx, ax */
            ii(0xa405, 1);    cbw();                                    /* cbw */
            ii(0xa406, 1);    retw(); return;                           /* ret */
        }
    }
}
