using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0xa264-dfc683cb")]
        public void Method_0000_a264()
        {
            ii(0xa264, 3);    mov(ax, 0x4300);                          /* mov ax, 0x4300 */
            ii(0xa267, 2);    @int(0x2f);                               /* int 0x2f */
            ii(0xa269, 2);    cmp(al, -0x80 /* 0x80 */);                /* cmp al, 0x80 */
            ii(0xa26b, 2);    if(jz(0xa26f, 2)) goto l_0xa26f;          /* jz 0xa26f */
            ii(0xa26d, 2);    xor(ax, ax);                              /* xor ax, ax */
        l_0xa26f:
            ii(0xa26f, 4);    or(memb[ds, 0x36], al);                   /* or [0x36], al */
            ii(0xa273, 1);    ret();                                    /* ret */
        }
    }
}
