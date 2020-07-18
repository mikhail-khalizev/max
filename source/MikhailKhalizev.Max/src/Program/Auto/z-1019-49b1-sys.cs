using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1019_49b1-7bf0ecef")]
        public void /* sys */ Method_1019_49b1()
        {
            ii(0x1019_49b1, 3);  add(esp, 8);                          /* add esp, 0x8 */
            ii(0x1019_49b4, 1);  pop(edi);                             /* pop edi */
            ii(0x1019_49b5, 1);  pop(esi);                             /* pop esi */
            ii(0x1019_49b6, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1019_49b7, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1019_49b8, 1);  ret();                                /* ret */
        }
    }
}
