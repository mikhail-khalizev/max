using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0a3ff059-3d43-4d51-bfb4-ac58d068067a")]
        public void /* sys */ Method_1018_d7a8()
        {
            ii(0x1018_d7a8, 5); mov(eax, 0x1020_b714);                  /* mov eax, 0x1020b714 */
            ii(0x1018_d7ad, 1); retd(); return;                         /* ret */
        }
    }
}
