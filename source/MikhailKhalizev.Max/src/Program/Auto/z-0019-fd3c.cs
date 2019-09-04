using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x19_fd3c-be1756ef")]
        public void Method_0019_fd3c()
        {
            ii(0x19_fd3c, 1); push(bp);                                 /* push bp */
            ii(0x19_fd3d, 2); mov(bp, sp);                              /* mov bp, sp */
            ii(0x19_fd3f, 1); push(ds);                                 /* push ds */
            ii(0x19_fd40, 3); mov(ax, 0xa8);                            /* mov ax, 0xa8 */
            ii(0x19_fd43, 2); mov(ds, ax);                              /* mov ds, ax */
            ii(0x19_fd45, 3); call(0x19_fcea, -0x5e);                   /* call 0xfcea */
            ii(0x19_fd48, 2); or(ax, ax);                               /* or ax, ax */
            ii(0x19_fd4a, 2); if(jnz(0x19_fd59, 0xd)) goto l_0x19_fd59; /* jnz 0xfd59 */
            ii(0x19_fd4c, 1); pusha();                                  /* pusha */
            ii(0x19_fd4d, 3); mov(ax, 0xbfde);                          /* mov ax, 0xbfde */
            ii(0x19_fd50, 3); mov(bx, 0x15);                            /* mov bx, 0x15 */
            ii(0x19_fd53, 3); mov(cx, memw[ss, bp + 6]);                /* mov cx, [bp+0x6] */
            ii(0x19_fd56, 2); @int(0x15);                               /* int 0x15 */
            ii(0x19_fd58, 1); popa();                                   /* popa */
        l_0x19_fd59:
            ii(0x19_fd59, 1); pop(ds);                                  /* pop ds */
            ii(0x19_fd5a, 1); leave();                                  /* leave */
            ii(0x19_fd5b, 3); retf(2);                                  /* retf 0x2 */
        }
    }
}
