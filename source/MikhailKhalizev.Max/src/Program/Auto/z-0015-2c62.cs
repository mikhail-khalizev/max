using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("a66f6088-4d02-4f42-9aca-41c9dfb1f82d")]
        public void Method_0015_2c62()
        {
            ii(0x15_2c62, 1); pushw(bp);                                /* push bp */
            ii(0x15_2c63, 2); mov(bp, sp);                              /* mov bp, sp */
            ii(0x15_2c65, 1); pushw(si);                                /* push si */
            ii(0x15_2c66, 1); pushw(di);                                /* push di */
            ii(0x15_2c67, 1); pushw(ds);                                /* push ds */
            ii(0x15_2c68, 1); popw(es);                                 /* pop es */
            ii(0x15_2c69, 3); mov(dx, memw_a16[ss, bp + 0x6]);          /* mov dx, [bp+0x6] */
            ii(0x15_2c6c, 3); mov(si, 0x3ff8);                          /* mov si, 0x3ff8 */
        l_0x15_2c6f:
            ii(0x15_2c6f, 1); lodsw_a16();                              /* lodsw */
            ii(0x15_2c70, 2); cmp(ax, dx);                              /* cmp ax, dx */
            ii(0x15_2c72, 2); if(jzw(0x15_2c84, 0x10)) goto l_0x15_2c84; /* jz 0x2c84 */
            ii(0x15_2c74, 1); inc(ax);                                  /* inc ax */
            ii(0x15_2c75, 1); xchg(si, ax);                             /* xchg si, ax */
            ii(0x15_2c76, 2); if(jzw(0x15_2c84, 0xc)) goto l_0x15_2c84; /* jz 0x2c84 */
            ii(0x15_2c78, 1); xchg(di, ax);                             /* xchg di, ax */
            ii(0x15_2c79, 2); xor(ax, ax);                              /* xor ax, ax */
            ii(0x15_2c7b, 3); mov(cx, 0xffff);                          /* mov cx, 0xffff */
            ii(0x15_2c7e, 2); repne_a16(() => scasb_a16());             /* repne scasb */
            ii(0x15_2c80, 2); mov(si, di);                              /* mov si, di */
            ii(0x15_2c82, 2); jmpw(0x15_2c6f, -0x15); goto l_0x15_2c6f; /* jmp 0x2c6f */
        l_0x15_2c84:
            ii(0x15_2c84, 1); xchg(si, ax);                             /* xchg si, ax */
            ii(0x15_2c85, 1); popw(di);                                 /* pop di */
            ii(0x15_2c86, 1); popw(si);                                 /* pop si */
            ii(0x15_2c87, 2); mov(sp, bp);                              /* mov sp, bp */
            ii(0x15_2c89, 1); popw(bp);                                 /* pop bp */
            ii(0x15_2c8a, 3); retfw(0x2); return;                       /* retf 0x2 */
        }
    }
}
