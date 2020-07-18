using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1a_0de7-e97613a9")]
        public void Method_001a_0de7()
        {
            ii(0x1a_0de7, 4);  enter(0x1e, 0);                         /* enter 0x1e, 0x0 */
            ii(0x1a_0deb, 1);  push(ds);                               /* push ds */
            ii(0x1a_0dec, 3);  mov(ax, 0xa8);                          /* mov ax, 0xa8 */
            ii(0x1a_0def, 2);  mov(ds, ax);                            /* mov ds, ax */
            ii(0x1a_0df1, 4);  mov(memb[ss, bp - 30], 0x62);           /* mov byte [bp-0x1e], 0x62 */
            ii(0x1a_0df5, 4);  mov(memb[ss, bp - 29], 0x70);           /* mov byte [bp-0x1d], 0x70 */
            ii(0x1a_0df9, 4);  mov(memb[ss, bp - 28], 0x20);           /* mov byte [bp-0x1c], 0x20 */
            ii(0x1a_0dfd, 2);  push(0);                                /* push 0x0 */
            ii(0x1a_0dff, 3);  push(memw[ss, bp + 8]);                 /* push word [bp+0x8] */
            ii(0x1a_0e02, 2);  push(0x10);                             /* push 0x10 */
            ii(0x1a_0e04, 2);  push(4);                                /* push 0x4 */
            ii(0x1a_0e06, 3);  lea(ax, memw[ss, bp - 27]);             /* lea ax, [bp-0x1b] */
            ii(0x1a_0e09, 1);  push(ss);                               /* push ss */
            ii(0x1a_0e0a, 1);  push(ax);                               /* push ax */
            ii(0x1a_0e0b, 1);  push(cs);                               /* push cs */
            ii(0x1a_0e0c, 3);  call(0x1a_03cb, -0xa44);                /* call 0x3cb */
            ii(0x1a_0e0f, 4);  mov(memb[ss, bp - 23], 0x3a);           /* mov byte [bp-0x17], 0x3a */
            ii(0x1a_0e13, 2);  push(0);                                /* push 0x0 */
            ii(0x1a_0e15, 3);  push(memw[ss, bp + 6]);                 /* push word [bp+0x6] */
            ii(0x1a_0e18, 2);  push(0x10);                             /* push 0x10 */
            ii(0x1a_0e1a, 2);  push(4);                                /* push 0x4 */
            ii(0x1a_0e1c, 3);  lea(ax, memw[ss, bp - 22]);             /* lea ax, [bp-0x16] */
            ii(0x1a_0e1f, 1);  push(ss);                               /* push ss */
            ii(0x1a_0e20, 1);  push(ax);                               /* push ax */
            ii(0x1a_0e21, 1);  push(cs);                               /* push cs */
            ii(0x1a_0e22, 3);  call(0x1a_03cb, -0xa5a);                /* call 0x3cb */
            ii(0x1a_0e25, 3);  lea(ax, memw[ss, bp - 18]);             /* lea ax, [bp-0x12] */
            ii(0x1a_0e28, 1);  push(ss);                               /* push ss */
            ii(0x1a_0e29, 1);  push(ax);                               /* push ax */
            ii(0x1a_0e2a, 1);  push(ds);                               /* push ds */
            ii(0x1a_0e2b, 3);  push(0x38a9);                           /* push 0x38a9 */
            ii(0x1a_0e2e, 3);  call(0x19_ff6c, -0xec5);                /* call 0xff6c */
            ii(0x1a_0e31, 3);  lea(ax, memw[ss, bp - 30]);             /* lea ax, [bp-0x1e] */
            ii(0x1a_0e34, 1);  push(ss);                               /* push ss */
            ii(0x1a_0e35, 1);  push(ax);                               /* push ax */
            ii(0x1a_0e36, 5);  call_far_abs(0x80, 0x4f2c);             /* call word 0x80:0x4f2c */
            ii(0x1a_0e3b, 1);  pop(bx);                                /* pop bx */
            ii(0x1a_0e3c, 1);  pop(bx);                                /* pop bx */
            ii(0x1a_0e3d, 1);  pop(ds);                                /* pop ds */
            ii(0x1a_0e3e, 1);  leave();                                /* leave */
            ii(0x1a_0e3f, 3);  retf(4);                                /* retf 0x4 */
        }
    }
}
