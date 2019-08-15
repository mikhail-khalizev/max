using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("97fb0333-768f-41f2-9bc0-b0c709715c71")]
        public void /* sys */ Method_1016_611f()
        {
            ii(0x1016_611f, 1); pushd(edx);                             /* push edx */
            ii(0x1016_6120, 6); mov(edx, memd_a32[ds, 0x101b_e7bc]);    /* mov edx, [0x101be7bc] */
            ii(0x1016_6126, 2); mov(memd_a32[ds, eax], edx);            /* mov [eax], edx */
            ii(0x1016_6128, 5); mov(memd_a32[ds, 0x101b_e7bc], eax);    /* mov [0x101be7bc], eax */
            ii(0x1016_612d, 1); popd(edx);                              /* pop edx */
            ii(0x1016_612e, 1); retd(); return;                         /* ret */
        }
    }
}
