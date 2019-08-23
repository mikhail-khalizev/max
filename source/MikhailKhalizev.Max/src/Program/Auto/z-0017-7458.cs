using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x17_7458-6bb548e7")]
        public void Method_0017_7458()
        {
            ii(0x17_7458, 1); push(ds);                                 /* push ds */
            ii(0x17_7459, 3); mov(ax, 0x3e68);                          /* mov ax, 0x3e68 */
            ii(0x17_745c, 2); mov(ds, ax);                              /* mov ds, ax */
            ii(0x17_745e, 4); mov(es, memw[ds, 0x1dc8]);                /* mov es, [0x1dc8] */
            ii(0x17_7462, 6); cmp(memb[es, 0x2e], 0xb);                 /* cmp byte [es:0x2e], 0xb */
            ii(0x17_7468, 2); if(jnz(0x17_7470, 0x6)) goto l_0x17_7470; /* jnz 0x7470 */
            ii(0x17_746a, 3); mov(ax, 0x1);                             /* mov ax, 0x1 */
            ii(0x17_746d, 1); pop(ds);                                  /* pop ds */
            ii(0x17_746e, 1); retf(); return;                           /* retf */
        //  ii(0x17_746f, 1); Недостижимый код.
        l_0x17_7470:
            ii(0x17_7470, 2); sub(ax, ax);                              /* sub ax, ax */
            ii(0x17_7472, 1); pop(ds);                                  /* pop ds */
            ii(0x17_7473, 1); retf();                                   /* retf */
        }
    }
}
