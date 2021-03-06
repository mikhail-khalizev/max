using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x59f4-22d2681f")]
        public void Method_0000_59f4()
        {
            ii(0x59f4, 1);  push(bp);                                  /* push bp */
            ii(0x59f5, 2);  mov(bp, sp);                               /* mov bp, sp */
            ii(0x59f7, 3);  sub(sp, 0xe);                              /* sub sp, 0xe */
            ii(0x59fa, 4);  mov(memb[ss, bp - 13], 0x4c);              /* mov byte [bp-0xd], 0x4c */
            ii(0x59fe, 3);  mov(al, memb[ss, bp + 4]);                 /* mov al, [bp+0x4] */
            ii(0x5a01, 3);  mov(memb[ss, bp - 14], al);                /* mov [bp-0xe], al */
            ii(0x5a04, 3);  lea(ax, memw[ss, bp - 14]);                /* lea ax, [bp-0xe] */
            ii(0x5a07, 1);  push(ax);                                  /* push ax */
            ii(0x5a08, 1);  push(ax);                                  /* push ax */
            ii(0x5a09, 3);  call(0x5cc0, 0x2b4);                       /* call 0x5cc0 */
            ii(0x5a0c, 1);  pop(bx);                                   /* pop bx */
            ii(0x5a0d, 1);  pop(bx);                                   /* pop bx */
            ii(0x5a0e, 2);  mov(sp, bp);                               /* mov sp, bp */
            ii(0x5a10, 1);  pop(bp);                                   /* pop bp */
            ii(0x5a11, 1);  ret();                                     /* ret */
        }
    }
}
