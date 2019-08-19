using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x18_b2a3-cda00669")]
        public void Method_0018_b2a3()
        {
            ii(0x18_b2a3, 3); mov(si, 0x6);                             /* mov si, 0x6 */
            ii(0x18_b2a6, 2); jmpw(0x18_b2ab, 0x3); goto l_0x18_b2ab;   /* jmp 0xb2ab */
        //  ii(0x18_b2a8, 3); Недостижимый код.
        l_0x18_b2ab:
            ii(0x18_b2ab, 3); callw(0x18_a893, -0xa1b);                 /* call 0xa893 */
            ii(0x18_b2ae, 4); mov(di, memw_a16[ds, 0xc3e]);             /* mov di, [0xc3e] */
            ii(0x18_b2b2, 2); mov(memw_a16[ss, bp + si], di);           /* mov [bp+si], di */
            ii(0x18_b2b4, 2); mov(ax, memw_a16[ds, bx + si]);           /* mov ax, [bx+si] */
            ii(0x18_b2b6, 3); callw(0x18_b2bc, 0x3);                    /* call 0xb2bc */
            ii(0x18_b2b9, 3); if(jmpw_func(0x18_a81f, -0xa9d)) return;  /* jmp 0xa81f */
        }
    }
}
