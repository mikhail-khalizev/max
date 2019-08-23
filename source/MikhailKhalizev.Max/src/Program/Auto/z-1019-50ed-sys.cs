using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1019_50ed-c448813f")]
        public void /* sys */ Method_1019_50ed()
        {
            ii(0x1019_50ed, 1); push(ebp);                              /* push ebp */
            ii(0x1019_50ee, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1019_50f0, 1); push(esi);                              /* push esi */
            ii(0x1019_50f1, 1); push(edi);                              /* push edi */
            ii(0x1019_50f2, 1); push(ebx);                              /* push ebx */
            ii(0x1019_50f3, 1); push(ecx);                              /* push ecx */
            ii(0x1019_50f4, 2); push(fs);                               /* push fs */
            ii(0x1019_50f6, 2); push(gs);                               /* push gs */
            ii(0x1019_50f8, 1); push(es);                               /* push es */
            ii(0x1019_50f9, 4); lfs(edi, ss, ebp + 0x10);               /* lfs edi, [ebp+0x10] */
            ii(0x1019_50fd, 5); mov(eax, 0x3);                          /* mov eax, 0x3 */
            ii(0x1019_5102, 4); mov(bx, 0x8);                           /* mov bx, 0x8 */
            ii(0x1019_5106, 3); call_far_ind(ss, ebp + 0x8);            /* call far dword [ebp+0x8] */
            ii(0x1019_5109, 1); pop(es);                                /* pop es */
            ii(0x1019_510a, 2); pop(gs);                                /* pop gs */
            ii(0x1019_510c, 2); pop(fs);                                /* pop fs */
            ii(0x1019_510e, 1); pop(ecx);                               /* pop ecx */
            ii(0x1019_510f, 1); pop(ebx);                               /* pop ebx */
            ii(0x1019_5110, 1); pop(edi);                               /* pop edi */
            ii(0x1019_5111, 1); pop(esi);                               /* pop esi */
            ii(0x1019_5112, 1); pop(ebp);                               /* pop ebp */
            ii(0x1019_5113, 1); ret();                                  /* ret */
        }
    }
}
