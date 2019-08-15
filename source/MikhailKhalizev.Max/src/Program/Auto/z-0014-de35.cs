using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("2a6795d4-6c65-459c-b7aa-d7cb3c5a3b31")]
        public void Method_0014_de35()
        {
            ii(0x14_de35, 1); pushw(cx);                                /* push cx */
            ii(0x14_de36, 3); mov(cx, 0x148);                           /* mov cx, 0x148 */
            ii(0x14_de39, 3); callw(0x14_ee48, 0x100c);                 /* call 0xee48 */
            ii(0x14_de3c, 1); popw(cx);                                 /* pop cx */
            ii(0x14_de3d, 8); if(jmpd_far_abs(0x80, 0x20)) return;      /* jmp dword 0x80:0x80 */
        }
    }
}
