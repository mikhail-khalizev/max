using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1018_d7a2-b5e9992c")]
        public void /* sys */ Method_1018_d7a2()
        {
            ii(0x1018_d7a2, 5); mov(eax, 0x1020_b710);                  /* mov eax, 0x1020b710 */
            ii(0x1018_d7a7, 1); retd(); return;                         /* ret */
        }
    }
}
