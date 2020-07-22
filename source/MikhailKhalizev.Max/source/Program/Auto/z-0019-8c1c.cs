using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x19_8c1c-eaf25980")]
        public void Method_0019_8c1c()
        {
            ii(0x19_8c1c, 4);  enter(4, 0);                            /* enter 0x4, 0x0 */
            ii(0x19_8c20, 3);  les(bx, memw[ss, bp + 4]);              /* les bx, [bp+0x4] */
            ii(0x19_8c23, 4);  push(memw[es, bx + 2]);                 /* push word [es:bx+0x2] */
            ii(0x19_8c27, 3);  push(memw[es, bx]);                     /* push word [es:bx] */
            ii(0x19_8c2a, 3);  call(0x19_ff2f, 0x7302);                /* call 0xff2f */
            ii(0x19_8c2d, 3);  les(bx, memw[ss, bp + 4]);              /* les bx, [bp+0x4] */
            ii(0x19_8c30, 3);  add(ax, memw[es, bx]);                  /* add ax, [es:bx] */
            ii(0x19_8c33, 4);  mov(dx, memw[es, bx + 2]);              /* mov dx, [es:bx+0x2] */
            ii(0x19_8c37, 1);  inc(ax);                                /* inc ax */
            ii(0x19_8c38, 1);  push(dx);                               /* push dx */
            ii(0x19_8c39, 1);  push(ax);                               /* push ax */
            ii(0x19_8c3a, 1);  push(ds);                               /* push ds */
            ii(0x19_8c3b, 3);  push(0x1a7c);                           /* push 0x1a7c */
            ii(0x19_8c3e, 3);  call(0x19_ffd5, 0x7394);                /* call 0xffd5 */
            ii(0x19_8c41, 3);  mov(memw[ss, bp - 4], ax);              /* mov [bp-0x4], ax */
            ii(0x19_8c44, 3);  mov(memw[ss, bp - 2], dx);              /* mov [bp-0x2], dx */
            ii(0x19_8c47, 2);  or(dx, ax);                             /* or dx, ax */
            ii(0x19_8c49, 2);  if(jz(0x19_8c65, 0x1a)) goto l_0x19_8c65;/* jz 0x8c65 */
            ii(0x19_8c4b, 3);  les(bx, memw[ss, bp - 4]);              /* les bx, [bp-0x4] */
            ii(0x19_8c4e, 5);  mov(memb[es, bx + 25], 0);              /* mov byte [es:bx+0x19], 0x0 */
            ii(0x19_8c53, 1);  push(es);                               /* push es */
            ii(0x19_8c54, 1);  push(bx);                               /* push bx */
            ii(0x19_8c55, 3);  push(0x200);                            /* push 0x200 */
            ii(0x19_8c58, 3);  call(0x19_c7eb, 0x3b90);                /* call 0xc7eb */
            ii(0x19_8c5b, 3);  les(bx, memw[ss, bp + 4]);              /* les bx, [bp+0x4] */
            ii(0x19_8c5e, 3);  mov(memw[es, bx], ax);                  /* mov [es:bx], ax */
            ii(0x19_8c61, 4);  mov(memw[es, bx + 2], dx);              /* mov [es:bx+0x2], dx */
        l_0x19_8c65:
            ii(0x19_8c65, 1);  leave();                                /* leave */
            ii(0x19_8c66, 3);  ret(4);                                 /* ret 0x4 */
        }
    }
}
