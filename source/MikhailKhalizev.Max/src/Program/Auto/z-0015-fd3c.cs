using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("8ecf33ea-86ad-42c2-9f0b-12516f873ccf")]
        public void Method_0015_fd3c()
        {
            ii(0x15_fd3c, 1); pushw(bp);                                /* push bp */
            ii(0x15_fd3d, 2); mov(bp, sp);                              /* mov bp, sp */
            ii(0x15_fd3f, 1); pushw(ds);                                /* push ds */
            ii(0x15_fd40, 3); mov(ax, 0xa8);                            /* mov ax, 0xa8 */
            ii(0x15_fd43, 2); mov(ds, ax);                              /* mov ds, ax */
            ii(0x15_fd45, 3); callw(0x15_fcea, -0x5e);                  /* call 0xfcea */
            ii(0x15_fd48, 2); or(ax, ax);                               /* or ax, ax */
            ii(0x15_fd4a, 2); if(jnzw(0x15_fd59, 0xd)) goto l_0x15_fd59; /* jnz 0xfd59 */
            ii(0x15_fd4c, 1); pusha();                                  /* pusha */
            ii(0x15_fd4d, 3); mov(ax, 0xbfde);                          /* mov ax, 0xbfde */
            ii(0x15_fd50, 3); mov(bx, 0x15);                            /* mov bx, 0x15 */
            ii(0x15_fd53, 3); mov(cx, memw_a16[ss, bp + 0x6]);          /* mov cx, [bp+0x6] */
            ii(0x15_fd56, 2); @int(0x15);                               /* int 0x15 */
            ii(0x15_fd58, 1); popa();                                   /* popa */
        l_0x15_fd59:
            ii(0x15_fd59, 1); popw(ds);                                 /* pop ds */
            ii(0x15_fd5a, 1); leavew();                                 /* leave */
            ii(0x15_fd5b, 3); retfw(0x2); return;                       /* retf 0x2 */
        }
    }
}
