using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("955ecb16-140f-412f-b753-b3f1d381fc17")]
        public void Method_0001_0dfe()
        {
            ii(0x1_0dfe, 4);  mov(dx, memw_a16[ds, 0x4c]);              /* mov dx, [0x4c] */
            ii(0x1_0e02, 2);  if(jmpw_func(0x1_0e2c, 0x28)) return;     /* jmp 0xe2c */
        }
    }
}
