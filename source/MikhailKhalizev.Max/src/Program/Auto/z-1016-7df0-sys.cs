using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("2243c4f2-3e07-42d1-bed9-9c90882261f7")]
        public void /* sys */ Method_1016_7df0()
        {
            ii(0x1016_7df0, 1); pushd(ebx);                             /* push ebx */
            ii(0x1016_7df1, 1); pushd(ecx);                             /* push ecx */
            ii(0x1016_7df2, 1); pushd(esi);                             /* push esi */
            ii(0x1016_7df3, 2); mov(ecx, eax);                          /* mov ecx, eax */
            ii(0x1016_7df5, 2); mov(esi, edx);                          /* mov esi, edx */
            ii(0x1016_7df7, 6); mov(ebx, memd_a32[ds, 0x101c_b2d8]);    /* mov ebx, [0x101cb2d8] */
            ii(0x1016_7dfd, 1); dec(ebx);                               /* dec ebx */
            ii(0x1016_7dfe, 3); cmp(ebx, 0x1);                          /* cmp ebx, 0x1 */
            ii(0x1016_7e01, 2); if(jld(0x1016_7e2d, 0x2a)) goto l_0x1016_7e2d; /* jl 0x10167e2d */
            ii(0x1016_7e03, 7); lea(edx, ebx * 4 + 0);                  /* lea edx, [ebx*4] */
        l_0x1016_7e0a:
            ii(0x1016_7e0a, 6); mov(eax, memd_a32[ds, edx + 0x101c_b1fc]); /* mov eax, [edx+0x101cb1fc] */
            ii(0x1016_7e10, 3); cmp(ecx, memd_a32[ds, eax + 0x8]);      /* cmp ecx, [eax+0x8] */
            ii(0x1016_7e13, 2); if(jld(0x1016_7e24, 0xf)) goto l_0x1016_7e24; /* jl 0x10167e24 */
            ii(0x1016_7e15, 3); cmp(ecx, memd_a32[ds, eax + 0x10]);     /* cmp ecx, [eax+0x10] */
            ii(0x1016_7e18, 2); if(jgd(0x1016_7e24, 0xa)) goto l_0x1016_7e24; /* jg 0x10167e24 */
            ii(0x1016_7e1a, 3); cmp(esi, memd_a32[ds, eax + 0xc]);      /* cmp esi, [eax+0xc] */
            ii(0x1016_7e1d, 2); if(jld(0x1016_7e24, 0x5)) goto l_0x1016_7e24; /* jl 0x10167e24 */
            ii(0x1016_7e1f, 3); cmp(esi, memd_a32[ds, eax + 0x14]);     /* cmp esi, [eax+0x14] */
            ii(0x1016_7e22, 2); if(jled(0x1016_7e2d, 0x9)) goto l_0x1016_7e2d; /* jle 0x10167e2d */
        l_0x1016_7e24:
            ii(0x1016_7e24, 3); sub(edx, 0x4);                          /* sub edx, 0x4 */
            ii(0x1016_7e27, 1); dec(ebx);                               /* dec ebx */
            ii(0x1016_7e28, 3); cmp(edx, 0x4);                          /* cmp edx, 0x4 */
            ii(0x1016_7e2b, 2); if(jged(0x1016_7e0a, -0x23)) goto l_0x1016_7e0a; /* jge 0x10167e0a */
        l_0x1016_7e2d:
            ii(0x1016_7e2d, 7); mov(eax, memd_a32[ds, ebx * 4 + 0x101c_b1fc]); /* mov eax, [ebx*4+0x101cb1fc] */
            ii(0x1016_7e34, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x1016_7e36, 1); popd(esi);                              /* pop esi */
            ii(0x1016_7e37, 1); popd(ecx);                              /* pop ecx */
            ii(0x1016_7e38, 1); popd(ebx);                              /* pop ebx */
            ii(0x1016_7e39, 1); retd(); return;                         /* ret */
        }
    }
}
