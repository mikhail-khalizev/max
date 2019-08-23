using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1018_1cc4-28e1748")]
        public void /* sys */ Method_1018_1cc4()
        {
            ii(0x1018_1cc4, 3); add(eax, 0x8);                          /* add eax, 0x8 */
            ii(0x1018_1cc7, 1); ret();                                  /* ret */
        }
    }
}
