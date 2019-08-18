using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0f15cdaf-1f94-4f82-b9b5-c25813f3d3d7")]
        public void /* sys */ Method_1019_50c7()
        {
            ii(0x1019_50c7, 1); pushd(ebp);                             /* push ebp */
            ii(0x1019_50c8, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1019_50ca, 1); pushd(esi);                             /* push esi */
            ii(0x1019_50cb, 1); pushd(edi);                             /* push edi */
            ii(0x1019_50cc, 1); pushd(ebx);                             /* push ebx */
            ii(0x1019_50cd, 1); pushd(ecx);                             /* push ecx */
            ii(0x1019_50ce, 2); pushd(fs);                              /* push fs */
            ii(0x1019_50d0, 2); pushd(gs);                              /* push gs */
            ii(0x1019_50d2, 1); pushd(es);                              /* push es */
            ii(0x1019_50d3, 4); lfs(edi, ss, ebp + 0x10);               /* lfs edi, [ebp+0x10] */
            ii(0x1019_50d7, 5); mov(eax, 0x2);                          /* mov eax, 0x2 */
            ii(0x1019_50dc, 3); mov(ebx, memd_a32[ss, ebp + 0x18]);     /* mov ebx, [ebp+0x18] */
            ii(0x1019_50df, 3); calld_a32_far_ind(ss, ebp + 0x8);       /* call far dword [ebp+0x8] */
            ii(0x1019_50e2, 1); popd(es);                               /* pop es */
            ii(0x1019_50e3, 2); popd(gs);                               /* pop gs */
            ii(0x1019_50e5, 2); popd(fs);                               /* pop fs */
            ii(0x1019_50e7, 1); popd(ecx);                              /* pop ecx */
            ii(0x1019_50e8, 1); popd(ebx);                              /* pop ebx */
            ii(0x1019_50e9, 1); popd(edi);                              /* pop edi */
            ii(0x1019_50ea, 1); popd(esi);                              /* pop esi */
            ii(0x1019_50eb, 1); popd(ebp);                              /* pop ebp */
            ii(0x1019_50ec, 1); retd(); return;                         /* ret */
        }
    }
}
