using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("13cf80b2-65f8-4a87-a120-9809cbf5df21")]
        public void /* sys */ Method_1017_2d30()
        {
            ii(0x1017_2d30, 5); mov(eax, memd_a32[ds, 0x1020_9540]);    /* mov eax, [0x10209540] */
            ii(0x1017_2d35, 1); retd(); return;                         /* ret */
        }
    }
}
