using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("5c0a977a-c969-449b-b8bb-07a7c2de3d75")]
        public void Method_1019_c529()
        {
            ii(0x1019_c529, 1); pushd(edx);                             /* push edx */
            ii(0x1019_c52a, 3); cmp(eax, 0x5);                          /* cmp eax, 0x5 */
            ii(0x1019_c52d, 2); if(jbed(0x1019_c533, 0x4)) goto l_0x1019_c533; /* jbe 0x1019c533 */
            ii(0x1019_c52f, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1019_c531, 1); popd(edx);                              /* pop edx */
            ii(0x1019_c532, 1); retd(); return;                         /* ret */
        l_0x1019_c533:
            ii(0x1019_c533, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1019_c535, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1019_c538, 2); sub(eax, edx);                          /* sub eax, edx */
            ii(0x1019_c53a, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1019_c53d, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1019_c53f, 2); add(eax, eax);                          /* add eax, eax */
            ii(0x1019_c541, 5); add(eax, 0x101b_e5a0);                  /* add eax, 0x101be5a0 */
            ii(0x1019_c546, 1); popd(edx);                              /* pop edx */
            ii(0x1019_c547, 1); retd(); return;                         /* ret */
        }
    }
}
