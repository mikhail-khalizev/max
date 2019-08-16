using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("1c3e34cd-9859-490d-908f-b574a2541a3a")]
        public void Method_0015_4c34()
        {
            ii(0x15_4c34, 4); enterw(0x14, 0);                          /* enter 0x14, 0x0 */
            ii(0x15_4c38, 1); pushw(ds);                                /* push ds */
            ii(0x15_4c39, 3); mov(ax, 0xa8);                            /* mov ax, 0xa8 */
            ii(0x15_4c3c, 2); mov(ds, ax);                              /* mov ds, ax */
            ii(0x15_4c3e, 5); cmp(memw_a16[ds, 0x3b72], 0);             /* cmp word [0x3b72], 0x0 */
            ii(0x15_4c43, 2); if(jnzw(0x15_4c66, 0x21)) goto l_0x15_4c66; /* jnz 0x4c66 */
            ii(0x15_4c45, 5); mov(memw_a16[ss, bp - 0x4], 0x1);         /* mov word [bp-0x4], 0x1 */
            ii(0x15_4c4a, 2); pushw(0);                                 /* push 0x0 */
            ii(0x15_4c4c, 2); pushw(0);                                 /* push 0x0 */
            ii(0x15_4c4e, 3); lea(ax, bp - 0x14);                       /* lea ax, [bp-0x14] */
            ii(0x15_4c51, 1); pushw(ss);                                /* push ss */
            ii(0x15_4c52, 1); pushw(ax);                                /* push ax */
            ii(0x15_4c53, 3); pushw(memw_a16[ss, bp + 0x6]);            /* push word [bp+0x6] */
            ii(0x15_4c56, 2); pushw(0x1);                               /* push 0x1 */
            ii(0x15_4c58, 1); nop();                                    /* nop */
            ii(0x15_4c59, 1); pushw(cs);                                /* push cs */
            ii(0x15_4c5a, 3); callw(0x15_41fd, -0xa60);                 /* call 0x41fd */
            ii(0x15_4c5d, 3); add(sp, 0xc);                             /* add sp, 0xc */
            ii(0x15_4c60, 2); sub(ax, ax);                              /* sub ax, ax */
            ii(0x15_4c62, 1); popw(ds);                                 /* pop ds */
            ii(0x15_4c63, 1); leavew();                                 /* leave */
            ii(0x15_4c64, 1); retfw(); return;                          /* retf */
        //    ii(0x15_4c65, 1); nop();                                    /* nop */
        l_0x15_4c66:
            ii(0x15_4c66, 3); mov(ax, memw_a16[ss, bp + 0x6]);          /* mov ax, [bp+0x6] */
            ii(0x15_4c69, 3); mov(memw_a16[ss, bp - 0x8], ax);          /* mov [bp-0x8], ax */
            ii(0x15_4c6c, 5); mov(memw_a16[ss, bp - 0x6], 0x700);       /* mov word [bp-0x6], 0x700 */
            ii(0x15_4c71, 2); pushw(0);                                 /* push 0x0 */
            ii(0x15_4c73, 2); pushw(0);                                 /* push 0x0 */
            ii(0x15_4c75, 3); lea(ax, bp - 0x14);                       /* lea ax, [bp-0x14] */
            ii(0x15_4c78, 1); pushw(ss);                                /* push ss */
            ii(0x15_4c79, 1); pushw(ax);                                /* push ax */
            ii(0x15_4c7a, 3); pushw(0xff00);                            /* push 0xff00 */
            ii(0x15_4c7d, 1); nop();                                    /* nop */
            ii(0x15_4c7e, 1); pushw(cs);                                /* push cs */
            ii(0x15_4c7f, 3); callw(0x15_4188, -0xafa);                 /* call 0x4188 */
            ii(0x15_4c82, 3); add(sp, 0xa);                             /* add sp, 0xa */
            ii(0x15_4c85, 2); sub(ax, ax);                              /* sub ax, ax */
            ii(0x15_4c87, 1); popw(ds);                                 /* pop ds */
            ii(0x15_4c88, 1); leavew();                                 /* leave */
            ii(0x15_4c89, 1); retfw(); return;                          /* retf */
        }
    }
}
