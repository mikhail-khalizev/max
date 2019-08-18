using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("ce319f74-f93b-4e80-be73-87bb9d8a6d18")]
        public void /* sys */ Method_1016_ce8c()
        {
            ii(0x1016_ce8c, 1); pushd(ebx);                             /* push ebx */
            ii(0x1016_ce8d, 1); pushd(ecx);                             /* push ecx */
            ii(0x1016_ce8e, 1); pushd(edx);                             /* push edx */
            ii(0x1016_ce8f, 1); pushd(esi);                             /* push esi */
            ii(0x1016_ce90, 1); pushd(edi);                             /* push edi */
            ii(0x1016_ce91, 5); mov(esi, 0x101e_0520);                  /* mov esi, 0x101e0520 */
            ii(0x1016_ce96, 5); mov(edi, 0x100);                        /* mov edi, 0x100 */
            ii(0x1016_ce9b, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
        l_0x1016_ce9d:
            ii(0x1016_ce9d, 7); cmp(memb_a32[ds, ecx + 0x101d_0420], 0); /* cmp byte [ecx+0x101d0420], 0x0 */
            ii(0x1016_cea4, 2); if(jzd(0x1016_ceaf, 0x9)) goto l_0x1016_ceaf; /* jz 0x1016ceaf */
            ii(0x1016_cea6, 2); mov(eax, ecx);                          /* mov eax, ecx */
            ii(0x1016_cea8, 5); calld(/* sys */ 0x1016_cd84, -0x129);   /* call 0x1016cd84 */
            ii(0x1016_cead, 2); jmpd(0x1016_ceba, 0xb); goto l_0x1016_ceba; /* jmp 0x1016ceba */
        l_0x1016_ceaf:
            ii(0x1016_ceaf, 2); mov(ebx, edi);                          /* mov ebx, edi */
            ii(0x1016_ceb1, 2); mov(eax, esi);                          /* mov eax, esi */
            ii(0x1016_ceb3, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1016_ceb5, 5); calld(Definitions.sys_memset, -0x70da); /* call 0x10165de0 */
        l_0x1016_ceba:
            ii(0x1016_ceba, 1); inc(ecx);                               /* inc ecx */
            ii(0x1016_cebb, 6); add(esi, 0x100);                        /* add esi, 0x100 */
            ii(0x1016_cec1, 6); cmp(ecx, 0x100);                        /* cmp ecx, 0x100 */
            ii(0x1016_cec7, 2); if(jld(0x1016_ce9d, -0x2c)) goto l_0x1016_ce9d; /* jl 0x1016ce9d */
            ii(0x1016_cec9, 1); popd(edi);                              /* pop edi */
            ii(0x1016_ceca, 1); popd(esi);                              /* pop esi */
            ii(0x1016_cecb, 1); popd(edx);                              /* pop edx */
            ii(0x1016_cecc, 1); popd(ecx);                              /* pop ecx */
            ii(0x1016_cecd, 1); popd(ebx);                              /* pop ebx */
            ii(0x1016_cece, 1); retd(); return;                         /* ret */
        }
    }
}
