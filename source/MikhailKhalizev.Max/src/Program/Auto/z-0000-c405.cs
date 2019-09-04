using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0xc405-33a4c219")]
        public void Method_0000_c405()
        {
            ii(0xc405, 3);    mov(ax, 0x3300);                          /* mov ax, 0x3300 */
            ii(0xc408, 2);    @int(0x21);                               /* int 0x21 */
            ii(0xc40a, 2);    mov(cl, dl);                              /* mov cl, dl */
            ii(0xc40c, 2);    mov(bx, sp);                              /* mov bx, sp */
            ii(0xc40e, 3);    mov(dl, memb[ds, bx + 2]);                /* mov dl, [bx+0x2] */
            ii(0xc411, 1);    inc(ax);                                  /* inc ax */
            ii(0xc412, 2);    @int(0x21);                               /* int 0x21 */
            ii(0xc414, 1);    xchg(cx, ax);                             /* xchg cx, ax */
            ii(0xc415, 1);    cbw();                                    /* cbw */
            ii(0xc416, 1);    ret();                                    /* ret */
        }
    }
}
