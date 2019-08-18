using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("6a5d8f4b-bcc4-4c86-a59f-21a7898801e8")]
        public void /* sys */ Method_1016_e234()
        {
            ii(0x1016_e234, 1); pushd(ebx);                             /* push ebx */
            ii(0x1016_e235, 1); pushd(ecx);                             /* push ecx */
            ii(0x1016_e236, 1); pushd(edx);                             /* push edx */
            ii(0x1016_e237, 1); pushd(esi);                             /* push esi */
            ii(0x1016_e238, 2); xor(edx, edx);                          /* xor edx, edx */
        l_0x1016_e23a:
            ii(0x1016_e23a, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1016_e23c, 2); mov(al, dl);                            /* mov al, dl */
            ii(0x1016_e23e, 1); inc(edx);                               /* inc edx */
            ii(0x1016_e23f, 5); calld(/* sys */ 0x1016_d630, -0xc14);   /* call 0x1016d630 */
            ii(0x1016_e244, 6); cmp(edx, 0x100);                        /* cmp edx, 0x100 */
            ii(0x1016_e24a, 2); if(jld(0x1016_e23a, -0x12)) goto l_0x1016_e23a; /* jl 0x1016e23a */
            ii(0x1016_e24c, 6); mov(ebx, memd_a32[ds, 0x1020_8520]);    /* mov ebx, [0x10208520] */
            ii(0x1016_e252, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1016_e254, 2); test(ebx, ebx);                         /* test ebx, ebx */
            ii(0x1016_e256, 2); if(jled(0x1016_e273, 0x1b)) goto l_0x1016_e273; /* jle 0x1016e273 */
            ii(0x1016_e258, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
        l_0x1016_e25a:
            ii(0x1016_e25a, 6); mov(eax, memd_a32[ds, ebx + 0x101c_fca0]); /* mov eax, [ebx+0x101cfca0] */
            ii(0x1016_e260, 5); calld(Definitions.sys_free, -0x31a4);   /* call 0x1016b0c1 */
            ii(0x1016_e265, 1); inc(edx);                               /* inc edx */
            ii(0x1016_e266, 6); mov(ecx, memd_a32[ds, 0x1020_8520]);    /* mov ecx, [0x10208520] */
            ii(0x1016_e26c, 3); add(ebx, 0x4);                          /* add ebx, 0x4 */
            ii(0x1016_e26f, 2); cmp(edx, ecx);                          /* cmp edx, ecx */
            ii(0x1016_e271, 2); if(jld(0x1016_e25a, -0x19)) goto l_0x1016_e25a; /* jl 0x1016e25a */
        l_0x1016_e273:
            ii(0x1016_e273, 2); xor(esi, esi);                          /* xor esi, esi */
            ii(0x1016_e275, 6); mov(memd_a32[ds, 0x1020_8520], esi);    /* mov [0x10208520], esi */
            ii(0x1016_e27b, 1); popd(esi);                              /* pop esi */
            ii(0x1016_e27c, 1); popd(edx);                              /* pop edx */
            ii(0x1016_e27d, 1); popd(ecx);                              /* pop ecx */
            ii(0x1016_e27e, 1); popd(ebx);                              /* pop ebx */
            ii(0x1016_e27f, 1); retd(); return;                         /* ret */
        }
    }
}
