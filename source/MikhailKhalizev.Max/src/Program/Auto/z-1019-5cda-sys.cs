using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1019_5cda-e7833084")]
        public void /* sys */ Method_1019_5cda()
        {
            ii(0x1019_5cda, 3); add(esp, 0x4);                          /* add esp, 0x4 */
            ii(0x1019_5cdd, 1); pop(ebp);                               /* pop ebp */
            ii(0x1019_5cde, 1); pop(edi);                               /* pop edi */
            ii(0x1019_5cdf, 1); pop(esi);                               /* pop esi */
            ii(0x1019_5ce0, 1); pop(edx);                               /* pop edx */
            ii(0x1019_5ce1, 1); pop(ecx);                               /* pop ecx */
            ii(0x1019_5ce2, 1); pop(ebx);                               /* pop ebx */
            ii(0x1019_5ce3, 1); ret();                                  /* ret */
        }
    }
}
