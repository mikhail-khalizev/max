using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("716b896e-2a0c-4202-a13d-b9247e0788f4")]
        public void Method_0018_de35()
        {
            ii(0x18_de35, 1); pushw(cx);                                /* push cx */
            ii(0x18_de36, 3); mov(cx, 0x148);                           /* mov cx, 0x148 */
            ii(0x18_de39, 3); callw(0x18_ee48, 0x100c);                 /* call 0xee48 */
            ii(0x18_de3c, 1); popw(cx);                                 /* pop cx */
            ii(0x18_de3d, 8); if(jmpd_far_abs(0x80, 0x20)) return;      /* jmp dword 0x80:0x80 */
        }
    }
}
