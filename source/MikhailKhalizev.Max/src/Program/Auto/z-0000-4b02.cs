using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x4b02-12c9c546")]
        public void Method_0000_4b02()
        {
            ii(0x4b02, 3);    and(bl, 0xf8);                            /* and bl, 0xf8 */
            ii(0x4b05, 3);    mov(dh, memb[ds, bx + 7]);                /* mov dh, [bx+0x7] */
            ii(0x4b08, 3);    mov(dl, memb[ds, bx + 4]);                /* mov dl, [bx+0x4] */
            ii(0x4b0b, 3);    mov(bx, memw[ds, bx + 2]);                /* mov bx, [bx+0x2] */
            ii(0x4b0e, 3);    and(bl, 0xf0);                            /* and bl, 0xf0 */
            ii(0x4b11, 2);    or(bl, dl);                               /* or bl, dl */
            ii(0x4b13, 3);    ror(bx, 4);                               /* ror bx, 0x4 */
            ii(0x4b16, 4);    test(dx, 0xfff0);                         /* test dx, 0xfff0 */
            ii(0x4b1a, 2);    if(jz(0x4b1f, 3)) goto l_0x4b1f;          /* jz 0x4b1f */
            ii(0x4b1c, 3);    mov(bx, 0xe000);                          /* mov bx, 0xe000 */
        l_0x4b1f:
            ii(0x4b1f, 1);    ret();                                    /* ret */
        }
    }
}
