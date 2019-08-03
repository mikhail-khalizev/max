using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("96957bde-2239-4009-8ce3-0971d89845e8")]
        public void /* sys */ Method_1016_b96c()
        {
            ii(0x1016_b96c, 1); pushd(ebx);                             /* push ebx */
            ii(0x1016_b96d, 1); pushd(ecx);                             /* push ecx */
            ii(0x1016_b96e, 1); pushd(edx);                             /* push edx */
            ii(0x1016_b96f, 1); pushd(esi);                             /* push esi */
            ii(0x1016_b970, 6); mov(edx, memd_a32[ds, 0x101b_de60]);    /* mov edx, [0x101bde60] */
            ii(0x1016_b976, 2); test(edx, edx);                         /* test edx, edx */
            ii(0x1016_b978, 2); if(jzd(0x1016_b981, 0x7)) goto l_0x1016_b981; /* jz 0x1016b981 */
            ii(0x1016_b97a, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1016_b97c, 5); calld(Definitions.sys_free_internal, 0x16ad3); /* call 0x10182454 */
        l_0x1016_b981:
            ii(0x1016_b981, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1016_b983, 6); mov(ecx, memd_a32[ds, 0x101b_de68]);    /* mov ecx, [0x101bde68] */
            ii(0x1016_b989, 6); mov(memd_a32[ds, 0x101b_de60], ebx);    /* mov [0x101bde60], ebx */
            ii(0x1016_b98f, 2); test(ecx, ecx);                         /* test ecx, ecx */
            ii(0x1016_b991, 2); if(jzd(0x1016_b99d, 0xa)) goto l_0x1016_b99d; /* jz 0x1016b99d */
            ii(0x1016_b993, 5); mov(eax, /* sys */ 0x1016_bc4c);        /* mov eax, 0x1016bc4c */
            ii(0x1016_b998, 5); calld(/* sys */ 0x1016_b42c, -0x571);   /* call 0x1016b42c */
        l_0x1016_b99d:
            ii(0x1016_b99d, 2); xor(esi, esi);                          /* xor esi, esi */
            ii(0x1016_b99f, 6); mov(memd_a32[ds, 0x101b_de68], esi);    /* mov [0x101bde68], esi */
            ii(0x1016_b9a5, 1); popd(esi);                              /* pop esi */
            ii(0x1016_b9a6, 1); popd(edx);                              /* pop edx */
            ii(0x1016_b9a7, 1); popd(ecx);                              /* pop ecx */
            ii(0x1016_b9a8, 1); popd(ebx);                              /* pop ebx */
            ii(0x1016_b9a9, 1); retd(); return;                         /* ret */
        }
    }
}
