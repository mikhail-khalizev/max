using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1019_4dd7-656cea93")]
        public void /* sys */ Method_1019_4dd7()
        {
            ii(0x1019_4dd7, 1); push(ebp);                              /* push ebp */
            ii(0x1019_4dd8, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1019_4dda, 1); push(esi);                              /* push esi */
            ii(0x1019_4ddb, 1); push(edi);                              /* push edi */
            ii(0x1019_4ddc, 1); push(ebx);                              /* push ebx */
            ii(0x1019_4ddd, 1); push(ecx);                              /* push ecx */
            ii(0x1019_4dde, 2); push(fs);                               /* push fs */
            ii(0x1019_4de0, 2); push(gs);                               /* push gs */
            ii(0x1019_4de2, 1); push(es);                               /* push es */
            ii(0x1019_4de3, 3); mov(esi, memd[ss, ebp + 0x8]);          /* mov esi, [ebp+0x8] */
            ii(0x1019_4de6, 3); les(edi, ss, ebp + 0xc);                /* les edi, [ebp+0xc] */
            ii(0x1019_4de9, 5); mov(ecx, 0x20);                         /* mov ecx, 0x20 */
        l_0x1019_4dee:
            ii(0x1019_4dee, 2); mov(memd[ds, esi], edi);                /* mov [esi], edi */
            ii(0x1019_4df0, 4); mov(memw[ds, esi + 0x4], es);           /* mov [esi+0x4], es */
            ii(0x1019_4df4, 3); add(edi, 0x6c);                         /* add edi, 0x6c */
            ii(0x1019_4df7, 3); add(esi, 0x6);                          /* add esi, 0x6 */
            ii(0x1019_4dfa, 2); if(loop(0x1019_4dee, -0xe)) goto l_0x1019_4dee; /* loop 0x10194dee */
            ii(0x1019_4dfc, 1); pop(es);                                /* pop es */
            ii(0x1019_4dfd, 2); pop(gs);                                /* pop gs */
            ii(0x1019_4dff, 2); pop(fs);                                /* pop fs */
            ii(0x1019_4e01, 1); pop(ecx);                               /* pop ecx */
            ii(0x1019_4e02, 1); pop(ebx);                               /* pop ebx */
            ii(0x1019_4e03, 1); pop(edi);                               /* pop edi */
            ii(0x1019_4e04, 1); pop(esi);                               /* pop esi */
            ii(0x1019_4e05, 1); pop(ebp);                               /* pop ebp */
            ii(0x1019_4e06, 1); ret();                                  /* ret */
        }
    }
}
