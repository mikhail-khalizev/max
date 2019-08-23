using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1016_a2cc-7ab5a021")]
        public void /* sys */ Method_1016_a2cc()
        {
            ii(0x1016_a2cc, 1); pushd(ebx);                             /* push ebx */
            ii(0x1016_a2cd, 1); pushd(ecx);                             /* push ecx */
            ii(0x1016_a2ce, 1); pushd(esi);                             /* push esi */
            ii(0x1016_a2cf, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1016_a2d1, 2); mov(esi, edx);                          /* mov esi, edx */
            ii(0x1016_a2d3, 6); mov(edx, memd_a32[ds, 0x101b_dde8]);    /* mov edx, [0x101bdde8] */
            ii(0x1016_a2d9, 2); test(edx, edx);                         /* test edx, edx */
            ii(0x1016_a2db, 2); if(jled(0x1016_a315, 0x38)) goto l_0x1016_a315; /* jle 0x1016a315 */
            ii(0x1016_a2dd, 2); mov(ecx, edx);                          /* mov ecx, edx */
            ii(0x1016_a2df, 3); shl(edx, 0x2);                          /* shl edx, 0x2 */
            ii(0x1016_a2e2, 2); sub(edx, ecx);                          /* sub edx, ecx */
            ii(0x1016_a2e4, 3); shl(edx, 0x2);                          /* shl edx, 0x2 */
            ii(0x1016_a2e7, 2); sub(edx, ecx);                          /* sub edx, ecx */
            ii(0x1016_a2e9, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1016_a2eb, 3); shl(edx, 0x2);                          /* shl edx, 0x2 */
        l_0x1016_a2ee:
            ii(0x1016_a2ee, 6); cmp(ebx, memd_a32[ds, eax + 0x101c_f7ac]); /* cmp ebx, [eax+0x101cf7ac] */
            ii(0x1016_a2f4, 2); if(jld(0x1016_a30e, 0x18)) goto l_0x1016_a30e; /* jl 0x1016a30e */
            ii(0x1016_a2f6, 6); cmp(ebx, memd_a32[ds, eax + 0x101c_f7b0]); /* cmp ebx, [eax+0x101cf7b0] */
            ii(0x1016_a2fc, 2); if(jgd(0x1016_a30e, 0x10)) goto l_0x1016_a30e; /* jg 0x1016a30e */
            ii(0x1016_a2fe, 5); mov(edx, 0x101c_f7ac);                  /* mov edx, 0x101cf7ac */
            ii(0x1016_a303, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1016_a305, 2); mov(memd_a32[ds, esi], edx);            /* mov [esi], edx */
            ii(0x1016_a307, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x1016_a30c, 2); jmpd(0x1016_a317, 0x9); goto l_0x1016_a317; /* jmp 0x1016a317 */
        l_0x1016_a30e:
            ii(0x1016_a30e, 3); add(eax, 0x2c);                         /* add eax, 0x2c */
            ii(0x1016_a311, 2); cmp(eax, edx);                          /* cmp eax, edx */
            ii(0x1016_a313, 2); if(jld(0x1016_a2ee, -0x27)) goto l_0x1016_a2ee; /* jl 0x1016a2ee */
        l_0x1016_a315:
            ii(0x1016_a315, 2); xor(edx, edx);                          /* xor edx, edx */
        l_0x1016_a317:
            ii(0x1016_a317, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1016_a319, 1); popd(esi);                              /* pop esi */
            ii(0x1016_a31a, 1); popd(ecx);                              /* pop ecx */
            ii(0x1016_a31b, 1); popd(ebx);                              /* pop ebx */
            ii(0x1016_a31c, 1); retd();                                 /* ret */
        }
    }
}
