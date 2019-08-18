using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("fd3d14a1-ab13-48bc-ae3d-de6d21ab0948")]
        public void /* sys */ Method_1019_4ff3()
        {
            ii(0x1019_4ff3, 1); pushd(ebp);                             /* push ebp */
            ii(0x1019_4ff4, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1019_4ff6, 1); pushd(esi);                             /* push esi */
            ii(0x1019_4ff7, 1); pushd(edi);                             /* push edi */
            ii(0x1019_4ff8, 1); pushd(ebx);                             /* push ebx */
            ii(0x1019_4ff9, 1); pushd(ecx);                             /* push ecx */
            ii(0x1019_4ffa, 2); pushd(fs);                              /* push fs */
            ii(0x1019_4ffc, 2); pushd(gs);                              /* push gs */
            ii(0x1019_4ffe, 1); pushd(es);                              /* push es */
            ii(0x1019_4fff, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x1019_5004, 4); lfs(edi, ss, ebp + 0x10);               /* lfs edi, [ebp+0x10] */
            ii(0x1019_5008, 3); calld_a32_far_ind(ss, ebp + 0x8);       /* call far dword [ebp+0x8] */
            ii(0x1019_500b, 1); popd(es);                               /* pop es */
            ii(0x1019_500c, 2); popd(gs);                               /* pop gs */
            ii(0x1019_500e, 2); popd(fs);                               /* pop fs */
            ii(0x1019_5010, 1); popd(ecx);                              /* pop ecx */
            ii(0x1019_5011, 1); popd(ebx);                              /* pop ebx */
            ii(0x1019_5012, 1); popd(edi);                              /* pop edi */
            ii(0x1019_5013, 1); popd(esi);                              /* pop esi */
            ii(0x1019_5014, 1); popd(ebp);                              /* pop ebp */
            ii(0x1019_5015, 1); retd(); return;                         /* ret */
        }
    }
}
