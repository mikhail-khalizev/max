using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1018_1ce6-4bf14d7b")]
        public void /* sys */ Method_1018_1ce6()
        {
            ii(0x1018_1ce6, 10);  mov(memd[ds, 0x1020_a224], 0x101b_e7c0);/* mov dword [0x1020a224], 0x101be7c0 */
            ii(0x1018_1cf0, 1);  ret();                                /* ret */
        }
    }
}
