using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x19_face-478b5870")]
        public void Method_0019_face()
        {
            ii(0x19_face, 1);  push(bp);                               /* push bp */
            ii(0x19_facf, 2);  mov(bp, sp);                            /* mov bp, sp */
            ii(0x19_fad1, 1);  push(ds);                               /* push ds */
            ii(0x19_fad2, 3);  mov(ax, 0xa8);                          /* mov ax, 0xa8 */
            ii(0x19_fad5, 2);  mov(ds, ax);                            /* mov ds, ax */
            ii(0x19_fad7, 3);  push(memw[ss, bp + 8]);                 /* push word [bp+0x8] */
            ii(0x19_fada, 3);  push(memw[ss, bp + 6]);                 /* push word [bp+0x6] */
            ii(0x19_fadd, 3);  call(0x19_fa6b, -0x75);                 /* call 0xfa6b */
            ii(0x19_fae0, 1);  pop(ds);                                /* pop ds */
            ii(0x19_fae1, 1);  leave();                                /* leave */
            ii(0x19_fae2, 3);  retf(4);                                /* retf 0x4 */
        }
    }
}
