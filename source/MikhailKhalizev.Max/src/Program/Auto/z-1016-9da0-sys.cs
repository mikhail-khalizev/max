using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1016_9da0-d5f2d12b")]
        public void /* sys */ Method_1016_9da0()
        {
            ii(0x1016_9da0, 1); pushd(ebx);                             /* push ebx */
            ii(0x1016_9da1, 1); pushd(ecx);                             /* push ecx */
            ii(0x1016_9da2, 1); pushd(esi);                             /* push esi */
            ii(0x1016_9da3, 1); pushd(edi);                             /* push edi */
            ii(0x1016_9da4, 1); pushd(ebp);                             /* push ebp */
            ii(0x1016_9da5, 2); mov(edi, eax);                          /* mov edi, eax */
            ii(0x1016_9da7, 2); mov(ebp, edx);                          /* mov ebp, edx */
            ii(0x1016_9da9, 3); mov(esi, memd_a32[ds, eax + 0x30]);     /* mov esi, [eax+0x30] */
            ii(0x1016_9dac, 2); test(esi, esi);                         /* test esi, esi */
            ii(0x1016_9dae, 2); if(jnzd(0x1016_9db9, 0x9)) goto l_0x1016_9db9; /* jnz 0x10169db9 */
            ii(0x1016_9db0, 2); jmpd(0x1016_9ddb, 0x29); goto l_0x1016_9ddb; /* jmp 0x10169ddb */
        l_0x1016_9db2:
            ii(0x1016_9db2, 3); mov(esi, memd_a32[ds, esi + 0x70]);     /* mov esi, [esi+0x70] */
            ii(0x1016_9db5, 2); test(esi, esi);                         /* test esi, esi */
            ii(0x1016_9db7, 2); if(jzd(0x1016_9ddb, 0x22)) goto l_0x1016_9ddb; /* jz 0x10169ddb */
        l_0x1016_9db9:
            ii(0x1016_9db9, 4); cmp(memd_a32[ds, esi + 0x70], 0);       /* cmp dword [esi+0x70], 0x0 */
            ii(0x1016_9dbd, 2); if(jnzd(0x1016_9db2, -0xd)) goto l_0x1016_9db2; /* jnz 0x10169db2 */
            ii(0x1016_9dbf, 2); test(esi, esi);                         /* test esi, esi */
            ii(0x1016_9dc1, 2); if(jnzd(0x1016_9dc9, 0x6)) goto l_0x1016_9dc9; /* jnz 0x10169dc9 */
            ii(0x1016_9dc3, 1); popd(ebp);                              /* pop ebp */
            ii(0x1016_9dc4, 1); popd(edi);                              /* pop edi */
            ii(0x1016_9dc5, 1); popd(esi);                              /* pop esi */
            ii(0x1016_9dc6, 1); popd(ecx);                              /* pop ecx */
            ii(0x1016_9dc7, 1); popd(ebx);                              /* pop ebx */
            ii(0x1016_9dc8, 1); retd(); return;                         /* ret */
        l_0x1016_9dc9:
            ii(0x1016_9dc9, 1); pushd(ebp);                             /* push ebp */
            ii(0x1016_9dca, 2); mov(edx, edi);                          /* mov edx, edi */
            ii(0x1016_9dcc, 2); mov(eax, esi);                          /* mov eax, esi */
            ii(0x1016_9dce, 3); mov(ebx, memd_a32[ds, esi + 0x48]);     /* mov ebx, [esi+0x48] */
            ii(0x1016_9dd1, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x1016_9dd3, 5); calld(/* sys */ 0x1016_9b90, -0x248);   /* call 0x10169b90 */
            ii(0x1016_9dd8, 3); mov(esi, memd_a32[ds, esi + 0x6c]);     /* mov esi, [esi+0x6c] */
        l_0x1016_9ddb:
            ii(0x1016_9ddb, 2); test(esi, esi);                         /* test esi, esi */
            ii(0x1016_9ddd, 2); if(jnzd(0x1016_9dc9, -0x16)) goto l_0x1016_9dc9; /* jnz 0x10169dc9 */
            ii(0x1016_9ddf, 1); popd(ebp);                              /* pop ebp */
            ii(0x1016_9de0, 1); popd(edi);                              /* pop edi */
            ii(0x1016_9de1, 1); popd(esi);                              /* pop esi */
            ii(0x1016_9de2, 1); popd(ecx);                              /* pop ecx */
            ii(0x1016_9de3, 1); popd(ebx);                              /* pop ebx */
            ii(0x1016_9de4, 1); retd();                                 /* ret */
        }
    }
}
