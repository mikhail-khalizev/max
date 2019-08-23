using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1016_c298-8b6a0c81")]
        public void /* sys */ Method_1016_c298()
        {
            ii(0x1016_c298, 1); push(ebx);                              /* push ebx */
            ii(0x1016_c299, 1); push(esi);                              /* push esi */
            ii(0x1016_c29a, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1016_c29c, 5); mov(eax, memd[ds, 0x101c_fbd4]);        /* mov eax, [0x101cfbd4] */
            ii(0x1016_c2a1, 6); add(eax, memd[ds, 0x101c_fbfc]);        /* add eax, [0x101cfbfc] */
            ii(0x1016_c2a7, 6); mov(esi, memd[ds, 0x101c_fbf8]);        /* mov esi, [0x101cfbf8] */
            ii(0x1016_c2ad, 2); mov(memd[ds, ebx], eax);                /* mov [ebx], eax */
            ii(0x1016_c2af, 5); mov(eax, memd[ds, 0x101c_fbd0]);        /* mov eax, [0x101cfbd0] */
            ii(0x1016_c2b4, 2); add(eax, esi);                          /* add eax, esi */
            ii(0x1016_c2b6, 2); mov(memd[ds, edx], eax);                /* mov [edx], eax */
            ii(0x1016_c2b8, 1); pop(esi);                               /* pop esi */
            ii(0x1016_c2b9, 1); pop(ebx);                               /* pop ebx */
            ii(0x1016_c2ba, 1); ret();                                  /* ret */
        }
    }
}
