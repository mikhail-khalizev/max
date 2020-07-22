using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0xaa14-dfc683cb")]
        public void Method_0000_aa14()
        {
            ii(0xaa14, 3);  mov(ax, 0x4300);                           /* mov ax, 0x4300 */
            ii(0xaa17, 2);  @int(0x2f);                                /* int 0x2f */
            ii(0xaa19, 2);  cmp(al, -0x80 /* 0x80 */);                 /* cmp al, 0x80 */
            ii(0xaa1b, 2);  if(jz(0xaa1f, 2)) goto l_0xaa1f;           /* jz 0xaa1f */
            ii(0xaa1d, 2);  xor(ax, ax);                               /* xor ax, ax */
        l_0xaa1f:
            ii(0xaa1f, 4);  or(memb[ds, 0x36], al);                    /* or [0x36], al */
            ii(0xaa23, 1);  ret();                                     /* ret */
        }
    }
}
