using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x18_de51-78fe9895")]
        public void Method_0018_de51()
        {
            ii(0x18_de51, 1); pushw(cx);                                /* push cx */
            ii(0x18_de52, 3); mov(cx, 0x269);                           /* mov cx, 0x269 */
            ii(0x18_de55, 3); callw(0x18_ee48, 0xff0);                  /* call 0xee48 */
            ii(0x18_de58, 1); popw(cx);                                 /* pop cx */
            ii(0x18_de59, 8); jmpd_far_abs(0x80, 0x24);                 /* jmp dword 0x80:0x80 */
        }
    }
}
