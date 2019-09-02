using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1_1a64-d04f0bae")]
        public void Method_0001_1a64()
        {
            ii(0x1_1a64, 1);  push(bp);                                 /* push bp */
            ii(0x1_1a65, 2);  mov(bp, sp);                              /* mov bp, sp */
            ii(0x1_1a67, 2);  push(8);                                  /* push 0x8 */
            ii(0x1_1a69, 1);  pop(ds);                                  /* pop ds */
            ii(0x1_1a6a, 1);  pushfw();                                 /* pushfw */
            ii(0x1_1a6b, 1);  cli();                                    /* cli */
            ii(0x1_1a6c, 3);  mov(bx, memw[ss, bp + 4]);                /* mov bx, [bp+0x4] */
            ii(0x1_1a6f, 3);  and(bl, 0xf8);                            /* and bl, 0xf8 */
            ii(0x1_1a72, 3);  mov(ax, memw[ss, bp + 0xa]);              /* mov ax, [bp+0xa] */
            ii(0x1_1a75, 2);  mov(memw[ds, bx], ax);                    /* mov [bx], ax */
            ii(0x1_1a77, 3);  mov(al, memb[ss, bp + 0xc]);              /* mov al, [bp+0xc] */
            ii(0x1_1a7a, 3);  mov(memb[ds, bx + 5], al);                /* mov [bx+0x5], al */
            ii(0x1_1a7d, 3);  mov(ax, memw[ss, bp + 6]);                /* mov ax, [bp+0x6] */
            ii(0x1_1a80, 3);  mov(dx, memw[ss, bp + 8]);                /* mov dx, [bp+0x8] */
            ii(0x1_1a83, 3);  mov(cx, 4);                               /* mov cx, 0x4 */
        l_0x1_1a86:
            ii(0x1_1a86, 2);  shl(ax, 1);                               /* shl ax, 1 */
            ii(0x1_1a88, 2);  rcl(dx, 1);                               /* rcl dx, 1 */
            ii(0x1_1a8a, 2);  if(loop(0x1_1a86, -6)) goto l_0x1_1a86;   /* loop 0x1a86 */
            ii(0x1_1a8c, 3);  mov(memw[ds, bx + 2], ax);                /* mov [bx+0x2], ax */
            ii(0x1_1a8f, 3);  mov(memb[ds, bx + 4], dl);                /* mov [bx+0x4], dl */
            ii(0x1_1a92, 3);  mov(memb[ds, bx + 7], dh);                /* mov [bx+0x7], dh */
            ii(0x1_1a95, 1);  pop(dx);                                  /* pop dx */
            ii(0x1_1a96, 1);  pop(bp);                                  /* pop bp */
            ii(0x1_1a97, 1);  pop(ax);                                  /* pop ax */
            ii(0x1_1a98, 2);  mov(cx, ss);                              /* mov cx, ss */
            ii(0x1_1a9a, 2);  mov(ss, cx);                              /* mov ss, cx */
            ii(0x1_1a9c, 2);  push(0x20);                               /* push 0x20 */
            ii(0x1_1a9e, 1);  pop(ds);                                  /* pop ds */
            ii(0x1_1a9f, 1);  push(dx);                                 /* push dx */
            ii(0x1_1aa0, 1);  popfw();                                  /* popfw */
            ii(0x1_1aa1, 2);  jmp_abs(ax);                              /* jmp ax */
        }
    }
}
