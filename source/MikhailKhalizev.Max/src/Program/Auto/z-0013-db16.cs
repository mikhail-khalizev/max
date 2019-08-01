using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("ca285bfd-6980-4242-a855-30d23dbc3f31")]
        public void Method_0013_db16()
        {
            ii(0x13_db16, 1); pushw(bp);                                /* push bp */
            ii(0x13_db17, 2); mov(bp, sp);                              /* mov bp, sp */
            ii(0x13_db19, 2); mov(dx, di);                              /* mov dx, di */
            ii(0x13_db1b, 2); mov(ax, ds);                              /* mov ax, ds */
            ii(0x13_db1d, 2); mov(es, ax);                              /* mov es, ax */
            ii(0x13_db1f, 3); mov(di, memw_a16[ss, bp + 0x6]);          /* mov di, [bp+0x6] */
            ii(0x13_db22, 2); xor(ax, ax);                              /* xor ax, ax */
            ii(0x13_db24, 3); mov(cx, 0xffff);                          /* mov cx, 0xffff */
            ii(0x13_db27, 2); repne_a16(() => scasb_a16());             /* repne scasb */
            ii(0x13_db29, 2); not(cx);                                  /* not cx */
            ii(0x13_db2b, 1); dec(cx);                                  /* dec cx */
            ii(0x13_db2c, 1); xchg(cx, ax);                             /* xchg cx, ax */
            ii(0x13_db2d, 2); mov(di, dx);                              /* mov di, dx */
            ii(0x13_db2f, 1); popw(bp);                                 /* pop bp */
            ii(0x13_db30, 1); retfw(); return;                          /* retf */
        }
    }
}
