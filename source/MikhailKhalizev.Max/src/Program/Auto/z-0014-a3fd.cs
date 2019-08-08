using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("4fce693e-a06c-4486-9e17-a0a169784ea9")]
        public void Method_0014_a3fd()
        {
            ii(0x14_a3fd, 2); cmp(al, 0x5);                             /* cmp al, 0x5 */
            ii(0x14_a3ff, 2); if(jbew(0x14_a406, 0x5)) goto l_0x14_a406; /* jbe 0xa406 */
            ii(0x14_a401, 3); mov(ax, 0xffff);                          /* mov ax, 0xffff */
            ii(0x14_a404, 2); if(jmpw_func(0x14_a3f7, -0xf)) return;    /* jmp 0xa3f7 */
        l_0x14_a406:
            ii(0x14_a406, 4); xchg(memb_a16[ds, 0x980], al);            /* xchg [0x980], al */
            ii(0x14_a40a, 1); retw(); return;                           /* ret */
        }
    }
}
