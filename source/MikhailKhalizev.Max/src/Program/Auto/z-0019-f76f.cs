using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x19_f76f-3e66d3da")]
        public void Method_0019_f76f()
        {
            ii(0x19_f76f, 4);  enter(0xc, 0);                          /* enter 0xc, 0x0 */
            ii(0x19_f773, 1);  push(di);                               /* push di */
            ii(0x19_f774, 1);  push(si);                               /* push si */
            ii(0x19_f775, 5);  mov(memw[ss, bp - 4], 0xa1d4);          /* mov word [bp-0x4], 0xa1d4 */
            ii(0x19_f77a, 5);  mov(memw[ss, bp - 2], 0x88);            /* mov word [bp-0x2], 0x88 */
            ii(0x19_f77f, 3);  mov(ax, memw[ss, bp - 2]);              /* mov ax, [bp-0x2] */
            ii(0x19_f782, 3);  mov(memw[ss, bp - 8], ax);              /* mov [bp-0x8], ax */
            ii(0x19_f785, 3);  mov(ax, memw[ss, bp - 4]);              /* mov ax, [bp-0x4] */
            ii(0x19_f788, 3);  mov(memw[ss, bp - 12], ax);             /* mov [bp-0xc], ax */
            ii(0x19_f78b, 5);  mov(memw[ss, bp - 10], 0);              /* mov word [bp-0xa], 0x0 */
            ii(0x19_f790, 3);  lea(ax, memw[ss, bp - 12]);             /* lea ax, [bp-0xc] */
            ii(0x19_f793, 1);  push(ss);                               /* push ss */
            ii(0x19_f794, 1);  push(ax);                               /* push ax */
            ii(0x19_f795, 2);  push(0x24);                             /* push 0x24 */
            ii(0x19_f797, 5);  call_far_abs(0x80, 0xb38);              /* call word 0x80:0xb38 */
            ii(0x19_f79c, 3);  add(sp, 6);                             /* add sp, 0x6 */
            ii(0x19_f79f, 3);  mov(memw[ss, bp - 6], ax);              /* mov [bp-0x6], ax */
            ii(0x19_f7a2, 3);  mov(si, memw[ss, bp - 6]);              /* mov si, [bp-0x6] */
            ii(0x19_f7a5, 3);  and(si, -8 /* 0xf8 */);                 /* and si, 0xfff8 */
            ii(0x19_f7a8, 4);  mov(es, memw[ds, 0x3fd8]);              /* mov es, [0x3fd8] */
            ii(0x19_f7ac, 5);  les(bx, memw[es, 0x122]);               /* les bx, [es:0x122] */
            ii(0x19_f7b1, 4);  mov(memb[es, bx + si], 3);              /* mov byte [es:bx+si], 0x3 */
            ii(0x19_f7b5, 2);  push(1);                                /* push 0x1 */
            ii(0x19_f7b7, 2);  push(0x24);                             /* push 0x24 */
            ii(0x19_f7b9, 1);  nop();                                  /* nop */
            ii(0x19_f7ba, 1);  push(cs);                               /* push cs */
            ii(0x19_f7bb, 3);  call(0x1a_606f, 0x68b1);                /* call 0x606f */
            ii(0x19_f7be, 3);  add(sp, 4);                             /* add sp, 0x4 */
            ii(0x19_f7c1, 1);  pop(si);                                /* pop si */
            ii(0x19_f7c2, 1);  pop(di);                                /* pop di */
            ii(0x19_f7c3, 1);  leave();                                /* leave */
            ii(0x19_f7c4, 1);  retf();                                 /* retf */
        }
    }
}
