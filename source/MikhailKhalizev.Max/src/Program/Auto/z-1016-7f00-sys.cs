using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("52502152-f27e-4b2a-a701-9e9985c428ed")]
        public void /* sys */ Method_1016_7f00()
        {
            ii(0x1016_7f00, 1); pushd(ebx);                             /* push ebx */
            ii(0x1016_7f01, 1); pushd(ecx);                             /* push ecx */
            ii(0x1016_7f02, 1); pushd(esi);                             /* push esi */
            ii(0x1016_7f03, 1); pushd(edi);                             /* push edi */
            ii(0x1016_7f04, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1016_7f06, 2); mov(edi, edx);                          /* mov edi, edx */
            ii(0x1016_7f08, 6); mov(edx, memd_a32[ds, 0x101c_b2d8]);    /* mov edx, [0x101cb2d8] */
            ii(0x1016_7f0e, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x1016_7f10, 2); test(edx, edx);                         /* test edx, edx */
            ii(0x1016_7f12, 2); if(jled(0x1016_7f51, 0x3d)) goto l_0x1016_7f51; /* jle 0x10167f51 */
            ii(0x1016_7f14, 6); mov(esi, memd_a32[ds, 0x101c_b2d8]);    /* mov esi, [0x101cb2d8] */
            ii(0x1016_7f1a, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1016_7f1c, 3); shl(esi, 0x2);                          /* shl esi, 0x2 */
        l_0x1016_7f1f:
            ii(0x1016_7f1f, 6); mov(eax, memd_a32[ds, edx + 0x101c_b1fc]); /* mov eax, [edx+0x101cb1fc] */
            ii(0x1016_7f25, 3); mov(eax, memd_a32[ds, eax + 0x30]);     /* mov eax, [eax+0x30] */
            ii(0x1016_7f28, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1016_7f2a, 2); if(jzd(0x1016_7f49, 0x1d)) goto l_0x1016_7f49; /* jz 0x10167f49 */
        l_0x1016_7f2c:
            ii(0x1016_7f2c, 2); cmp(ebx, memd_a32[ds, eax]);            /* cmp ebx, [eax] */
            ii(0x1016_7f2e, 2); if(jnzd(0x1016_7f42, 0x12)) goto l_0x1016_7f42; /* jnz 0x10167f42 */
            ii(0x1016_7f30, 2); test(edi, edi);                         /* test edi, edi */
            ii(0x1016_7f32, 2); if(jzd(0x1016_7f53, 0x1f)) goto l_0x1016_7f53; /* jz 0x10167f53 */
            ii(0x1016_7f34, 7); mov(edx, memd_a32[ds, ecx * 4 + 0x101c_b1fc]); /* mov edx, [ecx*4+0x101cb1fc] */
            ii(0x1016_7f3b, 2); mov(memd_a32[ds, edi], edx);            /* mov [edi], edx */
            ii(0x1016_7f3d, 1); popd(edi);                              /* pop edi */
            ii(0x1016_7f3e, 1); popd(esi);                              /* pop esi */
            ii(0x1016_7f3f, 1); popd(ecx);                              /* pop ecx */
            ii(0x1016_7f40, 1); popd(ebx);                              /* pop ebx */
            ii(0x1016_7f41, 1); retd(); return;                         /* ret */
        l_0x1016_7f42:
            ii(0x1016_7f42, 3); mov(eax, memd_a32[ds, eax + 0x70]);     /* mov eax, [eax+0x70] */
            ii(0x1016_7f45, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1016_7f47, 2); if(jnzd(0x1016_7f2c, -0x1d)) goto l_0x1016_7f2c; /* jnz 0x10167f2c */
        l_0x1016_7f49:
            ii(0x1016_7f49, 3); add(edx, 0x4);                          /* add edx, 0x4 */
            ii(0x1016_7f4c, 1); inc(ecx);                               /* inc ecx */
            ii(0x1016_7f4d, 2); cmp(edx, esi);                          /* cmp edx, esi */
            ii(0x1016_7f4f, 2); if(jld(0x1016_7f1f, -0x32)) goto l_0x1016_7f1f; /* jl 0x10167f1f */
        l_0x1016_7f51:
            ii(0x1016_7f51, 2); xor(eax, eax);                          /* xor eax, eax */
        l_0x1016_7f53:
            ii(0x1016_7f53, 1); popd(edi);                              /* pop edi */
            ii(0x1016_7f54, 1); popd(esi);                              /* pop esi */
            ii(0x1016_7f55, 1); popd(ecx);                              /* pop ecx */
            ii(0x1016_7f56, 1); popd(ebx);                              /* pop ebx */
            ii(0x1016_7f57, 1); retd(); return;                         /* ret */
        }
    }
}
