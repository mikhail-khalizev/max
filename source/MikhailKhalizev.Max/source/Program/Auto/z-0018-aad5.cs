using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x18_aad5-6e04d72")]
        public void Method_0018_aad5()
        {
            ii(0x18_aad5, 1);  push(bx);                               /* push bx */
            ii(0x18_aad6, 2);  mov(bx, di);                            /* mov bx, di */
            ii(0x18_aad8, 3);  mov(ax, 6);                             /* mov ax, 0x6 */
            ii(0x18_aadb, 1);  push(cs);                               /* push cs */
            ii(0x18_aadc, 3);  call(0x18_a3b9, -0x726);                /* call 0xa3b9 */
            ii(0x18_aadf, 1);  xchg(dx, ax);                           /* xchg dx, ax */
            ii(0x18_aae0, 1);  pop(bx);                                /* pop bx */
            ii(0x18_aae1, 2);  jmp_func(0x18_ab00, 0x1d);              /* jmp 0xab00 */
        }
    }
}
