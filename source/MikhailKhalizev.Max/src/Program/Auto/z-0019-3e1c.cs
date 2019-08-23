using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x19_3e1c-8020fe71")]
        public void Method_0019_3e1c()
        {
            ii(0x19_3e1c, 1); pushw(di);                                /* push di */
            ii(0x19_3e1d, 3); mov(si, memw_a16[ds, bx + 0x8]);          /* mov si, [bx+0x8] */
            ii(0x19_3e20, 3); cmp(si, memw_a16[ds, bx + 0xa]);          /* cmp si, [bx+0xa] */
            ii(0x19_3e23, 2); if(jnzw(0x19_3e28, 0x3)) goto l_0x19_3e28; /* jnz 0x3e28 */
            ii(0x19_3e25, 3); mov(si, memw_a16[ds, bx + 0x6]);          /* mov si, [bx+0x6] */
        l_0x19_3e28:
            ii(0x19_3e28, 1); lodsw_a16();                              /* lodsw */
            ii(0x19_3e29, 3); cmp(ax, 0xfffe);                          /* cmp ax, 0xfffe */
            ii(0x19_3e2c, 2); if(jzw(0x19_3e36, 0x8)) goto l_0x19_3e36; /* jz 0x3e36 */
            ii(0x19_3e2e, 2); mov(di, si);                              /* mov di, si */
            ii(0x19_3e30, 2); and(al, 0xfe);                            /* and al, 0xfe */
            ii(0x19_3e32, 2); add(si, ax);                              /* add si, ax */
            ii(0x19_3e34, 2); jmpw(0x19_3e28, -0xe); goto l_0x19_3e28;  /* jmp 0x3e28 */
        l_0x19_3e36:
            ii(0x19_3e36, 1); dec(di);                                  /* dec di */
            ii(0x19_3e37, 1); dec(di);                                  /* dec di */
            ii(0x19_3e38, 2); mov(si, di);                              /* mov si, di */
            ii(0x19_3e3a, 1); popw(di);                                 /* pop di */
            ii(0x19_3e3b, 1); retw();                                   /* ret */
        }
    }
}
