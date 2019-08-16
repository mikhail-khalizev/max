using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("62c7200d-9c31-4c14-81a6-26389a665406")]
        public void Method_0014_a724()
        {
            ii(0x14_a724, 3); mov(ax, 0x22bb);                          /* mov ax, 0x22bb */
            ii(0x14_a727, 2); if(jmpw_func(0x14_a72c, 0x3)) return;     /* jmp 0xa72c */
        }
    }
}
