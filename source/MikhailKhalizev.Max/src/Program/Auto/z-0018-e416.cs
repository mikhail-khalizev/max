using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("326120db-3175-40a9-afa8-a73c14794e57")]
        public void Method_0018_e416()
        {
            ii(0x18_e416, 1); pushw(di);                                /* push di */
            ii(0x18_e417, 2); pushw(0x16);                              /* push 0x16 */
            ii(0x18_e419, 3); callw(0x18_e868, 0x44c);                  /* call 0xe868 */
            ii(0x18_e41c, 2); if(jmpw_func(0x18_e3ac, -0x72)) return;   /* jmp 0xe3ac */
        }
    }
}
