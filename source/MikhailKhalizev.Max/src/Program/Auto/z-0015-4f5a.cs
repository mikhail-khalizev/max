using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("096115c2-e42c-4e6b-b11b-4b320cdbe93a")]
        public void Method_0015_4f5a()
        {
            ii(0x15_4f5a, 1); pushw(bp);                                /* push bp */
            ii(0x15_4f5b, 2); mov(bp, sp);                              /* mov bp, sp */
            ii(0x15_4f5d, 1); pushw(ds);                                /* push ds */
            ii(0x15_4f5e, 3); mov(ax, 0xa8);                            /* mov ax, 0xa8 */
            ii(0x15_4f61, 2); mov(ds, ax);                              /* mov ds, ax */
            ii(0x15_4f63, 4); mov(es, memw_a16[ds, 0x3fe8]);            /* mov es, [0x3fe8] */
            ii(0x15_4f67, 4); mov(ax, memw_a16[es, 0x3b78]);            /* mov ax, [es:0x3b78] */
            ii(0x15_4f6b, 2); sub(bx, bx);                              /* sub bx, bx */
            ii(0x15_4f6d, 2); mov(es, ax);                              /* mov es, ax */
            ii(0x15_4f6f, 4); mov(ax, memw_a16[es, bx + 0x42]);         /* mov ax, [es:bx+0x42] */
            ii(0x15_4f73, 4); mov(dx, memw_a16[es, bx + 0x44]);         /* mov dx, [es:bx+0x44] */
            ii(0x15_4f77, 3); les(bx, ss, bp + 0x6);                    /* les bx, [bp+0x6] */
            ii(0x15_4f7a, 3); mov(memw_a16[es, bx], ax);                /* mov [es:bx], ax */
            ii(0x15_4f7d, 4); mov(memw_a16[es, bx + 0x2], dx);          /* mov [es:bx+0x2], dx */
            ii(0x15_4f81, 4); mov(es, memw_a16[ds, 0x3fe8]);            /* mov es, [0x3fe8] */
            ii(0x15_4f85, 4); mov(ax, memw_a16[es, 0x3b78]);            /* mov ax, [es:0x3b78] */
            ii(0x15_4f89, 2); sub(bx, bx);                              /* sub bx, bx */
            ii(0x15_4f8b, 2); mov(es, ax);                              /* mov es, ax */
            ii(0x15_4f8d, 3); mov(ax, memw_a16[ss, bp + 0x6]);          /* mov ax, [bp+0x6] */
            ii(0x15_4f90, 3); mov(dx, memw_a16[ss, bp + 0x8]);          /* mov dx, [bp+0x8] */
            ii(0x15_4f93, 4); mov(memw_a16[es, bx + 0x42], ax);         /* mov [es:bx+0x42], ax */
            ii(0x15_4f97, 4); mov(memw_a16[es, bx + 0x44], dx);         /* mov [es:bx+0x44], dx */
            ii(0x15_4f9b, 1); popw(ds);                                 /* pop ds */
            ii(0x15_4f9c, 1); leavew();                                 /* leave */
            ii(0x15_4f9d, 1); retfw(); return;                          /* retf */
        }
    }
}
