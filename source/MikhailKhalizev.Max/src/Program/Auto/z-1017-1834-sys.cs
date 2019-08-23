using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1017_1834-3ae42d26")]
        public void /* sys */ Method_1017_1834()
        {
            ii(0x1017_1834, 1); push(ebx);                              /* push ebx */
            ii(0x1017_1835, 1); push(edx);                              /* push edx */
            ii(0x1017_1836, 3); sub(esp, 0x1c);                         /* sub esp, 0x1c */
            ii(0x1017_1839, 2); mov(ah, 0xf);                           /* mov ah, 0xf */
            ii(0x1017_183b, 2); mov(ebx, esp);                          /* mov ebx, esp */
            ii(0x1017_183d, 2); mov(edx, esp);                          /* mov edx, esp */
            ii(0x1017_183f, 4); mov(memb[ss, esp + 0x1], ah);           /* mov [esp+0x1], ah */
            ii(0x1017_1843, 5); mov(eax, 0x10);                         /* mov eax, 0x10 */
            ii(0x1017_1848, 5); call(/* sys */ 0x1016_c606, -0x5247);   /* call 0x1016c606 */
            ii(0x1017_184d, 3); mov(al, memb[ss, esp]);                 /* mov al, [esp] */
            ii(0x1017_1850, 3); add(esp, 0x1c);                         /* add esp, 0x1c */
            ii(0x1017_1853, 1); pop(edx);                               /* pop edx */
            ii(0x1017_1854, 1); pop(ebx);                               /* pop ebx */
            ii(0x1017_1855, 1); ret();                                  /* ret */
        }
    }
}
