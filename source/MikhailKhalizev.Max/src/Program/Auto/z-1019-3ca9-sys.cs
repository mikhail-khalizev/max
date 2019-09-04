using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1019_3ca9-50e57970")]
        public void /* sys */ Method_1019_3ca9()
        {
            ii(0x1019_3ca9, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1019_3caa, 1);  pop(edi);                             /* pop edi */
            ii(0x1019_3cab, 1);  pop(esi);                             /* pop esi */
            ii(0x1019_3cac, 1);  leave();                              /* leave */
            ii(0x1019_3cad, 1);  ret();                                /* ret */
        }
    }
}
