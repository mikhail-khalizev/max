using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x19_9e8b-6e1718bd")]
        public void Method_0019_9e8b()
        {
            ii(0x19_9e8b, 4);  enter(8, 0);                            /* enter 0x8, 0x0 */
            ii(0x19_9e8f, 1);  push(si);                               /* push si */
            ii(0x19_9e90, 4);  mov(es, memw[ds, 0x3fbe]);              /* mov es, [0x3fbe] */
            ii(0x19_9e94, 4);  mov(ax, memw[es, 0x3b7a]);              /* mov ax, [es:0x3b7a] */
            ii(0x19_9e98, 2);  sub(bx, bx);                            /* sub bx, bx */
            ii(0x19_9e9a, 2);  mov(es, ax);                            /* mov es, ax */
            ii(0x19_9e9c, 4);  push(memw[es, bx + 50]);                /* push word [es:bx+0x32] */
            ii(0x19_9ea0, 4);  push(memw[es, bx + 54]);                /* push word [es:bx+0x36] */
            ii(0x19_9ea4, 4);  push(memw[es, bx + 52]);                /* push word [es:bx+0x34] */
            ii(0x19_9ea8, 5);  call_far_abs(0x80, 0x56e0);             /* call word 0x80:0x56e0 */
            ii(0x19_9ead, 3);  add(sp, 6);                             /* add sp, 0x6 */
            ii(0x19_9eb0, 3);  mov(memw[ss, bp - 4], ax);              /* mov [bp-0x4], ax */
            ii(0x19_9eb3, 3);  mov(memw[ss, bp - 2], dx);              /* mov [bp-0x2], dx */
            ii(0x19_9eb6, 2);  or(dx, ax);                             /* or dx, ax */
            ii(0x19_9eb8, 2);  if(jz(0x19_9ecd, 0x13)) goto l_0x19_9ecd;/* jz 0x9ecd */
            ii(0x19_9eba, 3);  les(bx, memw[ss, bp - 4]);              /* les bx, [bp-0x4] */
            ii(0x19_9ebd, 3);  mov(si, memw[ss, bp + 4]);              /* mov si, [bp+0x4] */
            ii(0x19_9ec0, 4);  mov(memb[es, bx + si], 0xff);           /* mov byte [es:bx+si], 0xff */
            ii(0x19_9ec4, 1);  push(es);                               /* push es */
            ii(0x19_9ec5, 1);  push(bx);                               /* push bx */
            ii(0x19_9ec6, 5);  call_far_abs(0x80, 0x4f60);             /* call word 0x80:0x4f60 */
            ii(0x19_9ecb, 1);  pop(bx);                                /* pop bx */
            ii(0x19_9ecc, 1);  pop(bx);                                /* pop bx */
        l_0x19_9ecd:
            ii(0x19_9ecd, 1);  pop(si);                                /* pop si */
            ii(0x19_9ece, 1);  leave();                                /* leave */
            ii(0x19_9ecf, 3);  ret(2);                                 /* ret 0x2 */
        }
    }
}
