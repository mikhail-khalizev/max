using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("2cdc40f9-e22b-4da8-b479-6781e3e01246")]
        public void Method_0018_dd01()
        {
            ii(0x18_dd01, 2); mov(bx, sp);                              /* mov bx, sp */
            ii(0x18_dd03, 4); mov(bx, memw_a16[ss, bx + 0x2]);          /* mov bx, [ss:bx+0x2] */
            ii(0x18_dd07, 3); mov(ax, 0x1);                             /* mov ax, 0x1 */
            ii(0x18_dd0a, 1); pushw(cs);                                /* push cs */
            ii(0x18_dd0b, 3); callw(0x18_a3b9, -0x3955);                /* call 0xa3b9 */
            ii(0x18_dd0e, 2); if(jmpw_func(0x18_dcfb, -0x15)) return;   /* jmp 0xdcfb */
        }
    }
}
