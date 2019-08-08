using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("d898f59d-de0e-4c33-a0a1-510fa46a0e1e")]
        public void Method_0014_a54d()
        {
            ii(0x14_a54d, 3); mov(memw_a16[ss, bp + 0x12], ds);         /* mov [bp+0x12], ds */
            ii(0x14_a550, 5); mov(memw_a16[ss, bp + 0x16], 0x98);       /* mov word [bp+0x16], 0x98 */
            ii(0x14_a555, 3); mov(ax, memw_a16[ds, 0x11f4]);            /* mov ax, [0x11f4] */
            ii(0x14_a558, 3); mov(memw_a16[ss, bp + 0x10], ax);         /* mov [bp+0x10], ax */
            ii(0x14_a55b, 3); mov(ax, memw_a16[ds, 0x11f6]);            /* mov ax, [0x11f6] */
            ii(0x14_a55e, 3); mov(memw_a16[ss, bp + 0x14], ax);         /* mov [bp+0x14], ax */
            ii(0x14_a561, 5); mov(memw_a16[ss, bp + 0xa], 0xc10);       /* mov word [bp+0xa], 0xc10 */
            ii(0x14_a566, 5); mov(memw_a16[ss, bp + 0x8], 0x4229);      /* mov word [bp+0x8], 0x4229 */
            ii(0x14_a56b, 3); if(jmpw_func(0x14_a838, 0x2ca)) return;   /* jmp 0xa838 */
        }
    }
}
