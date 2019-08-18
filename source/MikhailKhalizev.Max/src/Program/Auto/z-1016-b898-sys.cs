using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("a462861f-b3c1-40bb-a899-5762f0bfa116")]
        public void /* sys */ Method_1016_b898()
        {
            ii(0x1016_b898, 1); pushd(edx);                             /* push edx */
            ii(0x1016_b899, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1016_b89b, 5); calld(/* sys */ 0x1016_b7b8, -0xe8);    /* call 0x1016b7b8 */
            ii(0x1016_b8a0, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1016_b8a2, 2); if(jad(0x1016_b8a8, 0x4)) goto l_0x1016_b8a8; /* ja 0x1016b8a8 */
            ii(0x1016_b8a4, 2); sub(eax, edx);                          /* sub eax, edx */
            ii(0x1016_b8a6, 1); popd(edx);                              /* pop edx */
            ii(0x1016_b8a7, 1); retd(); return;                         /* ret */
        l_0x1016_b8a8:
            ii(0x1016_b8a8, 5); mov(eax, 0x7fff_ffff);                  /* mov eax, 0x7fffffff */
            ii(0x1016_b8ad, 1); popd(edx);                              /* pop edx */
            ii(0x1016_b8ae, 1); retd(); return;                         /* ret */
        }
    }
}
