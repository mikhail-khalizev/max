using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x19_55db-36617466")]
        public void Method_0019_55db()
        {
            ii(0x19_55db, 4); enter(4, 0);                              /* enter 0x4, 0x0 */
            ii(0x19_55df, 1); push(di);                                 /* push di */
            ii(0x19_55e0, 1); push(si);                                 /* push si */
            ii(0x19_55e1, 5); call_far_abs(0x80, 0x51a8);               /* call word 0x80:0x51a8 */
            ii(0x19_55e6, 3); cmp(ax, 0);                               /* cmp ax, 0x0 */
            ii(0x19_55e9, 2); if(jnz(0x19_55ee, 3)) goto l_0x19_55ee;   /* jnz 0x55ee */
            ii(0x19_55eb, 3); jmp(0x19_55f1, 3); goto l_0x19_55f1;      /* jmp 0x55f1 */
        l_0x19_55ee:
            ii(0x19_55ee, 3); jmp(0x19_5616, 0x25); goto l_0x19_5616;   /* jmp 0x5616 */
        l_0x19_55f1:
            ii(0x19_55f1, 4); mov(es, memw[ds, 0x3f88]);                /* mov es, [0x3f88] */
            ii(0x19_55f5, 4); mov(ax, memw[es, 0x3b74]);                /* mov ax, [es:0x3b74] */
            ii(0x19_55f9, 5); mov(memw[ss, bp - 4], 0);                 /* mov word [bp-0x4], 0x0 */
            ii(0x19_55fe, 3); mov(memw[ss, bp - 2], ax);                /* mov [bp-0x2], ax */
            ii(0x19_5601, 3); push(0x780);                              /* push 0x780 */
            ii(0x19_5604, 1); push(ds);                                 /* push ds */
            ii(0x19_5605, 3); push(0x40f0);                             /* push 0x40f0 */
            ii(0x19_5608, 3); push(memw[ss, bp - 2]);                   /* push word [bp-0x2] */
            ii(0x19_560b, 3); push(memw[ss, bp - 4]);                   /* push word [bp-0x4] */
            ii(0x19_560e, 1); nop();                                    /* nop */
            ii(0x19_560f, 1); push(cs);                                 /* push cs */
            ii(0x19_5610, 3); call(0x19_0f5f, -0x46b4);                 /* call 0xf5f */
            ii(0x19_5613, 3); add(sp, 0xa);                             /* add sp, 0xa */
        l_0x19_5616:
            ii(0x19_5616, 1); pop(si);                                  /* pop si */
            ii(0x19_5617, 1); pop(di);                                  /* pop di */
            ii(0x19_5618, 1); leave();                                  /* leave */
            ii(0x19_5619, 1); ret();                                    /* ret */
        }
    }
}
