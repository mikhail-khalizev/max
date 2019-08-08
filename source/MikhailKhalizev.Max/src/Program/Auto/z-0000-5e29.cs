using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("b097060c-d7c5-48d2-900b-02ce6a068295")]
        public void Method_0000_5e29()
        {
            ii(0x5e29, 3);    callw(0x46cc, -0x1760);                   /* call 0x46cc */
            ii(0x5e2c, 1);    retw(); return;                           /* ret */
        }
    }
}
