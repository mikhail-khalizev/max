using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x19_55db-36617466")]
        public void Method_0019_55db()
        {
            ii(0x19_55db, 4); enterw(0x4, 0);                           /* enter 0x4, 0x0 */
            ii(0x19_55df, 1); pushw(di);                                /* push di */
            ii(0x19_55e0, 1); pushw(si);                                /* push si */
            ii(0x19_55e1, 5); callw_far_abs(0x80, 0x51a8);              /* call word 0x80:0x51a8 */
            ii(0x19_55e6, 3); cmp(ax, 0);                               /* cmp ax, 0x0 */
            ii(0x19_55e9, 2); if(jnzw(0x19_55ee, 0x3)) goto l_0x19_55ee; /* jnz 0x55ee */
            ii(0x19_55eb, 3); jmpw(0x19_55f1, 0x3); goto l_0x19_55f1;   /* jmp 0x55f1 */
        l_0x19_55ee:
            ii(0x19_55ee, 3); jmpw(0x19_5616, 0x25); goto l_0x19_5616;  /* jmp 0x5616 */
        l_0x19_55f1:
            ii(0x19_55f1, 4); mov(es, memw_a16[ds, 0x3f88]);            /* mov es, [0x3f88] */
            ii(0x19_55f5, 4); mov(ax, memw_a16[es, 0x3b74]);            /* mov ax, [es:0x3b74] */
            ii(0x19_55f9, 5); mov(memw_a16[ss, bp - 0x4], 0);           /* mov word [bp-0x4], 0x0 */
            ii(0x19_55fe, 3); mov(memw_a16[ss, bp - 0x2], ax);          /* mov [bp-0x2], ax */
            ii(0x19_5601, 3); pushw(0x780);                             /* push 0x780 */
            ii(0x19_5604, 1); pushw(ds);                                /* push ds */
            ii(0x19_5605, 3); pushw(0x40f0);                            /* push 0x40f0 */
            ii(0x19_5608, 3); pushw(memw_a16[ss, bp - 0x2]);            /* push word [bp-0x2] */
            ii(0x19_560b, 3); pushw(memw_a16[ss, bp - 0x4]);            /* push word [bp-0x4] */
            ii(0x19_560e, 1); nop();                                    /* nop */
            ii(0x19_560f, 1); pushw(cs);                                /* push cs */
            ii(0x19_5610, 3); callw(0x19_0f5f, -0x46b4);                /* call 0xf5f */
            ii(0x19_5613, 3); add(sp, 0xa);                             /* add sp, 0xa */
        l_0x19_5616:
            ii(0x19_5616, 1); popw(si);                                 /* pop si */
            ii(0x19_5617, 1); popw(di);                                 /* pop di */
            ii(0x19_5618, 1); leavew();                                 /* leave */
            ii(0x19_5619, 1); retw(); return;                           /* ret */
        }
    }
}
