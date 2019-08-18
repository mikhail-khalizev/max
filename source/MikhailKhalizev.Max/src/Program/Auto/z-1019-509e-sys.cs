using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("5ecbc97b-4b0e-446d-b313-adb8041927b3")]
        public void /* sys */ Method_1019_509e()
        {
            ii(0x1019_509e, 1); pushd(ebp);                             /* push ebp */
            ii(0x1019_509f, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1019_50a1, 1); pushd(esi);                             /* push esi */
            ii(0x1019_50a2, 1); pushd(edi);                             /* push edi */
            ii(0x1019_50a3, 1); pushd(ebx);                             /* push ebx */
            ii(0x1019_50a4, 1); pushd(ecx);                             /* push ecx */
            ii(0x1019_50a5, 2); pushd(fs);                              /* push fs */
            ii(0x1019_50a7, 2); pushd(gs);                              /* push gs */
            ii(0x1019_50a9, 1); pushd(es);                              /* push es */
            ii(0x1019_50aa, 4); lfs(edi, ss, ebp + 0x10);               /* lfs edi, [ebp+0x10] */
            ii(0x1019_50ae, 5); mov(eax, 0x4);                          /* mov eax, 0x4 */
            ii(0x1019_50b3, 3); mov(ecx, memd_a32[ss, ebp + 0x1c]);     /* mov ecx, [ebp+0x1c] */
            ii(0x1019_50b6, 3); mov(edi, memd_a32[ss, ebp + 0x18]);     /* mov edi, [ebp+0x18] */
            ii(0x1019_50b9, 3); calld_a32_far_ind(ss, ebp + 0x8);       /* call far dword [ebp+0x8] */
            ii(0x1019_50bc, 1); popd(es);                               /* pop es */
            ii(0x1019_50bd, 2); popd(gs);                               /* pop gs */
            ii(0x1019_50bf, 2); popd(fs);                               /* pop fs */
            ii(0x1019_50c1, 1); popd(ecx);                              /* pop ecx */
            ii(0x1019_50c2, 1); popd(ebx);                              /* pop ebx */
            ii(0x1019_50c3, 1); popd(edi);                              /* pop edi */
            ii(0x1019_50c4, 1); popd(esi);                              /* pop esi */
            ii(0x1019_50c5, 1); popd(ebp);                              /* pop ebp */
            ii(0x1019_50c6, 1); retd(); return;                         /* ret */
        }
    }
}
