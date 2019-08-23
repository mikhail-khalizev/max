using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x9fb7-8e6cb464")]
        public void Method_0000_9fb7()
        {
            ii(0x9fb7, 3);    call(0x41fd, -0x5dbd);                    /* call 0x41fd */
            ii(0x9fba, 3);    cmp(cl, 0x1);                             /* cmp cl, 0x1 */
            ii(0x9fbd, 2);    sbb(dx, dx);                              /* sbb dx, dx */
            ii(0x9fbf, 2);    inb(al, 0x92);                            /* in al, 0x92 */
            ii(0x9fc1, 2);    mov(bx, ax);                              /* mov bx, ax */
            ii(0x9fc3, 3);    and(bx, 0x2);                             /* and bx, 0x2 */
            ii(0x9fc6, 3);    cmp(bl, 0x2);                             /* cmp bl, 0x2 */
            ii(0x9fc9, 2);    sbb(bx, bx);                              /* sbb bx, bx */
            ii(0x9fcb, 2);    xor(bx, dx);                              /* xor bx, dx */
            ii(0x9fcd, 2);    or(si, bx);                               /* or si, bx */
            ii(0x9fcf, 1);    ret();                                    /* ret */
        }
    }
}
