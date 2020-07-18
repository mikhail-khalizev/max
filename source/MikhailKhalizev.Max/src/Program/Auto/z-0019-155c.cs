using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x19_155c-54a5f9ad")]
        public void Method_0019_155c()
        {
            ii(0x19_155c, 4);  enter(4, 0);                            /* enter 0x4, 0x0 */
            ii(0x19_1560, 1);  push(ds);                               /* push ds */
            ii(0x19_1561, 3);  mov(ax, 0xa8);                          /* mov ax, 0xa8 */
            ii(0x19_1564, 2);  mov(ds, ax);                            /* mov ds, ax */
            ii(0x19_1566, 1);  push(ds);                               /* push ds */
            ii(0x19_1567, 3);  push(0x38c8);                           /* push 0x38c8 */
            ii(0x19_156a, 1);  nop();                                  /* nop */
            ii(0x19_156b, 1);  push(cs);                               /* push cs */
            ii(0x19_156c, 3);  call(0x19_5030, 0x3ac1);                /* call 0x5030 */
            ii(0x19_156f, 1);  pop(bx);                                /* pop bx */
            ii(0x19_1570, 1);  pop(bx);                                /* pop bx */
            ii(0x19_1571, 3);  mov(memw[ss, bp - 4], ax);              /* mov [bp-0x4], ax */
            ii(0x19_1574, 3);  mov(memw[ss, bp - 2], dx);              /* mov [bp-0x2], dx */
            ii(0x19_1577, 2);  or(dx, ax);                             /* or dx, ax */
            ii(0x19_1579, 2);  if(jz(0x19_159a, 0x1f)) goto l_0x19_159a;/* jz 0x159a */
            ii(0x19_157b, 1);  push(ds);                               /* push ds */
            ii(0x19_157c, 3);  push(0x38cf);                           /* push 0x38cf */
            ii(0x19_157f, 3);  push(memw[ss, bp - 2]);                 /* push word [bp-0x2] */
            ii(0x19_1582, 1);  push(ax);                               /* push ax */
            ii(0x19_1583, 1);  nop();                                  /* nop */
            ii(0x19_1584, 1);  push(cs);                               /* push cs */
            ii(0x19_1585, 3);  call(0x19_4eb0, 0x3928);                /* call 0x4eb0 */
            ii(0x19_1588, 3);  add(sp, 8);                             /* add sp, 0x8 */
            ii(0x19_158b, 3);  mov(memw[ds, 0x38bc], ax);              /* mov [0x38bc], ax */
            ii(0x19_158e, 4);  mov(memw[ds, 0x38be], dx);              /* mov [0x38be], dx */
            ii(0x19_1592, 2);  mov(ax, dx);                            /* mov ax, dx */
            ii(0x19_1594, 4);  or(ax, memw[ds, 0x38bc]);               /* or ax, [0x38bc] */
            ii(0x19_1598, 2);  if(jnz(0x19_15a3, 9)) goto l_0x19_15a3; /* jnz 0x15a3 */
        l_0x19_159a:
            ii(0x19_159a, 3);  push(0xee);                             /* push 0xee */
            ii(0x19_159d, 1);  nop();                                  /* nop */
            ii(0x19_159e, 1);  push(cs);                               /* push cs */
            ii(0x19_159f, 3);  call(0x19_292f, 0x138d);                /* call 0x292f */
            ii(0x19_15a2, 1);  pop(bx);                                /* pop bx */
        l_0x19_15a3:
            ii(0x19_15a3, 1);  push(ds);                               /* push ds */
            ii(0x19_15a4, 3);  push(0x38d8);                           /* push 0x38d8 */
            ii(0x19_15a7, 3);  push(memw[ss, bp - 2]);                 /* push word [bp-0x2] */
            ii(0x19_15aa, 3);  push(memw[ss, bp - 4]);                 /* push word [bp-0x4] */
            ii(0x19_15ad, 1);  nop();                                  /* nop */
            ii(0x19_15ae, 1);  push(cs);                               /* push cs */
            ii(0x19_15af, 3);  call(0x19_4eb0, 0x38fe);                /* call 0x4eb0 */
            ii(0x19_15b2, 3);  add(sp, 8);                             /* add sp, 0x8 */
            ii(0x19_15b5, 3);  mov(memw[ds, 0x38c0], ax);              /* mov [0x38c0], ax */
            ii(0x19_15b8, 4);  mov(memw[ds, 0x38c2], dx);              /* mov [0x38c2], dx */
            ii(0x19_15bc, 3);  mov(ax, memw[ss, bp + 6]);              /* mov ax, [bp+0x6] */
            ii(0x19_15bf, 3);  mov(dx, memw[ss, bp + 8]);              /* mov dx, [bp+0x8] */
            ii(0x19_15c2, 3);  mov(memw[ds, 0x38c4], ax);              /* mov [0x38c4], ax */
            ii(0x19_15c5, 4);  mov(memw[ds, 0x38c6], dx);              /* mov [0x38c6], dx */
            ii(0x19_15c9, 1);  push(cs);                               /* push cs */
            ii(0x19_15ca, 3);  call(0x19_153a, -0x93);                 /* call 0x153a */
            ii(0x19_15cd, 1);  pop(ds);                                /* pop ds */
            ii(0x19_15ce, 1);  leave();                                /* leave */
            ii(0x19_15cf, 3);  retf(4);                                /* retf 0x4 */
        }
    }
}
