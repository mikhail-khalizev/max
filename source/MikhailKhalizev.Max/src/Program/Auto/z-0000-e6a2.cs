using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0xe6a2-e01c802")]
        public void Method_0000_e6a2()
        {
            ii(0xe6a2, 2);    inb(al, 0xd);                             /* in al, 0xd */
            ii(0xe6a4, 3);    mov(ax, memw_a16[ss, bp + 0x10]);         /* mov ax, [bp+0x10] */
            ii(0xe6a7, 1);    stosw_a16();                              /* stosw */
            ii(0xe6a8, 3);    mov(ax, memw_a16[ss, bp + 0x14]);         /* mov ax, [bp+0x14] */
            ii(0xe6ab, 1);    stosw_a16();                              /* stosw */
            ii(0xe6ac, 3);    mov(ax, memw_a16[ss, bp + 0x8]);          /* mov ax, [bp+0x8] */
            ii(0xe6af, 1);    stosw_a16();                              /* stosw */
            ii(0xe6b0, 3);    mov(ax, memw_a16[ss, bp + 0xa]);          /* mov ax, [bp+0xa] */
            ii(0xe6b3, 1);    stosw_a16();                              /* stosw */
            ii(0xe6b4, 1);    xchg(cx, ax);                             /* xchg cx, ax */
            ii(0xe6b5, 2);    if(jcxzw(0xe6bc, 0x5)) goto l_0xe6bc;     /* jcxz 0xe6bc */
            ii(0xe6b7, 5);    or(memb_a16[ds, 0x47], 0x20);             /* or byte [0x47], 0x20 */
        l_0xe6bc:
            ii(0xe6bc, 1);    retw(); return;                           /* ret */
        }
    }
}
