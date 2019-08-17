using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("f78e8ca8-df99-4144-8295-ec6c9d83070b")]
        public void Method_0013_83d4()
        {
            ii(0x13_83d4, 4); enterw(0x4, 0);                           /* enter 0x4, 0x0 */
            ii(0x13_83d8, 1); pushw(si);                                /* push si */
            ii(0x13_83d9, 1); pushw(ds);                                /* push ds */
            ii(0x13_83da, 3); mov(ax, 0x3e68);                          /* mov ax, 0x3e68 */
            ii(0x13_83dd, 2); mov(ds, ax);                              /* mov ds, ax */
            ii(0x13_83df, 3); mov(ax, memw_a16[ds, 0xa2e]);             /* mov ax, [0xa2e] */
            ii(0x13_83e2, 4); or(ax, memw_a16[ds, 0xa2c]);              /* or ax, [0xa2c] */
            ii(0x13_83e6, 2); if(jnzw(0x13_83ec, 0x4)) goto l_0x13_83ec; /* jnz 0x83ec */
            ii(0x13_83e8, 1); popw(ds);                                 /* pop ds */
            ii(0x13_83e9, 1); popw(si);                                 /* pop si */
            ii(0x13_83ea, 1); leavew();                                 /* leave */
            ii(0x13_83eb, 1); retfw(); return;                          /* retf */
        l_0x13_83ec:
            ii(0x13_83ec, 1); pushw(cs);                                /* push cs */
            ii(0x13_83ed, 3); callw(0x13_8d64, 0x974);                  /* call 0x8d64 */
        }
    }
}
