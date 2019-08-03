using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("4516c5cc-cb7d-4f1f-828f-c0c2df9e786a")]
        public void /* sys */ Method_1019_4f0e()
        {
            ii(0x1019_4f0e, 1); pushd(ebp);                             /* push ebp */
            ii(0x1019_4f0f, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1019_4f11, 1); pushd(esi);                             /* push esi */
            ii(0x1019_4f12, 1); pushd(edi);                             /* push edi */
            ii(0x1019_4f13, 1); pushd(ebx);                             /* push ebx */
            ii(0x1019_4f14, 1); pushd(ecx);                             /* push ecx */
            ii(0x1019_4f15, 2); pushd(fs);                              /* push fs */
            ii(0x1019_4f17, 2); pushd(gs);                              /* push gs */
            ii(0x1019_4f19, 1); pushd(es);                              /* push es */
            ii(0x1019_4f1a, 5); mov(eax, 0);                            /* mov eax, 0x0 */
            ii(0x1019_4f1f, 4); lfs(edi, ss, ebp + 0x10);               /* lfs edi, [ebp+0x10] */
            ii(0x1019_4f23, 3); calld_a32_far_ind(ss, ebp + 0x8);       /* call far dword [ebp+0x8] */
            ii(0x1019_4f26, 1); popd(es);                               /* pop es */
            ii(0x1019_4f27, 2); popd(gs);                               /* pop gs */
            ii(0x1019_4f29, 2); popd(fs);                               /* pop fs */
            ii(0x1019_4f2b, 1); popd(ecx);                              /* pop ecx */
            ii(0x1019_4f2c, 1); popd(ebx);                              /* pop ebx */
            ii(0x1019_4f2d, 1); popd(edi);                              /* pop edi */
            ii(0x1019_4f2e, 1); popd(esi);                              /* pop esi */
            ii(0x1019_4f2f, 1); popd(ebp);                              /* pop ebp */
            ii(0x1019_4f30, 1); retd(); return;                         /* ret */
        }
    }
}
