using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x19_44f6-fd4f28c7")]
        public void Method_0019_44f6()
        {
            ii(0x19_44f6, 4);  enter(8, 0);                            /* enter 0x8, 0x0 */
            ii(0x19_44fa, 1);  push(ds);                               /* push ds */
            ii(0x19_44fb, 3);  mov(ax, 0xa8);                          /* mov ax, 0xa8 */
            ii(0x19_44fe, 2);  mov(ds, ax);                            /* mov ds, ax */
            ii(0x19_4500, 3);  lea(ax, memw[ss, bp - 8]);              /* lea ax, [bp-0x8] */
            ii(0x19_4503, 1);  push(ss);                               /* push ss */
            ii(0x19_4504, 1);  push(ax);                               /* push ax */
            ii(0x19_4505, 3);  push(memw[ss, bp + 8]);                 /* push word [bp+0x8] */
            ii(0x19_4508, 1);  push(cs);                               /* push cs */
            ii(0x19_4509, 3);  call(0x19_4412, -0xfa);                 /* call 0x4412 */
            ii(0x19_450c, 3);  add(sp, 6);                             /* add sp, 0x6 */
            ii(0x19_450f, 2);  or(ax, ax);                             /* or ax, ax */
            ii(0x19_4511, 2);  if(jnz(0x19_4518, 5)) goto l_0x19_4518; /* jnz 0x4518 */
            ii(0x19_4513, 2);  sub(ax, ax);                            /* sub ax, ax */
            ii(0x19_4515, 1);  pop(ds);                                /* pop ds */
            ii(0x19_4516, 1);  leave();                                /* leave */
            ii(0x19_4517, 1);  retf(); return;                         /* retf */
        l_0x19_4518:
            ii(0x19_4518, 3);  mov(ax, memw[ss, bp - 8]);              /* mov ax, [bp-0x8] */
            ii(0x19_451b, 1);  pop(ds);                                /* pop ds */
            ii(0x19_451c, 1);  leave();                                /* leave */
            ii(0x19_451d, 1);  retf();                                 /* retf */
        }
    }
}
