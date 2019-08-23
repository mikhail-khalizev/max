using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1017_d1da-b016c4de")]
        public void /* sys */ Method_1017_d1da()
        {
            ii(0x1017_d1da, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1017_d1dc, 2); if(jld(0x1017_d1ea, 0xc)) goto l_0x1017_d1ea; /* jl 0x1017d1ea */
            ii(0x1017_d1de, 6); cmp(eax, memd_a32[ds, 0x101c_09d0]);    /* cmp eax, [0x101c09d0] */
            ii(0x1017_d1e4, 6); if(jbed_func(0x1018_d6b2, 0x1_04c8)) return; /* jbe 0x1018d6b2 */
        l_0x1017_d1ea:
            ii(0x1017_d1ea, 5); mov(eax, 0x4);                          /* mov eax, 0x4 */
            ii(0x1017_d1ef, 5); calld(/* sys */ 0x1018_d3bf, 0x1_01cb); /* call 0x1018d3bf */
            ii(0x1017_d1f4, 5); mov(eax, 0xffff_ffff);                  /* mov eax, 0xffffffff */
            ii(0x1017_d1f9, 1); retd();                                 /* ret */
        }
    }
}
