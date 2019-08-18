using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("635dcb27-29ef-4b96-88ef-2760be8a2f49")]
        public void /* sys */ Method_1018_5f28()
        {
            ii(0x1018_5f28, 1); pushd(edx);                             /* push edx */
            ii(0x1018_5f29, 6); mov(edx, memd_a32[ds, 0x101b_e850]);    /* mov edx, [0x101be850] */
            ii(0x1018_5f2f, 5); mov(memd_a32[ds, 0x101b_e850], eax);    /* mov [0x101be850], eax */
            ii(0x1018_5f34, 3); mov(memd_a32[ds, eax + 0x10], edx);     /* mov [eax+0x10], edx */
            ii(0x1018_5f37, 1); popd(edx);                              /* pop edx */
            ii(0x1018_5f38, 1); retd(); return;                         /* ret */
        }
    }
}
