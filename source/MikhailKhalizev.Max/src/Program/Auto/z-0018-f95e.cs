using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("62f9bfcf-8454-4729-8400-87e9b3d0763c")]
        public void Method_0018_f95e()
        {
            ii(0x18_f95e, 4); enterw(0, 0);                             /* enter 0x0, 0x0 */
            ii(0x18_f962, 1); cli();                                    /* cli */
            ii(0x18_f963, 5); movzx(esi, memw_a16[ss, bp + 0x6]);       /* movzx esi, word [bp+0x6] */
            ii(0x18_f968, 4); mov(eax, memd_a16[ds, 0xa42]);            /* mov eax, [0xa42] */
            ii(0x18_f96c, 2); mov(memw_a16[ds, si], ax);                /* mov [si], ax */
            ii(0x18_f96e, 3); if(jmpw_func(0x18_fb55, 0x1e4)) return;   /* jmp 0xfb55 */
        }
    }
}
