using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("883389bb-3f3b-44cd-af39-a4b9446a9557")]
        public void /* sys */ Method_1016_9a78()
        {
            ii(0x1016_9a78, 1); pushd(ebx);                             /* push ebx */
            ii(0x1016_9a79, 1); pushd(ecx);                             /* push ecx */
            ii(0x1016_9a7a, 1); pushd(esi);                             /* push esi */
            ii(0x1016_9a7b, 2); mov(esi, edx);                          /* mov esi, edx */
            ii(0x1016_9a7d, 7); cmp(memd_a32[ds, 0x101b_ddbc], 0);      /* cmp dword [0x101bddbc], 0x0 */
            ii(0x1016_9a84, 2); if(jnzd(0x1016_9a8f, 0x9)) goto l_0x1016_9a8f; /* jnz 0x10169a8f */
            ii(0x1016_9a86, 5); mov(eax, 0xffff_ffff);                  /* mov eax, 0xffffffff */
            ii(0x1016_9a8b, 1); popd(esi);                              /* pop esi */
            ii(0x1016_9a8c, 1); popd(ecx);                              /* pop ecx */
            ii(0x1016_9a8d, 1); popd(ebx);                              /* pop ebx */
            ii(0x1016_9a8e, 1); retd(); return;                         /* ret */
        l_0x1016_9a8f:
            ii(0x1016_9a8f, 5); mov(ebx, 0x1);                          /* mov ebx, 0x1 */
            ii(0x1016_9a94, 2); mov(edx, esi);                          /* mov edx, esi */
            ii(0x1016_9a96, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x1016_9a98, 5); calld(/* sys */ 0x1016_99b8, -0xe5);    /* call 0x101699b8 */
            ii(0x1016_9a9d, 3); cmp(eax, -0x1 /* 0xff */);              /* cmp eax, 0xffffffff */
            ii(0x1016_9aa0, 2); if(jzd(0x1016_9ac9, 0x27)) goto l_0x1016_9ac9; /* jz 0x10169ac9 */
            ii(0x1016_9aa2, 2); mov(eax, memd_a32[ds, esi]);            /* mov eax, [esi] */
            ii(0x1016_9aa4, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1016_9aa6, 5); calld(/* sys */ 0x1016_7f00, -0x1bab);  /* call 0x10167f00 */
            ii(0x1016_9aab, 2); mov(ecx, eax);                          /* mov ecx, eax */
            ii(0x1016_9aad, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1016_9aaf, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1016_9ab1, 2); jmpd(0x1016_9abf, 0xc); goto l_0x1016_9abf; /* jmp 0x10169abf */
        l_0x1016_9ab3:
            ii(0x1016_9ab3, 4); mov(ebx, memd_a32[ds, ebx + eax + 0x10]); /* mov ebx, [ebx+eax+0x10] */
            ii(0x1016_9ab7, 3); add(eax, 0x4);                          /* add eax, 0x4 */
            ii(0x1016_9aba, 1); inc(edx);                               /* inc edx */
            ii(0x1016_9abb, 4); or(memb_a32[ds, ebx + 0x6], 0x4);       /* or byte [ebx+0x6], 0x4 */
        l_0x1016_9abf:
            ii(0x1016_9abf, 3); mov(ebx, memd_a32[ds, ecx + 0x68]);     /* mov ebx, [ecx+0x68] */
            ii(0x1016_9ac2, 3); cmp(edx, memd_a32[ds, ebx + 0xc]);      /* cmp edx, [ebx+0xc] */
            ii(0x1016_9ac5, 2); if(jld(0x1016_9ab3, -0x14)) goto l_0x1016_9ab3; /* jl 0x10169ab3 */
            ii(0x1016_9ac7, 2); xor(eax, eax);                          /* xor eax, eax */
        l_0x1016_9ac9:
            ii(0x1016_9ac9, 1); popd(esi);                              /* pop esi */
            ii(0x1016_9aca, 1); popd(ecx);                              /* pop ecx */
            ii(0x1016_9acb, 1); popd(ebx);                              /* pop ebx */
            ii(0x1016_9acc, 1); retd(); return;                         /* ret */
        }
    }
}
