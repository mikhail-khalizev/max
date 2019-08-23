using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1018_6e66-766c867a")]
        public void /* sys */ Method_1018_6e66()
        {
            ii(0x1018_6e66, 1); pop(edi);                               /* pop edi */
            ii(0x1018_6e67, 1); pop(esi);                               /* pop esi */
            ii(0x1018_6e68, 1); pop(edx);                               /* pop edx */
            ii(0x1018_6e69, 1); pop(ecx);                               /* pop ecx */
            ii(0x1018_6e6a, 1); pop(ebx);                               /* pop ebx */
            ii(0x1018_6e6b, 1); ret();                                  /* ret */
        }
    }
}
