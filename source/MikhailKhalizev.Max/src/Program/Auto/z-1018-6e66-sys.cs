using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("1147a17d-155f-4f6b-abaf-a998670451a0")]
        public void /* sys */ Method_1018_6e66()
        {
            ii(0x1018_6e66, 1); popd(edi);                              /* pop edi */
            ii(0x1018_6e67, 1); popd(esi);                              /* pop esi */
            ii(0x1018_6e68, 1); popd(edx);                              /* pop edx */
            ii(0x1018_6e69, 1); popd(ecx);                              /* pop ecx */
            ii(0x1018_6e6a, 1); popd(ebx);                              /* pop ebx */
            ii(0x1018_6e6b, 1); retd(); return;                         /* ret */
        }
    }
}
