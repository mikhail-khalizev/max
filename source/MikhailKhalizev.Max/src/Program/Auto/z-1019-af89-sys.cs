using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("e3989541-73f4-4a5e-98f0-15a73114aa48")]
        public void /* sys */ Method_1019_af89()
        {
            ii(0x1019_af89, 1); pushd(ebx);                             /* push ebx */
            ii(0x1019_af8a, 1); pushd(ecx);                             /* push ecx */
            ii(0x1019_af8b, 1); pushd(esi);                             /* push esi */
            ii(0x1019_af8c, 1); pushd(ebp);                             /* push ebp */
            ii(0x1019_af8d, 3); mov(ecx, memd_a32[ds, eax + 0x8]);      /* mov ecx, [eax+0x8] */
            ii(0x1019_af90, 3); mov(esi, memd_a32[ds, edx + 0x8]);      /* mov esi, [edx+0x8] */
            ii(0x1019_af93, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1019_af95, 2); cmp(ecx, esi);                          /* cmp ecx, esi */
            ii(0x1019_af97, 2); if(jld(0x1019_afad, 0x14)) goto l_0x1019_afad; /* jl 0x1019afad */
            ii(0x1019_af99, 2); if(jnzd(0x1019_afb2, 0x17)) goto l_0x1019_afb2; /* jnz 0x1019afb2 */
            ii(0x1019_af9b, 3); mov(ecx, memd_a32[ds, eax + 0x4]);      /* mov ecx, [eax+0x4] */
            ii(0x1019_af9e, 3); mov(ebp, memd_a32[ds, edx + 0x4]);      /* mov ebp, [edx+0x4] */
            ii(0x1019_afa1, 2); cmp(ecx, ebp);                          /* cmp ecx, ebp */
            ii(0x1019_afa3, 2); if(jld(0x1019_afad, 0x8)) goto l_0x1019_afad; /* jl 0x1019afad */
            ii(0x1019_afa5, 2); if(jnzd(0x1019_afb2, 0xb)) goto l_0x1019_afb2; /* jnz 0x1019afb2 */
            ii(0x1019_afa7, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x1019_afa9, 2); cmp(eax, memd_a32[ds, edx]);            /* cmp eax, [edx] */
            ii(0x1019_afab, 2); if(jged(0x1019_afb2, 0x5)) goto l_0x1019_afb2; /* jge 0x1019afb2 */
        l_0x1019_afad:
            ii(0x1019_afad, 5); mov(ebx, 0x1);                          /* mov ebx, 0x1 */
        l_0x1019_afb2:
            ii(0x1019_afb2, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1019_afb4, 1); popd(ebp);                              /* pop ebp */
            ii(0x1019_afb5, 1); popd(esi);                              /* pop esi */
            ii(0x1019_afb6, 1); popd(ecx);                              /* pop ecx */
            ii(0x1019_afb7, 1); popd(ebx);                              /* pop ebx */
            ii(0x1019_afb8, 1); retd(); return;                         /* ret */
        }
    }
}
