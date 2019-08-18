using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("c3c0d400-f1f7-4407-8e99-e14b5352da51")]
        public void /* sys */ Method_1016_d5a0()
        {
            ii(0x1016_d5a0, 1); pushd(ebx);                             /* push ebx */
            ii(0x1016_d5a1, 1); pushd(ecx);                             /* push ecx */
            ii(0x1016_d5a2, 1); pushd(edx);                             /* push edx */
            ii(0x1016_d5a3, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x1016_d5a5, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
        l_0x1016_d5a7:
            ii(0x1016_d5a7, 7); cmp(memd_a32[ds, ebx + 0x101d_0020], 0); /* cmp dword [ebx+0x101d0020], 0x0 */
            ii(0x1016_d5ae, 2); if(jzd(0x1016_d5bf, 0xf)) goto l_0x1016_d5bf; /* jz 0x1016d5bf */
            ii(0x1016_d5b0, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1016_d5b2, 6); mov(eax, memd_a32[ds, ebx + 0x101d_0020]); /* mov eax, [ebx+0x101d0020] */
            ii(0x1016_d5b8, 2); mov(dl, cl);                            /* mov dl, cl */
            ii(0x1016_d5ba, 5); calld(/* sys */ 0x1016_d354, -0x26b);   /* call 0x1016d354 */
        l_0x1016_d5bf:
            ii(0x1016_d5bf, 1); inc(ecx);                               /* inc ecx */
            ii(0x1016_d5c0, 3); add(ebx, 0x4);                          /* add ebx, 0x4 */
            ii(0x1016_d5c3, 6); cmp(ecx, 0x100);                        /* cmp ecx, 0x100 */
            ii(0x1016_d5c9, 2); if(jld(0x1016_d5a7, -0x24)) goto l_0x1016_d5a7; /* jl 0x1016d5a7 */
            ii(0x1016_d5cb, 1); popd(edx);                              /* pop edx */
            ii(0x1016_d5cc, 1); popd(ecx);                              /* pop ecx */
            ii(0x1016_d5cd, 1); popd(ebx);                              /* pop ebx */
            ii(0x1016_d5ce, 1); retd(); return;                         /* ret */
        }
    }
}
