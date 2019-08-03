using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("685e22c9-e49f-4367-afe5-0088c5c12b21")]
        public void /* sys */ sys_fopen()
        {
            ii(0x1017_237a, 1); pushd(ebx);                             /* push ebx */
            ii(0x1017_237b, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1017_237d, 5); calld(/* sys */ 0x1017_2341, -0x41);    /* call 0x10172341 */
            ii(0x1017_2382, 1); popd(ebx);                              /* pop ebx */
            ii(0x1017_2383, 1); retd(); return;                         /* ret */
        }
    }
}
