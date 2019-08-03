using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("809acb2c-e053-45a4-9c18-b919be9b7f32")]
        public void /* sys */ Method_1018_4ed0()
        {
            ii(0x1018_4ed0, 1); pushd(ebx);                             /* push ebx */
            ii(0x1018_4ed1, 1); pushd(ecx);                             /* push ecx */
            ii(0x1018_4ed2, 1); pushd(esi);                             /* push esi */
            ii(0x1018_4ed3, 2); mov(esi, edx);                          /* mov esi, edx */
            ii(0x1018_4ed5, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x1018_4ed7, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1018_4ed9, 2); test(esi, esi);                         /* test esi, esi */
            ii(0x1018_4edb, 2); if(jled(0x1018_4ef5, 0x18)) goto l_0x1018_4ef5; /* jle 0x10184ef5 */
            ii(0x1018_4edd, 2); mov(ebx, eax);                          /* mov ebx, eax */
        l_0x1018_4edf:
            ii(0x1018_4edf, 2); mov(eax, memd_a32[ds, ebx]);            /* mov eax, [ebx] */
            ii(0x1018_4ee1, 6); calld_abs(memd_a32[ds, 0x101b_ddf4]);   /* call dword [0x101bddf4] */
            ii(0x1018_4ee7, 2); cmp(eax, ecx);                          /* cmp eax, ecx */
            ii(0x1018_4ee9, 2); if(jled(0x1018_4eed, 0x2)) goto l_0x1018_4eed; /* jle 0x10184eed */
            ii(0x1018_4eeb, 2); mov(ecx, eax);                          /* mov ecx, eax */
        l_0x1018_4eed:
            ii(0x1018_4eed, 1); inc(edx);                               /* inc edx */
            ii(0x1018_4eee, 3); add(ebx, 0x4);                          /* add ebx, 0x4 */
            ii(0x1018_4ef1, 2); cmp(edx, esi);                          /* cmp edx, esi */
            ii(0x1018_4ef3, 2); if(jld(0x1018_4edf, -0x16)) goto l_0x1018_4edf; /* jl 0x10184edf */
        l_0x1018_4ef5:
            ii(0x1018_4ef5, 2); mov(eax, ecx);                          /* mov eax, ecx */
            ii(0x1018_4ef7, 1); popd(esi);                              /* pop esi */
            ii(0x1018_4ef8, 1); popd(ecx);                              /* pop ecx */
            ii(0x1018_4ef9, 1); popd(ebx);                              /* pop ebx */
            ii(0x1018_4efa, 1); retd(); return;                         /* ret */
        }
    }
}
