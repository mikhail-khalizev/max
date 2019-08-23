using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1019_50c7-87671f45")]
        public void /* sys */ Method_1019_50c7()
        {
            ii(0x1019_50c7, 1); push(ebp);                              /* push ebp */
            ii(0x1019_50c8, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1019_50ca, 1); push(esi);                              /* push esi */
            ii(0x1019_50cb, 1); push(edi);                              /* push edi */
            ii(0x1019_50cc, 1); push(ebx);                              /* push ebx */
            ii(0x1019_50cd, 1); push(ecx);                              /* push ecx */
            ii(0x1019_50ce, 2); pushd(fs);                              /* push fs */
            ii(0x1019_50d0, 2); pushd(gs);                              /* push gs */
            ii(0x1019_50d2, 1); pushd(es);                              /* push es */
            ii(0x1019_50d3, 4); lfs(edi, memd[ss, ebp + 0x10]);         /* lfs edi, [ebp+0x10] */
            ii(0x1019_50d7, 5); mov(eax, 0x2);                          /* mov eax, 0x2 */
            ii(0x1019_50dc, 3); mov(ebx, memd[ss, ebp + 0x18]);         /* mov ebx, [ebp+0x18] */
            ii(0x1019_50df, 3); call_far_ind(memd[ss, ebp + 0x8]);      /* call far dword [ebp+0x8] */
            ii(0x1019_50e2, 1); popd(es);                               /* pop es */
            ii(0x1019_50e3, 2); popd(gs);                               /* pop gs */
            ii(0x1019_50e5, 2); popd(fs);                               /* pop fs */
            ii(0x1019_50e7, 1); pop(ecx);                               /* pop ecx */
            ii(0x1019_50e8, 1); pop(ebx);                               /* pop ebx */
            ii(0x1019_50e9, 1); pop(edi);                               /* pop edi */
            ii(0x1019_50ea, 1); pop(esi);                               /* pop esi */
            ii(0x1019_50eb, 1); pop(ebp);                               /* pop ebp */
            ii(0x1019_50ec, 1); ret();                                  /* ret */
        }
    }
}
