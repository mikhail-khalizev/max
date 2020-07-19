using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x18_0a40-10208ab0")]
        public void Method_0018_0a40()
        {
            ii(0x18_0a40, 1);  push(ds);                               /* push ds */
            ii(0x18_0a41, 3);  mov(ax, 0x3e68);                        /* mov ax, 0x3e68 */
            ii(0x18_0a44, 2);  mov(ds, ax);                            /* mov ds, ax */
            ii(0x18_0a46, 3);  mov(ax, memw[ds, 0x1418]);              /* mov ax, [0x1418] */
            ii(0x18_0a49, 2);  sub(bx, bx);                            /* sub bx, bx */
            ii(0x18_0a4b, 2);  mov(es, ax);                            /* mov es, ax */
            ii(0x18_0a4d, 4);  mov(al, memb[es, bx + 71]);             /* mov al, [es:bx+0x47] */
            ii(0x18_0a51, 3);  and(ax, 0x80);                          /* and ax, 0x80 */
            ii(0x18_0a54, 1);  pop(ds);                                /* pop ds */
            ii(0x18_0a55, 1);  ret();                                  /* ret */
        }
    }
}
