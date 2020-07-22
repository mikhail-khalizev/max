using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x7b77-6d253b49")]
        public void Method_0000_7b77()
        {
            ii(0x7b77, 1);  push(bp);                                  /* push bp */
            ii(0x7b78, 2);  mov(bp, sp);                               /* mov bp, sp */
            ii(0x7b7a, 4);  cmp(memw[ss, bp + 4], 1);                  /* cmp word [bp+0x4], 0x1 */
            ii(0x7b7e, 2);  if(jz(0x7b92, 0x12)) goto l_0x7b92;        /* jz 0x7b92 */
            ii(0x7b80, 4);  cmp(memw[ss, bp + 4], 5);                  /* cmp word [bp+0x4], 0x5 */
            ii(0x7b84, 2);  if(jz(0x7b92, 0xc)) goto l_0x7b92;         /* jz 0x7b92 */
            ii(0x7b86, 4);  cmp(memw[ss, bp + 4], 0xe);                /* cmp word [bp+0x4], 0xe */
            ii(0x7b8a, 2);  if(jz(0x7b92, 6)) goto l_0x7b92;           /* jz 0x7b92 */
            ii(0x7b8c, 4);  cmp(memw[ss, bp + 4], 0xf);                /* cmp word [bp+0x4], 0xf */
            ii(0x7b90, 2);  if(jnz(0x7b97, 5)) goto l_0x7b97;          /* jnz 0x7b97 */
        l_0x7b92:
            ii(0x7b92, 3);  mov(ax, 1);                                /* mov ax, 0x1 */
            ii(0x7b95, 1);  pop(bp);                                   /* pop bp */
            ii(0x7b96, 1);  ret(); return;                             /* ret */
        l_0x7b97:
            ii(0x7b97, 2);  sub(ax, ax);                               /* sub ax, ax */
            ii(0x7b99, 1);  pop(bp);                                   /* pop bp */
            ii(0x7b9a, 1);  ret();                                     /* ret */
        }
    }
}
