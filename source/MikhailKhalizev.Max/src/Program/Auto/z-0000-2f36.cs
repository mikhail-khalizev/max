using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("ff3d3a66-fc8f-4da8-8ae8-bab53207cf00")]
        public void Method_0000_2f36()
        {
            ii(0x2f36, 2);    @int(0x15);                               /* int 0x15 */
            ii(0x2f38, 1);    retfw(); return;                          /* retf */
        }
    }
}
