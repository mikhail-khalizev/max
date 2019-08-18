using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("f31ed27d-ada0-4ec5-8abe-bcfd3ba4cc3a")]
        public void /* sys */ Method_1019_3ca9()
        {
            ii(0x1019_3ca9, 1); popd(ebx);                              /* pop ebx */
            ii(0x1019_3caa, 1); popd(edi);                              /* pop edi */
            ii(0x1019_3cab, 1); popd(esi);                              /* pop esi */
            ii(0x1019_3cac, 1); leaved();                               /* leave */
            ii(0x1019_3cad, 1); retd(); return;                         /* ret */
        }
    }
}
