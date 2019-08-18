using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("28f57a6d-c072-42e9-ae51-00e899c28eb0")]
        public void Method_0000_c405()
        {
            ii(0xc405, 3);    mov(ax, 0x3300);                          /* mov ax, 0x3300 */
            ii(0xc408, 2);    @int(0x21);                               /* int 0x21 */
            ii(0xc40a, 2);    mov(cl, dl);                              /* mov cl, dl */
            ii(0xc40c, 2);    mov(bx, sp);                              /* mov bx, sp */
            ii(0xc40e, 3);    mov(dl, memb_a16[ds, bx + 0x2]);          /* mov dl, [bx+0x2] */
            ii(0xc411, 1);    inc(ax);                                  /* inc ax */
            ii(0xc412, 2);    @int(0x21);                               /* int 0x21 */
            ii(0xc414, 1);    xchg(cx, ax);                             /* xchg cx, ax */
            ii(0xc415, 1);    cbw();                                    /* cbw */
            ii(0xc416, 1);    retw(); return;                           /* ret */
        }
    }
}
