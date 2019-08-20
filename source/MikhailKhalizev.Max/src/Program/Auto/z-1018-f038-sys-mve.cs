using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1018_f038-e8bc76ff")]
        public void /* sys_mve */ Method_1018_f038()
        {
            ii(0x1018_f038, 7); lea(eax, esi * 8 - 0x4);                /* lea eax, [esi*8-0x4] */
        }
    }
}
