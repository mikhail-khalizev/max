using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("d32da1f0-5529-4f36-a6c9-a6e41268dcda")]
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
