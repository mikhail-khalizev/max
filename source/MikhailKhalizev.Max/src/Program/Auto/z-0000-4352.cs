using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x4352-12c9c546")]
        public void Method_0000_4352()
        {
            ii(0x4352, 3);    and(bl, 0xf8);                            /* and bl, 0xf8 */
            ii(0x4355, 3);    mov(dh, memb[ds, bx + 7]);                /* mov dh, [bx+0x7] */
            ii(0x4358, 3);    mov(dl, memb[ds, bx + 4]);                /* mov dl, [bx+0x4] */
            ii(0x435b, 3);    mov(bx, memw[ds, bx + 2]);                /* mov bx, [bx+0x2] */
            ii(0x435e, 3);    and(bl, 0xf0);                            /* and bl, 0xf0 */
            ii(0x4361, 2);    or(bl, dl);                               /* or bl, dl */
            ii(0x4363, 3);    ror(bx, 4);                               /* ror bx, 0x4 */
            ii(0x4366, 4);    test(dx, 0xfff0);                         /* test dx, 0xfff0 */
            ii(0x436a, 2);    if(jz(0x436f, 3)) goto l_0x436f;          /* jz 0x436f */
            ii(0x436c, 3);    mov(bx, 0xe000);                          /* mov bx, 0xe000 */
        l_0x436f:
            ii(0x436f, 1);    ret();                                    /* ret */
        }
    }
}
