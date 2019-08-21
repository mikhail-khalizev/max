using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1018_7d92-5cc5645a")]
        public void /* sys */ Method_1018_7d92()
        {
            ii(0x1018_7d92, 1); pushd(ebx);                             /* push ebx */
            ii(0x1018_7d93, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1018_7d95, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1018_7d97, 2); mov(edx, memd_a32[ds, ebx]);            /* mov edx, [ebx] */
            ii(0x1018_7d99, 5); calld(/* sys */ 0x1017_29f1, -0x1_53ad); /* call 0x101729f1 */
            ii(0x1018_7d9e, 3); inc(memd_a32[ds, ebx + 0x10]);          /* inc dword [ebx+0x10] */
            ii(0x1018_7da1, 1); popd(ebx);                              /* pop ebx */
            ii(0x1018_7da2, 1); retd(); return;                         /* ret */
        }
    }
}
