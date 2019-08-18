using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("8697e2c9-83d3-4c5b-abc8-131232cd7f50")]
        public void /* sys */ Method_1018_1cc8()
        {
            ii(0x1018_1cc8, 1); pushd(ebx);                             /* push ebx */
            ii(0x1018_1cc9, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1018_1ccb, 3); mov(eax, memd_a32[ds, eax + 0x4]);      /* mov eax, [eax+0x4] */
            ii(0x1018_1cce, 3); mov(eax, memd_a32[ds, eax + 0x4]);      /* mov eax, [eax+0x4] */
            ii(0x1018_1cd1, 1); dec(edx);                               /* dec edx */
            ii(0x1018_1cd2, 5); calld(/* sys */ 0x1018_d304, 0xb62d);   /* call 0x1018d304 */
            ii(0x1018_1cd7, 3); imul(edx, eax);                         /* imul edx, eax */
            ii(0x1018_1cda, 3); mov(eax, memd_a32[ds, ebx + 0xc]);      /* mov eax, [ebx+0xc] */
            ii(0x1018_1cdd, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1018_1cdf, 1); popd(ebx);                              /* pop ebx */
            ii(0x1018_1ce0, 1); retd(); return;                         /* ret */
        }
    }
}
