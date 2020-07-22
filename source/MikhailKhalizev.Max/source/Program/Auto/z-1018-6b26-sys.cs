using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1018_6b26-4cecc5c4")]
        public void /* sys */ Method_1018_6b26()
        {
            ii(0x1018_6b26, 1);  popd(ds);                             /* pop ds */
            ii(0x1018_6b27, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1018_6b28, 1);  pop(edi);                             /* pop edi */
            ii(0x1018_6b29, 1);  pop(esi);                             /* pop esi */
            ii(0x1018_6b2a, 1);  ret();                                /* ret */
        }
    }
}
