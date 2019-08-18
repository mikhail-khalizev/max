using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("81e0c9d1-58ee-488d-a142-a29e5f6b3692")]
        public void /* sys */ Method_1018_d348()
        {
            ii(0x1018_d348, 3); mov(memd_a32[ds, eax + 0x4], edx);      /* mov [eax+0x4], edx */
            ii(0x1018_d34b, 3); mov(memd_a32[ds, eax + 0x8], ebx);      /* mov [eax+0x8], ebx */
            ii(0x1018_d34e, 6); mov(edx, memd_a32[ds, 0x1020_a1f8]);    /* mov edx, [0x1020a1f8] */
            ii(0x1018_d354, 2); mov(memd_a32[ds, eax], edx);            /* mov [eax], edx */
            ii(0x1018_d356, 5); mov(memd_a32[ds, 0x1020_a1f8], eax);    /* mov [0x1020a1f8], eax */
            ii(0x1018_d35b, 5); mov(eax, 0x1020_a1f8);                  /* mov eax, 0x1020a1f8 */
            ii(0x1018_d360, 1); retd(); return;                         /* ret */
        }
    }
}
