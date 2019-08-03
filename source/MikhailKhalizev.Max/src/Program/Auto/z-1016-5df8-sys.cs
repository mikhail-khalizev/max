using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("db47860b-6b41-4457-9577-b13dd0c704fe")]
        public void /* sys */ Method_1016_5df8()
        {
            ii(0x1016_5df8, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1016_5dfa, 2); if(jged(0x1016_5dfe, 0x2)) goto l_0x1016_5dfe; /* jge 0x10165dfe */
            ii(0x1016_5dfc, 2); neg(eax);                               /* neg eax */
        l_0x1016_5dfe:
            ii(0x1016_5dfe, 1); retd(); return;                         /* ret */
        }
    }
}
