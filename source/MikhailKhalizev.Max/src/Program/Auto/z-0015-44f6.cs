using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("a373191a-fe57-4301-a588-b9bea707ae78")]
        public void Method_0015_44f6()
        {
            ii(0x15_44f6, 4); enterw(0x8, 0);                           /* enter 0x8, 0x0 */
            ii(0x15_44fa, 1); pushw(ds);                                /* push ds */
            ii(0x15_44fb, 3); mov(ax, 0xa8);                            /* mov ax, 0xa8 */
            ii(0x15_44fe, 2); mov(ds, ax);                              /* mov ds, ax */
            ii(0x15_4500, 3); lea(ax, bp - 0x8);                        /* lea ax, [bp-0x8] */
            ii(0x15_4503, 1); pushw(ss);                                /* push ss */
            ii(0x15_4504, 1); pushw(ax);                                /* push ax */
            ii(0x15_4505, 3); pushw(memw_a16[ss, bp + 0x8]);            /* push word [bp+0x8] */
            ii(0x15_4508, 1); pushw(cs);                                /* push cs */
            ii(0x15_4509, 3); callw(0x15_4412, -0xfa);                  /* call 0x4412 */
            ii(0x15_450c, 3); add(sp, 0x6);                             /* add sp, 0x6 */
            ii(0x15_450f, 2); or(ax, ax);                               /* or ax, ax */
            ii(0x15_4511, 2); if(jnzw(0x15_4518, 0x5)) goto l_0x15_4518; /* jnz 0x4518 */
            ii(0x15_4513, 2); sub(ax, ax);                              /* sub ax, ax */
            ii(0x15_4515, 1); popw(ds);                                 /* pop ds */
            ii(0x15_4516, 1); leavew();                                 /* leave */
            ii(0x15_4517, 1); retfw(); return;                          /* retf */
        l_0x15_4518:
            ii(0x15_4518, 3); mov(ax, memw_a16[ss, bp - 0x8]);          /* mov ax, [bp-0x8] */
            ii(0x15_451b, 1); popw(ds);                                 /* pop ds */
            ii(0x15_451c, 1); leavew();                                 /* leave */
            ii(0x15_451d, 1); retfw(); return;                          /* retf */
        }
    }
}
