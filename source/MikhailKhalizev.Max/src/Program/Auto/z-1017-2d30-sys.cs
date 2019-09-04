using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1017_2d30-86633fe7")]
        public void /* sys */ Method_1017_2d30()
        {
            ii(0x1017_2d30, 5);  mov(eax, memd[ds, 0x1020_9540]);      /* mov eax, [0x10209540] */
            ii(0x1017_2d35, 1);  ret();                                /* ret */
        }
    }
}
