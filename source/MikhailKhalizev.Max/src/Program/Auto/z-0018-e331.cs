using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0043f060-c2b4-47de-8a1b-c684feb5e036")]
        public void Method_0018_e331()
        {
            ii(0x18_e331, 2); pushw(0x38);                              /* push 0x38 */
            ii(0x18_e333, 1); popw(ds);                                 /* pop ds */
            ii(0x18_e334, 4); mov(si, memw_a32[ss, ebp + 0x14]);        /* mov si, [ebp+0x14] */
            ii(0x18_e338, 4); and(si, 0xff);                            /* and si, 0xff */
            ii(0x18_e33c, 3); shl(si, 0x2);                             /* shl si, 0x2 */
            ii(0x18_e33f, 1); lodsw_a16();                              /* lodsw */
            ii(0x18_e340, 4); mov(memw_a32[ss, ebp + 0x18], ax);        /* mov [ebp+0x18], ax */
            ii(0x18_e344, 1); lodsw_a16();                              /* lodsw */
            ii(0x18_e345, 4); mov(memw_a32[ss, ebp + 0x1c], ax);        /* mov [ebp+0x1c], ax */
            ii(0x18_e349, 3); if(jmpw_func(0x18_e067, -0x2e5)) return;  /* jmp 0xe067 */
        }
    }
}
