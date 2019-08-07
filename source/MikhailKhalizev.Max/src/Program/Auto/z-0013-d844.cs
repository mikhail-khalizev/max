using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("df1ec9d1-362c-47fe-b3b8-9d03d4e81d06")]
        public void Method_0013_d844()
        {
            ii(0x13_d844, 1); pushw(bp);                                /* push bp */
            ii(0x13_d845, 2); mov(bp, sp);                              /* mov bp, sp */
            ii(0x13_d847, 1); pushw(si);                                /* push si */
            ii(0x13_d848, 1); pushw(di);                                /* push di */
            ii(0x13_d849, 1); pushw(ds);                                /* push ds */
            ii(0x13_d84a, 1); popw(es);                                 /* pop es */
            ii(0x13_d84b, 3); mov(dx, memw_a16[ss, bp + 0x6]);          /* mov dx, [bp+0x6] */
            ii(0x13_d84e, 3); mov(si, 0x1dda);                          /* mov si, 0x1dda */
        l_0x13_d851:
            ii(0x13_d851, 1); lodsw_a16();                              /* lodsw */
            ii(0x13_d852, 2); cmp(ax, dx);                              /* cmp ax, dx */
            ii(0x13_d854, 2); if(jzw(0x13_d866, 0x10)) goto l_0x13_d866; /* jz 0xd866 */
            ii(0x13_d856, 1); inc(ax);                                  /* inc ax */
            ii(0x13_d857, 1); xchg(si, ax);                             /* xchg si, ax */
            ii(0x13_d858, 2); if(jzw(0x13_d866, 0xc)) goto l_0x13_d866; /* jz 0xd866 */
            ii(0x13_d85a, 1); xchg(di, ax);                             /* xchg di, ax */
            ii(0x13_d85b, 2); xor(ax, ax);                              /* xor ax, ax */
            ii(0x13_d85d, 3); mov(cx, 0xffff);                          /* mov cx, 0xffff */
            ii(0x13_d860, 2); repne_a16(() => scasb_a16());             /* repne scasb */
            ii(0x13_d862, 2); mov(si, di);                              /* mov si, di */
            ii(0x13_d864, 2); jmpw(0x13_d851, -0x15); goto l_0x13_d851; /* jmp 0xd851 */
        l_0x13_d866:
            ii(0x13_d866, 1); xchg(si, ax);                             /* xchg si, ax */
            ii(0x13_d867, 1); popw(di);                                 /* pop di */
            ii(0x13_d868, 1); popw(si);                                 /* pop si */
            ii(0x13_d869, 2); mov(sp, bp);                              /* mov sp, bp */
            ii(0x13_d86b, 1); popw(bp);                                 /* pop bp */
            ii(0x13_d86c, 3); retfw(0x2); return;                       /* retf 0x2 */
        }
    }
}
