using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("54416d59-175e-41c3-888c-e48b53976a36")]
        public void Method_0018_aad5()
        {
            ii(0x18_aad5, 1); pushw(bx);                                /* push bx */
            ii(0x18_aad6, 2); mov(bx, di);                              /* mov bx, di */
            ii(0x18_aad8, 3); mov(ax, 0x6);                             /* mov ax, 0x6 */
            ii(0x18_aadb, 1); pushw(cs);                                /* push cs */
            ii(0x18_aadc, 3); callw(0x18_a3b9, -0x726);                 /* call 0xa3b9 */
            ii(0x18_aadf, 1); xchg(dx, ax);                             /* xchg dx, ax */
            ii(0x18_aae0, 1); popw(bx);                                 /* pop bx */
            ii(0x18_aae1, 2); if(jmpw_func(0x18_ab00, 0x1d)) return;    /* jmp 0xab00 */
        }
    }
}
