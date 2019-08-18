using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1016_d668-7d554c41")]
        public void /* sys */ Method_1016_d668()
        {
            ii(0x1016_d668, 5); mov(memd_a32[ds, 0x101b_deb0], eax);    /* mov [0x101bdeb0], eax */
            ii(0x1016_d66d, 6); mov(memd_a32[ds, 0x101b_deb4], edx);    /* mov [0x101bdeb4], edx */
            ii(0x1016_d673, 6); mov(memd_a32[ds, 0x101b_deb8], ebx);    /* mov [0x101bdeb8], ebx */
            ii(0x1016_d679, 1); retd(); return;                         /* ret */
        }
    }
}
