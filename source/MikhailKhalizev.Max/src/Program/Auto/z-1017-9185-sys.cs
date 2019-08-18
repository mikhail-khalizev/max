using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("6741a4e4-a80e-459b-b68e-6530153d321d")]
        public void /* sys */ Method_1017_9185()
        {
            ii(0x1017_9185, 1); pushd(edx);                             /* push edx */
            ii(0x1017_9186, 6); mov(edx, memd_a32[ds, 0x101b_de0c]);    /* mov edx, [0x101bde0c] */
            ii(0x1017_918c, 5); calld(/* sys */ 0x1017_9193, 0x2);      /* call 0x10179193 */
            ii(0x1017_9191, 1); popd(edx);                              /* pop edx */
            ii(0x1017_9192, 1); retd(); return;                         /* ret */
        }
    }
}
