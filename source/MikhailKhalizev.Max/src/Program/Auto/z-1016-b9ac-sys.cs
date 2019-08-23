using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1016_b9ac-b45b08af")]
        public void /* sys */ Method_1016_b9ac()
        {
            ii(0x1016_b9ac, 1); pushd(edx);                             /* push edx */
            ii(0x1016_b9ad, 2); xor(eax, eax);                          /* xor eax, eax */
        l_0x1016_b9af:
            ii(0x1016_b9af, 6); mov(dl, memb_a32[ds, eax + 0x101b_de20]); /* mov dl, [eax+0x101bde20] */
            ii(0x1016_b9b5, 3); cmp(dl, 0xf);                           /* cmp dl, 0xf */
            ii(0x1016_b9b8, 2); if(jnzd(0x1016_b9c2, 0x8)) goto l_0x1016_b9c2; /* jnz 0x1016b9c2 */
            ii(0x1016_b9ba, 6); mov(dl, memb_a32[ds, 0x1020_851f]);     /* mov dl, [0x1020851f] */
            ii(0x1016_b9c0, 2); jmpd(0x1016_b9e5, 0x23); goto l_0x1016_b9e5; /* jmp 0x1016b9e5 */
        l_0x1016_b9c2:
            ii(0x1016_b9c2, 3); cmp(dl, 0x1);                           /* cmp dl, 0x1 */
            ii(0x1016_b9c5, 2); if(jnzd(0x1016_b9db, 0x14)) goto l_0x1016_b9db; /* jnz 0x1016b9db */
            ii(0x1016_b9c7, 6); mov(dl, memb_a32[ds, 0x1020_2628]);     /* mov dl, [0x10202628] */
            ii(0x1016_b9cd, 6); mov(memb_a32[ds, eax + 0x101b_de20], dl); /* mov [eax+0x101bde20], dl */
            ii(0x1016_b9d3, 1); inc(eax);                               /* inc eax */
            ii(0x1016_b9d4, 3); cmp(eax, 0x40);                         /* cmp eax, 0x40 */
            ii(0x1016_b9d7, 2); if(jld(0x1016_b9af, -0x2a)) goto l_0x1016_b9af; /* jl 0x1016b9af */
            ii(0x1016_b9d9, 1); popd(edx);                              /* pop edx */
            ii(0x1016_b9da, 1); retd(); return;                         /* ret */
        l_0x1016_b9db:
            ii(0x1016_b9db, 2); test(dl, dl);                           /* test dl, dl */
            ii(0x1016_b9dd, 2); if(jnzd(0x1016_b9eb, 0xc)) goto l_0x1016_b9eb; /* jnz 0x1016b9eb */
            ii(0x1016_b9df, 6); mov(dl, memb_a32[ds, 0x1020_0520]);     /* mov dl, [0x10200520] */
        l_0x1016_b9e5:
            ii(0x1016_b9e5, 6); mov(memb_a32[ds, eax + 0x101b_de20], dl); /* mov [eax+0x101bde20], dl */
        l_0x1016_b9eb:
            ii(0x1016_b9eb, 1); inc(eax);                               /* inc eax */
            ii(0x1016_b9ec, 3); cmp(eax, 0x40);                         /* cmp eax, 0x40 */
            ii(0x1016_b9ef, 2); if(jld(0x1016_b9af, -0x42)) goto l_0x1016_b9af; /* jl 0x1016b9af */
            ii(0x1016_b9f1, 1); popd(edx);                              /* pop edx */
            ii(0x1016_b9f2, 1); retd();                                 /* ret */
        }
    }
}
