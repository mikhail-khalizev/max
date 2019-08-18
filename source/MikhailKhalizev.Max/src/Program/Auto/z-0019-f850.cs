using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("622bc8dd-eb81-4785-b39c-78a8b3fb27df")]
        public void Method_0019_f850()
        {
            ii(0x19_f850, 4); enterw(0x4, 0);                           /* enter 0x4, 0x0 */
            ii(0x19_f854, 1); pushw(di);                                /* push di */
            ii(0x19_f855, 1); pushw(si);                                /* push si */
            ii(0x19_f856, 3); pushw(memw_a16[ss, bp + 0x6]);            /* push word [bp+0x6] */
            ii(0x19_f859, 2); pushw(0x23);                              /* push 0x23 */
            ii(0x19_f85b, 1); nop();                                    /* nop */
            ii(0x19_f85c, 1); pushw(cs);                                /* push cs */
            ii(0x19_f85d, 3); callw(0x19_f7ef, -0x71);                  /* call 0xf7ef */
            ii(0x19_f860, 3); add(sp, 0x4);                             /* add sp, 0x4 */
            ii(0x19_f863, 4); mov(es, memw_a16[ds, 0x3fdc]);            /* mov es, [0x3fdc] */
            ii(0x19_f867, 4); mov(ax, memw_a16[es, 0x3b78]);            /* mov ax, [es:0x3b78] */
            ii(0x19_f86b, 5); mov(memw_a16[ss, bp - 0x4], 0);           /* mov word [bp-0x4], 0x0 */
            ii(0x19_f870, 3); mov(memw_a16[ss, bp - 0x2], ax);          /* mov [bp-0x2], ax */
            ii(0x19_f873, 3); les(bx, ss, bp - 0x4);                    /* les bx, [bp-0x4] */
            ii(0x19_f876, 5); test(memb_a16[es, bx + 0x47], 0x1);       /* test byte [es:bx+0x47], 0x1 */
            ii(0x19_f87b, 2); if(jnzw(0x19_f880, 0x3)) goto l_0x19_f880; /* jnz 0xf880 */
            ii(0x19_f87d, 3); jmpw(0x19_f88d, 0xd); goto l_0x19_f88d;   /* jmp 0xf88d */
        l_0x19_f880:
            ii(0x19_f880, 3); pushw(memw_a16[ss, bp + 0x6]);            /* push word [bp+0x6] */
            ii(0x19_f883, 2); pushw(0x1b);                              /* push 0x1b */
            ii(0x19_f885, 1); nop();                                    /* nop */
            ii(0x19_f886, 1); pushw(cs);                                /* push cs */
            ii(0x19_f887, 3); callw(0x19_f7ef, -0x9b);                  /* call 0xf7ef */
            ii(0x19_f88a, 3); add(sp, 0x4);                             /* add sp, 0x4 */
        l_0x19_f88d:
            ii(0x19_f88d, 5); mov(memb_a16[ds, 0x308a], 0);             /* mov byte [0x308a], 0x0 */
            ii(0x19_f892, 1); popw(si);                                 /* pop si */
            ii(0x19_f893, 1); popw(di);                                 /* pop di */
            ii(0x19_f894, 1); leavew();                                 /* leave */
            ii(0x19_f895, 1); retfw(); return;                          /* retf */
        }
    }
}
