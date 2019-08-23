using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x17_e758-e8355e97")]
        public void Method_0017_e758()
        {
            ii(0x17_e758, 4); enterw(0, 0);                             /* enter 0x0, 0x0 */
            ii(0x17_e75c, 1); pushw(ds);                                /* push ds */
            ii(0x17_e75d, 3); mov(ax, 0x3e68);                          /* mov ax, 0x3e68 */
            ii(0x17_e760, 2); mov(ds, ax);                              /* mov ds, ax */
            ii(0x17_e762, 3); pushw(memw_a16[ss, bp + 0x8]);            /* push word [bp+0x8] */
            ii(0x17_e765, 1); nop();                                    /* nop */
            ii(0x17_e766, 1); pushw(cs);                                /* push cs */
            ii(0x17_e767, 3); callw(0x17_f1aa, 0xa40);                  /* call 0xf1aa */
            ii(0x17_e76a, 3); add(sp, 0x2);                             /* add sp, 0x2 */
            ii(0x17_e76d, 2); mov(cx, ax);                              /* mov cx, ax */
            ii(0x17_e76f, 3); cmp(cx, 0x1);                             /* cmp cx, 0x1 */
            ii(0x17_e772, 2); sbb(ax, ax);                              /* sbb ax, ax */
            ii(0x17_e774, 2); neg(ax);                                  /* neg ax */
            ii(0x17_e776, 1); popw(ds);                                 /* pop ds */
            ii(0x17_e777, 1); leavew();                                 /* leave */
            ii(0x17_e778, 1); retfw();                                  /* retf */
        }
    }
}
