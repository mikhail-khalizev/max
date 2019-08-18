using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1018_2212-df884027")]
        public void /* sys */ Method_1018_2212()
        {
            ii(0x1018_2212, 1); pushd(ebx);                             /* push ebx */
            ii(0x1018_2213, 1); pushd(edx);                             /* push edx */
            ii(0x1018_2214, 7); cmp(memb_a32[ds, 0x101b_ddad], 0);      /* cmp byte [0x101bddad], 0x0 */
            ii(0x1018_221b, 2); if(jzd(0x1018_2233, 0x16)) goto l_0x1018_2233; /* jz 0x10182233 */
            ii(0x1018_221d, 5); mov(edx, /* sys */ 0x1018_2209);        /* mov edx, 0x10182209 */
            ii(0x1018_2222, 5); mov(ebx, /* sys */ 0x1018_220e);        /* mov ebx, 0x1018220e */
            ii(0x1018_2227, 6); mov(memd_a32[ds, 0x101c_1c48], edx);    /* mov [0x101c1c48], edx */
            ii(0x1018_222d, 6); mov(memd_a32[ds, 0x101c_1c4c], ebx);    /* mov [0x101c1c4c], ebx */
        l_0x1018_2233:
            ii(0x1018_2233, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1018_2235, 6); mov(ax, memw_a32[ds, 0x101c_1c44]);     /* mov ax, [0x101c1c44] */
            ii(0x1018_223b, 5); calld(/* sys */ 0x1019_9bb8, 0x1_7978); /* call 0x10199bb8 */
            ii(0x1018_2240, 1); popd(edx);                              /* pop edx */
            ii(0x1018_2241, 1); popd(ebx);                              /* pop ebx */
            ii(0x1018_2242, 1); retd(); return;                         /* ret */
        }
    }
}
