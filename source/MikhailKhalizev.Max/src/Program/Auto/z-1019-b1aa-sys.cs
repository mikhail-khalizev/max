using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1019_b1aa-8f9481e3")]
        public void /* sys */ Method_1019_b1aa()
        {
            ii(0x1019_b1aa, 1); push(ebx);                              /* push ebx */
            ii(0x1019_b1ab, 1); push(ecx);                              /* push ecx */
            ii(0x1019_b1ac, 2); mov(ecx, edx);                          /* mov ecx, edx */
            ii(0x1019_b1ae, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
        l_0x1019_b1b0:
            ii(0x1019_b1b0, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1019_b1b2, 2); mov(dl, memb[ds, eax]);                 /* mov dl, [eax] */
            ii(0x1019_b1b4, 3); cmp(edx, 0x30);                         /* cmp edx, 0x30 */
            ii(0x1019_b1b7, 2); if(jl(0x1019_b1c9, 0x10)) goto l_0x1019_b1c9; /* jl 0x1019b1c9 */
            ii(0x1019_b1b9, 3); cmp(edx, 0x39);                         /* cmp edx, 0x39 */
            ii(0x1019_b1bc, 2); if(jg(0x1019_b1c9, 0xb)) goto l_0x1019_b1c9; /* jg 0x1019b1c9 */
            ii(0x1019_b1be, 3); imul(ebx, ebx, 0xa);                    /* imul ebx, ebx, 0xa */
            ii(0x1019_b1c1, 2); add(edx, ebx);                          /* add edx, ebx */
            ii(0x1019_b1c3, 1); inc(eax);                               /* inc eax */
            ii(0x1019_b1c4, 3); lea(ebx, memd[ds, edx - 0x30]);         /* lea ebx, [edx-0x30] */
            ii(0x1019_b1c7, 2); jmp(0x1019_b1b0, -0x19); goto l_0x1019_b1b0; /* jmp 0x1019b1b0 */
        l_0x1019_b1c9:
            ii(0x1019_b1c9, 2); mov(memd[ds, ecx], ebx);                /* mov [ecx], ebx */
            ii(0x1019_b1cb, 1); pop(ecx);                               /* pop ecx */
            ii(0x1019_b1cc, 1); pop(ebx);                               /* pop ebx */
            ii(0x1019_b1cd, 1); ret();                                  /* ret */
        }
    }
}
