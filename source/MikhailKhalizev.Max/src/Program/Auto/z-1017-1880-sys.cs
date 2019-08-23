using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1017_1880-3c13b8cd")]
        public void /* sys */ Method_1017_1880()
        {
            ii(0x1017_1880, 1); push(ebx);                              /* push ebx */
            ii(0x1017_1881, 1); push(edx);                              /* push edx */
            ii(0x1017_1882, 3); sub(esp, 0x38);                         /* sub esp, 0x38 */
            ii(0x1017_1885, 2); mov(ah, 0xf);                           /* mov ah, 0xf */
            ii(0x1017_1887, 2); mov(ebx, esp);                          /* mov ebx, esp */
            ii(0x1017_1889, 2); mov(edx, esp);                          /* mov edx, esp */
            ii(0x1017_188b, 4); mov(memb[ss, esp + 0x1], ah);           /* mov [esp+0x1], ah */
            ii(0x1017_188f, 5); mov(eax, 0x10);                         /* mov eax, 0x10 */
            ii(0x1017_1894, 5); call(/* sys */ 0x1016_c606, -0x5293);   /* call 0x1016c606 */
            ii(0x1017_1899, 6); mov(dl, memb[ds, 0x1020_8930]);         /* mov dl, [0x10208930] */
            ii(0x1017_189f, 3); cmp(dl, memb[ss, esp]);                 /* cmp dl, [esp] */
            ii(0x1017_18a2, 2); if(jz(0x1017_18c0, 0x1c)) goto l_0x1017_18c0; /* jz 0x101718c0 */
            ii(0x1017_18a4, 5); mov(eax, 0x10);                         /* mov eax, 0x10 */
            ii(0x1017_18a9, 4); mov(memb[ss, esp + 0x1c], dl);          /* mov [esp+0x1c], dl */
            ii(0x1017_18ad, 2); xor(bl, bl);                            /* xor bl, bl */
            ii(0x1017_18af, 4); lea(edx, memd[ss, esp + 0x1c]);         /* lea edx, [esp+0x1c] */
            ii(0x1017_18b3, 4); mov(memb[ss, esp + 0x1d], bl);          /* mov [esp+0x1d], bl */
            ii(0x1017_18b7, 4); lea(ebx, memd[ss, esp + 0x1c]);         /* lea ebx, [esp+0x1c] */
            ii(0x1017_18bb, 5); call(/* sys */ 0x1016_c606, -0x52ba);   /* call 0x1016c606 */
        l_0x1017_18c0:
            ii(0x1017_18c0, 3); add(esp, 0x38);                         /* add esp, 0x38 */
            ii(0x1017_18c3, 1); pop(edx);                               /* pop edx */
            ii(0x1017_18c4, 1); pop(ebx);                               /* pop ebx */
            ii(0x1017_18c5, 1); ret();                                  /* ret */
        }
    }
}
