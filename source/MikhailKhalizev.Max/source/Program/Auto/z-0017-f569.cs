using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x17_f569-edf152f6")]
        public void Method_0017_f569()
        {
            ii(0x17_f569, 4);  enter(8, 0);                            /* enter 0x8, 0x0 */
            ii(0x17_f56d, 1);  push(ds);                               /* push ds */
            ii(0x17_f56e, 3);  mov(ax, 0x3e68);                        /* mov ax, 0x3e68 */
            ii(0x17_f571, 2);  mov(ds, ax);                            /* mov ds, ax */
            ii(0x17_f573, 2);  sub(ax, ax);                            /* sub ax, ax */
            ii(0x17_f575, 3);  mov(memw[ss, bp - 2], ax);              /* mov [bp-0x2], ax */
            ii(0x17_f578, 3);  mov(memw[ss, bp - 4], ax);              /* mov [bp-0x4], ax */
            ii(0x17_f57b, 3);  mov(memw[ss, bp - 6], ax);              /* mov [bp-0x6], ax */
            ii(0x17_f57e, 3);  mov(memw[ss, bp - 8], ax);              /* mov [bp-0x8], ax */
            ii(0x17_f581, 3);  push(memw[ss, bp + 10]);                /* push word [bp+0xa] */
            ii(0x17_f584, 3);  push(memw[ss, bp + 8]);                 /* push word [bp+0x8] */
            ii(0x17_f587, 3);  push(memw[ss, bp + 6]);                 /* push word [bp+0x6] */
            ii(0x17_f58a, 3);  push(memw[ss, bp + 4]);                 /* push word [bp+0x4] */
            ii(0x17_f58d, 3);  lea(ax, memw[ss, bp - 4]);              /* lea ax, [bp-0x4] */
            ii(0x17_f590, 1);  push(ss);                               /* push ss */
            ii(0x17_f591, 1);  push(ax);                               /* push ax */
            ii(0x17_f592, 3);  lea(ax, memw[ss, bp - 8]);              /* lea ax, [bp-0x8] */
            ii(0x17_f595, 1);  push(ss);                               /* push ss */
            ii(0x17_f596, 1);  push(ax);                               /* push ax */
            ii(0x17_f597, 3);  call(0x17_f4f0, -0xaa);                 /* call 0xf4f0 */
            ii(0x17_f59a, 3);  mov(ax, memw[ss, bp - 8]);              /* mov ax, [bp-0x8] */
            ii(0x17_f59d, 3);  mov(dx, memw[ss, bp - 6]);              /* mov dx, [bp-0x6] */
            ii(0x17_f5a0, 1);  pop(ds);                                /* pop ds */
            ii(0x17_f5a1, 1);  leave();                                /* leave */
            ii(0x17_f5a2, 3);  ret(8);                                 /* ret 0x8 */
        }
    }
}
