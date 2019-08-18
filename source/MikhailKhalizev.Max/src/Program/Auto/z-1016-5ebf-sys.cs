using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1016_5ebf-13e83eb3")]
        public void /* sys */ Method_1016_5ebf()
        {
            ii(0x1016_5ebf, 1); pushd(edx);                             /* push edx */
            ii(0x1016_5ec0, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1016_5ec2, 5); calld(/* sys */ 0x1016_5e95, -0x32);    /* call 0x10165e95 */
            ii(0x1016_5ec7, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1016_5ec9, 2); if(jzd(0x1016_5ecd, 0x2)) goto l_0x1016_5ecd; /* jz 0x10165ecd */
            ii(0x1016_5ecb, 2); mov(memd_a32[ds, eax], edx);            /* mov [eax], edx */
        l_0x1016_5ecd:
            ii(0x1016_5ecd, 1); popd(edx);                              /* pop edx */
            ii(0x1016_5ece, 1); retd(); return;                         /* ret */
        }
    }
}
