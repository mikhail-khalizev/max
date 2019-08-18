using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("2736104f-6a50-49e9-b427-ab521d43b169")]
        public void /* sys */ Method_1018_d3bf()
        {
            ii(0x1018_d3bf, 1); pushd(edx);                             /* push edx */
            ii(0x1018_d3c0, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1018_d3c2, 5); calld(/* sys */ 0x1018_d7a2, 0x3db);    /* call 0x1018d7a2 */
            ii(0x1018_d3c7, 2); mov(memd_a32[ds, eax], edx);            /* mov [eax], edx */
            ii(0x1018_d3c9, 1); popd(edx);                              /* pop edx */
            ii(0x1018_d3ca, 1); retd(); return;                         /* ret */
        }
    }
}
