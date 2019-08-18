using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("eaf92892-2851-46ba-8ec0-d497883e22a5")]
        public void Method_100c_ddb2()
        {
            ii(0x100c_ddb2, 7); mov(bx, memw_a32[ds, 0x101c_59b6]);     /* mov bx, [0x101c59b6] */
            ii(0x100c_ddb9, 5); mov(ecx, 0x8);                          /* mov ecx, 0x8 */
            ii(0x100c_ddbe, 1); clc();                                  /* clc */
        l_0x100c_ddbf:
            ii(0x100c_ddbf, 2); rcl(al, 0x1);                           /* rcl al, 1 */
            ii(0x100c_ddc1, 3); rcl(bx, 0x1);                           /* rcl bx, 1 */
            ii(0x100c_ddc4, 2); if(jaed(0x100c_ddcb, 0x5)) goto l_0x100c_ddcb; /* jae 0x100cddcb */
            ii(0x100c_ddc6, 5); xor(bx, 0x1021);                        /* xor bx, 0x1021 */
        l_0x100c_ddcb:
            ii(0x100c_ddcb, 2); if(loopd_a32(0x100c_ddbf, -0xe)) goto l_0x100c_ddbf; /* loop 0x100cddbf */
            ii(0x100c_ddcd, 7); mov(memw_a32[ds, 0x101c_59b6], bx);     /* mov [0x101c59b6], bx */
            ii(0x100c_ddd4, 1); retd(); return;                         /* ret */
        }
    }
}
