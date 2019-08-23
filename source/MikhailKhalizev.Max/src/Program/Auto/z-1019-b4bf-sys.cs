using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1019_b4bf-e7833084")]
        public void /* sys */ Method_1019_b4bf()
        {
            ii(0x1019_b4bf, 3); add(esp, 0x4);                          /* add esp, 0x4 */
            ii(0x1019_b4c2, 1); pop(ebp);                               /* pop ebp */
            ii(0x1019_b4c3, 1); pop(edi);                               /* pop edi */
            ii(0x1019_b4c4, 1); pop(esi);                               /* pop esi */
            ii(0x1019_b4c5, 1); pop(edx);                               /* pop edx */
            ii(0x1019_b4c6, 1); pop(ecx);                               /* pop ecx */
            ii(0x1019_b4c7, 1); pop(ebx);                               /* pop ebx */
            ii(0x1019_b4c8, 1); ret();                                  /* ret */
        }
    }
}
