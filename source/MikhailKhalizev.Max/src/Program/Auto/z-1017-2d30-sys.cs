using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("7bef4a7b-e067-4adc-97fb-7695988e3740")]
        public void /* sys */ Method_1017_2d30()
        {
            ii(0x1017_2d30, 5); mov(eax, memd_a32[ds, 0x1020_9540]);    /* mov eax, [0x10209540] */
            ii(0x1017_2d35, 1); retd(); return;                         /* ret */
        }
    }
}
