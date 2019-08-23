using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x19_789c-87f7770d")]
        public void Method_0019_789c()
        {
            ii(0x19_789c, 4); enterw(0x2, 0);                           /* enter 0x2, 0x0 */
            ii(0x19_78a0, 1); pushw(di);                                /* push di */
            ii(0x19_78a1, 1); pushw(si);                                /* push si */
            ii(0x19_78a2, 4); mov(bx, memw_a16[ds, 0x1274]);            /* mov bx, [0x1274] */
            ii(0x19_78a6, 4); inc(memw_a16[ds, 0x1274]);                /* inc word [0x1274] */
            ii(0x19_78aa, 2); shl(bx, 0x1);                             /* shl bx, 1 */
            ii(0x19_78ac, 4); pushw(memw_a16[ds, bx + 0x4870]);         /* push word [bx+0x4870] */
            ii(0x19_78b0, 3); pushw(memw_a16[ss, bp + 0xa]);            /* push word [bp+0xa] */
            ii(0x19_78b3, 3); pushw(memw_a16[ss, bp + 0x8]);            /* push word [bp+0x8] */
            ii(0x19_78b6, 3); pushw(memw_a16[ss, bp + 0x6]);            /* push word [bp+0x6] */
            ii(0x19_78b9, 3); callw(0x19_78d4, 0x18);                   /* call 0x78d4 */
            ii(0x19_78bc, 3); add(sp, 0x8);                             /* add sp, 0x8 */
            ii(0x19_78bf, 3); jmpw(0x19_78c2, 0); goto l_0x19_78c2;     /* jmp 0x78c2 */
        l_0x19_78c2:
            ii(0x19_78c2, 1); popw(si);                                 /* pop si */
            ii(0x19_78c3, 1); popw(di);                                 /* pop di */
            ii(0x19_78c4, 1); leavew();                                 /* leave */
            ii(0x19_78c5, 1); retfw();                                  /* retf */
        }
    }
}
