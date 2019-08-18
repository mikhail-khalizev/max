using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("50dd637c-5197-4b57-b648-a19ab0671321")]
        public void Method_0000_6330()
        {
            ii(0x6330, 2);    sub(ax, ax);                              /* sub ax, ax */
            ii(0x6332, 1);    retw(); return;                           /* ret */
        }
    }
}
