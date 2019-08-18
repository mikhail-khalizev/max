using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1016_c6c8-12caa6c0")]
        public void /* sys */ Method_1016_c6c8()
        {
            ii(0x1016_c6c8, 1); pushd(ebx);                             /* push ebx */
            ii(0x1016_c6c9, 1); pushd(ecx);                             /* push ecx */
            ii(0x1016_c6ca, 1); pushd(edx);                             /* push edx */
            ii(0x1016_c6cb, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1016_c6cd, 5); mov(edx, /* sys */ 0x1016_c68d);        /* mov edx, 0x1016c68d */
            ii(0x1016_c6d2, 6); mov(ecx, memd_a32[ds, 0x101c_fc94]);    /* mov ecx, [0x101cfc94] */
            ii(0x1016_c6d8, 6); mov(memd_a32[ds, 0x101b_de80], edx);    /* mov [0x101bde80], edx */
            ii(0x1016_c6de, 3); cmp(ecx, 0x20);                         /* cmp ecx, 0x20 */
            ii(0x1016_c6e1, 2); if(jged(0x1016_c6fb, 0x18)) goto l_0x1016_c6fb; /* jge 0x1016c6fb */
            ii(0x1016_c6e3, 2); mov(eax, ecx);                          /* mov eax, ecx */
            ii(0x1016_c6e5, 2); xor(eax, ecx);                          /* xor eax, ecx */
            ii(0x1016_c6e7, 3); lea(edx, ecx + 0x1);                    /* lea edx, [ecx+0x1] */
            ii(0x1016_c6ea, 7); mov(memd_a32[ds, ecx * 4 + 0x101c_fc14], ebx); /* mov [ecx*4+0x101cfc14], ebx */
            ii(0x1016_c6f1, 6); mov(memd_a32[ds, 0x101c_fc94], edx);    /* mov [0x101cfc94], edx */
            ii(0x1016_c6f7, 1); popd(edx);                              /* pop edx */
            ii(0x1016_c6f8, 1); popd(ecx);                              /* pop ecx */
            ii(0x1016_c6f9, 1); popd(ebx);                              /* pop ebx */
            ii(0x1016_c6fa, 1); retd(); return;                         /* ret */
        l_0x1016_c6fb:
            ii(0x1016_c6fb, 5); mov(eax, 0xffff_ffff);                  /* mov eax, 0xffffffff */
            ii(0x1016_c700, 1); popd(edx);                              /* pop edx */
            ii(0x1016_c701, 1); popd(ecx);                              /* pop ecx */
            ii(0x1016_c702, 1); popd(ebx);                              /* pop ebx */
            ii(0x1016_c703, 1); retd(); return;                         /* ret */
        }
    }
}
