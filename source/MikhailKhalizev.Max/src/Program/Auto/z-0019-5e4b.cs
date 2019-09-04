using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x19_5e4b-342e6caa")]
        public void Method_0019_5e4b()
        {
            ii(0x19_5e4b, 4);  enter(0, 0);                            /* enter 0x0, 0x0 */
            ii(0x19_5e4f, 1);  push(di);                               /* push di */
            ii(0x19_5e50, 1);  push(si);                               /* push si */
            ii(0x19_5e51, 1);  push(ds);                               /* push ds */
            ii(0x19_5e52, 3);  mov(ax, 0xa8);                          /* mov ax, 0xa8 */
            ii(0x19_5e55, 2);  mov(ds, ax);                            /* mov ds, ax */
            ii(0x19_5e57, 3);  mov(ax, 0xaba);                         /* mov ax, 0xaba */
            ii(0x19_5e5a, 2);  mov(dx, ds);                            /* mov dx, ds */
            ii(0x19_5e5c, 3);  jmp(0x19_5e5f, 0); goto l_0x19_5e5f;    /* jmp 0x5e5f */
        l_0x19_5e5f:
            ii(0x19_5e5f, 1);  pop(ds);                                /* pop ds */
            ii(0x19_5e60, 1);  pop(si);                                /* pop si */
            ii(0x19_5e61, 1);  pop(di);                                /* pop di */
            ii(0x19_5e62, 1);  leave();                                /* leave */
            ii(0x19_5e63, 1);  retf();                                 /* retf */
        }
    }
}
