using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x18_dedd-cd824158")]
        public void Method_0018_dedd()
        {
            ii(0x18_dedd, 1);  push(cx);                               /* push cx */
            ii(0x18_dede, 3);  mov(cx, 0x404e);                        /* mov cx, 0x404e */
            ii(0x18_dee1, 3);  call(0x18_ee48, 0xf64);                 /* call 0xee48 */
            ii(0x18_dee4, 1);  pop(cx);                                /* pop cx */
            ii(0x18_dee5, 8);  jmpd_far_abs(0x80, 0x38);               /* jmp dword 0x80:0x80 */
        }
    }
}
