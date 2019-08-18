using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1016_b1e4-9ee16826")]
        public void /* sys */ Method_1016_b1e4()
        {
            ii(0x1016_b1e4, 1); pushd(edx);                             /* push edx */
            ii(0x1016_b1e5, 5); mov(eax, memd_a32[ds, 0x101c_fb54]);    /* mov eax, [0x101cfb54] */
            ii(0x1016_b1ea, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1016_b1ec, 2); if(jzd(0x1016_b1fc, 0xe)) goto l_0x1016_b1fc; /* jz 0x1016b1fc */
        l_0x1016_b1ee:
            ii(0x1016_b1ee, 3); mov(edx, memd_a32[ds, eax + 0x8]);      /* mov edx, [eax+0x8] */
            ii(0x1016_b1f1, 5); calld(Definitions.sys_free_internal, 0x1_725e); /* call 0x10182454 */
            ii(0x1016_b1f6, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1016_b1f8, 2); test(edx, edx);                         /* test edx, edx */
            ii(0x1016_b1fa, 2); if(jnzd(0x1016_b1ee, -0xe)) goto l_0x1016_b1ee; /* jnz 0x1016b1ee */
        l_0x1016_b1fc:
            ii(0x1016_b1fc, 5); calld(/* sys */ 0x1017_2b98, 0x7997);   /* call 0x10172b98 */
            ii(0x1016_b201, 5); calld(/* sys */ 0x1016_b96c, 0x766);    /* call 0x1016b96c */
            ii(0x1016_b206, 1); popd(edx);                              /* pop edx */
            ii(0x1016_b207, 1); retd(); return;                         /* ret */
        }
    }
}
