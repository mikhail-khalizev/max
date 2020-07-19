using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x18_0bfe-4706b396")]
        public void Method_0018_0bfe()
        {
            ii(0x18_0bfe, 4);  enter(0xa, 0);                          /* enter 0xa, 0x0 */
            ii(0x18_0c02, 1);  push(ds);                               /* push ds */
            ii(0x18_0c03, 3);  mov(ax, 0x3e68);                        /* mov ax, 0x3e68 */
            ii(0x18_0c06, 2);  mov(ds, ax);                            /* mov ds, ax */
            ii(0x18_0c08, 3);  push(memw[ss, bp + 10]);                /* push word [bp+0xa] */
            ii(0x18_0c0b, 3);  push(memw[ss, bp + 8]);                 /* push word [bp+0x8] */
            ii(0x18_0c0e, 1);  nop();                                  /* nop */
            ii(0x18_0c0f, 1);  push(cs);                               /* push cs */
            ii(0x18_0c10, 3);  call(0x17_e91a, -0x22f9);               /* call 0xe91a */
            ii(0x18_0c13, 1);  pop(bx);                                /* pop bx */
            ii(0x18_0c14, 1);  pop(bx);                                /* pop bx */
            ii(0x18_0c15, 3);  mov(memw[ss, bp - 4], ax);              /* mov [bp-0x4], ax */
            ii(0x18_0c18, 3);  mov(memw[ss, bp - 2], dx);              /* mov [bp-0x2], dx */
            ii(0x18_0c1b, 1);  push(dx);                               /* push dx */
            ii(0x18_0c1c, 1);  push(ax);                               /* push ax */
            ii(0x18_0c1d, 3);  push(memw[ss, bp + 6]);                 /* push word [bp+0x6] */
            ii(0x18_0c20, 3);  push(memw[ss, bp + 4]);                 /* push word [bp+0x4] */
            ii(0x18_0c23, 1);  nop();                                  /* nop */
            ii(0x18_0c24, 1);  push(cs);                               /* push cs */
            ii(0x18_0c25, 3);  call(0x17_e91a, -0x230e);               /* call 0xe91a */
            ii(0x18_0c28, 1);  pop(bx);                                /* pop bx */
            ii(0x18_0c29, 1);  pop(bx);                                /* pop bx */
            ii(0x18_0c2a, 3);  sub(ax, memw[ss, bp - 4]);              /* sub ax, [bp-0x4] */
            ii(0x18_0c2d, 3);  sbb(dx, memw[ss, bp - 2]);              /* sbb dx, [bp-0x2] */
            ii(0x18_0c30, 1);  push(dx);                               /* push dx */
            ii(0x18_0c31, 1);  push(ax);                               /* push ax */
            ii(0x18_0c32, 3);  call(0x18_0bc2, -0x73);                 /* call 0xbc2 */
            ii(0x18_0c35, 1);  pop(ds);                                /* pop ds */
            ii(0x18_0c36, 1);  leave();                                /* leave */
            ii(0x18_0c37, 3);  ret(8);                                 /* ret 0x8 */
        }
    }
}
