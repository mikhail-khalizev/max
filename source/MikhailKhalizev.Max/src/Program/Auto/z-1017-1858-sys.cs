using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1017_1858-34928fce")]
        public void /* sys */ Method_1017_1858()
        {
            ii(0x1017_1858, 1); push(ebx);                              /* push ebx */
            ii(0x1017_1859, 1); push(edx);                              /* push edx */
            ii(0x1017_185a, 3); sub(esp, 0x1c);                         /* sub esp, 0x1c */
            ii(0x1017_185d, 2); mov(ah, 0xf);                           /* mov ah, 0xf */
            ii(0x1017_185f, 2); mov(ebx, esp);                          /* mov ebx, esp */
            ii(0x1017_1861, 2); mov(edx, esp);                          /* mov edx, esp */
            ii(0x1017_1863, 4); mov(memb[ss, esp + 0x1], ah);           /* mov [esp+0x1], ah */
            ii(0x1017_1867, 5); mov(eax, 0x10);                         /* mov eax, 0x10 */
            ii(0x1017_186c, 5); call(/* sys */ 0x1016_c606, -0x526b);   /* call 0x1016c606 */
            ii(0x1017_1871, 3); mov(dl, memb[ss, esp]);                 /* mov dl, [esp] */
            ii(0x1017_1874, 6); mov(memb[ds, 0x1020_8930], dl);         /* mov [0x10208930], dl */
            ii(0x1017_187a, 3); add(esp, 0x1c);                         /* add esp, 0x1c */
            ii(0x1017_187d, 1); pop(edx);                               /* pop edx */
            ii(0x1017_187e, 1); pop(ebx);                               /* pop ebx */
            ii(0x1017_187f, 1); ret();                                  /* ret */
        }
    }
}
