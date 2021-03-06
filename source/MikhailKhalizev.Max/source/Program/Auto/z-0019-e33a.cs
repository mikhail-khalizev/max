using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x19_e33a-9716192a")]
        public void Method_0019_e33a()
        {
            ii(0x19_e33a, 4);  enter(0x1a, 0);                         /* enter 0x1a, 0x0 */
            ii(0x19_e33e, 1);  push(ds);                               /* push ds */
            ii(0x19_e33f, 3);  mov(ax, 0xa8);                          /* mov ax, 0xa8 */
            ii(0x19_e342, 2);  mov(ds, ax);                            /* mov ds, ax */
            ii(0x19_e344, 5);  mov(memw[ss, bp - 18], 0x5000);         /* mov word [bp-0x12], 0x5000 */
            ii(0x19_e349, 3);  les(bx, memw[ss, bp + 4]);              /* les bx, [bp+0x4] */
            ii(0x19_e34c, 3);  mov(memw[ss, bp - 4], bx);              /* mov [bp-0x4], bx */
            ii(0x19_e34f, 3);  mov(memw[ss, bp - 2], es);              /* mov [bp-0x2], es */
            ii(0x19_e352, 4);  mov(ax, memw[es, bx + 32]);             /* mov ax, [es:bx+0x20] */
            ii(0x19_e356, 3);  mov(memw[ss, bp - 16], ax);             /* mov [bp-0x10], ax */
            ii(0x19_e359, 2);  sub(ax, ax);                            /* sub ax, ax */
            ii(0x19_e35b, 3);  mov(memw[ss, bp - 20], ax);             /* mov [bp-0x14], ax */
            ii(0x19_e35e, 3);  mov(memw[ss, bp - 26], ax);             /* mov [bp-0x1a], ax */
            ii(0x19_e361, 3);  lea(ax, memw[ss, bp - 26]);             /* lea ax, [bp-0x1a] */
            ii(0x19_e364, 1);  push(ss);                               /* push ss */
            ii(0x19_e365, 1);  push(ax);                               /* push ax */
            ii(0x19_e366, 3);  lea(ax, memw[ss, bp - 18]);             /* lea ax, [bp-0x12] */
            ii(0x19_e369, 1);  push(ss);                               /* push ss */
            ii(0x19_e36a, 1);  push(ax);                               /* push ax */
            ii(0x19_e36b, 1);  push(ss);                               /* push ss */
            ii(0x19_e36c, 1);  push(ax);                               /* push ax */
            ii(0x19_e36d, 4);  call_far_ind(memw[ds, 0x1a0c]);         /* call far word [0x1a0c] */
            ii(0x19_e371, 3);  add(sp, 0xc);                           /* add sp, 0xc */
            ii(0x19_e374, 2);  push(0x20);                             /* push 0x20 */
            ii(0x19_e376, 2);  push(0x18);                             /* push 0x18 */
            ii(0x19_e378, 4);  mov(es, memw[ds, 0x3fc8]);              /* mov es, [0x3fc8] */
            ii(0x19_e37c, 5);  push(memw[es, 0x3b7a]);                 /* push word [es:0x3b7a] */
            ii(0x19_e381, 3);  push(memw[ss, bp - 4]);                 /* push word [bp-0x4] */
            ii(0x19_e384, 3);  push(memw[ss, bp - 2]);                 /* push word [bp-0x2] */
            ii(0x19_e387, 5);  call_far_abs(0x80, 0x3efa);             /* call word 0x80:0x3efa */
            ii(0x19_e38c, 3);  add(sp, 0xa);                           /* add sp, 0xa */
            ii(0x19_e38f, 1);  pop(ds);                                /* pop ds */
            ii(0x19_e390, 1);  leave();                                /* leave */
            ii(0x19_e391, 3);  ret(4);                                 /* ret 0x4 */
        }
    }
}
