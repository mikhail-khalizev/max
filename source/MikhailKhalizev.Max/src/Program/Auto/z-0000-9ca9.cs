using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x9ca9-978e48f6")]
        public void Method_0000_9ca9()
        {
            ii(0x9ca9, 3);    callw(0x41fd, -0x5aaf);                   /* call 0x41fd */
            ii(0x9cac, 2);    mov(al, 0x45);                            /* mov al, 0x45 */
            ii(0x9cae, 3);    callw(0x3d23, -0x5f8e);                   /* call 0x3d23 */
            ii(0x9cb1, 2);    test(al, 0x80);                           /* test al, 0x80 */
            ii(0x9cb3, 2);    if(jnzw(0x9cc1, 0xc)) goto l_0x9cc1;      /* jnz 0x9cc1 */
            ii(0x9cb5, 2);    neg(cx);                                  /* neg cx */
            ii(0x9cb7, 3);    and(ch, 0x40);                            /* and ch, 0x40 */
            ii(0x9cba, 2);    xor(ch, al);                              /* xor ch, al */
            ii(0x9cbc, 2);    if(jzw(0x9cc1, 0x3)) goto l_0x9cc1;       /* jz 0x9cc1 */
            ii(0x9cbe, 2);    mov(al, 0x1);                             /* mov al, 0x1 */
            ii(0x9cc0, 1);    retw(); return;                           /* ret */
        l_0x9cc1:
            ii(0x9cc1, 2);    xor(ax, ax);                              /* xor ax, ax */
            ii(0x9cc3, 1);    retw();                                   /* ret */
        }
    }
}
