using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1016_5df8-1f21a9b6")]
        public void /* sys */ Method_1016_5df8()
        {
            ii(0x1016_5df8, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1016_5dfa, 2); if(jge(0x1016_5dfe, 0x2)) goto l_0x1016_5dfe; /* jge 0x10165dfe */
            ii(0x1016_5dfc, 2); neg(eax);                               /* neg eax */
        l_0x1016_5dfe:
            ii(0x1016_5dfe, 1); ret();                                  /* ret */
        }
    }
}
