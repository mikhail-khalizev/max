using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1018_ffff-990d")]
        public void /* sys_mve */ Method_1018_ffff()
        {
            ii(0x1018_ffff, 2); mov(ah, bh);                            /* mov ah, bh */
        }
    }
}
