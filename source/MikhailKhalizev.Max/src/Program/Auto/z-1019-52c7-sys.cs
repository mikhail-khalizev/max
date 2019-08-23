using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1019_52c7-83f1e967")]
        public void /* sys */ Method_1019_52c7()
        {
            ii(0x1019_52c7, 1); push(ebp);                              /* push ebp */
            ii(0x1019_52c8, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1019_52ca, 1); push(esi);                              /* push esi */
            ii(0x1019_52cb, 1); push(edi);                              /* push edi */
            ii(0x1019_52cc, 1); push(ebx);                              /* push ebx */
            ii(0x1019_52cd, 1); push(ecx);                              /* push ecx */
            ii(0x1019_52ce, 2); push(fs);                               /* push fs */
            ii(0x1019_52d0, 2); push(gs);                               /* push gs */
            ii(0x1019_52d2, 1); push(es);                               /* push es */
            ii(0x1019_52d3, 4); mov(ax, 0x1600);                        /* mov ax, 0x1600 */
            ii(0x1019_52d7, 2); @int(0x2f);                             /* int 0x2f */
            ii(0x1019_52d9, 1); pop(es);                                /* pop es */
            ii(0x1019_52da, 2); pop(gs);                                /* pop gs */
            ii(0x1019_52dc, 2); pop(fs);                                /* pop fs */
            ii(0x1019_52de, 1); pop(ecx);                               /* pop ecx */
            ii(0x1019_52df, 1); pop(ebx);                               /* pop ebx */
            ii(0x1019_52e0, 1); pop(edi);                               /* pop edi */
            ii(0x1019_52e1, 1); pop(esi);                               /* pop esi */
            ii(0x1019_52e2, 1); pop(ebp);                               /* pop ebp */
            ii(0x1019_52e3, 1); ret();                                  /* ret */
        }
    }
}
