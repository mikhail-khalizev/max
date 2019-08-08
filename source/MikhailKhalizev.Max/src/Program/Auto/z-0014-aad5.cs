using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("68caa843-10ea-4392-94e0-bdbf70498e9c")]
        public void Method_0014_aad5()
        {
            ii(0x14_aad5, 1); pushw(bx);                                /* push bx */
            ii(0x14_aad6, 2); mov(bx, di);                              /* mov bx, di */
            ii(0x14_aad8, 3); mov(ax, 0x6);                             /* mov ax, 0x6 */
            ii(0x14_aadb, 1); pushw(cs);                                /* push cs */
            ii(0x14_aadc, 3); callw(0x14_a3b9, -0x726);                 /* call 0xa3b9 */
            ii(0x14_aadf, 1); xchg(dx, ax);                             /* xchg dx, ax */
            ii(0x14_aae0, 1); popw(bx);                                 /* pop bx */
            ii(0x14_aae1, 2); if(jmpw_func(0x14_ab00, 0x1d)) return;    /* jmp 0xab00 */
        }
    }
}
