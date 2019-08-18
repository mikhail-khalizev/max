using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1028_95e1-b8d2d7ec")]
        public void Method_1028_95e1()
        {
            ii(0x1028_95e1, 5); mov(edx, 0x75);                         /* mov edx, 0x75 */
            ii(0x1028_95e6, 1); retd(); return;                         /* ret */
        }
    }
}
