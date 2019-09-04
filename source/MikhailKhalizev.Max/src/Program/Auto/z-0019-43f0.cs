using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x19_43f0-f7276699")]
        public void Method_0019_43f0()
        {
            ii(0x19_43f0, 4);  enter(0, 0);                            /* enter 0x0, 0x0 */
            ii(0x19_43f4, 1);  push(ds);                               /* push ds */
            ii(0x19_43f5, 3);  mov(ax, 0xa8);                          /* mov ax, 0xa8 */
            ii(0x19_43f8, 2);  mov(ds, ax);                            /* mov ds, ax */
            ii(0x19_43fa, 3);  push(memw[ss, bp + 8]);                 /* push word [bp+0x8] */
            ii(0x19_43fd, 1);  nop();                                  /* nop */
            ii(0x19_43fe, 1);  push(cs);                               /* push cs */
            ii(0x19_43ff, 3);  call(0x19_4c34, 0x832);                 /* call 0x4c34 */
            ii(0x19_4402, 3);  add(sp, 2);                             /* add sp, 0x2 */
            ii(0x19_4405, 2);  mov(cx, ax);                            /* mov cx, ax */
            ii(0x19_4407, 3);  cmp(cx, 1);                             /* cmp cx, 0x1 */
            ii(0x19_440a, 2);  sbb(ax, ax);                            /* sbb ax, ax */
            ii(0x19_440c, 2);  neg(ax);                                /* neg ax */
            ii(0x19_440e, 1);  pop(ds);                                /* pop ds */
            ii(0x19_440f, 1);  leave();                                /* leave */
            ii(0x19_4410, 1);  retf();                                 /* retf */
        }
    }
}
