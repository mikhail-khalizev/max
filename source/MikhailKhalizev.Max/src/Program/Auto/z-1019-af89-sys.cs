using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1019_af89-44bb0488")]
        public void /* sys */ Method_1019_af89()
        {
            ii(0x1019_af89, 1); push(ebx);                              /* push ebx */
            ii(0x1019_af8a, 1); push(ecx);                              /* push ecx */
            ii(0x1019_af8b, 1); push(esi);                              /* push esi */
            ii(0x1019_af8c, 1); push(ebp);                              /* push ebp */
            ii(0x1019_af8d, 3); mov(ecx, memd[ds, eax + 8]);            /* mov ecx, [eax+0x8] */
            ii(0x1019_af90, 3); mov(esi, memd[ds, edx + 8]);            /* mov esi, [edx+0x8] */
            ii(0x1019_af93, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1019_af95, 2); cmp(ecx, esi);                          /* cmp ecx, esi */
            ii(0x1019_af97, 2); if(jl(0x1019_afad, 0x14)) goto l_0x1019_afad; /* jl 0x1019afad */
            ii(0x1019_af99, 2); if(jnz(0x1019_afb2, 0x17)) goto l_0x1019_afb2; /* jnz 0x1019afb2 */
            ii(0x1019_af9b, 3); mov(ecx, memd[ds, eax + 4]);            /* mov ecx, [eax+0x4] */
            ii(0x1019_af9e, 3); mov(ebp, memd[ds, edx + 4]);            /* mov ebp, [edx+0x4] */
            ii(0x1019_afa1, 2); cmp(ecx, ebp);                          /* cmp ecx, ebp */
            ii(0x1019_afa3, 2); if(jl(0x1019_afad, 8)) goto l_0x1019_afad; /* jl 0x1019afad */
            ii(0x1019_afa5, 2); if(jnz(0x1019_afb2, 0xb)) goto l_0x1019_afb2; /* jnz 0x1019afb2 */
            ii(0x1019_afa7, 2); mov(eax, memd[ds, eax]);                /* mov eax, [eax] */
            ii(0x1019_afa9, 2); cmp(eax, memd[ds, edx]);                /* cmp eax, [edx] */
            ii(0x1019_afab, 2); if(jge(0x1019_afb2, 5)) goto l_0x1019_afb2; /* jge 0x1019afb2 */
        l_0x1019_afad:
            ii(0x1019_afad, 5); mov(ebx, 1);                            /* mov ebx, 0x1 */
        l_0x1019_afb2:
            ii(0x1019_afb2, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1019_afb4, 1); pop(ebp);                               /* pop ebp */
            ii(0x1019_afb5, 1); pop(esi);                               /* pop esi */
            ii(0x1019_afb6, 1); pop(ecx);                               /* pop ecx */
            ii(0x1019_afb7, 1); pop(ebx);                               /* pop ebx */
            ii(0x1019_afb8, 1); ret();                                  /* ret */
        }
    }
}
