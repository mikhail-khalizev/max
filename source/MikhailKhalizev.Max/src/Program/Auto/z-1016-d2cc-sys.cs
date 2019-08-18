using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1016_d2cc-aaa0471b")]
        public void /* sys */ Method_1016_d2cc()
        {
            ii(0x1016_d2cc, 1); pushd(ebx);                             /* push ebx */
            ii(0x1016_d2cd, 1); pushd(ecx);                             /* push ecx */
            ii(0x1016_d2ce, 1); pushd(edx);                             /* push edx */
            ii(0x1016_d2cf, 1); pushd(esi);                             /* push esi */
            ii(0x1016_d2d0, 1); pushd(edi);                             /* push edi */
            ii(0x1016_d2d1, 5); mov(ecx, 0x300);                        /* mov ecx, 0x300 */
            ii(0x1016_d2d6, 5); mov(edi, 0x101b_dec0);                  /* mov edi, 0x101bdec0 */
            ii(0x1016_d2db, 5); mov(ebx, 0x100);                        /* mov ebx, 0x100 */
            ii(0x1016_d2e0, 2); mov(esi, eax);                          /* mov esi, eax */
            ii(0x1016_d2e2, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x1016_d2e7, 1); pushd(edi);                             /* push edi */
            ii(0x1016_d2e8, 2); mov(eax, ecx);                          /* mov eax, ecx */
            ii(0x1016_d2ea, 3); shr(ecx, 0x2);                          /* shr ecx, 0x2 */
            ii(0x1016_d2ed, 2); repne_a32(() => movsd_a32());           /* repne movsd */
            ii(0x1016_d2ef, 2); mov(cl, al);                            /* mov cl, al */
            ii(0x1016_d2f1, 3); and(cl, 0x3);                           /* and cl, 0x3 */
            ii(0x1016_d2f4, 2); repne_a32(() => movsb_a32());           /* repne movsb */
            ii(0x1016_d2f6, 1); popd(edi);                              /* pop edi */
            ii(0x1016_d2f7, 5); mov(eax, 0x101d_0420);                  /* mov eax, 0x101d0420 */
            ii(0x1016_d2fc, 5); calld(Definitions.sys_memset, -0x7521); /* call 0x10165de0 */
            ii(0x1016_d301, 1); popd(edi);                              /* pop edi */
            ii(0x1016_d302, 1); popd(esi);                              /* pop esi */
            ii(0x1016_d303, 1); popd(edx);                              /* pop edx */
            ii(0x1016_d304, 1); popd(ecx);                              /* pop ecx */
            ii(0x1016_d305, 1); popd(ebx);                              /* pop ebx */
            ii(0x1016_d306, 1); retd(); return;                         /* ret */
        }
    }
}
