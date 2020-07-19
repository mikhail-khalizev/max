using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x18_b058-961a6c9")]
        public void Method_0018_b058()
        {
            ii(0x18_b058, 1);  push(bp);                               /* push bp */
            ii(0x18_b059, 2);  mov(bp, sp);                            /* mov bp, sp */
            ii(0x18_b05b, 3);  mov(bp, memw[ss, bp + 4]);              /* mov bp, [bp+0x4] */
            ii(0x18_b05e, 4);  mov(bx, memw[ds, 0x996]);               /* mov bx, [0x996] */
            ii(0x18_b062, 4);  mov(memb[ds, bx + 23], 0x48);           /* mov byte [bx+0x17], 0x48 */
            ii(0x18_b066, 3);  call(0x18_a893, -0x7d6);                /* call 0xa893 */
            ii(0x18_b069, 2);  xor(dx, dx);                            /* xor dx, dx */
            ii(0x18_b06b, 3);  mov(ax, memw[ds, bx + 16]);             /* mov ax, [bx+0x10] */
            ii(0x18_b06e, 3);  mov(memw[ss, bp + 16], ax);             /* mov [bp+0x10], ax */
            ii(0x18_b071, 3);  mov(memw[ds, 0x11fa], ax);              /* mov [0x11fa], ax */
            ii(0x18_b074, 3);  mov(ax, memw[ds, bx + 22]);             /* mov ax, [bx+0x16] */
            ii(0x18_b077, 3);  mov(memw[ss, bp + 22], ax);             /* mov [bp+0x16], ax */
            ii(0x18_b07a, 4);  test(memb[ds, bx + 38], 1);             /* test byte [bx+0x26], 0x1 */
            ii(0x18_b07e, 2);  if(jz(0x18_b082, 2)) goto l_0x18_b082;  /* jz 0xb082 */
            ii(0x18_b080, 2);  xor(ax, ax);                            /* xor ax, ax */
        l_0x18_b082:
            ii(0x18_b082, 1);  pop(bp);                                /* pop bp */
            ii(0x18_b083, 1);  ret();                                  /* ret */
        }
    }
}
