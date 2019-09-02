using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x18_b2a3-cda00669")]
        public void Method_0018_b2a3()
        {
            ii(0x18_b2a3, 3); mov(si, 6);                               /* mov si, 0x6 */
            ii(0x18_b2a6, 2); jmp(0x18_b2ab, 3); goto l_0x18_b2ab;      /* jmp 0xb2ab */
        //  ii(0x18_b2a8, 3); mov(si, 4);                               /* mov si, 0x4 */
        l_0x18_b2ab:
            ii(0x18_b2ab, 3); call(0x18_a893, -0xa1b);                  /* call 0xa893 */
            ii(0x18_b2ae, 4); mov(di, memw[ds, 0xc3e]);                 /* mov di, [0xc3e] */
            ii(0x18_b2b2, 2); mov(memw[ss, bp + si], di);               /* mov [bp+si], di */
            ii(0x18_b2b4, 2); mov(ax, memw[ds, bx + si]);               /* mov ax, [bx+si] */
            ii(0x18_b2b6, 3); call(0x18_b2bc, 3);                       /* call 0xb2bc */
            ii(0x18_b2b9, 3); if(jmp_func(0x18_a81f, -0xa9d)) return;   /* jmp 0xa81f */
        }
    }
}
