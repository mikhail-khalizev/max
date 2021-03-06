using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x61de-16c66f28")]
        public void Method_0000_61de()
        {
            ii(0x61de, 1);  push(bp);                                  /* push bp */
            ii(0x61df, 2);  mov(bp, sp);                               /* mov bp, sp */
            ii(0x61e1, 3);  sub(sp, 2);                                /* sub sp, 0x2 */
            ii(0x61e4, 3);  push(memw[ss, bp + 4]);                    /* push word [bp+0x4] */
            ii(0x61e7, 3);  call(0xa363, 0x4179);                      /* call 0xa363 */
            ii(0x61ea, 1);  pop(bx);                                   /* pop bx */
            ii(0x61eb, 3);  mov(memw[ss, bp - 2], ax);                 /* mov [bp-0x2], ax */
            ii(0x61ee, 1);  inc(ax);                                   /* inc ax */
            ii(0x61ef, 2);  if(jz(0x61f6, 5)) goto l_0x61f6;           /* jz 0x61f6 */
            ii(0x61f1, 3);  mov(ax, memw[ss, bp - 2]);                 /* mov ax, [bp-0x2] */
            ii(0x61f4, 2);  jmp(0x61f8, 2); goto l_0x61f8;             /* jmp 0x61f8 */
        l_0x61f6:
            ii(0x61f6, 2);  sub(ax, ax);                               /* sub ax, ax */
        l_0x61f8:
            ii(0x61f8, 2);  mov(sp, bp);                               /* mov sp, bp */
            ii(0x61fa, 1);  pop(bp);                                   /* pop bp */
            ii(0x61fb, 1);  ret();                                     /* ret */
        }
    }
}
