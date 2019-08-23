using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x19_fd12-b23afac0")]
        public void Method_0019_fd12()
        {
            ii(0x19_fd12, 1); pushw(bp);                                /* push bp */
            ii(0x19_fd13, 2); mov(bp, sp);                              /* mov bp, sp */
            ii(0x19_fd15, 1); pushw(ds);                                /* push ds */
            ii(0x19_fd16, 3); mov(ax, 0xa8);                            /* mov ax, 0xa8 */
            ii(0x19_fd19, 2); mov(ds, ax);                              /* mov ds, ax */
            ii(0x19_fd1b, 3); callw(0x19_fcea, -0x34);                  /* call 0xfcea */
            ii(0x19_fd1e, 2); or(ax, ax);                               /* or ax, ax */
            ii(0x19_fd20, 2); if(jnzw(0x19_fd2f, 0xd)) goto l_0x19_fd2f; /* jnz 0xfd2f */
            ii(0x19_fd22, 1); pusha();                                  /* pusha */
            ii(0x19_fd23, 3); mov(ax, 0xbfde);                          /* mov ax, 0xbfde */
            ii(0x19_fd26, 3); mov(bx, 0x14);                            /* mov bx, 0x14 */
            ii(0x19_fd29, 3); mov(cx, memw_a16[ss, bp + 0x6]);          /* mov cx, [bp+0x6] */
            ii(0x19_fd2c, 2); @int(0x15);                               /* int 0x15 */
            ii(0x19_fd2e, 1); popa();                                   /* popa */
        l_0x19_fd2f:
            ii(0x19_fd2f, 1); popw(ds);                                 /* pop ds */
            ii(0x19_fd30, 1); leavew();                                 /* leave */
            ii(0x19_fd31, 3); retfw(0x2);                               /* retf 0x2 */
        }
    }
}
