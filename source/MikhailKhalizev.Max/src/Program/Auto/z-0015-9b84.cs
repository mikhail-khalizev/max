using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("f7073e0f-6b56-4a25-9700-6aa50532a2cc")]
        public void Method_0015_9b84()
        {
            ii(0x15_9b84, 4); enterw(0x4, 0);                           /* enter 0x4, 0x0 */
            ii(0x15_9b88, 1); pushw(ds);                                /* push ds */
            ii(0x15_9b89, 3); pushw(0x1f04);                            /* push 0x1f04 */
            ii(0x15_9b8c, 5); callw_far_abs(0x80, 0x5aca);              /* call word 0x80:0x5aca */
            ii(0x15_9b91, 1); popw(bx);                                 /* pop bx */
            ii(0x15_9b92, 1); popw(bx);                                 /* pop bx */
            ii(0x15_9b93, 3); pushw(0x2000);                            /* push 0x2000 */
            ii(0x15_9b96, 5); callw_far_abs(0x80, 0x51e8);              /* call word 0x80:0x51e8 */
            ii(0x15_9b9b, 1); popw(bx);                                 /* pop bx */
            ii(0x15_9b9c, 3); mov(memw_a16[ss, bp - 0x4], ax);          /* mov [bp-0x4], ax */
            ii(0x15_9b9f, 3); mov(memw_a16[ss, bp - 0x2], dx);          /* mov [bp-0x2], dx */
            ii(0x15_9ba2, 1); pushw(dx);                                /* push dx */
            ii(0x15_9ba3, 1); pushw(ax);                                /* push ax */
            ii(0x15_9ba4, 3); callw(0x15_fa6b, 0x5ec4);                 /* call 0xfa6b */
            ii(0x15_9ba7, 3); mov(ax, memw_a16[ss, bp - 0x2]);          /* mov ax, [bp-0x2] */
            ii(0x15_9baa, 3); mov(memw_a16[ds, 0x19e0], ax);            /* mov [0x19e0], ax */
            ii(0x15_9bad, 6); mov(memw_a16[ds, 0x19e2], 0x1ffc);        /* mov word [0x19e2], 0x1ffc */
            ii(0x15_9bb3, 1); leavew();                                 /* leave */
            ii(0x15_9bb4, 1); retfw(); return;                          /* retf */
        }
    }
}
