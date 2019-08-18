using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("220b193b-2683-434f-aeef-fd1c06f0d937")]
        public void /* sys */ Method_1019_5cda()
        {
            ii(0x1019_5cda, 3); add(esp, 0x4);                          /* add esp, 0x4 */
            ii(0x1019_5cdd, 1); popd(ebp);                              /* pop ebp */
            ii(0x1019_5cde, 1); popd(edi);                              /* pop edi */
            ii(0x1019_5cdf, 1); popd(esi);                              /* pop esi */
            ii(0x1019_5ce0, 1); popd(edx);                              /* pop edx */
            ii(0x1019_5ce1, 1); popd(ecx);                              /* pop ecx */
            ii(0x1019_5ce2, 1); popd(ebx);                              /* pop ebx */
            ii(0x1019_5ce3, 1); retd(); return;                         /* ret */
        }
    }
}
