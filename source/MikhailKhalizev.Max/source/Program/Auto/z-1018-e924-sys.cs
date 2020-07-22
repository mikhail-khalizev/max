using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1018_e924-28e1b0f")]
        public void /* sys */ Method_1018_e924()
        {
            ii(0x1018_e924, 3);  add(edi, 8);                          /* add edi, 0x8 */
            ii(0x1018_e927, 1);  ret();                                /* ret */
        }
    }
}
