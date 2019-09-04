using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100c_dd8f-be5294f")]
        public void Method_100c_dd8f()
        {
            ii(0x100c_dd8f, 7); mov(bx, memw[ds, 0x101c_59b4]);         /* mov bx, [0x101c59b4] */
            ii(0x100c_dd96, 5); mov(ecx, 8);                            /* mov ecx, 0x8 */
            ii(0x100c_dd9b, 1); clc();                                  /* clc */
        l_0x100c_dd9c:
            ii(0x100c_dd9c, 2); rcl(al, 1);                             /* rcl al, 1 */
            ii(0x100c_dd9e, 3); rcl(bx, 1);                             /* rcl bx, 1 */
            ii(0x100c_dda1, 2); if(jae(0x100c_dda8, 5)) goto l_0x100c_dda8; /* jae 0x100cdda8 */
            ii(0x100c_dda3, 5); xor(bx, 0x1021);                        /* xor bx, 0x1021 */
        l_0x100c_dda8:
            ii(0x100c_dda8, 2); if(loop(0x100c_dd9c, -0xe)) goto l_0x100c_dd9c; /* loop 0x100cdd9c */
            ii(0x100c_ddaa, 7); mov(memw[ds, 0x101c_59b4], bx);         /* mov [0x101c59b4], bx */
            ii(0x100c_ddb1, 1); ret();                                  /* ret */
        }
    }
}
