using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x17_d844-e742cf7")]
        public void Method_0017_d844()
        {
            ii(0x17_d844, 1); push(bp);                                 /* push bp */
            ii(0x17_d845, 2); mov(bp, sp);                              /* mov bp, sp */
            ii(0x17_d847, 1); push(si);                                 /* push si */
            ii(0x17_d848, 1); push(di);                                 /* push di */
            ii(0x17_d849, 1); push(ds);                                 /* push ds */
            ii(0x17_d84a, 1); pop(es);                                  /* pop es */
            ii(0x17_d84b, 3); mov(dx, memw[ss, bp + 6]);                /* mov dx, [bp+0x6] */
            ii(0x17_d84e, 3); mov(si, 0x1dda);                          /* mov si, 0x1dda */
        l_0x17_d851:
            ii(0x17_d851, 1); lodsw();                                  /* lodsw */
            ii(0x17_d852, 2); cmp(ax, dx);                              /* cmp ax, dx */
            ii(0x17_d854, 2); if(jz(0x17_d866, 0x10)) goto l_0x17_d866; /* jz 0xd866 */
            ii(0x17_d856, 1); inc(ax);                                  /* inc ax */
            ii(0x17_d857, 1); xchg(si, ax);                             /* xchg si, ax */
            ii(0x17_d858, 2); if(jz(0x17_d866, 0xc)) goto l_0x17_d866;  /* jz 0xd866 */
            ii(0x17_d85a, 1); xchg(di, ax);                             /* xchg di, ax */
            ii(0x17_d85b, 2); xor(ax, ax);                              /* xor ax, ax */
            ii(0x17_d85d, 3); mov(cx, 0xffff);                          /* mov cx, 0xffff */
            ii(0x17_d860, 2); repne(() => scasb());                     /* repne scasb */
            ii(0x17_d862, 2); mov(si, di);                              /* mov si, di */
            ii(0x17_d864, 2); jmp(0x17_d851, -0x15); goto l_0x17_d851;  /* jmp 0xd851 */
        l_0x17_d866:
            ii(0x17_d866, 1); xchg(si, ax);                             /* xchg si, ax */
            ii(0x17_d867, 1); pop(di);                                  /* pop di */
            ii(0x17_d868, 1); pop(si);                                  /* pop si */
            ii(0x17_d869, 2); mov(sp, bp);                              /* mov sp, bp */
            ii(0x17_d86b, 1); pop(bp);                                  /* pop bp */
            ii(0x17_d86c, 3); retf(2);                                  /* retf 0x2 */
        }
    }
}
