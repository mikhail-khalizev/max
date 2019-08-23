using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x19_559c-b09285e1")]
        public void Method_0019_559c()
        {
            ii(0x19_559c, 4); enter(0x4, 0);                            /* enter 0x4, 0x0 */
            ii(0x19_55a0, 1); push(di);                                 /* push di */
            ii(0x19_55a1, 1); push(si);                                 /* push si */
            ii(0x19_55a2, 5); call_far_abs(0x80, 0x51a8);               /* call word 0x80:0x51a8 */
            ii(0x19_55a7, 3); cmp(ax, 0);                               /* cmp ax, 0x0 */
            ii(0x19_55aa, 2); if(jnz(0x19_55af, 0x3)) goto l_0x19_55af; /* jnz 0x55af */
            ii(0x19_55ac, 3); jmp(0x19_55b2, 0x3); goto l_0x19_55b2;    /* jmp 0x55b2 */
        l_0x19_55af:
            ii(0x19_55af, 3); jmp(0x19_55d7, 0x25); goto l_0x19_55d7;   /* jmp 0x55d7 */
        l_0x19_55b2:
            ii(0x19_55b2, 4); mov(es, memw[ds, 0x3f88]);                /* mov es, [0x3f88] */
            ii(0x19_55b6, 4); mov(ax, memw[es, 0x3b74]);                /* mov ax, [es:0x3b74] */
            ii(0x19_55ba, 5); mov(memw[ss, bp - 0x4], 0);               /* mov word [bp-0x4], 0x0 */
            ii(0x19_55bf, 3); mov(memw[ss, bp - 0x2], ax);              /* mov [bp-0x2], ax */
            ii(0x19_55c2, 3); push(0x780);                              /* push 0x780 */
            ii(0x19_55c5, 3); push(memw[ss, bp - 0x2]);                 /* push word [bp-0x2] */
            ii(0x19_55c8, 3); push(memw[ss, bp - 0x4]);                 /* push word [bp-0x4] */
            ii(0x19_55cb, 1); push(ds);                                 /* push ds */
            ii(0x19_55cc, 3); push(0x40f0);                             /* push 0x40f0 */
            ii(0x19_55cf, 1); nop();                                    /* nop */
            ii(0x19_55d0, 1); push(cs);                                 /* push cs */
            ii(0x19_55d1, 3); call(0x19_0f5f, -0x4675);                 /* call 0xf5f */
            ii(0x19_55d4, 3); add(sp, 0xa);                             /* add sp, 0xa */
        l_0x19_55d7:
            ii(0x19_55d7, 1); pop(si);                                  /* pop si */
            ii(0x19_55d8, 1); pop(di);                                  /* pop di */
            ii(0x19_55d9, 1); leave();                                  /* leave */
            ii(0x19_55da, 1); ret();                                    /* ret */
        }
    }
}
