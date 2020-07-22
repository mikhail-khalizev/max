using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1018_fe00-990b")]
        public void /* sys_mve */ Method_1018_fe00()
        {
            ii(0x1018_fe00, 2);  mov(ah, cl);                          /* mov ah, cl */
        }
    }
}
