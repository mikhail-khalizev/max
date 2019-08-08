using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("91aab4ab-4b04-4390-9fe3-5d07876666ca")]
        public void Method_0013_7458()
        {
            ii(0x13_7458, 1); pushw(ds);                                /* push ds */
            ii(0x13_7459, 3); mov(ax, 0x3e68);                          /* mov ax, 0x3e68 */
            ii(0x13_745c, 2); mov(ds, ax);                              /* mov ds, ax */
            ii(0x13_745e, 4); mov(es, memw_a16[ds, 0x1dc8]);            /* mov es, [0x1dc8] */
            ii(0x13_7462, 6); cmp(memb_a16[es, 0x2e], 0xb);             /* cmp byte [es:0x2e], 0xb */
            ii(0x13_7468, 2); if(jnzw(0x13_7470, 0x6)) goto l_0x13_7470; /* jnz 0x7470 */
            ii(0x13_746a, 3); mov(ax, 0x1);                             /* mov ax, 0x1 */
            ii(0x13_746d, 1); popw(ds);                                 /* pop ds */
            ii(0x13_746e, 1); retfw(); return;                          /* retf */
        //  ii(0x13_746f, 1); Недостижимый код.
        l_0x13_7470:
            ii(0x13_7470, 2); sub(ax, ax);                              /* sub ax, ax */
            ii(0x13_7472, 1); popw(ds);                                 /* pop ds */
            ii(0x13_7473, 1); retfw(); return;                          /* retf */
        }
    }
}
