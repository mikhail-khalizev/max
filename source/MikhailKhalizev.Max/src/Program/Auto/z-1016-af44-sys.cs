using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1016_af44-d224331")]
        public void /* sys */ Method_1016_af44()
        {
            ii(0x1016_af44, 1); pushd(esi);                             /* push esi */
            ii(0x1016_af45, 1); pushd(edi);                             /* push edi */
            ii(0x1016_af46, 3); sub(esp, 0x4);                          /* sub esp, 0x4 */
            ii(0x1016_af49, 2); mov(esi, edx);                          /* mov esi, edx */
            ii(0x1016_af4b, 2); mov(edi, ebx);                          /* mov edi, ebx */
            ii(0x1016_af4d, 2); mov(edx, ecx);                          /* mov edx, ecx */
            ii(0x1016_af4f, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x1016_af51, 2); test(ebx, ebx);                         /* test ebx, ebx */
            ii(0x1016_af53, 2); if(jled(0x1016_af84, 0x2f)) goto l_0x1016_af84; /* jle 0x1016af84 */
            ii(0x1016_af55, 2); sub(edx, esi);                          /* sub edx, esi */
            ii(0x1016_af57, 3); mov(memd_a32[ss, esp], edx);            /* mov [esp], edx */
        l_0x1016_af5a:
            ii(0x1016_af5a, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1016_af5c, 2); test(esi, esi);                         /* test esi, esi */
            ii(0x1016_af5e, 2); if(jled(0x1016_af7a, 0x1a)) goto l_0x1016_af7a; /* jle 0x1016af7a */
        l_0x1016_af60:
            ii(0x1016_af60, 2); mov(dl, memb_a32[ds, eax]);             /* mov dl, [eax] */
            ii(0x1016_af62, 6); and(edx, 0xff);                         /* and edx, 0xff */
            ii(0x1016_af68, 3); shl(edx, 0x8);                          /* shl edx, 0x8 */
            ii(0x1016_af6b, 1); inc(eax);                               /* inc eax */
            ii(0x1016_af6c, 6); mov(dl, memb_a32[ds, edx + 0x101e_05b3]); /* mov dl, [edx+0x101e05b3] */
            ii(0x1016_af72, 1); inc(ebx);                               /* inc ebx */
            ii(0x1016_af73, 3); mov(memb_a32[ds, eax - 0x1], dl);       /* mov [eax-0x1], dl */
            ii(0x1016_af76, 2); cmp(ebx, esi);                          /* cmp ebx, esi */
            ii(0x1016_af78, 2); if(jld(0x1016_af60, -0x1a)) goto l_0x1016_af60; /* jl 0x1016af60 */
        l_0x1016_af7a:
            ii(0x1016_af7a, 3); mov(edx, memd_a32[ss, esp]);            /* mov edx, [esp] */
            ii(0x1016_af7d, 1); inc(ecx);                               /* inc ecx */
            ii(0x1016_af7e, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1016_af80, 2); cmp(ecx, edi);                          /* cmp ecx, edi */
            ii(0x1016_af82, 2); if(jld(0x1016_af5a, -0x2a)) goto l_0x1016_af5a; /* jl 0x1016af5a */
        l_0x1016_af84:
            ii(0x1016_af84, 3); add(esp, 0x4);                          /* add esp, 0x4 */
            ii(0x1016_af87, 1); popd(edi);                              /* pop edi */
            ii(0x1016_af88, 1); popd(esi);                              /* pop esi */
            ii(0x1016_af89, 1); retd(); return;                         /* ret */
        }
    }
}
