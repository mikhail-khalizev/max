using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x9c92-e24c31ca")]
        public void Method_0000_9c92()
        {
            ii(0x9c92, 1);  push(es);                                  /* push es */
            ii(0x9c93, 3);  mov(ax, 0xf000);                           /* mov ax, 0xf000 */
            ii(0x9c96, 2);  mov(es, ax);                               /* mov es, ax */
            ii(0x9c98, 3);  mov(ax, 0);                                /* mov ax, 0x0 */
            ii(0x9c9b, 5);  mov(cl, memb[es, -2]);                     /* mov cl, [es:0xfffe] */
            ii(0x9ca0, 1);  pop(es);                                   /* pop es */
            ii(0x9ca1, 3);  cmp(cl, -0x1f /* 0xe1 */);                 /* cmp cl, 0xe1 */
            ii(0x9ca4, 2);  if(jnz(0x9ca8, 2)) goto l_0x9ca8;          /* jnz 0x9ca8 */
            ii(0x9ca6, 2);  mov(ax, cx);                               /* mov ax, cx */
        l_0x9ca8:
            ii(0x9ca8, 1);  ret();                                     /* ret */
        }
    }
}
