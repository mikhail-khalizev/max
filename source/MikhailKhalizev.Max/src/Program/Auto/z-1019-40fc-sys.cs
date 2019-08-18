using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1019_40fc-50e57970")]
        public void /* sys */ Method_1019_40fc()
        {
            ii(0x1019_40fc, 1); popd(ebx);                              /* pop ebx */
            ii(0x1019_40fd, 1); popd(edi);                              /* pop edi */
            ii(0x1019_40fe, 1); popd(esi);                              /* pop esi */
            ii(0x1019_40ff, 1); leaved();                               /* leave */
            ii(0x1019_4100, 1); retd(); return;                         /* ret */
        }
    }
}
