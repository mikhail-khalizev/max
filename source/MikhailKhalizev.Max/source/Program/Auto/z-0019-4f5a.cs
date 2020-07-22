using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x19_4f5a-5db68d57")]
        public void Method_0019_4f5a()
        {
            ii(0x19_4f5a, 1);  push(bp);                               /* push bp */
            ii(0x19_4f5b, 2);  mov(bp, sp);                            /* mov bp, sp */
            ii(0x19_4f5d, 1);  push(ds);                               /* push ds */
            ii(0x19_4f5e, 3);  mov(ax, 0xa8);                          /* mov ax, 0xa8 */
            ii(0x19_4f61, 2);  mov(ds, ax);                            /* mov ds, ax */
            ii(0x19_4f63, 4);  mov(es, memw[ds, 0x3fe8]);              /* mov es, [0x3fe8] */
            ii(0x19_4f67, 4);  mov(ax, memw[es, 0x3b78]);              /* mov ax, [es:0x3b78] */
            ii(0x19_4f6b, 2);  sub(bx, bx);                            /* sub bx, bx */
            ii(0x19_4f6d, 2);  mov(es, ax);                            /* mov es, ax */
            ii(0x19_4f6f, 4);  mov(ax, memw[es, bx + 66]);             /* mov ax, [es:bx+0x42] */
            ii(0x19_4f73, 4);  mov(dx, memw[es, bx + 68]);             /* mov dx, [es:bx+0x44] */
            ii(0x19_4f77, 3);  les(bx, memw[ss, bp + 6]);              /* les bx, [bp+0x6] */
            ii(0x19_4f7a, 3);  mov(memw[es, bx], ax);                  /* mov [es:bx], ax */
            ii(0x19_4f7d, 4);  mov(memw[es, bx + 2], dx);              /* mov [es:bx+0x2], dx */
            ii(0x19_4f81, 4);  mov(es, memw[ds, 0x3fe8]);              /* mov es, [0x3fe8] */
            ii(0x19_4f85, 4);  mov(ax, memw[es, 0x3b78]);              /* mov ax, [es:0x3b78] */
            ii(0x19_4f89, 2);  sub(bx, bx);                            /* sub bx, bx */
            ii(0x19_4f8b, 2);  mov(es, ax);                            /* mov es, ax */
            ii(0x19_4f8d, 3);  mov(ax, memw[ss, bp + 6]);              /* mov ax, [bp+0x6] */
            ii(0x19_4f90, 3);  mov(dx, memw[ss, bp + 8]);              /* mov dx, [bp+0x8] */
            ii(0x19_4f93, 4);  mov(memw[es, bx + 66], ax);             /* mov [es:bx+0x42], ax */
            ii(0x19_4f97, 4);  mov(memw[es, bx + 68], dx);             /* mov [es:bx+0x44], dx */
            ii(0x19_4f9b, 1);  pop(ds);                                /* pop ds */
            ii(0x19_4f9c, 1);  leave();                                /* leave */
            ii(0x19_4f9d, 1);  retf();                                 /* retf */
        }
    }
}
