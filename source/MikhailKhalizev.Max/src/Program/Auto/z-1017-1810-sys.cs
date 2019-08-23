using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1017_1810-ef751728")]
        public void /* sys */ Method_1017_1810()
        {
            ii(0x1017_1810, 1); pushd(ebx);                             /* push ebx */
            ii(0x1017_1811, 1); pushd(edx);                             /* push edx */
            ii(0x1017_1812, 3); sub(esp, 0x1c);                         /* sub esp, 0x1c */
            ii(0x1017_1815, 2); mov(ebx, esp);                          /* mov ebx, esp */
            ii(0x1017_1817, 2); xor(ah, ah);                            /* xor ah, ah */
            ii(0x1017_1819, 2); mov(edx, esp);                          /* mov edx, esp */
            ii(0x1017_181b, 4); mov(memb_a32[ss, esp + 0x1], ah);       /* mov [esp+0x1], ah */
            ii(0x1017_181f, 3); mov(memb_a32[ss, esp], al);             /* mov [esp], al */
            ii(0x1017_1822, 5); mov(eax, 0x10);                         /* mov eax, 0x10 */
            ii(0x1017_1827, 5); calld(/* sys */ 0x1016_c606, -0x5226);  /* call 0x1016c606 */
            ii(0x1017_182c, 3); add(esp, 0x1c);                         /* add esp, 0x1c */
            ii(0x1017_182f, 1); popd(edx);                              /* pop edx */
            ii(0x1017_1830, 1); popd(ebx);                              /* pop ebx */
            ii(0x1017_1831, 1); retd();                                 /* ret */
        }
    }
}
